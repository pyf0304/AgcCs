
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRelaTabWApi
 表名:vViewRelaTab(00050476)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:14
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
public static class  clsvViewRelaTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetmId(this clsvViewRelaTabEN objvViewRelaTabEN, long lngmId, string strComparisonOp="")
	{
objvViewRelaTabEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.mId) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.mId, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.mId] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewId">界面Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetViewId(this clsvViewRelaTabEN objvViewRelaTabEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewId, convViewRelaTab.ViewId);
clsCheckSql.CheckFieldLen(strViewId, 8, convViewRelaTab.ViewId);
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convViewRelaTab.ViewId);
objvViewRelaTabEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.ViewId) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.ViewId, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.ViewId] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewName">界面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetViewName(this clsvViewRelaTabEN objvViewRelaTabEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewName, 100, convViewRelaTab.ViewName);
objvViewRelaTabEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.ViewName) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.ViewName, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.ViewName] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewCnName">视图中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetViewCnName(this clsvViewRelaTabEN objvViewRelaTabEN, string strViewCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewCnName, 100, convViewRelaTab.ViewCnName);
objvViewRelaTabEN.ViewCnName = strViewCnName; //视图中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.ViewCnName) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.ViewCnName, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.ViewCnName] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetRegionId(this clsvViewRelaTabEN objvViewRelaTabEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convViewRelaTab.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, convViewRelaTab.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convViewRelaTab.RegionId);
objvViewRelaTabEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.RegionId) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.RegionId, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.RegionId] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionName">区域名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetRegionName(this clsvViewRelaTabEN objvViewRelaTabEN, string strRegionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionName, 50, convViewRelaTab.RegionName);
objvViewRelaTabEN.RegionName = strRegionName; //区域名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.RegionName) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.RegionName, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.RegionName] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetRegionTypeId(this clsvViewRelaTabEN objvViewRelaTabEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convViewRelaTab.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convViewRelaTab.RegionTypeId);
objvViewRelaTabEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.RegionTypeId) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.RegionTypeId, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.RegionTypeId] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeName">区域类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetRegionTypeName(this clsvViewRelaTabEN objvViewRelaTabEN, string strRegionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convViewRelaTab.RegionTypeName);
objvViewRelaTabEN.RegionTypeName = strRegionTypeName; //区域类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.RegionTypeName) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.RegionTypeName, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.RegionTypeName] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strInOutTypeId">INOUT类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetInOutTypeId(this clsvViewRelaTabEN objvViewRelaTabEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeId, convViewRelaTab.InOutTypeId);
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, convViewRelaTab.InOutTypeId);
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, convViewRelaTab.InOutTypeId);
objvViewRelaTabEN.InOutTypeId = strInOutTypeId; //INOUT类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.InOutTypeId) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.InOutTypeId, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.InOutTypeId] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strInOutTypeName">INOUT类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetInOutTypeName(this clsvViewRelaTabEN objvViewRelaTabEN, string strInOutTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInOutTypeName, 30, convViewRelaTab.InOutTypeName);
objvViewRelaTabEN.InOutTypeName = strInOutTypeName; //INOUT类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.InOutTypeName) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.InOutTypeName, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.InOutTypeName] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewTabTypeId">界面表类型码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetViewTabTypeId(this clsvViewRelaTabEN objvViewRelaTabEN, string strViewTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewTabTypeId, convViewRelaTab.ViewTabTypeId);
clsCheckSql.CheckFieldLen(strViewTabTypeId, 4, convViewRelaTab.ViewTabTypeId);
objvViewRelaTabEN.ViewTabTypeId = strViewTabTypeId; //界面表类型码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.ViewTabTypeId) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.ViewTabTypeId, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.ViewTabTypeId] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewTabTypeName">ViewTabTypeName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetViewTabTypeName(this clsvViewRelaTabEN objvViewRelaTabEN, string strViewTabTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewTabTypeName, 20, convViewRelaTab.ViewTabTypeName);
objvViewRelaTabEN.ViewTabTypeName = strViewTabTypeName; //ViewTabTypeName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.ViewTabTypeName) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.ViewTabTypeName, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.ViewTabTypeName] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetTabId(this clsvViewRelaTabEN objvViewRelaTabEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convViewRelaTab.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convViewRelaTab.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convViewRelaTab.TabId);
objvViewRelaTabEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.TabId) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.TabId, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.TabId] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetTabName(this clsvViewRelaTabEN objvViewRelaTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabName, 100, convViewRelaTab.TabName);
objvViewRelaTabEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.TabName) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.TabName, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.TabName] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFunction">表功能说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetTabFunction(this clsvViewRelaTabEN objvViewRelaTabEN, string strTabFunction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFunction, 500, convViewRelaTab.TabFunction);
objvViewRelaTabEN.TabFunction = strTabFunction; //表功能说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.TabFunction) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.TabFunction, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.TabFunction] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetPrjId(this clsvViewRelaTabEN objvViewRelaTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convViewRelaTab.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewRelaTab.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewRelaTab.PrjId);
objvViewRelaTabEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.PrjId) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.PrjId, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.PrjId] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetUpdDate(this clsvViewRelaTabEN objvViewRelaTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewRelaTab.UpdDate);
objvViewRelaTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.UpdDate) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.UpdDate, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.UpdDate] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetUpdUser(this clsvViewRelaTabEN objvViewRelaTabEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convViewRelaTab.UpdUser);
objvViewRelaTabEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.UpdUser) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.UpdUser, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.UpdUser] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetMemo(this clsvViewRelaTabEN objvViewRelaTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewRelaTab.Memo);
objvViewRelaTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRelaTabEN.dicFldComparisonOp.ContainsKey(convViewRelaTab.Memo) == false)
{
objvViewRelaTabEN.dicFldComparisonOp.Add(convViewRelaTab.Memo, strComparisonOp);
}
else
{
objvViewRelaTabEN.dicFldComparisonOp[convViewRelaTab.Memo] = strComparisonOp;
}
}
return objvViewRelaTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewRelaTabEN objvViewRelaTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.mId) == true)
{
string strComparisonOpmId = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewRelaTab.mId, objvViewRelaTabCond.mId, strComparisonOpmId);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.ViewId) == true)
{
string strComparisonOpViewId = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.ViewId, objvViewRelaTabCond.ViewId, strComparisonOpViewId);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.ViewName) == true)
{
string strComparisonOpViewName = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.ViewName, objvViewRelaTabCond.ViewName, strComparisonOpViewName);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.ViewCnName) == true)
{
string strComparisonOpViewCnName = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.ViewCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.ViewCnName, objvViewRelaTabCond.ViewCnName, strComparisonOpViewCnName);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.RegionId) == true)
{
string strComparisonOpRegionId = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.RegionId, objvViewRelaTabCond.RegionId, strComparisonOpRegionId);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.RegionName) == true)
{
string strComparisonOpRegionName = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.RegionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.RegionName, objvViewRelaTabCond.RegionName, strComparisonOpRegionName);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.RegionTypeId, objvViewRelaTabCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.RegionTypeName) == true)
{
string strComparisonOpRegionTypeName = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.RegionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.RegionTypeName, objvViewRelaTabCond.RegionTypeName, strComparisonOpRegionTypeName);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.InOutTypeId, objvViewRelaTabCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.InOutTypeName) == true)
{
string strComparisonOpInOutTypeName = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.InOutTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.InOutTypeName, objvViewRelaTabCond.InOutTypeName, strComparisonOpInOutTypeName);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.ViewTabTypeId) == true)
{
string strComparisonOpViewTabTypeId = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.ViewTabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.ViewTabTypeId, objvViewRelaTabCond.ViewTabTypeId, strComparisonOpViewTabTypeId);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.ViewTabTypeName) == true)
{
string strComparisonOpViewTabTypeName = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.ViewTabTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.ViewTabTypeName, objvViewRelaTabCond.ViewTabTypeName, strComparisonOpViewTabTypeName);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.TabId) == true)
{
string strComparisonOpTabId = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.TabId, objvViewRelaTabCond.TabId, strComparisonOpTabId);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.TabName) == true)
{
string strComparisonOpTabName = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.TabName, objvViewRelaTabCond.TabName, strComparisonOpTabName);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.TabFunction) == true)
{
string strComparisonOpTabFunction = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.TabFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.TabFunction, objvViewRelaTabCond.TabFunction, strComparisonOpTabFunction);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.PrjId) == true)
{
string strComparisonOpPrjId = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.PrjId, objvViewRelaTabCond.PrjId, strComparisonOpPrjId);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.UpdDate, objvViewRelaTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.UpdUser) == true)
{
string strComparisonOpUpdUser = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.UpdUser, objvViewRelaTabCond.UpdUser, strComparisonOpUpdUser);
}
if (objvViewRelaTabCond.IsUpdated(convViewRelaTab.Memo) == true)
{
string strComparisonOpMemo = objvViewRelaTabCond.dicFldComparisonOp[convViewRelaTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRelaTab.Memo, objvViewRelaTabCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v界面相关表(vViewRelaTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvViewRelaTabWApi
{
private static readonly string mstrApiControllerName = "vViewRelaTabApi";

 public clsvViewRelaTabWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewRelaTabEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvViewRelaTabEN objvViewRelaTabEN;
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
objvViewRelaTabEN = JsonConvert.DeserializeObject<clsvViewRelaTabEN>(strJson);
return objvViewRelaTabEN;
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
public static clsvViewRelaTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvViewRelaTabEN objvViewRelaTabEN;
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
objvViewRelaTabEN = JsonConvert.DeserializeObject<clsvViewRelaTabEN>(strJson);
return objvViewRelaTabEN;
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
public static List<clsvViewRelaTabEN> GetObjLst(string strWhereCond)
{
 List<clsvViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRelaTabEN>>(strJson);
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
public static List<clsvViewRelaTabEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRelaTabEN>>(strJson);
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
public static List<clsvViewRelaTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRelaTabEN>>(strJson);
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
public static List<clsvViewRelaTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRelaTabEN>>(strJson);
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
public static List<clsvViewRelaTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRelaTabEN>>(strJson);
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
public static List<clsvViewRelaTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRelaTabEN>>(strJson);
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
 /// <param name = "objvViewRelaTabENS">源对象</param>
 /// <param name = "objvViewRelaTabENT">目标对象</param>
 public static void CopyTo(clsvViewRelaTabEN objvViewRelaTabENS, clsvViewRelaTabEN objvViewRelaTabENT)
{
try
{
objvViewRelaTabENT.mId = objvViewRelaTabENS.mId; //mId
objvViewRelaTabENT.ViewId = objvViewRelaTabENS.ViewId; //界面Id
objvViewRelaTabENT.ViewName = objvViewRelaTabENS.ViewName; //界面名称
objvViewRelaTabENT.ViewCnName = objvViewRelaTabENS.ViewCnName; //视图中文名
objvViewRelaTabENT.RegionId = objvViewRelaTabENS.RegionId; //区域Id
objvViewRelaTabENT.RegionName = objvViewRelaTabENS.RegionName; //区域名称
objvViewRelaTabENT.RegionTypeId = objvViewRelaTabENS.RegionTypeId; //区域类型Id
objvViewRelaTabENT.RegionTypeName = objvViewRelaTabENS.RegionTypeName; //区域类型名称
objvViewRelaTabENT.InOutTypeId = objvViewRelaTabENS.InOutTypeId; //INOUT类型ID
objvViewRelaTabENT.InOutTypeName = objvViewRelaTabENS.InOutTypeName; //INOUT类型名称
objvViewRelaTabENT.ViewTabTypeId = objvViewRelaTabENS.ViewTabTypeId; //界面表类型码
objvViewRelaTabENT.ViewTabTypeName = objvViewRelaTabENS.ViewTabTypeName; //ViewTabTypeName
objvViewRelaTabENT.TabId = objvViewRelaTabENS.TabId; //表ID
objvViewRelaTabENT.TabName = objvViewRelaTabENS.TabName; //表名
objvViewRelaTabENT.TabFunction = objvViewRelaTabENS.TabFunction; //表功能说明
objvViewRelaTabENT.PrjId = objvViewRelaTabENS.PrjId; //工程Id
objvViewRelaTabENT.UpdDate = objvViewRelaTabENS.UpdDate; //修改日期
objvViewRelaTabENT.UpdUser = objvViewRelaTabENS.UpdUser; //修改者
objvViewRelaTabENT.Memo = objvViewRelaTabENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvViewRelaTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvViewRelaTabEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvViewRelaTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvViewRelaTabEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvViewRelaTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvViewRelaTabEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvViewRelaTabWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvViewRelaTabWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvViewRelaTabEN._CurrTabName, strPrjId);
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
public static DataTable GetDataTableByObjLst(List<clsvViewRelaTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convViewRelaTab.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convViewRelaTab.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.ViewCnName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.RegionName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.RegionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.InOutTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.InOutTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.ViewTabTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.ViewTabTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.TabFunction, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convViewRelaTab.Memo, Type.GetType("System.String"));
foreach (clsvViewRelaTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convViewRelaTab.mId] = objInFor[convViewRelaTab.mId];
objDR[convViewRelaTab.ViewId] = objInFor[convViewRelaTab.ViewId];
objDR[convViewRelaTab.ViewName] = objInFor[convViewRelaTab.ViewName];
objDR[convViewRelaTab.ViewCnName] = objInFor[convViewRelaTab.ViewCnName];
objDR[convViewRelaTab.RegionId] = objInFor[convViewRelaTab.RegionId];
objDR[convViewRelaTab.RegionName] = objInFor[convViewRelaTab.RegionName];
objDR[convViewRelaTab.RegionTypeId] = objInFor[convViewRelaTab.RegionTypeId];
objDR[convViewRelaTab.RegionTypeName] = objInFor[convViewRelaTab.RegionTypeName];
objDR[convViewRelaTab.InOutTypeId] = objInFor[convViewRelaTab.InOutTypeId];
objDR[convViewRelaTab.InOutTypeName] = objInFor[convViewRelaTab.InOutTypeName];
objDR[convViewRelaTab.ViewTabTypeId] = objInFor[convViewRelaTab.ViewTabTypeId];
objDR[convViewRelaTab.ViewTabTypeName] = objInFor[convViewRelaTab.ViewTabTypeName];
objDR[convViewRelaTab.TabId] = objInFor[convViewRelaTab.TabId];
objDR[convViewRelaTab.TabName] = objInFor[convViewRelaTab.TabName];
objDR[convViewRelaTab.TabFunction] = objInFor[convViewRelaTab.TabFunction];
objDR[convViewRelaTab.PrjId] = objInFor[convViewRelaTab.PrjId];
objDR[convViewRelaTab.UpdDate] = objInFor[convViewRelaTab.UpdDate];
objDR[convViewRelaTab.UpdUser] = objInFor[convViewRelaTab.UpdUser];
objDR[convViewRelaTab.Memo] = objInFor[convViewRelaTab.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}