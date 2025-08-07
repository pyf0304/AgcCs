
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewGroupWApi
 表名:vViewGroup(00050158)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:29
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
public static class  clsvViewGroupWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetUserId(this clsvViewGroupEN objvViewGroupEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convViewGroup.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convViewGroup.UserId);
objvViewGroupEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.UserId) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.UserId, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.UserId] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetPrjId(this clsvViewGroupEN objvViewGroupEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convViewGroup.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewGroup.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewGroup.PrjId);
objvViewGroupEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.PrjId) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.PrjId, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.PrjId] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetMemo(this clsvViewGroupEN objvViewGroupEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewGroup.Memo);
objvViewGroupEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.Memo) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.Memo, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.Memo] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDomain">域/包名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetPrjDomain(this clsvViewGroupEN objvViewGroupEN, string strPrjDomain, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjDomain, 128, convViewGroup.PrjDomain);
objvViewGroupEN.PrjDomain = strPrjDomain; //域/包名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.PrjDomain) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.PrjDomain, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.PrjDomain] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetUpdDate(this clsvViewGroupEN objvViewGroupEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewGroup.UpdDate);
objvViewGroupEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.UpdDate) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.UpdDate, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.UpdDate] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutRelaTabId">输出数据源表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetOutRelaTabId(this clsvViewGroupEN objvViewGroupEN, string strOutRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOutRelaTabId, convViewGroup.OutRelaTabId);
clsCheckSql.CheckFieldLen(strOutRelaTabId, 8, convViewGroup.OutRelaTabId);
clsCheckSql.CheckFieldForeignKey(strOutRelaTabId, 8, convViewGroup.OutRelaTabId);
objvViewGroupEN.OutRelaTabId = strOutRelaTabId; //输出数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.OutRelaTabId) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.OutRelaTabId, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.OutRelaTabId] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strInSqlDsTypeId">输入数据源类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetInSqlDsTypeId(this clsvViewGroupEN objvViewGroupEN, string strInSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInSqlDsTypeId, 2, convViewGroup.InSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strInSqlDsTypeId, 2, convViewGroup.InSqlDsTypeId);
objvViewGroupEN.InSqlDsTypeId = strInSqlDsTypeId; //输入数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.InSqlDsTypeId) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.InSqlDsTypeId, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.InSqlDsTypeId] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strInRelaTabId">输入数据源表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetInRelaTabId(this clsvViewGroupEN objvViewGroupEN, string strInRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInRelaTabId, 8, convViewGroup.InRelaTabId);
clsCheckSql.CheckFieldForeignKey(strInRelaTabId, 8, convViewGroup.InRelaTabId);
objvViewGroupEN.InRelaTabId = strInRelaTabId; //输入数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.InRelaTabId) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.InRelaTabId, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.InRelaTabId] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewGroupId">界面组ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetViewGroupId(this clsvViewGroupEN objvViewGroupEN, string strViewGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewGroupId, 8, convViewGroup.ViewGroupId);
clsCheckSql.CheckFieldForeignKey(strViewGroupId, 8, convViewGroup.ViewGroupId);
objvViewGroupEN.ViewGroupId = strViewGroupId; //界面组ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.ViewGroupId) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.ViewGroupId, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.ViewGroupId] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewGroupName">界面组名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetViewGroupName(this clsvViewGroupEN objvViewGroupEN, string strViewGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewGroupName, convViewGroup.ViewGroupName);
clsCheckSql.CheckFieldLen(strViewGroupName, 30, convViewGroup.ViewGroupName);
objvViewGroupEN.ViewGroupName = strViewGroupName; //界面组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.ViewGroupName) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.ViewGroupName, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.ViewGroupName] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strActionPath">Action路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetActionPath(this clsvViewGroupEN objvViewGroupEN, string strActionPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strActionPath, convViewGroup.ActionPath);
clsCheckSql.CheckFieldLen(strActionPath, 100, convViewGroup.ActionPath);
objvViewGroupEN.ActionPath = strActionPath; //Action路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.ActionPath) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.ActionPath, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.ActionPath] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutSqlDsTypeId">输出数据源类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetOutSqlDsTypeId(this clsvViewGroupEN objvViewGroupEN, string strOutSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutSqlDsTypeId, 2, convViewGroup.OutSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strOutSqlDsTypeId, 2, convViewGroup.OutSqlDsTypeId);
objvViewGroupEN.OutSqlDsTypeId = strOutSqlDsTypeId; //输出数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.OutSqlDsTypeId) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.OutSqlDsTypeId, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.OutSqlDsTypeId] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutSqlDsTypeName">OUT数据源类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetOutSqlDsTypeName(this clsvViewGroupEN objvViewGroupEN, string strOutSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutSqlDsTypeName, 20, convViewGroup.OutSqlDsTypeName);
objvViewGroupEN.OutSqlDsTypeName = strOutSqlDsTypeName; //OUT数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.OutSqlDsTypeName) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.OutSqlDsTypeName, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.OutSqlDsTypeName] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutTabName">OUT表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetOutTabName(this clsvViewGroupEN objvViewGroupEN, string strOutTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutTabName, 40, convViewGroup.OutTabName);
objvViewGroupEN.OutTabName = strOutTabName; //OUT表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.OutTabName) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.OutTabName, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.OutTabName] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strInSqlDsTypeName">IN数据源类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetInSqlDsTypeName(this clsvViewGroupEN objvViewGroupEN, string strInSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInSqlDsTypeName, 20, convViewGroup.InSqlDsTypeName);
objvViewGroupEN.InSqlDsTypeName = strInSqlDsTypeName; //IN数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.InSqlDsTypeName) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.InSqlDsTypeName, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.InSqlDsTypeName] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strInTabName">IN表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetInTabName(this clsvViewGroupEN objvViewGroupEN, string strInTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInTabName, 40, convViewGroup.InTabName);
objvViewGroupEN.InTabName = strInTabName; //IN表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.InTabName) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.InTabName, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.InTabName] = strComparisonOp;
}
}
return objvViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strTableNameForProg">编程用表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetTableNameForProg(this clsvViewGroupEN objvViewGroupEN, string strTableNameForProg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableNameForProg, 50, convViewGroup.TableNameForProg);
objvViewGroupEN.TableNameForProg = strTableNameForProg; //编程用表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewGroupEN.dicFldComparisonOp.ContainsKey(convViewGroup.TableNameForProg) == false)
{
objvViewGroupEN.dicFldComparisonOp.Add(convViewGroup.TableNameForProg, strComparisonOp);
}
else
{
objvViewGroupEN.dicFldComparisonOp[convViewGroup.TableNameForProg] = strComparisonOp;
}
}
return objvViewGroupEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewGroupEN objvViewGroupCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewGroupCond.IsUpdated(convViewGroup.UserId) == true)
{
string strComparisonOpUserId = objvViewGroupCond.dicFldComparisonOp[convViewGroup.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.UserId, objvViewGroupCond.UserId, strComparisonOpUserId);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.PrjId) == true)
{
string strComparisonOpPrjId = objvViewGroupCond.dicFldComparisonOp[convViewGroup.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.PrjId, objvViewGroupCond.PrjId, strComparisonOpPrjId);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.Memo) == true)
{
string strComparisonOpMemo = objvViewGroupCond.dicFldComparisonOp[convViewGroup.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.Memo, objvViewGroupCond.Memo, strComparisonOpMemo);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.PrjDomain) == true)
{
string strComparisonOpPrjDomain = objvViewGroupCond.dicFldComparisonOp[convViewGroup.PrjDomain];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.PrjDomain, objvViewGroupCond.PrjDomain, strComparisonOpPrjDomain);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.UpdDate) == true)
{
string strComparisonOpUpdDate = objvViewGroupCond.dicFldComparisonOp[convViewGroup.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.UpdDate, objvViewGroupCond.UpdDate, strComparisonOpUpdDate);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.OutRelaTabId) == true)
{
string strComparisonOpOutRelaTabId = objvViewGroupCond.dicFldComparisonOp[convViewGroup.OutRelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.OutRelaTabId, objvViewGroupCond.OutRelaTabId, strComparisonOpOutRelaTabId);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.InSqlDsTypeId) == true)
{
string strComparisonOpInSqlDsTypeId = objvViewGroupCond.dicFldComparisonOp[convViewGroup.InSqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.InSqlDsTypeId, objvViewGroupCond.InSqlDsTypeId, strComparisonOpInSqlDsTypeId);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.InRelaTabId) == true)
{
string strComparisonOpInRelaTabId = objvViewGroupCond.dicFldComparisonOp[convViewGroup.InRelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.InRelaTabId, objvViewGroupCond.InRelaTabId, strComparisonOpInRelaTabId);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.ViewGroupId) == true)
{
string strComparisonOpViewGroupId = objvViewGroupCond.dicFldComparisonOp[convViewGroup.ViewGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.ViewGroupId, objvViewGroupCond.ViewGroupId, strComparisonOpViewGroupId);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.ViewGroupName) == true)
{
string strComparisonOpViewGroupName = objvViewGroupCond.dicFldComparisonOp[convViewGroup.ViewGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.ViewGroupName, objvViewGroupCond.ViewGroupName, strComparisonOpViewGroupName);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.ActionPath) == true)
{
string strComparisonOpActionPath = objvViewGroupCond.dicFldComparisonOp[convViewGroup.ActionPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.ActionPath, objvViewGroupCond.ActionPath, strComparisonOpActionPath);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.OutSqlDsTypeId) == true)
{
string strComparisonOpOutSqlDsTypeId = objvViewGroupCond.dicFldComparisonOp[convViewGroup.OutSqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.OutSqlDsTypeId, objvViewGroupCond.OutSqlDsTypeId, strComparisonOpOutSqlDsTypeId);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.OutSqlDsTypeName) == true)
{
string strComparisonOpOutSqlDsTypeName = objvViewGroupCond.dicFldComparisonOp[convViewGroup.OutSqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.OutSqlDsTypeName, objvViewGroupCond.OutSqlDsTypeName, strComparisonOpOutSqlDsTypeName);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.OutTabName) == true)
{
string strComparisonOpOutTabName = objvViewGroupCond.dicFldComparisonOp[convViewGroup.OutTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.OutTabName, objvViewGroupCond.OutTabName, strComparisonOpOutTabName);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.InSqlDsTypeName) == true)
{
string strComparisonOpInSqlDsTypeName = objvViewGroupCond.dicFldComparisonOp[convViewGroup.InSqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.InSqlDsTypeName, objvViewGroupCond.InSqlDsTypeName, strComparisonOpInSqlDsTypeName);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.InTabName) == true)
{
string strComparisonOpInTabName = objvViewGroupCond.dicFldComparisonOp[convViewGroup.InTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.InTabName, objvViewGroupCond.InTabName, strComparisonOpInTabName);
}
if (objvViewGroupCond.IsUpdated(convViewGroup.TableNameForProg) == true)
{
string strComparisonOpTableNameForProg = objvViewGroupCond.dicFldComparisonOp[convViewGroup.TableNameForProg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewGroup.TableNameForProg, objvViewGroupCond.TableNameForProg, strComparisonOpTableNameForProg);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v界面组(vViewGroup)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvViewGroupWApi
{
private static readonly string mstrApiControllerName = "vViewGroupApi";

 public clsvViewGroupWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ViewGroupId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v界面组]...","0");
List<clsvViewGroupEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ViewGroupId";
objDDL.DataTextField="ViewGroupName";
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
public static void BindCbo_ViewGroupId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convViewGroup.ViewGroupId); 
List<clsvViewGroupEN> arrObjLst = clsvViewGroupWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN()
{
ViewGroupId = "0",
ViewGroupName = "选[v界面组]..."
};
arrObjLstSel.Insert(0, objvViewGroupEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convViewGroup.ViewGroupId;
objComboBox.DisplayMember = convViewGroup.ViewGroupName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewGroupEN GetObjByViewGroupId(string strViewGroupId)
{
if (strViewGroupId == "") return null;
string strAction = "GetObjByViewGroupId";
clsvViewGroupEN objvViewGroupEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewGroupId"] = strViewGroupId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvViewGroupEN = JsonConvert.DeserializeObject<clsvViewGroupEN>(strJson);
return objvViewGroupEN;
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
public static clsvViewGroupEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvViewGroupEN objvViewGroupEN;
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
objvViewGroupEN = JsonConvert.DeserializeObject<clsvViewGroupEN>(strJson);
return objvViewGroupEN;
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
//该表没有使用Cache,不需要生成[GetViewGroupNameByViewGroupIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewGroupEN> GetObjLst(string strWhereCond)
{
 List<clsvViewGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewGroupEN>>(strJson);
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
 /// <param name = "arrViewGroupId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewGroupEN> GetObjLstByViewGroupIdLst(List<string> arrViewGroupId)
{
 List<clsvViewGroupEN> arrObjLst; 
string strAction = "GetObjLstByViewGroupIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewGroupId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewGroupEN>>(strJson);
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
public static List<clsvViewGroupEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvViewGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewGroupEN>>(strJson);
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
public static List<clsvViewGroupEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvViewGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewGroupEN>>(strJson);
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
public static List<clsvViewGroupEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvViewGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewGroupEN>>(strJson);
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
public static List<clsvViewGroupEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvViewGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewGroupEN>>(strJson);
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
public static bool IsExist(string strViewGroupId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewGroupId"] = strViewGroupId
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
 /// <param name = "objvViewGroupENS">源对象</param>
 /// <param name = "objvViewGroupENT">目标对象</param>
 public static void CopyTo(clsvViewGroupEN objvViewGroupENS, clsvViewGroupEN objvViewGroupENT)
{
try
{
objvViewGroupENT.UserId = objvViewGroupENS.UserId; //用户Id
objvViewGroupENT.PrjId = objvViewGroupENS.PrjId; //工程Id
objvViewGroupENT.Memo = objvViewGroupENS.Memo; //说明
objvViewGroupENT.PrjDomain = objvViewGroupENS.PrjDomain; //域/包名
objvViewGroupENT.UpdDate = objvViewGroupENS.UpdDate; //修改日期
objvViewGroupENT.OutRelaTabId = objvViewGroupENS.OutRelaTabId; //输出数据源表ID
objvViewGroupENT.InSqlDsTypeId = objvViewGroupENS.InSqlDsTypeId; //输入数据源类型
objvViewGroupENT.InRelaTabId = objvViewGroupENS.InRelaTabId; //输入数据源表ID
objvViewGroupENT.ViewGroupId = objvViewGroupENS.ViewGroupId; //界面组ID
objvViewGroupENT.ViewGroupName = objvViewGroupENS.ViewGroupName; //界面组名称
objvViewGroupENT.ActionPath = objvViewGroupENS.ActionPath; //Action路径
objvViewGroupENT.OutSqlDsTypeId = objvViewGroupENS.OutSqlDsTypeId; //输出数据源类型
objvViewGroupENT.OutSqlDsTypeName = objvViewGroupENS.OutSqlDsTypeName; //OUT数据源类型
objvViewGroupENT.OutTabName = objvViewGroupENS.OutTabName; //OUT表
objvViewGroupENT.InSqlDsTypeName = objvViewGroupENS.InSqlDsTypeName; //IN数据源类型
objvViewGroupENT.InTabName = objvViewGroupENS.InTabName; //IN表
objvViewGroupENT.TableNameForProg = objvViewGroupENS.TableNameForProg; //编程用表名
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
public static DataTable ToDataTable(List<clsvViewGroupEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvViewGroupEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvViewGroupEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvViewGroupEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvViewGroupEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvViewGroupEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvViewGroupWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvViewGroupWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvViewGroupEN._CurrTabName, strPrjId);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvViewGroupEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convViewGroup.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.PrjDomain, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.OutRelaTabId, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.InSqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.InRelaTabId, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.ViewGroupId, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.ViewGroupName, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.ActionPath, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.OutSqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.OutSqlDsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.OutTabName, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.InSqlDsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.InTabName, Type.GetType("System.String"));
objDT.Columns.Add(convViewGroup.TableNameForProg, Type.GetType("System.String"));
foreach (clsvViewGroupEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convViewGroup.UserId] = objInFor[convViewGroup.UserId];
objDR[convViewGroup.PrjId] = objInFor[convViewGroup.PrjId];
objDR[convViewGroup.Memo] = objInFor[convViewGroup.Memo];
objDR[convViewGroup.PrjDomain] = objInFor[convViewGroup.PrjDomain];
objDR[convViewGroup.UpdDate] = objInFor[convViewGroup.UpdDate];
objDR[convViewGroup.OutRelaTabId] = objInFor[convViewGroup.OutRelaTabId];
objDR[convViewGroup.InSqlDsTypeId] = objInFor[convViewGroup.InSqlDsTypeId];
objDR[convViewGroup.InRelaTabId] = objInFor[convViewGroup.InRelaTabId];
objDR[convViewGroup.ViewGroupId] = objInFor[convViewGroup.ViewGroupId];
objDR[convViewGroup.ViewGroupName] = objInFor[convViewGroup.ViewGroupName];
objDR[convViewGroup.ActionPath] = objInFor[convViewGroup.ActionPath];
objDR[convViewGroup.OutSqlDsTypeId] = objInFor[convViewGroup.OutSqlDsTypeId];
objDR[convViewGroup.OutSqlDsTypeName] = objInFor[convViewGroup.OutSqlDsTypeName];
objDR[convViewGroup.OutTabName] = objInFor[convViewGroup.OutTabName];
objDR[convViewGroup.InSqlDsTypeName] = objInFor[convViewGroup.InSqlDsTypeName];
objDR[convViewGroup.InTabName] = objInFor[convViewGroup.InTabName];
objDR[convViewGroup.TableNameForProg] = objInFor[convViewGroup.TableNameForProg];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}