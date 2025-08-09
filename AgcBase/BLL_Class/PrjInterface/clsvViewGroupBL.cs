
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewGroupBL
 表名:vViewGroup(00050158)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:58
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
public static class  clsvViewGroupBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strViewGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewGroupEN GetObj(this K_ViewGroupId_vViewGroup myKey)
{
clsvViewGroupEN objvViewGroupEN = clsvViewGroupBL.vViewGroupDA.GetObjByViewGroupId(myKey.Value);
return objvViewGroupEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetUserId(this clsvViewGroupEN objvViewGroupEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convViewGroup.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convViewGroup.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetPrjId(this clsvViewGroupEN objvViewGroupEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convViewGroup.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewGroup.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewGroup.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetMemo(this clsvViewGroupEN objvViewGroupEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewGroup.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetPrjDomain(this clsvViewGroupEN objvViewGroupEN, string strPrjDomain, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDomain, 128, convViewGroup.PrjDomain);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetUpdDate(this clsvViewGroupEN objvViewGroupEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewGroup.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetOutRelaTabId(this clsvViewGroupEN objvViewGroupEN, string strOutRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOutRelaTabId, convViewGroup.OutRelaTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutRelaTabId, 8, convViewGroup.OutRelaTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOutRelaTabId, 8, convViewGroup.OutRelaTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetInSqlDsTypeId(this clsvViewGroupEN objvViewGroupEN, string strInSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInSqlDsTypeId, 2, convViewGroup.InSqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInSqlDsTypeId, 2, convViewGroup.InSqlDsTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetInRelaTabId(this clsvViewGroupEN objvViewGroupEN, string strInRelaTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInRelaTabId, 8, convViewGroup.InRelaTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInRelaTabId, 8, convViewGroup.InRelaTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetViewGroupId(this clsvViewGroupEN objvViewGroupEN, string strViewGroupId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewGroupId, 8, convViewGroup.ViewGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewGroupId, 8, convViewGroup.ViewGroupId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetViewGroupName(this clsvViewGroupEN objvViewGroupEN, string strViewGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewGroupName, convViewGroup.ViewGroupName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewGroupName, 30, convViewGroup.ViewGroupName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetActionPath(this clsvViewGroupEN objvViewGroupEN, string strActionPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strActionPath, convViewGroup.ActionPath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strActionPath, 100, convViewGroup.ActionPath);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetOutSqlDsTypeId(this clsvViewGroupEN objvViewGroupEN, string strOutSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutSqlDsTypeId, 2, convViewGroup.OutSqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOutSqlDsTypeId, 2, convViewGroup.OutSqlDsTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetOutSqlDsTypeName(this clsvViewGroupEN objvViewGroupEN, string strOutSqlDsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutSqlDsTypeName, 20, convViewGroup.OutSqlDsTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetOutTabName(this clsvViewGroupEN objvViewGroupEN, string strOutTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutTabName, 40, convViewGroup.OutTabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetInSqlDsTypeName(this clsvViewGroupEN objvViewGroupEN, string strInSqlDsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInSqlDsTypeName, 20, convViewGroup.InSqlDsTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetInTabName(this clsvViewGroupEN objvViewGroupEN, string strInTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInTabName, 40, convViewGroup.InTabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewGroupEN SetTableNameForProg(this clsvViewGroupEN objvViewGroupEN, string strTableNameForProg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableNameForProg, 50, convViewGroup.TableNameForProg);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvViewGroupENS">源对象</param>
 /// <param name = "objvViewGroupENT">目标对象</param>
 public static void CopyTo(this clsvViewGroupEN objvViewGroupENS, clsvViewGroupEN objvViewGroupENT)
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
 /// <param name = "objvViewGroupENS">源对象</param>
 /// <returns>目标对象=>clsvViewGroupEN:objvViewGroupENT</returns>
 public static clsvViewGroupEN CopyTo(this clsvViewGroupEN objvViewGroupENS)
{
try
{
 clsvViewGroupEN objvViewGroupENT = new clsvViewGroupEN()
{
UserId = objvViewGroupENS.UserId, //用户Id
PrjId = objvViewGroupENS.PrjId, //工程Id
Memo = objvViewGroupENS.Memo, //说明
PrjDomain = objvViewGroupENS.PrjDomain, //域/包名
UpdDate = objvViewGroupENS.UpdDate, //修改日期
OutRelaTabId = objvViewGroupENS.OutRelaTabId, //输出数据源表ID
InSqlDsTypeId = objvViewGroupENS.InSqlDsTypeId, //输入数据源类型
InRelaTabId = objvViewGroupENS.InRelaTabId, //输入数据源表ID
ViewGroupId = objvViewGroupENS.ViewGroupId, //界面组ID
ViewGroupName = objvViewGroupENS.ViewGroupName, //界面组名称
ActionPath = objvViewGroupENS.ActionPath, //Action路径
OutSqlDsTypeId = objvViewGroupENS.OutSqlDsTypeId, //输出数据源类型
OutSqlDsTypeName = objvViewGroupENS.OutSqlDsTypeName, //OUT数据源类型
OutTabName = objvViewGroupENS.OutTabName, //OUT表
InSqlDsTypeName = objvViewGroupENS.InSqlDsTypeName, //IN数据源类型
InTabName = objvViewGroupENS.InTabName, //IN表
TableNameForProg = objvViewGroupENS.TableNameForProg, //编程用表名
};
 return objvViewGroupENT;
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
public static void CheckProperty4Condition(this clsvViewGroupEN objvViewGroupEN)
{
 clsvViewGroupBL.vViewGroupDA.CheckProperty4Condition(objvViewGroupEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vViewGroup
{
public virtual bool UpdRelaTabDate(string strViewGroupId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v界面组(vViewGroup)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvViewGroupBL
{
public static RelatedActions_vViewGroup relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvViewGroupDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvViewGroupDA vViewGroupDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvViewGroupDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvViewGroupBL()
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
if (string.IsNullOrEmpty(clsvViewGroupEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewGroupEN._ConnectString);
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
public static DataTable GetDataTable_vViewGroup(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewGroupDA.GetDataTable_vViewGroup(strWhereCond);
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
objDT = vViewGroupDA.GetDataTable(strWhereCond);
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
objDT = vViewGroupDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vViewGroupDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vViewGroupDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vViewGroupDA.GetDataTable_Top(objTopPara);
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
objDT = vViewGroupDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vViewGroupDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vViewGroupDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewGroupIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvViewGroupEN> GetObjLstByViewGroupIdLst(List<string> arrViewGroupIdLst)
{
List<clsvViewGroupEN> arrObjLst = new List<clsvViewGroupEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewGroupIdLst, true);
 string strWhereCond = string.Format("ViewGroupId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN();
try
{
objvViewGroupEN.UserId = objRow[convViewGroup.UserId].ToString().Trim(); //用户Id
objvViewGroupEN.PrjId = objRow[convViewGroup.PrjId].ToString().Trim(); //工程Id
objvViewGroupEN.Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(); //说明
objvViewGroupEN.PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(); //域/包名
objvViewGroupEN.UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(); //修改日期
objvViewGroupEN.OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objvViewGroupEN.InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewGroupEN.InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objvViewGroupEN.ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objvViewGroupEN.ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objvViewGroupEN.ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(); //Action路径
objvViewGroupEN.OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewGroupEN.OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型
objvViewGroupEN.OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(); //OUT表
objvViewGroupEN.InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型
objvViewGroupEN.InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(); //IN表
objvViewGroupEN.TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewGroupIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvViewGroupEN> GetObjLstByViewGroupIdLstCache(List<string> arrViewGroupIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvViewGroupEN._CurrTabName, strPrjId);
List<clsvViewGroupEN> arrvViewGroupObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewGroupEN> arrvViewGroupObjLst_Sel =
arrvViewGroupObjLstCache
.Where(x => arrViewGroupIdLst.Contains(x.ViewGroupId));
return arrvViewGroupObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewGroupEN> GetObjLst(string strWhereCond)
{
List<clsvViewGroupEN> arrObjLst = new List<clsvViewGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN();
try
{
objvViewGroupEN.UserId = objRow[convViewGroup.UserId].ToString().Trim(); //用户Id
objvViewGroupEN.PrjId = objRow[convViewGroup.PrjId].ToString().Trim(); //工程Id
objvViewGroupEN.Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(); //说明
objvViewGroupEN.PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(); //域/包名
objvViewGroupEN.UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(); //修改日期
objvViewGroupEN.OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objvViewGroupEN.InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewGroupEN.InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objvViewGroupEN.ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objvViewGroupEN.ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objvViewGroupEN.ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(); //Action路径
objvViewGroupEN.OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewGroupEN.OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型
objvViewGroupEN.OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(); //OUT表
objvViewGroupEN.InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型
objvViewGroupEN.InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(); //IN表
objvViewGroupEN.TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewGroupEN);
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
public static List<clsvViewGroupEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewGroupEN> arrObjLst = new List<clsvViewGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN();
try
{
objvViewGroupEN.UserId = objRow[convViewGroup.UserId].ToString().Trim(); //用户Id
objvViewGroupEN.PrjId = objRow[convViewGroup.PrjId].ToString().Trim(); //工程Id
objvViewGroupEN.Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(); //说明
objvViewGroupEN.PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(); //域/包名
objvViewGroupEN.UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(); //修改日期
objvViewGroupEN.OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objvViewGroupEN.InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewGroupEN.InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objvViewGroupEN.ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objvViewGroupEN.ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objvViewGroupEN.ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(); //Action路径
objvViewGroupEN.OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewGroupEN.OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型
objvViewGroupEN.OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(); //OUT表
objvViewGroupEN.InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型
objvViewGroupEN.InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(); //IN表
objvViewGroupEN.TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvViewGroupCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvViewGroupEN> GetSubObjLstCache(clsvViewGroupEN objvViewGroupCond)
{
 string strPrjId = objvViewGroupCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvViewGroupBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvViewGroupEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewGroupEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewGroup._AttributeName)
{
if (objvViewGroupCond.IsUpdated(strFldName) == false) continue;
if (objvViewGroupCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewGroupCond[strFldName].ToString());
}
else
{
if (objvViewGroupCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewGroupCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewGroupCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewGroupCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewGroupCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewGroupCond[strFldName]));
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
public static List<clsvViewGroupEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvViewGroupEN> arrObjLst = new List<clsvViewGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN();
try
{
objvViewGroupEN.UserId = objRow[convViewGroup.UserId].ToString().Trim(); //用户Id
objvViewGroupEN.PrjId = objRow[convViewGroup.PrjId].ToString().Trim(); //工程Id
objvViewGroupEN.Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(); //说明
objvViewGroupEN.PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(); //域/包名
objvViewGroupEN.UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(); //修改日期
objvViewGroupEN.OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objvViewGroupEN.InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewGroupEN.InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objvViewGroupEN.ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objvViewGroupEN.ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objvViewGroupEN.ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(); //Action路径
objvViewGroupEN.OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewGroupEN.OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型
objvViewGroupEN.OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(); //OUT表
objvViewGroupEN.InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型
objvViewGroupEN.InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(); //IN表
objvViewGroupEN.TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewGroupEN);
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
public static List<clsvViewGroupEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvViewGroupEN> arrObjLst = new List<clsvViewGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN();
try
{
objvViewGroupEN.UserId = objRow[convViewGroup.UserId].ToString().Trim(); //用户Id
objvViewGroupEN.PrjId = objRow[convViewGroup.PrjId].ToString().Trim(); //工程Id
objvViewGroupEN.Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(); //说明
objvViewGroupEN.PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(); //域/包名
objvViewGroupEN.UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(); //修改日期
objvViewGroupEN.OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objvViewGroupEN.InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewGroupEN.InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objvViewGroupEN.ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objvViewGroupEN.ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objvViewGroupEN.ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(); //Action路径
objvViewGroupEN.OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewGroupEN.OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型
objvViewGroupEN.OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(); //OUT表
objvViewGroupEN.InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型
objvViewGroupEN.InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(); //IN表
objvViewGroupEN.TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewGroupEN);
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
List<clsvViewGroupEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvViewGroupEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewGroupEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvViewGroupEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvViewGroupEN> arrObjLst = new List<clsvViewGroupEN>(); 
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
	clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN();
try
{
objvViewGroupEN.UserId = objRow[convViewGroup.UserId].ToString().Trim(); //用户Id
objvViewGroupEN.PrjId = objRow[convViewGroup.PrjId].ToString().Trim(); //工程Id
objvViewGroupEN.Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(); //说明
objvViewGroupEN.PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(); //域/包名
objvViewGroupEN.UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(); //修改日期
objvViewGroupEN.OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objvViewGroupEN.InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewGroupEN.InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objvViewGroupEN.ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objvViewGroupEN.ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objvViewGroupEN.ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(); //Action路径
objvViewGroupEN.OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewGroupEN.OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型
objvViewGroupEN.OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(); //OUT表
objvViewGroupEN.InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型
objvViewGroupEN.InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(); //IN表
objvViewGroupEN.TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewGroupEN);
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
public static List<clsvViewGroupEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvViewGroupEN> arrObjLst = new List<clsvViewGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN();
try
{
objvViewGroupEN.UserId = objRow[convViewGroup.UserId].ToString().Trim(); //用户Id
objvViewGroupEN.PrjId = objRow[convViewGroup.PrjId].ToString().Trim(); //工程Id
objvViewGroupEN.Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(); //说明
objvViewGroupEN.PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(); //域/包名
objvViewGroupEN.UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(); //修改日期
objvViewGroupEN.OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objvViewGroupEN.InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewGroupEN.InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objvViewGroupEN.ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objvViewGroupEN.ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objvViewGroupEN.ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(); //Action路径
objvViewGroupEN.OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewGroupEN.OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型
objvViewGroupEN.OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(); //OUT表
objvViewGroupEN.InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型
objvViewGroupEN.InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(); //IN表
objvViewGroupEN.TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewGroupEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvViewGroupEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvViewGroupEN> arrObjLst = new List<clsvViewGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN();
try
{
objvViewGroupEN.UserId = objRow[convViewGroup.UserId].ToString().Trim(); //用户Id
objvViewGroupEN.PrjId = objRow[convViewGroup.PrjId].ToString().Trim(); //工程Id
objvViewGroupEN.Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(); //说明
objvViewGroupEN.PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(); //域/包名
objvViewGroupEN.UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(); //修改日期
objvViewGroupEN.OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objvViewGroupEN.InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewGroupEN.InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objvViewGroupEN.ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objvViewGroupEN.ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objvViewGroupEN.ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(); //Action路径
objvViewGroupEN.OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewGroupEN.OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型
objvViewGroupEN.OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(); //OUT表
objvViewGroupEN.InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型
objvViewGroupEN.InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(); //IN表
objvViewGroupEN.TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewGroupEN);
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
public static List<clsvViewGroupEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvViewGroupEN> arrObjLst = new List<clsvViewGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN();
try
{
objvViewGroupEN.UserId = objRow[convViewGroup.UserId].ToString().Trim(); //用户Id
objvViewGroupEN.PrjId = objRow[convViewGroup.PrjId].ToString().Trim(); //工程Id
objvViewGroupEN.Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(); //说明
objvViewGroupEN.PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(); //域/包名
objvViewGroupEN.UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(); //修改日期
objvViewGroupEN.OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objvViewGroupEN.InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewGroupEN.InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objvViewGroupEN.ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objvViewGroupEN.ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objvViewGroupEN.ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(); //Action路径
objvViewGroupEN.OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewGroupEN.OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型
objvViewGroupEN.OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(); //OUT表
objvViewGroupEN.InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型
objvViewGroupEN.InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(); //IN表
objvViewGroupEN.TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewGroupEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvViewGroupEN> arrObjLst = new List<clsvViewGroupEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN();
try
{
objvViewGroupEN.UserId = objRow[convViewGroup.UserId].ToString().Trim(); //用户Id
objvViewGroupEN.PrjId = objRow[convViewGroup.PrjId].ToString().Trim(); //工程Id
objvViewGroupEN.Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(); //说明
objvViewGroupEN.PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(); //域/包名
objvViewGroupEN.UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(); //修改日期
objvViewGroupEN.OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objvViewGroupEN.InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewGroupEN.InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objvViewGroupEN.ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objvViewGroupEN.ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objvViewGroupEN.ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(); //Action路径
objvViewGroupEN.OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewGroupEN.OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型
objvViewGroupEN.OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(); //OUT表
objvViewGroupEN.InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型
objvViewGroupEN.InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(); //IN表
objvViewGroupEN.TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewGroupEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvViewGroupEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvViewGroup(ref clsvViewGroupEN objvViewGroupEN)
{
bool bolResult = vViewGroupDA.GetvViewGroup(ref objvViewGroupEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strViewGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewGroupEN GetObjByViewGroupId(string strViewGroupId)
{
if (strViewGroupId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strViewGroupId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strViewGroupId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strViewGroupId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvViewGroupEN objvViewGroupEN = vViewGroupDA.GetObjByViewGroupId(strViewGroupId);
return objvViewGroupEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvViewGroupEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvViewGroupEN objvViewGroupEN = vViewGroupDA.GetFirstObj(strWhereCond);
 return objvViewGroupEN;
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
public static clsvViewGroupEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvViewGroupEN objvViewGroupEN = vViewGroupDA.GetObjByDataRow(objRow);
 return objvViewGroupEN;
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
public static clsvViewGroupEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvViewGroupEN objvViewGroupEN = vViewGroupDA.GetObjByDataRow(objRow);
 return objvViewGroupEN;
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
 /// <param name = "strViewGroupId">所给的关键字</param>
 /// <param name = "lstvViewGroupObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewGroupEN GetObjByViewGroupIdFromList(string strViewGroupId, List<clsvViewGroupEN> lstvViewGroupObjLst)
{
foreach (clsvViewGroupEN objvViewGroupEN in lstvViewGroupObjLst)
{
if (objvViewGroupEN.ViewGroupId == strViewGroupId)
{
return objvViewGroupEN;
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
 string strViewGroupId;
 try
 {
 strViewGroupId = new clsvViewGroupDA().GetFirstID(strWhereCond);
 return strViewGroupId;
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
 arrList = vViewGroupDA.GetID(strWhereCond);
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
bool bolIsExist = vViewGroupDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strViewGroupId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strViewGroupId)
{
if (string.IsNullOrEmpty(strViewGroupId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strViewGroupId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vViewGroupDA.IsExist(strViewGroupId);
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
 bolIsExist = clsvViewGroupDA.IsExistTable();
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
 bolIsExist = vViewGroupDA.IsExistTable(strTabName);
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
 /// <param name = "objvViewGroupEN">源简化对象</param>
 public static void SetUpdFlag(clsvViewGroupEN objvViewGroupEN)
{
try
{
objvViewGroupEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvViewGroupEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convViewGroup.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.UserId = objvViewGroupEN.UserId; //用户Id
}
if (arrFldSet.Contains(convViewGroup.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.PrjId = objvViewGroupEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convViewGroup.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.Memo = objvViewGroupEN.Memo == "[null]" ? null :  objvViewGroupEN.Memo; //说明
}
if (arrFldSet.Contains(convViewGroup.PrjDomain, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.PrjDomain = objvViewGroupEN.PrjDomain == "[null]" ? null :  objvViewGroupEN.PrjDomain; //域/包名
}
if (arrFldSet.Contains(convViewGroup.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.UpdDate = objvViewGroupEN.UpdDate == "[null]" ? null :  objvViewGroupEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convViewGroup.OutRelaTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.OutRelaTabId = objvViewGroupEN.OutRelaTabId; //输出数据源表ID
}
if (arrFldSet.Contains(convViewGroup.InSqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.InSqlDsTypeId = objvViewGroupEN.InSqlDsTypeId == "[null]" ? null :  objvViewGroupEN.InSqlDsTypeId; //输入数据源类型
}
if (arrFldSet.Contains(convViewGroup.InRelaTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.InRelaTabId = objvViewGroupEN.InRelaTabId == "[null]" ? null :  objvViewGroupEN.InRelaTabId; //输入数据源表ID
}
if (arrFldSet.Contains(convViewGroup.ViewGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.ViewGroupId = objvViewGroupEN.ViewGroupId; //界面组ID
}
if (arrFldSet.Contains(convViewGroup.ViewGroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.ViewGroupName = objvViewGroupEN.ViewGroupName; //界面组名称
}
if (arrFldSet.Contains(convViewGroup.ActionPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.ActionPath = objvViewGroupEN.ActionPath; //Action路径
}
if (arrFldSet.Contains(convViewGroup.OutSqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.OutSqlDsTypeId = objvViewGroupEN.OutSqlDsTypeId == "[null]" ? null :  objvViewGroupEN.OutSqlDsTypeId; //输出数据源类型
}
if (arrFldSet.Contains(convViewGroup.OutSqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.OutSqlDsTypeName = objvViewGroupEN.OutSqlDsTypeName == "[null]" ? null :  objvViewGroupEN.OutSqlDsTypeName; //OUT数据源类型
}
if (arrFldSet.Contains(convViewGroup.OutTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.OutTabName = objvViewGroupEN.OutTabName == "[null]" ? null :  objvViewGroupEN.OutTabName; //OUT表
}
if (arrFldSet.Contains(convViewGroup.InSqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.InSqlDsTypeName = objvViewGroupEN.InSqlDsTypeName == "[null]" ? null :  objvViewGroupEN.InSqlDsTypeName; //IN数据源类型
}
if (arrFldSet.Contains(convViewGroup.InTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.InTabName = objvViewGroupEN.InTabName == "[null]" ? null :  objvViewGroupEN.InTabName; //IN表
}
if (arrFldSet.Contains(convViewGroup.TableNameForProg, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewGroupEN.TableNameForProg = objvViewGroupEN.TableNameForProg == "[null]" ? null :  objvViewGroupEN.TableNameForProg; //编程用表名
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
 /// <param name = "objvViewGroupEN">源简化对象</param>
 public static void AccessFldValueNull(clsvViewGroupEN objvViewGroupEN)
{
try
{
if (objvViewGroupEN.Memo == "[null]") objvViewGroupEN.Memo = null; //说明
if (objvViewGroupEN.PrjDomain == "[null]") objvViewGroupEN.PrjDomain = null; //域/包名
if (objvViewGroupEN.UpdDate == "[null]") objvViewGroupEN.UpdDate = null; //修改日期
if (objvViewGroupEN.InSqlDsTypeId == "[null]") objvViewGroupEN.InSqlDsTypeId = null; //输入数据源类型
if (objvViewGroupEN.InRelaTabId == "[null]") objvViewGroupEN.InRelaTabId = null; //输入数据源表ID
if (objvViewGroupEN.OutSqlDsTypeId == "[null]") objvViewGroupEN.OutSqlDsTypeId = null; //输出数据源类型
if (objvViewGroupEN.OutSqlDsTypeName == "[null]") objvViewGroupEN.OutSqlDsTypeName = null; //OUT数据源类型
if (objvViewGroupEN.OutTabName == "[null]") objvViewGroupEN.OutTabName = null; //OUT表
if (objvViewGroupEN.InSqlDsTypeName == "[null]") objvViewGroupEN.InSqlDsTypeName = null; //IN数据源类型
if (objvViewGroupEN.InTabName == "[null]") objvViewGroupEN.InTabName = null; //IN表
if (objvViewGroupEN.TableNameForProg == "[null]") objvViewGroupEN.TableNameForProg = null; //编程用表名
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
public static void CheckProperty4Condition(clsvViewGroupEN objvViewGroupEN)
{
 vViewGroupDA.CheckProperty4Condition(objvViewGroupEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_ViewGroupId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convViewGroup.ViewGroupId); 
List<clsvViewGroupEN> arrObjLst = clsvViewGroupBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_ViewGroupId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v界面组]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convViewGroup.ViewGroupId); 
IEnumerable<clsvViewGroupEN> arrObjLst = clsvViewGroupBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = convViewGroup.ViewGroupId;
objDDL.DataTextField = convViewGroup.ViewGroupName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ViewGroupIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v界面组]...","0");
List<clsvViewGroupEN> arrvViewGroupObjLst = GetAllvViewGroupObjLstCache(strPrjId); 
objDDL.DataValueField = convViewGroup.ViewGroupId;
objDDL.DataTextField = convViewGroup.ViewGroupName;
objDDL.DataSource = arrvViewGroupObjLst;
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
if (clsSQLDSTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewGroupBL没有刷新缓存机制(clsViewGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewGroupId");
//if (arrvViewGroupObjLstCache == null)
//{
//arrvViewGroupObjLstCache = vViewGroupDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strViewGroupId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewGroupEN GetObjByViewGroupIdCache(string strViewGroupId, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvViewGroupEN._CurrTabName, strPrjId);
List<clsvViewGroupEN> arrvViewGroupObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewGroupEN> arrvViewGroupObjLst_Sel =
arrvViewGroupObjLstCache
.Where(x=> x.ViewGroupId == strViewGroupId 
);
if (arrvViewGroupObjLst_Sel.Count() == 0)
{
   clsvViewGroupEN obj = clsvViewGroupBL.GetObjByViewGroupId(strViewGroupId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strViewGroupId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvViewGroupObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetViewGroupNameByViewGroupIdCache(string strViewGroupId, string strPrjId)
{
if (string.IsNullOrEmpty(strViewGroupId) == true) return "";
//获取缓存中的对象列表
clsvViewGroupEN objvViewGroup = GetObjByViewGroupIdCache(strViewGroupId, strPrjId);
if (objvViewGroup == null) return "";
return objvViewGroup.ViewGroupName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByViewGroupIdCache(string strViewGroupId, string strPrjId)
{
if (string.IsNullOrEmpty(strViewGroupId) == true) return "";
//获取缓存中的对象列表
clsvViewGroupEN objvViewGroup = GetObjByViewGroupIdCache(strViewGroupId, strPrjId);
if (objvViewGroup == null) return "";
return objvViewGroup.ViewGroupName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewGroupEN> GetAllvViewGroupObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvViewGroupEN> arrvViewGroupObjLstCache = GetObjLstCache(strPrjId); 
return arrvViewGroupObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewGroupEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvViewGroupEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvViewGroupEN> arrvViewGroupObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvViewGroupObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvViewGroupEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvViewGroupEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvViewGroupEN._RefreshTimeLst.Count == 0) return "";
return clsvViewGroupEN._RefreshTimeLst[clsvViewGroupEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strViewGroupId, string strPrjId)
{
if (strInFldName != convViewGroup.ViewGroupId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convViewGroup._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convViewGroup._AttributeName));
throw new Exception(strMsg);
}
var objvViewGroup = clsvViewGroupBL.GetObjByViewGroupIdCache(strViewGroupId, strPrjId);
if (objvViewGroup == null) return "";
return objvViewGroup[strOutFldName].ToString();
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
int intRecCount = clsvViewGroupDA.GetRecCount(strTabName);
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
int intRecCount = clsvViewGroupDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvViewGroupDA.GetRecCount();
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
int intRecCount = clsvViewGroupDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvViewGroupCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvViewGroupEN objvViewGroupCond)
{
 string strPrjId = objvViewGroupCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvViewGroupBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvViewGroupEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewGroupEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewGroup._AttributeName)
{
if (objvViewGroupCond.IsUpdated(strFldName) == false) continue;
if (objvViewGroupCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewGroupCond[strFldName].ToString());
}
else
{
if (objvViewGroupCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewGroupCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewGroupCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewGroupCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewGroupCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewGroupCond[strFldName]));
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
 List<string> arrList = clsvViewGroupDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vViewGroupDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vViewGroupDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}