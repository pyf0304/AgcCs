
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlViewRelaTabWApi
 表名:SqlViewRelaTab(00050247)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:40:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsSqlViewRelaTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabId">相关表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetRelaTabId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaTabId, 8, conSqlViewRelaTab.RelaTabId);
clsCheckSql.CheckFieldForeignKey(strRelaTabId, 8, conSqlViewRelaTab.RelaTabId);
objSqlViewRelaTabEN.RelaTabId = strRelaTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.RelaTabId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.RelaTabId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.RelaTabId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewId">Sql视图Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetSqlViewId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strSqlViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewId, conSqlViewRelaTab.SqlViewId);
clsCheckSql.CheckFieldLen(strSqlViewId, 8, conSqlViewRelaTab.SqlViewId);
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, conSqlViewRelaTab.SqlViewId);
objSqlViewRelaTabEN.SqlViewId = strSqlViewId; //Sql视图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.SqlViewId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.SqlViewId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.SqlViewId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetTabId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conSqlViewRelaTab.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, conSqlViewRelaTab.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conSqlViewRelaTab.TabId);
objSqlViewRelaTabEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.TabId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.TabId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.TabId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabAliases">表别名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetTabAliases(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strTabAliases, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabAliases, conSqlViewRelaTab.TabAliases);
clsCheckSql.CheckFieldLen(strTabAliases, 100, conSqlViewRelaTab.TabAliases);
objSqlViewRelaTabEN.TabAliases = strTabAliases; //表别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.TabAliases) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.TabAliases, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.TabAliases] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaFldId">关系字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetRelaFldId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strRelaFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaFldId, 8, conSqlViewRelaTab.RelaFldId);
clsCheckSql.CheckFieldForeignKey(strRelaFldId, 8, conSqlViewRelaTab.RelaFldId);
objSqlViewRelaTabEN.RelaFldId = strRelaFldId; //关系字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.RelaFldId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.RelaFldId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.RelaFldId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strOtherFldId">其他表字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetOtherFldId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strOtherFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOtherFldId, 8, conSqlViewRelaTab.OtherFldId);
clsCheckSql.CheckFieldForeignKey(strOtherFldId, 8, conSqlViewRelaTab.OtherFldId);
objSqlViewRelaTabEN.OtherFldId = strOtherFldId; //其他表字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.OtherFldId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.OtherFldId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.OtherFldId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strOtherTabId">其他表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetOtherTabId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strOtherTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOtherTabId, 8, conSqlViewRelaTab.OtherTabId);
clsCheckSql.CheckFieldForeignKey(strOtherTabId, 8, conSqlViewRelaTab.OtherTabId);
objSqlViewRelaTabEN.OtherTabId = strOtherTabId; //其他表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.OtherTabId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.OtherTabId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.OtherTabId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSvRelaTabTypeId">Sql视图相关表类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetSvRelaTabTypeId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strSvRelaTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSvRelaTabTypeId, conSqlViewRelaTab.SvRelaTabTypeId);
clsCheckSql.CheckFieldLen(strSvRelaTabTypeId, 2, conSqlViewRelaTab.SvRelaTabTypeId);
clsCheckSql.CheckFieldForeignKey(strSvRelaTabTypeId, 2, conSqlViewRelaTab.SvRelaTabTypeId);
objSqlViewRelaTabEN.SvRelaTabTypeId = strSvRelaTabTypeId; //Sql视图相关表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.SvRelaTabTypeId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.SvRelaTabTypeId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.SvRelaTabTypeId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabRelationTypeId">表关系类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetTabRelationTypeId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strTabRelationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabRelationTypeId, conSqlViewRelaTab.TabRelationTypeId);
clsCheckSql.CheckFieldLen(strTabRelationTypeId, 2, conSqlViewRelaTab.TabRelationTypeId);
clsCheckSql.CheckFieldForeignKey(strTabRelationTypeId, 2, conSqlViewRelaTab.TabRelationTypeId);
objSqlViewRelaTabEN.TabRelationTypeId = strTabRelationTypeId; //表关系类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.TabRelationTypeId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.TabRelationTypeId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.TabRelationTypeId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabRelationText">表关系文本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetTabRelationText(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strTabRelationText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabRelationText, 500, conSqlViewRelaTab.TabRelationText);
objSqlViewRelaTabEN.TabRelationText = strTabRelationText; //表关系文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.TabRelationText) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.TabRelationText, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.TabRelationText] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetOrderNum(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conSqlViewRelaTab.OrderNum);
objSqlViewRelaTabEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.OrderNum) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.OrderNum, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.OrderNum] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetPrjId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conSqlViewRelaTab.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conSqlViewRelaTab.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conSqlViewRelaTab.PrjId);
objSqlViewRelaTabEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.PrjId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.PrjId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.PrjId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetUpdDate(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSqlViewRelaTab.UpdDate);
objSqlViewRelaTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.UpdDate) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.UpdDate, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.UpdDate] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetUpdUserId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSqlViewRelaTab.UpdUserId);
objSqlViewRelaTabEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.UpdUserId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.UpdUserId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.UpdUserId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetMemo(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSqlViewRelaTab.Memo);
objSqlViewRelaTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.Memo) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.Memo, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.Memo] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSqlViewRelaTabEN objSqlViewRelaTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.RelaTabId) == true)
{
string strComparisonOpRelaTabId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.RelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.RelaTabId, objSqlViewRelaTabCond.RelaTabId, strComparisonOpRelaTabId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.SqlViewId) == true)
{
string strComparisonOpSqlViewId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.SqlViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.SqlViewId, objSqlViewRelaTabCond.SqlViewId, strComparisonOpSqlViewId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.TabId) == true)
{
string strComparisonOpTabId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.TabId, objSqlViewRelaTabCond.TabId, strComparisonOpTabId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.TabAliases) == true)
{
string strComparisonOpTabAliases = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.TabAliases];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.TabAliases, objSqlViewRelaTabCond.TabAliases, strComparisonOpTabAliases);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.RelaFldId) == true)
{
string strComparisonOpRelaFldId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.RelaFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.RelaFldId, objSqlViewRelaTabCond.RelaFldId, strComparisonOpRelaFldId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.OtherFldId) == true)
{
string strComparisonOpOtherFldId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.OtherFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.OtherFldId, objSqlViewRelaTabCond.OtherFldId, strComparisonOpOtherFldId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.OtherTabId) == true)
{
string strComparisonOpOtherTabId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.OtherTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.OtherTabId, objSqlViewRelaTabCond.OtherTabId, strComparisonOpOtherTabId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.SvRelaTabTypeId) == true)
{
string strComparisonOpSvRelaTabTypeId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.SvRelaTabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.SvRelaTabTypeId, objSqlViewRelaTabCond.SvRelaTabTypeId, strComparisonOpSvRelaTabTypeId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.TabRelationTypeId) == true)
{
string strComparisonOpTabRelationTypeId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.TabRelationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.TabRelationTypeId, objSqlViewRelaTabCond.TabRelationTypeId, strComparisonOpTabRelationTypeId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.TabRelationText) == true)
{
string strComparisonOpTabRelationText = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.TabRelationText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.TabRelationText, objSqlViewRelaTabCond.TabRelationText, strComparisonOpTabRelationText);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.OrderNum) == true)
{
string strComparisonOpOrderNum = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conSqlViewRelaTab.OrderNum, objSqlViewRelaTabCond.OrderNum, strComparisonOpOrderNum);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.PrjId) == true)
{
string strComparisonOpPrjId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.PrjId, objSqlViewRelaTabCond.PrjId, strComparisonOpPrjId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.UpdDate, objSqlViewRelaTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.UpdUserId, objSqlViewRelaTabCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.Memo) == true)
{
string strComparisonOpMemo = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.Memo, objSqlViewRelaTabCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
 if (string.IsNullOrEmpty(objSqlViewRelaTabEN.RelaTabId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objSqlViewRelaTabEN.sfUpdFldSetStr = objSqlViewRelaTabEN.getsfUpdFldSetStr();
clsSqlViewRelaTabWApi.CheckPropertyNew(objSqlViewRelaTabEN); 
bool bolResult = clsSqlViewRelaTabWApi.UpdateRecord(objSqlViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabWApi.ReFreshCache(objSqlViewRelaTabEN.PrjId);
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
 /// 获取唯一性条件串--SqlViewRelaTab(Sql视图相关表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:SqlViewId_TabAliases
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSqlViewRelaTabEN == null) return "";
if (objSqlViewRelaTabEN.RelaTabId == null || objSqlViewRelaTabEN.RelaTabId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewRelaTabEN.SqlViewId);
 sbCondition.AppendFormat(" and TabAliases = '{0}'", objSqlViewRelaTabEN.TabAliases);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RelaTabId !=  '{0}'", objSqlViewRelaTabEN.RelaTabId);
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewRelaTabEN.SqlViewId);
 sbCondition.AppendFormat(" and TabAliases = '{0}'", objSqlViewRelaTabEN.TabAliases);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
try
{
 if (string.IsNullOrEmpty(objSqlViewRelaTabEN.RelaTabId) == true || clsSqlViewRelaTabWApi.IsExist(objSqlViewRelaTabEN.RelaTabId) == true)
 {
     objSqlViewRelaTabEN.RelaTabId = clsSqlViewRelaTabWApi.GetMaxStrId();
 }
clsSqlViewRelaTabWApi.CheckPropertyNew(objSqlViewRelaTabEN); 
bool bolResult = clsSqlViewRelaTabWApi.AddNewRecord(objSqlViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabWApi.ReFreshCache(objSqlViewRelaTabEN.PrjId);
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
try
{
clsSqlViewRelaTabWApi.CheckPropertyNew(objSqlViewRelaTabEN); 
string strRelaTabId = clsSqlViewRelaTabWApi.AddNewRecordWithMaxId(objSqlViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabWApi.ReFreshCache(objSqlViewRelaTabEN.PrjId);
return strRelaTabId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objSqlViewRelaTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strWhereCond)
{
try
{
clsSqlViewRelaTabWApi.CheckPropertyNew(objSqlViewRelaTabEN); 
bool bolResult = clsSqlViewRelaTabWApi.UpdateWithCondition(objSqlViewRelaTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabWApi.ReFreshCache(objSqlViewRelaTabEN.PrjId);
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
 /// Sql视图相关表(SqlViewRelaTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsSqlViewRelaTabWApi
{
private static readonly string mstrApiControllerName = "SqlViewRelaTabApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsSqlViewRelaTabWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
if (!Object.Equals(null, objSqlViewRelaTabEN.RelaTabId) && GetStrLen(objSqlViewRelaTabEN.RelaTabId) > 8)
{
 throw new Exception("字段[相关表Id]的长度不能超过8!");
}
if (!Object.Equals(null, objSqlViewRelaTabEN.SqlViewId) && GetStrLen(objSqlViewRelaTabEN.SqlViewId) > 8)
{
 throw new Exception("字段[Sql视图Id]的长度不能超过8!");
}
if (!Object.Equals(null, objSqlViewRelaTabEN.TabId) && GetStrLen(objSqlViewRelaTabEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objSqlViewRelaTabEN.TabAliases) && GetStrLen(objSqlViewRelaTabEN.TabAliases) > 100)
{
 throw new Exception("字段[表别名]的长度不能超过100!");
}
if (!Object.Equals(null, objSqlViewRelaTabEN.RelaFldId) && GetStrLen(objSqlViewRelaTabEN.RelaFldId) > 8)
{
 throw new Exception("字段[关系字段]的长度不能超过8!");
}
if (!Object.Equals(null, objSqlViewRelaTabEN.OtherFldId) && GetStrLen(objSqlViewRelaTabEN.OtherFldId) > 8)
{
 throw new Exception("字段[其他表字段]的长度不能超过8!");
}
if (!Object.Equals(null, objSqlViewRelaTabEN.OtherTabId) && GetStrLen(objSqlViewRelaTabEN.OtherTabId) > 8)
{
 throw new Exception("字段[其他表Id]的长度不能超过8!");
}
if (!Object.Equals(null, objSqlViewRelaTabEN.SvRelaTabTypeId) && GetStrLen(objSqlViewRelaTabEN.SvRelaTabTypeId) > 2)
{
 throw new Exception("字段[Sql视图相关表类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objSqlViewRelaTabEN.TabRelationTypeId) && GetStrLen(objSqlViewRelaTabEN.TabRelationTypeId) > 2)
{
 throw new Exception("字段[表关系类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objSqlViewRelaTabEN.TabRelationText) && GetStrLen(objSqlViewRelaTabEN.TabRelationText) > 500)
{
 throw new Exception("字段[表关系文本]的长度不能超过500!");
}
if (!Object.Equals(null, objSqlViewRelaTabEN.PrjId) && GetStrLen(objSqlViewRelaTabEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objSqlViewRelaTabEN.UpdDate) && GetStrLen(objSqlViewRelaTabEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objSqlViewRelaTabEN.UpdUserId) && GetStrLen(objSqlViewRelaTabEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objSqlViewRelaTabEN.Memo) && GetStrLen(objSqlViewRelaTabEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objSqlViewRelaTabEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRelaTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSqlViewRelaTabEN GetObjByRelaTabId(string strRelaTabId)
{
if (strRelaTabId == "") return null;
string strAction = "GetObjByRelaTabId";
clsSqlViewRelaTabEN objSqlViewRelaTabEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strRelaTabId"] = strRelaTabId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objSqlViewRelaTabEN = JsonConvert.DeserializeObject<clsSqlViewRelaTabEN>(strJson);
return objSqlViewRelaTabEN;
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
public static clsSqlViewRelaTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsSqlViewRelaTabEN objSqlViewRelaTabEN;
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
objSqlViewRelaTabEN = JsonConvert.DeserializeObject<clsSqlViewRelaTabEN>(strJson);
return objSqlViewRelaTabEN;
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
 /// <param name = "strRelaTabId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSqlViewRelaTabEN GetObjByRelaTabIdCache(string strRelaTabId,string strPrjId)
{
if (string.IsNullOrEmpty(strRelaTabId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsSqlViewRelaTabEN._CurrTabName, strPrjId);
List<clsSqlViewRelaTabEN> arrSqlViewRelaTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsSqlViewRelaTabEN> arrSqlViewRelaTabObjLst_Sel =
from objSqlViewRelaTabEN in arrSqlViewRelaTabObjLstCache
where objSqlViewRelaTabEN.RelaTabId == strRelaTabId 
select objSqlViewRelaTabEN;
if (arrSqlViewRelaTabObjLst_Sel.Count() == 0)
{
   clsSqlViewRelaTabEN obj = clsSqlViewRelaTabWApi.GetObjByRelaTabId(strRelaTabId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrSqlViewRelaTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlViewRelaTabEN> GetObjLst(string strWhereCond)
{
 List<clsSqlViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewRelaTabEN>>(strJson);
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
 /// <param name = "arrRelaTabId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlViewRelaTabEN> GetObjLstByRelaTabIdLst(List<string> arrRelaTabId)
{
 List<clsSqlViewRelaTabEN> arrObjLst; 
string strAction = "GetObjLstByRelaTabIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelaTabId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewRelaTabEN>>(strJson);
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
 /// <param name = "arrRelaTabId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsSqlViewRelaTabEN> GetObjLstByRelaTabIdLstCache(List<string> arrRelaTabId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsSqlViewRelaTabEN._CurrTabName, strPrjId);
List<clsSqlViewRelaTabEN> arrSqlViewRelaTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsSqlViewRelaTabEN> arrSqlViewRelaTabObjLst_Sel =
from objSqlViewRelaTabEN in arrSqlViewRelaTabObjLstCache
where arrRelaTabId.Contains(objSqlViewRelaTabEN.RelaTabId)
select objSqlViewRelaTabEN;
return arrSqlViewRelaTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlViewRelaTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsSqlViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewRelaTabEN>>(strJson);
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
public static List<clsSqlViewRelaTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsSqlViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewRelaTabEN>>(strJson);
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
public static List<clsSqlViewRelaTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsSqlViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewRelaTabEN>>(strJson);
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
public static List<clsSqlViewRelaTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsSqlViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewRelaTabEN>>(strJson);
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
public static int DelRecord(string strRelaTabId)
{
string strAction = "DelRecord";
try
{
 clsSqlViewRelaTabEN objSqlViewRelaTabEN = clsSqlViewRelaTabWApi.GetObjByRelaTabId(strRelaTabId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strRelaTabId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsSqlViewRelaTabWApi.ReFreshCache(objSqlViewRelaTabEN.PrjId);
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
public static int DelSqlViewRelaTabs(List<string> arrRelaTabId)
{
string strAction = "DelSqlViewRelaTabs";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelaTabId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsSqlViewRelaTabEN objSqlViewRelaTabEN = clsSqlViewRelaTabWApi.GetObjByRelaTabId(arrRelaTabId[0]);
clsSqlViewRelaTabWApi.ReFreshCache(objSqlViewRelaTabEN.PrjId);
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
public static int DelSqlViewRelaTabsByCond(string strWhereCond)
{
string strAction = "DelSqlViewRelaTabsByCond";
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
public static bool AddNewRecord(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlViewRelaTabEN>(objSqlViewRelaTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabWApi.ReFreshCache(objSqlViewRelaTabEN.PrjId);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlViewRelaTabEN>(objSqlViewRelaTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabWApi.ReFreshCache(objSqlViewRelaTabEN.PrjId);
var strRelaTabId = (string)jobjReturn0["returnStr"];
return strRelaTabId;
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
public static bool UpdateRecord(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
if (string.IsNullOrEmpty(objSqlViewRelaTabEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSqlViewRelaTabEN.RelaTabId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlViewRelaTabEN>(objSqlViewRelaTabEN);
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
 /// <param name = "objSqlViewRelaTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objSqlViewRelaTabEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSqlViewRelaTabEN.RelaTabId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSqlViewRelaTabEN.RelaTabId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlViewRelaTabEN>(objSqlViewRelaTabEN);
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
public static bool IsExist(string strRelaTabId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strRelaTabId"] = strRelaTabId
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSqlViewRelaTabENS">源对象</param>
 /// <param name = "objSqlViewRelaTabENT">目标对象</param>
 public static void CopyTo(clsSqlViewRelaTabEN objSqlViewRelaTabENS, clsSqlViewRelaTabEN objSqlViewRelaTabENT)
{
try
{
objSqlViewRelaTabENT.RelaTabId = objSqlViewRelaTabENS.RelaTabId; //相关表Id
objSqlViewRelaTabENT.SqlViewId = objSqlViewRelaTabENS.SqlViewId; //Sql视图Id
objSqlViewRelaTabENT.TabId = objSqlViewRelaTabENS.TabId; //表ID
objSqlViewRelaTabENT.TabAliases = objSqlViewRelaTabENS.TabAliases; //表别名
objSqlViewRelaTabENT.RelaFldId = objSqlViewRelaTabENS.RelaFldId; //关系字段
objSqlViewRelaTabENT.OtherFldId = objSqlViewRelaTabENS.OtherFldId; //其他表字段
objSqlViewRelaTabENT.OtherTabId = objSqlViewRelaTabENS.OtherTabId; //其他表Id
objSqlViewRelaTabENT.SvRelaTabTypeId = objSqlViewRelaTabENS.SvRelaTabTypeId; //Sql视图相关表类型Id
objSqlViewRelaTabENT.TabRelationTypeId = objSqlViewRelaTabENS.TabRelationTypeId; //表关系类型Id
objSqlViewRelaTabENT.TabRelationText = objSqlViewRelaTabENS.TabRelationText; //表关系文本
objSqlViewRelaTabENT.OrderNum = objSqlViewRelaTabENS.OrderNum; //序号
objSqlViewRelaTabENT.PrjId = objSqlViewRelaTabENS.PrjId; //工程Id
objSqlViewRelaTabENT.UpdDate = objSqlViewRelaTabENS.UpdDate; //修改日期
objSqlViewRelaTabENT.UpdUserId = objSqlViewRelaTabENS.UpdUserId; //修改用户Id
objSqlViewRelaTabENT.Memo = objSqlViewRelaTabENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsSqlViewRelaTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsSqlViewRelaTabEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsSqlViewRelaTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsSqlViewRelaTabEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsSqlViewRelaTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsSqlViewRelaTabEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsSqlViewRelaTabWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsSqlViewRelaTabWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsSqlViewRelaTabEN._CurrTabName, strPrjId);
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
if (clsSqlViewRelaTabWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsSqlViewRelaTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsSqlViewRelaTabWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSqlViewRelaTabEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsSqlViewRelaTabWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsSqlViewRelaTabWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsSqlViewRelaTabEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsSqlViewRelaTabEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conSqlViewRelaTab.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsSqlViewRelaTabEN._CurrTabName, strPrjId);
List<clsSqlViewRelaTabEN> arrSqlViewRelaTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrSqlViewRelaTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSqlViewRelaTabEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsSqlViewRelaTabEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsSqlViewRelaTabWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsSqlViewRelaTabWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsSqlViewRelaTabEN._CurrTabName, strPrjId);
List<clsSqlViewRelaTabEN> arrSqlViewRelaTabObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrSqlViewRelaTabObjLstCache = CacheHelper.Get<List<clsSqlViewRelaTabEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrSqlViewRelaTabObjLstCache = CacheHelper.Get<List<clsSqlViewRelaTabEN>>(strKey);
}
return arrSqlViewRelaTabObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsSqlViewRelaTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conSqlViewRelaTab.RelaTabId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewRelaTab.SqlViewId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewRelaTab.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewRelaTab.TabAliases, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewRelaTab.RelaFldId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewRelaTab.OtherFldId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewRelaTab.OtherTabId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewRelaTab.SvRelaTabTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewRelaTab.TabRelationTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewRelaTab.TabRelationText, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewRelaTab.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conSqlViewRelaTab.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewRelaTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewRelaTab.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlViewRelaTab.Memo, Type.GetType("System.String"));
foreach (clsSqlViewRelaTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conSqlViewRelaTab.RelaTabId] = objInFor[conSqlViewRelaTab.RelaTabId];
objDR[conSqlViewRelaTab.SqlViewId] = objInFor[conSqlViewRelaTab.SqlViewId];
objDR[conSqlViewRelaTab.TabId] = objInFor[conSqlViewRelaTab.TabId];
objDR[conSqlViewRelaTab.TabAliases] = objInFor[conSqlViewRelaTab.TabAliases];
objDR[conSqlViewRelaTab.RelaFldId] = objInFor[conSqlViewRelaTab.RelaFldId];
objDR[conSqlViewRelaTab.OtherFldId] = objInFor[conSqlViewRelaTab.OtherFldId];
objDR[conSqlViewRelaTab.OtherTabId] = objInFor[conSqlViewRelaTab.OtherTabId];
objDR[conSqlViewRelaTab.SvRelaTabTypeId] = objInFor[conSqlViewRelaTab.SvRelaTabTypeId];
objDR[conSqlViewRelaTab.TabRelationTypeId] = objInFor[conSqlViewRelaTab.TabRelationTypeId];
objDR[conSqlViewRelaTab.TabRelationText] = objInFor[conSqlViewRelaTab.TabRelationText];
objDR[conSqlViewRelaTab.OrderNum] = objInFor[conSqlViewRelaTab.OrderNum];
objDR[conSqlViewRelaTab.PrjId] = objInFor[conSqlViewRelaTab.PrjId];
objDR[conSqlViewRelaTab.UpdDate] = objInFor[conSqlViewRelaTab.UpdDate];
objDR[conSqlViewRelaTab.UpdUserId] = objInFor[conSqlViewRelaTab.UpdUserId];
objDR[conSqlViewRelaTab.Memo] = objInFor[conSqlViewRelaTab.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// Sql视图相关表(SqlViewRelaTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4SqlViewRelaTab : clsCommFun4BLV2
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
clsSqlViewRelaTabWApi.ReFreshThisCache(strPrjId);
}
}

}