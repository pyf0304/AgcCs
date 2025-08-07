
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRelaTabBL
 表名:vViewRelaTab(00050476)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:46:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvViewRelaTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewRelaTabEN GetObj(this K_mId_vViewRelaTab myKey)
{
clsvViewRelaTabEN objvViewRelaTabEN = clsvViewRelaTabBL.vViewRelaTabDA.GetObjBymId(myKey.Value);
return objvViewRelaTabEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetViewId(this clsvViewRelaTabEN objvViewRelaTabEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewId, convViewRelaTab.ViewId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, convViewRelaTab.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convViewRelaTab.ViewId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetViewName(this clsvViewRelaTabEN objvViewRelaTabEN, string strViewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, convViewRelaTab.ViewName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetViewCnName(this clsvViewRelaTabEN objvViewRelaTabEN, string strViewCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewCnName, 100, convViewRelaTab.ViewCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetRegionId(this clsvViewRelaTabEN objvViewRelaTabEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convViewRelaTab.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, convViewRelaTab.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convViewRelaTab.RegionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetRegionName(this clsvViewRelaTabEN objvViewRelaTabEN, string strRegionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionName, 50, convViewRelaTab.RegionName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetRegionTypeId(this clsvViewRelaTabEN objvViewRelaTabEN, string strRegionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convViewRelaTab.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convViewRelaTab.RegionTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetRegionTypeName(this clsvViewRelaTabEN objvViewRelaTabEN, string strRegionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convViewRelaTab.RegionTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetInOutTypeId(this clsvViewRelaTabEN objvViewRelaTabEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeId, convViewRelaTab.InOutTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, convViewRelaTab.InOutTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, convViewRelaTab.InOutTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetInOutTypeName(this clsvViewRelaTabEN objvViewRelaTabEN, string strInOutTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeName, 30, convViewRelaTab.InOutTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetViewTabTypeId(this clsvViewRelaTabEN objvViewRelaTabEN, string strViewTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewTabTypeId, convViewRelaTab.ViewTabTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewTabTypeId, 4, convViewRelaTab.ViewTabTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetViewTabTypeName(this clsvViewRelaTabEN objvViewRelaTabEN, string strViewTabTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewTabTypeName, 20, convViewRelaTab.ViewTabTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetTabId(this clsvViewRelaTabEN objvViewRelaTabEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convViewRelaTab.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convViewRelaTab.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convViewRelaTab.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetTabName(this clsvViewRelaTabEN objvViewRelaTabEN, string strTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convViewRelaTab.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetTabFunction(this clsvViewRelaTabEN objvViewRelaTabEN, string strTabFunction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFunction, 500, convViewRelaTab.TabFunction);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetPrjId(this clsvViewRelaTabEN objvViewRelaTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convViewRelaTab.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewRelaTab.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewRelaTab.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetUpdDate(this clsvViewRelaTabEN objvViewRelaTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewRelaTab.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetUpdUser(this clsvViewRelaTabEN objvViewRelaTabEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convViewRelaTab.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRelaTabEN SetMemo(this clsvViewRelaTabEN objvViewRelaTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewRelaTab.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvViewRelaTabENS">源对象</param>
 /// <param name = "objvViewRelaTabENT">目标对象</param>
 public static void CopyTo(this clsvViewRelaTabEN objvViewRelaTabENS, clsvViewRelaTabEN objvViewRelaTabENT)
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
 /// <param name = "objvViewRelaTabENS">源对象</param>
 /// <returns>目标对象=>clsvViewRelaTabEN:objvViewRelaTabENT</returns>
 public static clsvViewRelaTabEN CopyTo(this clsvViewRelaTabEN objvViewRelaTabENS)
{
try
{
 clsvViewRelaTabEN objvViewRelaTabENT = new clsvViewRelaTabEN()
{
mId = objvViewRelaTabENS.mId, //mId
ViewId = objvViewRelaTabENS.ViewId, //界面Id
ViewName = objvViewRelaTabENS.ViewName, //界面名称
ViewCnName = objvViewRelaTabENS.ViewCnName, //视图中文名
RegionId = objvViewRelaTabENS.RegionId, //区域Id
RegionName = objvViewRelaTabENS.RegionName, //区域名称
RegionTypeId = objvViewRelaTabENS.RegionTypeId, //区域类型Id
RegionTypeName = objvViewRelaTabENS.RegionTypeName, //区域类型名称
InOutTypeId = objvViewRelaTabENS.InOutTypeId, //INOUT类型ID
InOutTypeName = objvViewRelaTabENS.InOutTypeName, //INOUT类型名称
ViewTabTypeId = objvViewRelaTabENS.ViewTabTypeId, //界面表类型码
ViewTabTypeName = objvViewRelaTabENS.ViewTabTypeName, //ViewTabTypeName
TabId = objvViewRelaTabENS.TabId, //表ID
TabName = objvViewRelaTabENS.TabName, //表名
TabFunction = objvViewRelaTabENS.TabFunction, //表功能说明
PrjId = objvViewRelaTabENS.PrjId, //工程Id
UpdDate = objvViewRelaTabENS.UpdDate, //修改日期
UpdUser = objvViewRelaTabENS.UpdUser, //修改者
Memo = objvViewRelaTabENS.Memo, //说明
};
 return objvViewRelaTabENT;
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
public static void CheckProperty4Condition(this clsvViewRelaTabEN objvViewRelaTabEN)
{
 clsvViewRelaTabBL.vViewRelaTabDA.CheckProperty4Condition(objvViewRelaTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vViewRelaTab
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v界面相关表(vViewRelaTab)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvViewRelaTabBL
{
public static RelatedActions_vViewRelaTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvViewRelaTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvViewRelaTabDA vViewRelaTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvViewRelaTabDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvViewRelaTabBL()
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
if (string.IsNullOrEmpty(clsvViewRelaTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewRelaTabEN._ConnectString);
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
public static DataTable GetDataTable_vViewRelaTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewRelaTabDA.GetDataTable_vViewRelaTab(strWhereCond);
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
objDT = vViewRelaTabDA.GetDataTable(strWhereCond);
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
objDT = vViewRelaTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vViewRelaTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vViewRelaTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vViewRelaTabDA.GetDataTable_Top(objTopPara);
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
objDT = vViewRelaTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vViewRelaTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vViewRelaTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvViewRelaTabEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvViewRelaTabEN> arrObjLst = new List<clsvViewRelaTabEN>(); 
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
	clsvViewRelaTabEN objvViewRelaTabEN = new clsvViewRelaTabEN();
try
{
objvViewRelaTabEN.mId = Int32.Parse(objRow[convViewRelaTab.mId].ToString().Trim()); //mId
objvViewRelaTabEN.ViewId = objRow[convViewRelaTab.ViewId].ToString().Trim(); //界面Id
objvViewRelaTabEN.ViewName = objRow[convViewRelaTab.ViewName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewName].ToString().Trim(); //界面名称
objvViewRelaTabEN.ViewCnName = objRow[convViewRelaTab.ViewCnName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewCnName].ToString().Trim(); //视图中文名
objvViewRelaTabEN.RegionId = objRow[convViewRelaTab.RegionId].ToString().Trim(); //区域Id
objvViewRelaTabEN.RegionName = objRow[convViewRelaTab.RegionName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionName].ToString().Trim(); //区域名称
objvViewRelaTabEN.RegionTypeId = objRow[convViewRelaTab.RegionTypeId] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRelaTabEN.RegionTypeName = objRow[convViewRelaTab.RegionTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRelaTabEN.InOutTypeId = objRow[convViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRelaTabEN.InOutTypeName = objRow[convViewRelaTab.InOutTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRelaTabEN.ViewTabTypeId = objRow[convViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objvViewRelaTabEN.ViewTabTypeName = objRow[convViewRelaTab.ViewTabTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewTabTypeName].ToString().Trim(); //ViewTabTypeName
objvViewRelaTabEN.TabId = objRow[convViewRelaTab.TabId].ToString().Trim(); //表ID
objvViewRelaTabEN.TabName = objRow[convViewRelaTab.TabName] == DBNull.Value ? null : objRow[convViewRelaTab.TabName].ToString().Trim(); //表名
objvViewRelaTabEN.TabFunction = objRow[convViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[convViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objvViewRelaTabEN.PrjId = objRow[convViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvViewRelaTabEN.UpdDate = objRow[convViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvViewRelaTabEN.UpdUser = objRow[convViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[convViewRelaTab.UpdUser].ToString().Trim(); //修改者
objvViewRelaTabEN.Memo = objRow[convViewRelaTab.Memo] == DBNull.Value ? null : objRow[convViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvViewRelaTabEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvViewRelaTabEN._CurrTabName, strPrjId);
List<clsvViewRelaTabEN> arrvViewRelaTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewRelaTabEN> arrvViewRelaTabObjLst_Sel =
arrvViewRelaTabObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvViewRelaTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRelaTabEN> GetObjLst(string strWhereCond)
{
List<clsvViewRelaTabEN> arrObjLst = new List<clsvViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRelaTabEN objvViewRelaTabEN = new clsvViewRelaTabEN();
try
{
objvViewRelaTabEN.mId = Int32.Parse(objRow[convViewRelaTab.mId].ToString().Trim()); //mId
objvViewRelaTabEN.ViewId = objRow[convViewRelaTab.ViewId].ToString().Trim(); //界面Id
objvViewRelaTabEN.ViewName = objRow[convViewRelaTab.ViewName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewName].ToString().Trim(); //界面名称
objvViewRelaTabEN.ViewCnName = objRow[convViewRelaTab.ViewCnName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewCnName].ToString().Trim(); //视图中文名
objvViewRelaTabEN.RegionId = objRow[convViewRelaTab.RegionId].ToString().Trim(); //区域Id
objvViewRelaTabEN.RegionName = objRow[convViewRelaTab.RegionName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionName].ToString().Trim(); //区域名称
objvViewRelaTabEN.RegionTypeId = objRow[convViewRelaTab.RegionTypeId] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRelaTabEN.RegionTypeName = objRow[convViewRelaTab.RegionTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRelaTabEN.InOutTypeId = objRow[convViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRelaTabEN.InOutTypeName = objRow[convViewRelaTab.InOutTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRelaTabEN.ViewTabTypeId = objRow[convViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objvViewRelaTabEN.ViewTabTypeName = objRow[convViewRelaTab.ViewTabTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewTabTypeName].ToString().Trim(); //ViewTabTypeName
objvViewRelaTabEN.TabId = objRow[convViewRelaTab.TabId].ToString().Trim(); //表ID
objvViewRelaTabEN.TabName = objRow[convViewRelaTab.TabName] == DBNull.Value ? null : objRow[convViewRelaTab.TabName].ToString().Trim(); //表名
objvViewRelaTabEN.TabFunction = objRow[convViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[convViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objvViewRelaTabEN.PrjId = objRow[convViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvViewRelaTabEN.UpdDate = objRow[convViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvViewRelaTabEN.UpdUser = objRow[convViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[convViewRelaTab.UpdUser].ToString().Trim(); //修改者
objvViewRelaTabEN.Memo = objRow[convViewRelaTab.Memo] == DBNull.Value ? null : objRow[convViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRelaTabEN);
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
public static List<clsvViewRelaTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewRelaTabEN> arrObjLst = new List<clsvViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRelaTabEN objvViewRelaTabEN = new clsvViewRelaTabEN();
try
{
objvViewRelaTabEN.mId = Int32.Parse(objRow[convViewRelaTab.mId].ToString().Trim()); //mId
objvViewRelaTabEN.ViewId = objRow[convViewRelaTab.ViewId].ToString().Trim(); //界面Id
objvViewRelaTabEN.ViewName = objRow[convViewRelaTab.ViewName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewName].ToString().Trim(); //界面名称
objvViewRelaTabEN.ViewCnName = objRow[convViewRelaTab.ViewCnName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewCnName].ToString().Trim(); //视图中文名
objvViewRelaTabEN.RegionId = objRow[convViewRelaTab.RegionId].ToString().Trim(); //区域Id
objvViewRelaTabEN.RegionName = objRow[convViewRelaTab.RegionName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionName].ToString().Trim(); //区域名称
objvViewRelaTabEN.RegionTypeId = objRow[convViewRelaTab.RegionTypeId] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRelaTabEN.RegionTypeName = objRow[convViewRelaTab.RegionTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRelaTabEN.InOutTypeId = objRow[convViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRelaTabEN.InOutTypeName = objRow[convViewRelaTab.InOutTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRelaTabEN.ViewTabTypeId = objRow[convViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objvViewRelaTabEN.ViewTabTypeName = objRow[convViewRelaTab.ViewTabTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewTabTypeName].ToString().Trim(); //ViewTabTypeName
objvViewRelaTabEN.TabId = objRow[convViewRelaTab.TabId].ToString().Trim(); //表ID
objvViewRelaTabEN.TabName = objRow[convViewRelaTab.TabName] == DBNull.Value ? null : objRow[convViewRelaTab.TabName].ToString().Trim(); //表名
objvViewRelaTabEN.TabFunction = objRow[convViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[convViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objvViewRelaTabEN.PrjId = objRow[convViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvViewRelaTabEN.UpdDate = objRow[convViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvViewRelaTabEN.UpdUser = objRow[convViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[convViewRelaTab.UpdUser].ToString().Trim(); //修改者
objvViewRelaTabEN.Memo = objRow[convViewRelaTab.Memo] == DBNull.Value ? null : objRow[convViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvViewRelaTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvViewRelaTabEN> GetSubObjLstCache(clsvViewRelaTabEN objvViewRelaTabCond)
{
 string strPrjId = objvViewRelaTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvViewRelaTabBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvViewRelaTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewRelaTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewRelaTab._AttributeName)
{
if (objvViewRelaTabCond.IsUpdated(strFldName) == false) continue;
if (objvViewRelaTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewRelaTabCond[strFldName].ToString());
}
else
{
if (objvViewRelaTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewRelaTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewRelaTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewRelaTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewRelaTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewRelaTabCond[strFldName]));
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
public static List<clsvViewRelaTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvViewRelaTabEN> arrObjLst = new List<clsvViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRelaTabEN objvViewRelaTabEN = new clsvViewRelaTabEN();
try
{
objvViewRelaTabEN.mId = Int32.Parse(objRow[convViewRelaTab.mId].ToString().Trim()); //mId
objvViewRelaTabEN.ViewId = objRow[convViewRelaTab.ViewId].ToString().Trim(); //界面Id
objvViewRelaTabEN.ViewName = objRow[convViewRelaTab.ViewName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewName].ToString().Trim(); //界面名称
objvViewRelaTabEN.ViewCnName = objRow[convViewRelaTab.ViewCnName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewCnName].ToString().Trim(); //视图中文名
objvViewRelaTabEN.RegionId = objRow[convViewRelaTab.RegionId].ToString().Trim(); //区域Id
objvViewRelaTabEN.RegionName = objRow[convViewRelaTab.RegionName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionName].ToString().Trim(); //区域名称
objvViewRelaTabEN.RegionTypeId = objRow[convViewRelaTab.RegionTypeId] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRelaTabEN.RegionTypeName = objRow[convViewRelaTab.RegionTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRelaTabEN.InOutTypeId = objRow[convViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRelaTabEN.InOutTypeName = objRow[convViewRelaTab.InOutTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRelaTabEN.ViewTabTypeId = objRow[convViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objvViewRelaTabEN.ViewTabTypeName = objRow[convViewRelaTab.ViewTabTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewTabTypeName].ToString().Trim(); //ViewTabTypeName
objvViewRelaTabEN.TabId = objRow[convViewRelaTab.TabId].ToString().Trim(); //表ID
objvViewRelaTabEN.TabName = objRow[convViewRelaTab.TabName] == DBNull.Value ? null : objRow[convViewRelaTab.TabName].ToString().Trim(); //表名
objvViewRelaTabEN.TabFunction = objRow[convViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[convViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objvViewRelaTabEN.PrjId = objRow[convViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvViewRelaTabEN.UpdDate = objRow[convViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvViewRelaTabEN.UpdUser = objRow[convViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[convViewRelaTab.UpdUser].ToString().Trim(); //修改者
objvViewRelaTabEN.Memo = objRow[convViewRelaTab.Memo] == DBNull.Value ? null : objRow[convViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRelaTabEN);
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
public static List<clsvViewRelaTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvViewRelaTabEN> arrObjLst = new List<clsvViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRelaTabEN objvViewRelaTabEN = new clsvViewRelaTabEN();
try
{
objvViewRelaTabEN.mId = Int32.Parse(objRow[convViewRelaTab.mId].ToString().Trim()); //mId
objvViewRelaTabEN.ViewId = objRow[convViewRelaTab.ViewId].ToString().Trim(); //界面Id
objvViewRelaTabEN.ViewName = objRow[convViewRelaTab.ViewName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewName].ToString().Trim(); //界面名称
objvViewRelaTabEN.ViewCnName = objRow[convViewRelaTab.ViewCnName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewCnName].ToString().Trim(); //视图中文名
objvViewRelaTabEN.RegionId = objRow[convViewRelaTab.RegionId].ToString().Trim(); //区域Id
objvViewRelaTabEN.RegionName = objRow[convViewRelaTab.RegionName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionName].ToString().Trim(); //区域名称
objvViewRelaTabEN.RegionTypeId = objRow[convViewRelaTab.RegionTypeId] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRelaTabEN.RegionTypeName = objRow[convViewRelaTab.RegionTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRelaTabEN.InOutTypeId = objRow[convViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRelaTabEN.InOutTypeName = objRow[convViewRelaTab.InOutTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRelaTabEN.ViewTabTypeId = objRow[convViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objvViewRelaTabEN.ViewTabTypeName = objRow[convViewRelaTab.ViewTabTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewTabTypeName].ToString().Trim(); //ViewTabTypeName
objvViewRelaTabEN.TabId = objRow[convViewRelaTab.TabId].ToString().Trim(); //表ID
objvViewRelaTabEN.TabName = objRow[convViewRelaTab.TabName] == DBNull.Value ? null : objRow[convViewRelaTab.TabName].ToString().Trim(); //表名
objvViewRelaTabEN.TabFunction = objRow[convViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[convViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objvViewRelaTabEN.PrjId = objRow[convViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvViewRelaTabEN.UpdDate = objRow[convViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvViewRelaTabEN.UpdUser = objRow[convViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[convViewRelaTab.UpdUser].ToString().Trim(); //修改者
objvViewRelaTabEN.Memo = objRow[convViewRelaTab.Memo] == DBNull.Value ? null : objRow[convViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRelaTabEN);
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
List<clsvViewRelaTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvViewRelaTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRelaTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvViewRelaTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvViewRelaTabEN> arrObjLst = new List<clsvViewRelaTabEN>(); 
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
	clsvViewRelaTabEN objvViewRelaTabEN = new clsvViewRelaTabEN();
try
{
objvViewRelaTabEN.mId = Int32.Parse(objRow[convViewRelaTab.mId].ToString().Trim()); //mId
objvViewRelaTabEN.ViewId = objRow[convViewRelaTab.ViewId].ToString().Trim(); //界面Id
objvViewRelaTabEN.ViewName = objRow[convViewRelaTab.ViewName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewName].ToString().Trim(); //界面名称
objvViewRelaTabEN.ViewCnName = objRow[convViewRelaTab.ViewCnName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewCnName].ToString().Trim(); //视图中文名
objvViewRelaTabEN.RegionId = objRow[convViewRelaTab.RegionId].ToString().Trim(); //区域Id
objvViewRelaTabEN.RegionName = objRow[convViewRelaTab.RegionName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionName].ToString().Trim(); //区域名称
objvViewRelaTabEN.RegionTypeId = objRow[convViewRelaTab.RegionTypeId] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRelaTabEN.RegionTypeName = objRow[convViewRelaTab.RegionTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRelaTabEN.InOutTypeId = objRow[convViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRelaTabEN.InOutTypeName = objRow[convViewRelaTab.InOutTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRelaTabEN.ViewTabTypeId = objRow[convViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objvViewRelaTabEN.ViewTabTypeName = objRow[convViewRelaTab.ViewTabTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewTabTypeName].ToString().Trim(); //ViewTabTypeName
objvViewRelaTabEN.TabId = objRow[convViewRelaTab.TabId].ToString().Trim(); //表ID
objvViewRelaTabEN.TabName = objRow[convViewRelaTab.TabName] == DBNull.Value ? null : objRow[convViewRelaTab.TabName].ToString().Trim(); //表名
objvViewRelaTabEN.TabFunction = objRow[convViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[convViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objvViewRelaTabEN.PrjId = objRow[convViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvViewRelaTabEN.UpdDate = objRow[convViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvViewRelaTabEN.UpdUser = objRow[convViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[convViewRelaTab.UpdUser].ToString().Trim(); //修改者
objvViewRelaTabEN.Memo = objRow[convViewRelaTab.Memo] == DBNull.Value ? null : objRow[convViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRelaTabEN);
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
public static List<clsvViewRelaTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvViewRelaTabEN> arrObjLst = new List<clsvViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRelaTabEN objvViewRelaTabEN = new clsvViewRelaTabEN();
try
{
objvViewRelaTabEN.mId = Int32.Parse(objRow[convViewRelaTab.mId].ToString().Trim()); //mId
objvViewRelaTabEN.ViewId = objRow[convViewRelaTab.ViewId].ToString().Trim(); //界面Id
objvViewRelaTabEN.ViewName = objRow[convViewRelaTab.ViewName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewName].ToString().Trim(); //界面名称
objvViewRelaTabEN.ViewCnName = objRow[convViewRelaTab.ViewCnName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewCnName].ToString().Trim(); //视图中文名
objvViewRelaTabEN.RegionId = objRow[convViewRelaTab.RegionId].ToString().Trim(); //区域Id
objvViewRelaTabEN.RegionName = objRow[convViewRelaTab.RegionName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionName].ToString().Trim(); //区域名称
objvViewRelaTabEN.RegionTypeId = objRow[convViewRelaTab.RegionTypeId] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRelaTabEN.RegionTypeName = objRow[convViewRelaTab.RegionTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRelaTabEN.InOutTypeId = objRow[convViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRelaTabEN.InOutTypeName = objRow[convViewRelaTab.InOutTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRelaTabEN.ViewTabTypeId = objRow[convViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objvViewRelaTabEN.ViewTabTypeName = objRow[convViewRelaTab.ViewTabTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewTabTypeName].ToString().Trim(); //ViewTabTypeName
objvViewRelaTabEN.TabId = objRow[convViewRelaTab.TabId].ToString().Trim(); //表ID
objvViewRelaTabEN.TabName = objRow[convViewRelaTab.TabName] == DBNull.Value ? null : objRow[convViewRelaTab.TabName].ToString().Trim(); //表名
objvViewRelaTabEN.TabFunction = objRow[convViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[convViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objvViewRelaTabEN.PrjId = objRow[convViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvViewRelaTabEN.UpdDate = objRow[convViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvViewRelaTabEN.UpdUser = objRow[convViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[convViewRelaTab.UpdUser].ToString().Trim(); //修改者
objvViewRelaTabEN.Memo = objRow[convViewRelaTab.Memo] == DBNull.Value ? null : objRow[convViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewRelaTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvViewRelaTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvViewRelaTabEN> arrObjLst = new List<clsvViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRelaTabEN objvViewRelaTabEN = new clsvViewRelaTabEN();
try
{
objvViewRelaTabEN.mId = Int32.Parse(objRow[convViewRelaTab.mId].ToString().Trim()); //mId
objvViewRelaTabEN.ViewId = objRow[convViewRelaTab.ViewId].ToString().Trim(); //界面Id
objvViewRelaTabEN.ViewName = objRow[convViewRelaTab.ViewName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewName].ToString().Trim(); //界面名称
objvViewRelaTabEN.ViewCnName = objRow[convViewRelaTab.ViewCnName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewCnName].ToString().Trim(); //视图中文名
objvViewRelaTabEN.RegionId = objRow[convViewRelaTab.RegionId].ToString().Trim(); //区域Id
objvViewRelaTabEN.RegionName = objRow[convViewRelaTab.RegionName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionName].ToString().Trim(); //区域名称
objvViewRelaTabEN.RegionTypeId = objRow[convViewRelaTab.RegionTypeId] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRelaTabEN.RegionTypeName = objRow[convViewRelaTab.RegionTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRelaTabEN.InOutTypeId = objRow[convViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRelaTabEN.InOutTypeName = objRow[convViewRelaTab.InOutTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRelaTabEN.ViewTabTypeId = objRow[convViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objvViewRelaTabEN.ViewTabTypeName = objRow[convViewRelaTab.ViewTabTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewTabTypeName].ToString().Trim(); //ViewTabTypeName
objvViewRelaTabEN.TabId = objRow[convViewRelaTab.TabId].ToString().Trim(); //表ID
objvViewRelaTabEN.TabName = objRow[convViewRelaTab.TabName] == DBNull.Value ? null : objRow[convViewRelaTab.TabName].ToString().Trim(); //表名
objvViewRelaTabEN.TabFunction = objRow[convViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[convViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objvViewRelaTabEN.PrjId = objRow[convViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvViewRelaTabEN.UpdDate = objRow[convViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvViewRelaTabEN.UpdUser = objRow[convViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[convViewRelaTab.UpdUser].ToString().Trim(); //修改者
objvViewRelaTabEN.Memo = objRow[convViewRelaTab.Memo] == DBNull.Value ? null : objRow[convViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRelaTabEN);
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
public static List<clsvViewRelaTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvViewRelaTabEN> arrObjLst = new List<clsvViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRelaTabEN objvViewRelaTabEN = new clsvViewRelaTabEN();
try
{
objvViewRelaTabEN.mId = Int32.Parse(objRow[convViewRelaTab.mId].ToString().Trim()); //mId
objvViewRelaTabEN.ViewId = objRow[convViewRelaTab.ViewId].ToString().Trim(); //界面Id
objvViewRelaTabEN.ViewName = objRow[convViewRelaTab.ViewName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewName].ToString().Trim(); //界面名称
objvViewRelaTabEN.ViewCnName = objRow[convViewRelaTab.ViewCnName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewCnName].ToString().Trim(); //视图中文名
objvViewRelaTabEN.RegionId = objRow[convViewRelaTab.RegionId].ToString().Trim(); //区域Id
objvViewRelaTabEN.RegionName = objRow[convViewRelaTab.RegionName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionName].ToString().Trim(); //区域名称
objvViewRelaTabEN.RegionTypeId = objRow[convViewRelaTab.RegionTypeId] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRelaTabEN.RegionTypeName = objRow[convViewRelaTab.RegionTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRelaTabEN.InOutTypeId = objRow[convViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRelaTabEN.InOutTypeName = objRow[convViewRelaTab.InOutTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRelaTabEN.ViewTabTypeId = objRow[convViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objvViewRelaTabEN.ViewTabTypeName = objRow[convViewRelaTab.ViewTabTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewTabTypeName].ToString().Trim(); //ViewTabTypeName
objvViewRelaTabEN.TabId = objRow[convViewRelaTab.TabId].ToString().Trim(); //表ID
objvViewRelaTabEN.TabName = objRow[convViewRelaTab.TabName] == DBNull.Value ? null : objRow[convViewRelaTab.TabName].ToString().Trim(); //表名
objvViewRelaTabEN.TabFunction = objRow[convViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[convViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objvViewRelaTabEN.PrjId = objRow[convViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvViewRelaTabEN.UpdDate = objRow[convViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvViewRelaTabEN.UpdUser = objRow[convViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[convViewRelaTab.UpdUser].ToString().Trim(); //修改者
objvViewRelaTabEN.Memo = objRow[convViewRelaTab.Memo] == DBNull.Value ? null : objRow[convViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRelaTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvViewRelaTabEN> arrObjLst = new List<clsvViewRelaTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRelaTabEN objvViewRelaTabEN = new clsvViewRelaTabEN();
try
{
objvViewRelaTabEN.mId = Int32.Parse(objRow[convViewRelaTab.mId].ToString().Trim()); //mId
objvViewRelaTabEN.ViewId = objRow[convViewRelaTab.ViewId].ToString().Trim(); //界面Id
objvViewRelaTabEN.ViewName = objRow[convViewRelaTab.ViewName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewName].ToString().Trim(); //界面名称
objvViewRelaTabEN.ViewCnName = objRow[convViewRelaTab.ViewCnName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewCnName].ToString().Trim(); //视图中文名
objvViewRelaTabEN.RegionId = objRow[convViewRelaTab.RegionId].ToString().Trim(); //区域Id
objvViewRelaTabEN.RegionName = objRow[convViewRelaTab.RegionName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionName].ToString().Trim(); //区域名称
objvViewRelaTabEN.RegionTypeId = objRow[convViewRelaTab.RegionTypeId] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRelaTabEN.RegionTypeName = objRow[convViewRelaTab.RegionTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRelaTabEN.InOutTypeId = objRow[convViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRelaTabEN.InOutTypeName = objRow[convViewRelaTab.InOutTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRelaTabEN.ViewTabTypeId = objRow[convViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objvViewRelaTabEN.ViewTabTypeName = objRow[convViewRelaTab.ViewTabTypeName] == DBNull.Value ? null : objRow[convViewRelaTab.ViewTabTypeName].ToString().Trim(); //ViewTabTypeName
objvViewRelaTabEN.TabId = objRow[convViewRelaTab.TabId].ToString().Trim(); //表ID
objvViewRelaTabEN.TabName = objRow[convViewRelaTab.TabName] == DBNull.Value ? null : objRow[convViewRelaTab.TabName].ToString().Trim(); //表名
objvViewRelaTabEN.TabFunction = objRow[convViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[convViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objvViewRelaTabEN.PrjId = objRow[convViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvViewRelaTabEN.UpdDate = objRow[convViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvViewRelaTabEN.UpdUser = objRow[convViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[convViewRelaTab.UpdUser].ToString().Trim(); //修改者
objvViewRelaTabEN.Memo = objRow[convViewRelaTab.Memo] == DBNull.Value ? null : objRow[convViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRelaTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvViewRelaTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvViewRelaTab(ref clsvViewRelaTabEN objvViewRelaTabEN)
{
bool bolResult = vViewRelaTabDA.GetvViewRelaTab(ref objvViewRelaTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewRelaTabEN GetObjBymId(long lngmId)
{
clsvViewRelaTabEN objvViewRelaTabEN = vViewRelaTabDA.GetObjBymId(lngmId);
return objvViewRelaTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvViewRelaTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvViewRelaTabEN objvViewRelaTabEN = vViewRelaTabDA.GetFirstObj(strWhereCond);
 return objvViewRelaTabEN;
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
public static clsvViewRelaTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvViewRelaTabEN objvViewRelaTabEN = vViewRelaTabDA.GetObjByDataRow(objRow);
 return objvViewRelaTabEN;
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
public static clsvViewRelaTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvViewRelaTabEN objvViewRelaTabEN = vViewRelaTabDA.GetObjByDataRow(objRow);
 return objvViewRelaTabEN;
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
 /// <param name = "lstvViewRelaTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewRelaTabEN GetObjBymIdFromList(long lngmId, List<clsvViewRelaTabEN> lstvViewRelaTabObjLst)
{
foreach (clsvViewRelaTabEN objvViewRelaTabEN in lstvViewRelaTabObjLst)
{
if (objvViewRelaTabEN.mId == lngmId)
{
return objvViewRelaTabEN;
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
 lngmId = new clsvViewRelaTabDA().GetFirstID(strWhereCond);
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
 arrList = vViewRelaTabDA.GetID(strWhereCond);
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
bool bolIsExist = vViewRelaTabDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vViewRelaTabDA.IsExist(lngmId);
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
 bolIsExist = clsvViewRelaTabDA.IsExistTable();
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
 bolIsExist = vViewRelaTabDA.IsExistTable(strTabName);
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
 /// <param name = "objvViewRelaTabEN">源简化对象</param>
 public static void SetUpdFlag(clsvViewRelaTabEN objvViewRelaTabEN)
{
try
{
objvViewRelaTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvViewRelaTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convViewRelaTab.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.mId = objvViewRelaTabEN.mId; //mId
}
if (arrFldSet.Contains(convViewRelaTab.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.ViewId = objvViewRelaTabEN.ViewId; //界面Id
}
if (arrFldSet.Contains(convViewRelaTab.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.ViewName = objvViewRelaTabEN.ViewName == "[null]" ? null :  objvViewRelaTabEN.ViewName; //界面名称
}
if (arrFldSet.Contains(convViewRelaTab.ViewCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.ViewCnName = objvViewRelaTabEN.ViewCnName == "[null]" ? null :  objvViewRelaTabEN.ViewCnName; //视图中文名
}
if (arrFldSet.Contains(convViewRelaTab.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.RegionId = objvViewRelaTabEN.RegionId; //区域Id
}
if (arrFldSet.Contains(convViewRelaTab.RegionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.RegionName = objvViewRelaTabEN.RegionName == "[null]" ? null :  objvViewRelaTabEN.RegionName; //区域名称
}
if (arrFldSet.Contains(convViewRelaTab.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.RegionTypeId = objvViewRelaTabEN.RegionTypeId == "[null]" ? null :  objvViewRelaTabEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(convViewRelaTab.RegionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.RegionTypeName = objvViewRelaTabEN.RegionTypeName == "[null]" ? null :  objvViewRelaTabEN.RegionTypeName; //区域类型名称
}
if (arrFldSet.Contains(convViewRelaTab.InOutTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.InOutTypeId = objvViewRelaTabEN.InOutTypeId; //INOUT类型ID
}
if (arrFldSet.Contains(convViewRelaTab.InOutTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.InOutTypeName = objvViewRelaTabEN.InOutTypeName == "[null]" ? null :  objvViewRelaTabEN.InOutTypeName; //INOUT类型名称
}
if (arrFldSet.Contains(convViewRelaTab.ViewTabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.ViewTabTypeId = objvViewRelaTabEN.ViewTabTypeId; //界面表类型码
}
if (arrFldSet.Contains(convViewRelaTab.ViewTabTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.ViewTabTypeName = objvViewRelaTabEN.ViewTabTypeName == "[null]" ? null :  objvViewRelaTabEN.ViewTabTypeName; //ViewTabTypeName
}
if (arrFldSet.Contains(convViewRelaTab.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.TabId = objvViewRelaTabEN.TabId; //表ID
}
if (arrFldSet.Contains(convViewRelaTab.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.TabName = objvViewRelaTabEN.TabName == "[null]" ? null :  objvViewRelaTabEN.TabName; //表名
}
if (arrFldSet.Contains(convViewRelaTab.TabFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.TabFunction = objvViewRelaTabEN.TabFunction == "[null]" ? null :  objvViewRelaTabEN.TabFunction; //表功能说明
}
if (arrFldSet.Contains(convViewRelaTab.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.PrjId = objvViewRelaTabEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convViewRelaTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.UpdDate = objvViewRelaTabEN.UpdDate == "[null]" ? null :  objvViewRelaTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convViewRelaTab.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.UpdUser = objvViewRelaTabEN.UpdUser == "[null]" ? null :  objvViewRelaTabEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convViewRelaTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRelaTabEN.Memo = objvViewRelaTabEN.Memo == "[null]" ? null :  objvViewRelaTabEN.Memo; //说明
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
 /// <param name = "objvViewRelaTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsvViewRelaTabEN objvViewRelaTabEN)
{
try
{
if (objvViewRelaTabEN.ViewName == "[null]") objvViewRelaTabEN.ViewName = null; //界面名称
if (objvViewRelaTabEN.ViewCnName == "[null]") objvViewRelaTabEN.ViewCnName = null; //视图中文名
if (objvViewRelaTabEN.RegionName == "[null]") objvViewRelaTabEN.RegionName = null; //区域名称
if (objvViewRelaTabEN.RegionTypeId == "[null]") objvViewRelaTabEN.RegionTypeId = null; //区域类型Id
if (objvViewRelaTabEN.RegionTypeName == "[null]") objvViewRelaTabEN.RegionTypeName = null; //区域类型名称
if (objvViewRelaTabEN.InOutTypeName == "[null]") objvViewRelaTabEN.InOutTypeName = null; //INOUT类型名称
if (objvViewRelaTabEN.ViewTabTypeName == "[null]") objvViewRelaTabEN.ViewTabTypeName = null; //ViewTabTypeName
if (objvViewRelaTabEN.TabName == "[null]") objvViewRelaTabEN.TabName = null; //表名
if (objvViewRelaTabEN.TabFunction == "[null]") objvViewRelaTabEN.TabFunction = null; //表功能说明
if (objvViewRelaTabEN.UpdDate == "[null]") objvViewRelaTabEN.UpdDate = null; //修改日期
if (objvViewRelaTabEN.UpdUser == "[null]") objvViewRelaTabEN.UpdUser = null; //修改者
if (objvViewRelaTabEN.Memo == "[null]") objvViewRelaTabEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvViewRelaTabEN objvViewRelaTabEN)
{
 vViewRelaTabDA.CheckProperty4Condition(objvViewRelaTabEN);
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
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewRelaTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewRelaTabBL没有刷新缓存机制(clsViewRelaTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewTabTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewTabTypeBL没有刷新缓存机制(clsViewTabTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsInOutTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsInOutTypeBL没有刷新缓存机制(clsInOutTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewInfoBL没有刷新缓存机制(clsViewInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewTypeCodeTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewTypeCodeTabBL没有刷新缓存机制(clsViewTypeCodeTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewGroupBL没有刷新缓存机制(clsViewGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectBL没有刷新缓存机制(clsCMProjectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewMasterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewMasterBL没有刷新缓存机制(clsViewMasterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRegionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRegionTypeBL没有刷新缓存机制(clsRegionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewRegionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewRegionBL没有刷新缓存机制(clsViewRegionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPageDispModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPageDispModeBL没有刷新缓存机制(clsPageDispModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsGCContainerTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGCContainerTypeBL没有刷新缓存机制(clsGCContainerTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTitleStyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTitleStyleBL没有刷新缓存机制(clsTitleStyleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataGridStyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataGridStyleBL没有刷新缓存机制(clsDataGridStyleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewStyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewStyleBL没有刷新缓存机制(clsViewStyleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvViewRelaTabObjLstCache == null)
//{
//arrvViewRelaTabObjLstCache = vViewRelaTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewRelaTabEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvViewRelaTabEN._CurrTabName, strPrjId);
List<clsvViewRelaTabEN> arrvViewRelaTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewRelaTabEN> arrvViewRelaTabObjLst_Sel =
arrvViewRelaTabObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvViewRelaTabObjLst_Sel.Count() == 0)
{
   clsvViewRelaTabEN obj = clsvViewRelaTabBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvViewRelaTabObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewRelaTabEN> GetAllvViewRelaTabObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvViewRelaTabEN> arrvViewRelaTabObjLstCache = GetObjLstCache(strPrjId); 
return arrvViewRelaTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewRelaTabEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvViewRelaTabEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvViewRelaTabEN> arrvViewRelaTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvViewRelaTabObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvViewRelaTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvViewRelaTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvViewRelaTabEN._RefreshTimeLst.Count == 0) return "";
return clsvViewRelaTabEN._RefreshTimeLst[clsvViewRelaTabEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convViewRelaTab.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convViewRelaTab._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convViewRelaTab._AttributeName));
throw new Exception(strMsg);
}
var objvViewRelaTab = clsvViewRelaTabBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvViewRelaTab == null) return "";
return objvViewRelaTab[strOutFldName].ToString();
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
int intRecCount = clsvViewRelaTabDA.GetRecCount(strTabName);
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
int intRecCount = clsvViewRelaTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvViewRelaTabDA.GetRecCount();
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
int intRecCount = clsvViewRelaTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvViewRelaTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvViewRelaTabEN objvViewRelaTabCond)
{
 string strPrjId = objvViewRelaTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvViewRelaTabBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvViewRelaTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewRelaTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewRelaTab._AttributeName)
{
if (objvViewRelaTabCond.IsUpdated(strFldName) == false) continue;
if (objvViewRelaTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewRelaTabCond[strFldName].ToString());
}
else
{
if (objvViewRelaTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewRelaTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewRelaTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewRelaTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewRelaTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewRelaTabCond[strFldName]));
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
 List<string> arrList = clsvViewRelaTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vViewRelaTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vViewRelaTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}