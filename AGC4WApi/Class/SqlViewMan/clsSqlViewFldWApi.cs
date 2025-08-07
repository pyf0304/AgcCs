
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlViewFldWApi
 表名:SqlViewFld(00050249)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
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
public static class  clsSqlViewFldWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetmId(this clsSqlViewFldEN objSqlViewFldEN, long lngmId, string strComparisonOp="")
	{
objSqlViewFldEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.mId) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.mId, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.mId] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewId">Sql视图Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetSqlViewId(this clsSqlViewFldEN objSqlViewFldEN, string strSqlViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewId, conSqlViewFld.SqlViewId);
clsCheckSql.CheckFieldLen(strSqlViewId, 8, conSqlViewFld.SqlViewId);
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, conSqlViewFld.SqlViewId);
objSqlViewFldEN.SqlViewId = strSqlViewId; //Sql视图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.SqlViewId) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.SqlViewId, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.SqlViewId] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabId">相关表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetRelaTabId(this clsSqlViewFldEN objSqlViewFldEN, string strRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaTabId, 8, conSqlViewFld.RelaTabId);
clsCheckSql.CheckFieldForeignKey(strRelaTabId, 8, conSqlViewFld.RelaTabId);
objSqlViewFldEN.RelaTabId = strRelaTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.RelaTabId) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.RelaTabId, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.RelaTabId] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetFldId(this clsSqlViewFldEN objSqlViewFldEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, conSqlViewFld.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conSqlViewFld.FldId);
objSqlViewFldEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.FldId) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.FldId, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.FldId] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldExpression">字段表达式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetFldExpression(this clsSqlViewFldEN objSqlViewFldEN, string strFldExpression, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldExpression, 500, conSqlViewFld.FldExpression);
objSqlViewFldEN.FldExpression = strFldExpression; //字段表达式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.FldExpression) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.FldExpression, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.FldExpression] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldExpressionType">FldExpressionType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetFldExpressionType(this clsSqlViewFldEN objSqlViewFldEN, string strFldExpressionType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldExpressionType, 50, conSqlViewFld.FldExpressionType);
objSqlViewFldEN.FldExpressionType = strFldExpressionType; //FldExpressionType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.FldExpressionType) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.FldExpressionType, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.FldExpressionType] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldAliases">字段别名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetFieldAliases(this clsSqlViewFldEN objSqlViewFldEN, string strFieldAliases, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldAliases, 50, conSqlViewFld.FieldAliases);
objSqlViewFldEN.FieldAliases = strFieldAliases; //字段别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.FieldAliases) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.FieldAliases, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.FieldAliases] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilters">筛选器</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetFilters(this clsSqlViewFldEN objSqlViewFldEN, string strFilters, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFilters, 50, conSqlViewFld.Filters);
objSqlViewFldEN.Filters = strFilters; //筛选器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.Filters) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.Filters, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.Filters] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetOrderNum(this clsSqlViewFldEN objSqlViewFldEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conSqlViewFld.OrderNum);
objSqlViewFldEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.OrderNum) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.OrderNum, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.OrderNum] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetPrjId(this clsSqlViewFldEN objSqlViewFldEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conSqlViewFld.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conSqlViewFld.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conSqlViewFld.PrjId);
objSqlViewFldEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.PrjId) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.PrjId, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.PrjId] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetUpdDate(this clsSqlViewFldEN objSqlViewFldEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSqlViewFld.UpdDate);
objSqlViewFldEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.UpdDate) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.UpdDate, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.UpdDate] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetUpdUserId(this clsSqlViewFldEN objSqlViewFldEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSqlViewFld.UpdUserId);
objSqlViewFldEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.UpdUserId) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.UpdUserId, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.UpdUserId] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetMemo(this clsSqlViewFldEN objSqlViewFldEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSqlViewFld.Memo);
objSqlViewFldEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.Memo) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.Memo, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.Memo] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSqlViewFldEN objSqlViewFldCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.mId) == true)
{
string strComparisonOpmId = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conSqlViewFld.mId, objSqlViewFldCond.mId, strComparisonOpmId);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.SqlViewId) == true)
{
string strComparisonOpSqlViewId = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.SqlViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.SqlViewId, objSqlViewFldCond.SqlViewId, strComparisonOpSqlViewId);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.RelaTabId) == true)
{
string strComparisonOpRelaTabId = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.RelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.RelaTabId, objSqlViewFldCond.RelaTabId, strComparisonOpRelaTabId);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.FldId) == true)
{
string strComparisonOpFldId = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.FldId, objSqlViewFldCond.FldId, strComparisonOpFldId);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.FldExpression) == true)
{
string strComparisonOpFldExpression = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.FldExpression];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.FldExpression, objSqlViewFldCond.FldExpression, strComparisonOpFldExpression);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.FldExpressionType) == true)
{
string strComparisonOpFldExpressionType = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.FldExpressionType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.FldExpressionType, objSqlViewFldCond.FldExpressionType, strComparisonOpFldExpressionType);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.FieldAliases) == true)
{
string strComparisonOpFieldAliases = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.FieldAliases];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.FieldAliases, objSqlViewFldCond.FieldAliases, strComparisonOpFieldAliases);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.Filters) == true)
{
string strComparisonOpFilters = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.Filters];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.Filters, objSqlViewFldCond.Filters, strComparisonOpFilters);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.OrderNum) == true)
{
string strComparisonOpOrderNum = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conSqlViewFld.OrderNum, objSqlViewFldCond.OrderNum, strComparisonOpOrderNum);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.PrjId) == true)
{
string strComparisonOpPrjId = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.PrjId, objSqlViewFldCond.PrjId, strComparisonOpPrjId);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.UpdDate) == true)
{
string strComparisonOpUpdDate = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.UpdDate, objSqlViewFldCond.UpdDate, strComparisonOpUpdDate);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.UpdUserId, objSqlViewFldCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.Memo) == true)
{
string strComparisonOpMemo = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.Memo, objSqlViewFldCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSqlViewFldEN objSqlViewFldEN)
{
 if (objSqlViewFldEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objSqlViewFldEN.sfUpdFldSetStr = objSqlViewFldEN.getsfUpdFldSetStr();
clsSqlViewFldWApi.CheckPropertyNew(objSqlViewFldEN); 
bool bolResult = clsSqlViewFldWApi.UpdateRecord(objSqlViewFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 获取唯一性条件串--SqlViewFld(Sql视图字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_SqlViewId_RelaTabId_FldId_FldExpression
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSqlViewFldEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsSqlViewFldEN objSqlViewFldEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSqlViewFldEN == null) return "";
if (objSqlViewFldEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSqlViewFldEN.PrjId);
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewFldEN.SqlViewId);
 sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewFldEN.RelaTabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objSqlViewFldEN.FldId);
 sbCondition.AppendFormat(" and FldExpression = '{0}'", objSqlViewFldEN.FldExpression);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objSqlViewFldEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSqlViewFldEN.PrjId);
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewFldEN.SqlViewId);
 sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewFldEN.RelaTabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objSqlViewFldEN.FldId);
 sbCondition.AppendFormat(" and FldExpression = '{0}'", objSqlViewFldEN.FldExpression);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSqlViewFldEN objSqlViewFldEN)
{
try
{
clsSqlViewFldWApi.CheckPropertyNew(objSqlViewFldEN); 
bool bolResult = clsSqlViewFldWApi.AddNewRecord(objSqlViewFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSqlViewFldEN objSqlViewFldEN, string strWhereCond)
{
try
{
clsSqlViewFldWApi.CheckPropertyNew(objSqlViewFldEN); 
bool bolResult = clsSqlViewFldWApi.UpdateWithCondition(objSqlViewFldEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// Sql视图字段(SqlViewFld)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsSqlViewFldWApi
{
private static readonly string mstrApiControllerName = "SqlViewFldApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsSqlViewFldWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsSqlViewFldEN objSqlViewFldEN)
{
if (!Object.Equals(null, objSqlViewFldEN.SqlViewId) && GetStrLen(objSqlViewFldEN.SqlViewId) > 8)
{
 throw new Exception("字段[Sql视图Id]的长度不能超过8!");
}
if (!Object.Equals(null, objSqlViewFldEN.RelaTabId) && GetStrLen(objSqlViewFldEN.RelaTabId) > 8)
{
 throw new Exception("字段[相关表Id]的长度不能超过8!");
}
if (!Object.Equals(null, objSqlViewFldEN.FldId) && GetStrLen(objSqlViewFldEN.FldId) > 8)
{
 throw new Exception("字段[字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objSqlViewFldEN.FldExpression) && GetStrLen(objSqlViewFldEN.FldExpression) > 500)
{
 throw new Exception("字段[字段表达式]的长度不能超过500!");
}
if (!Object.Equals(null, objSqlViewFldEN.FldExpressionType) && GetStrLen(objSqlViewFldEN.FldExpressionType) > 50)
{
 throw new Exception("字段[FldExpressionType]的长度不能超过50!");
}
if (!Object.Equals(null, objSqlViewFldEN.FieldAliases) && GetStrLen(objSqlViewFldEN.FieldAliases) > 50)
{
 throw new Exception("字段[字段别名]的长度不能超过50!");
}
if (!Object.Equals(null, objSqlViewFldEN.Filters) && GetStrLen(objSqlViewFldEN.Filters) > 50)
{
 throw new Exception("字段[筛选器]的长度不能超过50!");
}
if (!Object.Equals(null, objSqlViewFldEN.PrjId) && GetStrLen(objSqlViewFldEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objSqlViewFldEN.UpdDate) && GetStrLen(objSqlViewFldEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objSqlViewFldEN.UpdUserId) && GetStrLen(objSqlViewFldEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objSqlViewFldEN.Memo) && GetStrLen(objSqlViewFldEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objSqlViewFldEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSqlViewFldEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsSqlViewFldEN objSqlViewFldEN;
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
objSqlViewFldEN = JsonConvert.DeserializeObject<clsSqlViewFldEN>(strJson);
return objSqlViewFldEN;
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
public static clsSqlViewFldEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsSqlViewFldEN objSqlViewFldEN;
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
objSqlViewFldEN = JsonConvert.DeserializeObject<clsSqlViewFldEN>(strJson);
return objSqlViewFldEN;
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

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlViewFldEN> GetObjLst(string strWhereCond)
{
 List<clsSqlViewFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewFldEN>>(strJson);
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
public static List<clsSqlViewFldEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsSqlViewFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewFldEN>>(strJson);
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
public static List<clsSqlViewFldEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsSqlViewFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewFldEN>>(strJson);
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
public static List<clsSqlViewFldEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsSqlViewFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewFldEN>>(strJson);
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
public static List<clsSqlViewFldEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsSqlViewFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewFldEN>>(strJson);
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
public static List<clsSqlViewFldEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsSqlViewFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewFldEN>>(strJson);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
try
{
 clsSqlViewFldEN objSqlViewFldEN = clsSqlViewFldWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelSqlViewFlds(List<string> arrmId)
{
string strAction = "DelSqlViewFlds";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelSqlViewFldsByCond(string strWhereCond)
{
string strAction = "DelSqlViewFldsByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsSqlViewFldEN objSqlViewFldEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlViewFldEN>(objSqlViewFldEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsSqlViewFldEN objSqlViewFldEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlViewFldEN>(objSqlViewFldEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsSqlViewFldEN objSqlViewFldEN)
{
if (string.IsNullOrEmpty(objSqlViewFldEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSqlViewFldEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlViewFldEN>(objSqlViewFldEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsSqlViewFldEN objSqlViewFldEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objSqlViewFldEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSqlViewFldEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSqlViewFldEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlViewFldEN>(objSqlViewFldEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase4Tab:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objSqlViewFldENS">源对象</param>
 /// <param name = "objSqlViewFldENT">目标对象</param>
 public static void CopyTo(clsSqlViewFldEN objSqlViewFldENS, clsSqlViewFldEN objSqlViewFldENT)
{
try
{
objSqlViewFldENT.mId = objSqlViewFldENS.mId; //mId
objSqlViewFldENT.SqlViewId = objSqlViewFldENS.SqlViewId; //Sql视图Id
objSqlViewFldENT.RelaTabId = objSqlViewFldENS.RelaTabId; //相关表Id
objSqlViewFldENT.FldId = objSqlViewFldENS.FldId; //字段Id
objSqlViewFldENT.FldExpression = objSqlViewFldENS.FldExpression; //字段表达式
objSqlViewFldENT.FldExpressionType = objSqlViewFldENS.FldExpressionType; //FldExpressionType
objSqlViewFldENT.FieldAliases = objSqlViewFldENS.FieldAliases; //字段别名
objSqlViewFldENT.Filters = objSqlViewFldENS.Filters; //筛选器
objSqlViewFldENT.OrderNum = objSqlViewFldENS.OrderNum; //序号
objSqlViewFldENT.PrjId = objSqlViewFldENS.PrjId; //工程Id
objSqlViewFldENT.UpdDate = objSqlViewFldENS.UpdDate; //修改日期
objSqlViewFldENT.UpdUserId = objSqlViewFldENS.UpdUserId; //修改用户Id
objSqlViewFldENT.Memo = objSqlViewFldENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsSqlViewFldEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsSqlViewFldEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsSqlViewFldEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsSqlViewFldEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsSqlViewFldEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsSqlViewFldEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsSqlViewFldWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsSqlViewFldWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsSqlViewFldEN._CurrTabName, strPrjId);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsSqlViewFldWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsSqlViewFldEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsSqlViewFldWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
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
public static DataTable GetDataTableByObjLst(List<clsSqlViewFldEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conSqlViewFld.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conSqlViewFld.SqlViewId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewFld.RelaTabId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewFld.FldId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewFld.FldExpression, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewFld.FldExpressionType, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewFld.FieldAliases, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewFld.Filters, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewFld.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conSqlViewFld.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewFld.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewFld.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewFld.Memo, Type.GetType("System.String"));
foreach (clsSqlViewFldEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conSqlViewFld.mId] = objInFor[conSqlViewFld.mId];
objDR[conSqlViewFld.SqlViewId] = objInFor[conSqlViewFld.SqlViewId];
objDR[conSqlViewFld.RelaTabId] = objInFor[conSqlViewFld.RelaTabId];
objDR[conSqlViewFld.FldId] = objInFor[conSqlViewFld.FldId];
objDR[conSqlViewFld.FldExpression] = objInFor[conSqlViewFld.FldExpression];
objDR[conSqlViewFld.FldExpressionType] = objInFor[conSqlViewFld.FldExpressionType];
objDR[conSqlViewFld.FieldAliases] = objInFor[conSqlViewFld.FieldAliases];
objDR[conSqlViewFld.Filters] = objInFor[conSqlViewFld.Filters];
objDR[conSqlViewFld.OrderNum] = objInFor[conSqlViewFld.OrderNum];
objDR[conSqlViewFld.PrjId] = objInFor[conSqlViewFld.PrjId];
objDR[conSqlViewFld.UpdDate] = objInFor[conSqlViewFld.UpdDate];
objDR[conSqlViewFld.UpdUserId] = objInFor[conSqlViewFld.UpdUserId];
objDR[conSqlViewFld.Memo] = objInFor[conSqlViewFld.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// Sql视图字段(SqlViewFld)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4SqlViewFld : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewFldWApi.ReFreshThisCache(strPrjId);
}
}

}