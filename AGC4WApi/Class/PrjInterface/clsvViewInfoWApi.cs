
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewInfoWApi
 表名:vViewInfo(00050157)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:38
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
public static class  clsvViewInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewId">界面Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewId(this clsvViewInfoEN objvViewInfoEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewId, 8, convViewInfo.ViewId);
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convViewInfo.ViewId);
objvViewInfoEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.ViewId) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.ViewId, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.ViewId] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strTitleStyleId">标题类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetTitleStyleId(this clsvViewInfoEN objvViewInfoEN, string strTitleStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTitleStyleId, 8, convViewInfo.TitleStyleId);
objvViewInfoEN.TitleStyleId = strTitleStyleId; //标题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.TitleStyleId) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.TitleStyleId, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.TitleStyleId] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strTitleStyleName">标题类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetTitleStyleName(this clsvViewInfoEN objvViewInfoEN, string strTitleStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTitleStyleName, convViewInfo.TitleStyleName);
clsCheckSql.CheckFieldLen(strTitleStyleName, 20, convViewInfo.TitleStyleName);
objvViewInfoEN.TitleStyleName = strTitleStyleName; //标题类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.TitleStyleName) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.TitleStyleName, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.TitleStyleName] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDgStyleId">DG模式ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetDgStyleId(this clsvViewInfoEN objvViewInfoEN, string strDgStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDgStyleId, 4, convViewInfo.DgStyleId);
objvViewInfoEN.DgStyleId = strDgStyleId; //DG模式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.DgStyleId) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.DgStyleId, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.DgStyleId] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDgStyleName">DG模式名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetDgStyleName(this clsvViewInfoEN objvViewInfoEN, string strDgStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDgStyleName, convViewInfo.DgStyleName);
clsCheckSql.CheckFieldLen(strDgStyleName, 30, convViewInfo.DgStyleName);
objvViewInfoEN.DgStyleName = strDgStyleName; //DG模式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.DgStyleName) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.DgStyleName, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.DgStyleName] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewName">界面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewName(this clsvViewInfoEN objvViewInfoEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, convViewInfo.ViewName);
clsCheckSql.CheckFieldLen(strViewName, 100, convViewInfo.ViewName);
objvViewInfoEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.ViewName) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.ViewName, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.ViewName] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetApplicationTypeId(this clsvViewInfoEN objvViewInfoEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convViewInfo.ApplicationTypeId);
objvViewInfoEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.ApplicationTypeId) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.ApplicationTypeId, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.ApplicationTypeId] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeSimName">应用程序类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetApplicationTypeSimName(this clsvViewInfoEN objvViewInfoEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convViewInfo.ApplicationTypeSimName);
objvViewInfoEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.ApplicationTypeSimName) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.ApplicationTypeSimName, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.ApplicationTypeSimName] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetFuncModuleAgcId(this clsvViewInfoEN objvViewInfoEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convViewInfo.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convViewInfo.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convViewInfo.FuncModuleAgcId);
objvViewInfoEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.FuncModuleAgcId) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.FuncModuleAgcId, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.FuncModuleAgcId] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetFuncModuleName(this clsvViewInfoEN objvViewInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convViewInfo.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convViewInfo.FuncModuleName);
objvViewInfoEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.FuncModuleName) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.FuncModuleName, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.FuncModuleName] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">功能模块英文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetFuncModuleEnName(this clsvViewInfoEN objvViewInfoEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convViewInfo.FuncModuleEnName);
objvViewInfoEN.FuncModuleEnName = strFuncModuleEnName; //功能模块英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.FuncModuleEnName) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.FuncModuleEnName, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.FuncModuleEnName] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseName">数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetDataBaseName(this clsvViewInfoEN objvViewInfoEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convViewInfo.DataBaseName);
objvViewInfoEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.DataBaseName) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.DataBaseName, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.DataBaseName] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyForMainTab">主表关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetKeyForMainTab(this clsvViewInfoEN objvViewInfoEN, string strKeyForMainTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyForMainTab, 50, convViewInfo.KeyForMainTab);
objvViewInfoEN.KeyForMainTab = strKeyForMainTab; //主表关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.KeyForMainTab) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.KeyForMainTab, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.KeyForMainTab] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyForDetailTab">明细表关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetKeyForDetailTab(this clsvViewInfoEN objvViewInfoEN, string strKeyForDetailTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyForDetailTab, 50, convViewInfo.KeyForDetailTab);
objvViewInfoEN.KeyForDetailTab = strKeyForDetailTab; //明细表关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.KeyForDetailTab) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.KeyForDetailTab, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.KeyForDetailTab] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedSort">是否需要排序</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetIsNeedSort(this clsvViewInfoEN objvViewInfoEN, bool bolIsNeedSort, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedSort, convViewInfo.IsNeedSort);
objvViewInfoEN.IsNeedSort = bolIsNeedSort; //是否需要排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.IsNeedSort) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.IsNeedSort, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.IsNeedSort] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedTransCode">是否需要转换代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetIsNeedTransCode(this clsvViewInfoEN objvViewInfoEN, bool bolIsNeedTransCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedTransCode, convViewInfo.IsNeedTransCode);
objvViewInfoEN.IsNeedTransCode = bolIsNeedTransCode; //是否需要转换代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.IsNeedTransCode) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.IsNeedTransCode, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.IsNeedTransCode] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedSetExportFld">是否需要设置导出字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetIsNeedSetExportFld(this clsvViewInfoEN objvViewInfoEN, bool bolIsNeedSetExportFld, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedSetExportFld, convViewInfo.IsNeedSetExportFld);
objvViewInfoEN.IsNeedSetExportFld = bolIsNeedSetExportFld; //是否需要设置导出字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.IsNeedSetExportFld) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.IsNeedSetExportFld, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.IsNeedSetExportFld] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetUserId(this clsvViewInfoEN objvViewInfoEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convViewInfo.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convViewInfo.UserId);
objvViewInfoEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.UserId) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.UserId, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.UserId] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetPrjId(this clsvViewInfoEN objvViewInfoEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convViewInfo.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewInfo.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewInfo.PrjId);
objvViewInfoEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.PrjId) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.PrjId, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.PrjId] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetPrjName(this clsvViewInfoEN objvViewInfoEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convViewInfo.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convViewInfo.PrjName);
objvViewInfoEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.PrjName) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.PrjName, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.PrjName] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewFunction">界面功能</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewFunction(this clsvViewInfoEN objvViewInfoEN, string strViewFunction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewFunction, 100, convViewInfo.ViewFunction);
objvViewInfoEN.ViewFunction = strViewFunction; //界面功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.ViewFunction) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.ViewFunction, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.ViewFunction] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewDetail">界面说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewDetail(this clsvViewInfoEN objvViewInfoEN, string strViewDetail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewDetail, 1000, convViewInfo.ViewDetail);
objvViewInfoEN.ViewDetail = strViewDetail; //界面说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.ViewDetail) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.ViewDetail, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.ViewDetail] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaMenuName">缺省菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetDefaMenuName(this clsvViewInfoEN objvViewInfoEN, string strDefaMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaMenuName, convViewInfo.DefaMenuName);
clsCheckSql.CheckFieldLen(strDefaMenuName, 100, convViewInfo.DefaMenuName);
objvViewInfoEN.DefaMenuName = strDefaMenuName; //缺省菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.DefaMenuName) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.DefaMenuName, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.DefaMenuName] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDetailTabId">明细表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetDetailTabId(this clsvViewInfoEN objvViewInfoEN, string strDetailTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDetailTabId, 8, convViewInfo.DetailTabId);
objvViewInfoEN.DetailTabId = strDetailTabId; //明细表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.DetailTabId) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.DetailTabId, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.DetailTabId] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetFileName(this clsvViewInfoEN objvViewInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convViewInfo.FileName);
clsCheckSql.CheckFieldLen(strFileName, 150, convViewInfo.FileName);
objvViewInfoEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.FileName) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.FileName, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.FileName] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilePath">文件路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetFilePath(this clsvViewInfoEN objvViewInfoEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convViewInfo.FilePath);
clsCheckSql.CheckFieldLen(strFilePath, 500, convViewInfo.FilePath);
objvViewInfoEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.FilePath) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.FilePath, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.FilePath] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strMainTabId">主表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetMainTabId(this clsvViewInfoEN objvViewInfoEN, string strMainTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMainTabId, 8, convViewInfo.MainTabId);
objvViewInfoEN.MainTabId = strMainTabId; //主表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.MainTabId) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.MainTabId, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.MainTabId] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewCnName">视图中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewCnName(this clsvViewInfoEN objvViewInfoEN, string strViewCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewCnName, 100, convViewInfo.ViewCnName);
objvViewInfoEN.ViewCnName = strViewCnName; //视图中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.ViewCnName) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.ViewCnName, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.ViewCnName] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewGroupId">界面组ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewGroupId(this clsvViewInfoEN objvViewInfoEN, string strViewGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewGroupId, convViewInfo.ViewGroupId);
clsCheckSql.CheckFieldLen(strViewGroupId, 8, convViewInfo.ViewGroupId);
clsCheckSql.CheckFieldForeignKey(strViewGroupId, 8, convViewInfo.ViewGroupId);
objvViewInfoEN.ViewGroupId = strViewGroupId; //界面组ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.ViewGroupId) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.ViewGroupId, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.ViewGroupId] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewGroupName">界面组名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewGroupName(this clsvViewInfoEN objvViewInfoEN, string strViewGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewGroupName, convViewInfo.ViewGroupName);
clsCheckSql.CheckFieldLen(strViewGroupName, 30, convViewInfo.ViewGroupName);
objvViewInfoEN.ViewGroupName = strViewGroupName; //界面组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.ViewGroupName) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.ViewGroupName, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.ViewGroupName] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strInSqlDsTypeId">输入数据源类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetInSqlDsTypeId(this clsvViewInfoEN objvViewInfoEN, string strInSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInSqlDsTypeId, 2, convViewInfo.InSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strInSqlDsTypeId, 2, convViewInfo.InSqlDsTypeId);
objvViewInfoEN.InSqlDsTypeId = strInSqlDsTypeId; //输入数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.InSqlDsTypeId) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.InSqlDsTypeId, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.InSqlDsTypeId] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutSqlDsTypeId">输出数据源类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetOutSqlDsTypeId(this clsvViewInfoEN objvViewInfoEN, string strOutSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutSqlDsTypeId, 2, convViewInfo.OutSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strOutSqlDsTypeId, 2, convViewInfo.OutSqlDsTypeId);
objvViewInfoEN.OutSqlDsTypeId = strOutSqlDsTypeId; //输出数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.OutSqlDsTypeId) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.OutSqlDsTypeId, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.OutSqlDsTypeId] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strGeneCodeDate">生成代码日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetGeneCodeDate(this clsvViewInfoEN objvViewInfoEN, string strGeneCodeDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convViewInfo.GeneCodeDate);
objvViewInfoEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.GeneCodeDate) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.GeneCodeDate, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.GeneCodeDate] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strTaskId">任务Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetTaskId(this clsvViewInfoEN objvViewInfoEN, string strTaskId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTaskId, 16, convViewInfo.TaskId);
clsCheckSql.CheckFieldForeignKey(strTaskId, 16, convViewInfo.TaskId);
objvViewInfoEN.TaskId = strTaskId; //任务Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.TaskId) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.TaskId, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.TaskId] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyId4Test">测试关键字Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetKeyId4Test(this clsvViewInfoEN objvViewInfoEN, string strKeyId4Test, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyId4Test, 50, convViewInfo.KeyId4Test);
objvViewInfoEN.KeyId4Test = strKeyId4Test; //测试关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.KeyId4Test) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.KeyId4Test, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.KeyId4Test] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewMasterId">界面母版Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewMasterId(this clsvViewInfoEN objvViewInfoEN, string strViewMasterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewMasterId, 8, convViewInfo.ViewMasterId);
clsCheckSql.CheckFieldForeignKey(strViewMasterId, 8, convViewInfo.ViewMasterId);
objvViewInfoEN.ViewMasterId = strViewMasterId; //界面母版Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.ViewMasterId) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.ViewMasterId, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.ViewMasterId] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewMasterName">界面母版名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewMasterName(this clsvViewInfoEN objvViewInfoEN, string strViewMasterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewMasterName, 50, convViewInfo.ViewMasterName);
objvViewInfoEN.ViewMasterName = strViewMasterName; //界面母版名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.ViewMasterName) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.ViewMasterName, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.ViewMasterName] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetUpdDate(this clsvViewInfoEN objvViewInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewInfo.UpdDate);
objvViewInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.UpdDate) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.UpdDate, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.UpdDate] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetUpdUserId(this clsvViewInfoEN objvViewInfoEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convViewInfo.UpdUserId);
objvViewInfoEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.UpdUserId) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.UpdUserId, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.UpdUserId] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetMemo(this clsvViewInfoEN objvViewInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewInfo.Memo);
objvViewInfoEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.Memo) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.Memo, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.Memo] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strMainTabName">主表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetMainTabName(this clsvViewInfoEN objvViewInfoEN, string strMainTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMainTabName, 100, convViewInfo.MainTabName);
objvViewInfoEN.MainTabName = strMainTabName; //主表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.MainTabName) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.MainTabName, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.MainTabName] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDetailTabName">详细表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetDetailTabName(this clsvViewInfoEN objvViewInfoEN, string strDetailTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDetailTabName, 40, convViewInfo.DetailTabName);
objvViewInfoEN.DetailTabName = strDetailTabName; //详细表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.DetailTabName) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.DetailTabName, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.DetailTabName] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strMainTabKeyFld">主表关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetMainTabKeyFld(this clsvViewInfoEN objvViewInfoEN, string strMainTabKeyFld, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMainTabKeyFld, 50, convViewInfo.MainTabKeyFld);
objvViewInfoEN.MainTabKeyFld = strMainTabKeyFld; //主表关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.MainTabKeyFld) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.MainTabKeyFld, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.MainTabKeyFld] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "intRegionNum">区域数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetRegionNum(this clsvViewInfoEN objvViewInfoEN, int intRegionNum, string strComparisonOp="")
	{
objvViewInfoEN.RegionNum = intRegionNum; //区域数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.RegionNum) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.RegionNum, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.RegionNum] = strComparisonOp;
}
}
return objvViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDetailTabKeyFld">详细表关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetDetailTabKeyFld(this clsvViewInfoEN objvViewInfoEN, string strDetailTabKeyFld, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDetailTabKeyFld, 50, convViewInfo.DetailTabKeyFld);
objvViewInfoEN.DetailTabKeyFld = strDetailTabKeyFld; //详细表关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfoEN.dicFldComparisonOp.ContainsKey(convViewInfo.DetailTabKeyFld) == false)
{
objvViewInfoEN.dicFldComparisonOp.Add(convViewInfo.DetailTabKeyFld, strComparisonOp);
}
else
{
objvViewInfoEN.dicFldComparisonOp[convViewInfo.DetailTabKeyFld] = strComparisonOp;
}
}
return objvViewInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewInfoEN objvViewInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewInfoCond.IsUpdated(convViewInfo.ViewId) == true)
{
string strComparisonOpViewId = objvViewInfoCond.dicFldComparisonOp[convViewInfo.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.ViewId, objvViewInfoCond.ViewId, strComparisonOpViewId);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.TitleStyleId) == true)
{
string strComparisonOpTitleStyleId = objvViewInfoCond.dicFldComparisonOp[convViewInfo.TitleStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.TitleStyleId, objvViewInfoCond.TitleStyleId, strComparisonOpTitleStyleId);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.TitleStyleName) == true)
{
string strComparisonOpTitleStyleName = objvViewInfoCond.dicFldComparisonOp[convViewInfo.TitleStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.TitleStyleName, objvViewInfoCond.TitleStyleName, strComparisonOpTitleStyleName);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.DgStyleId) == true)
{
string strComparisonOpDgStyleId = objvViewInfoCond.dicFldComparisonOp[convViewInfo.DgStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.DgStyleId, objvViewInfoCond.DgStyleId, strComparisonOpDgStyleId);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.DgStyleName) == true)
{
string strComparisonOpDgStyleName = objvViewInfoCond.dicFldComparisonOp[convViewInfo.DgStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.DgStyleName, objvViewInfoCond.DgStyleName, strComparisonOpDgStyleName);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.ViewName) == true)
{
string strComparisonOpViewName = objvViewInfoCond.dicFldComparisonOp[convViewInfo.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.ViewName, objvViewInfoCond.ViewName, strComparisonOpViewName);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvViewInfoCond.dicFldComparisonOp[convViewInfo.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewInfo.ApplicationTypeId, objvViewInfoCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objvViewInfoCond.dicFldComparisonOp[convViewInfo.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.ApplicationTypeSimName, objvViewInfoCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvViewInfoCond.dicFldComparisonOp[convViewInfo.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.FuncModuleAgcId, objvViewInfoCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvViewInfoCond.dicFldComparisonOp[convViewInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.FuncModuleName, objvViewInfoCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvViewInfoCond.dicFldComparisonOp[convViewInfo.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.FuncModuleEnName, objvViewInfoCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objvViewInfoCond.dicFldComparisonOp[convViewInfo.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.DataBaseName, objvViewInfoCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.KeyForMainTab) == true)
{
string strComparisonOpKeyForMainTab = objvViewInfoCond.dicFldComparisonOp[convViewInfo.KeyForMainTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.KeyForMainTab, objvViewInfoCond.KeyForMainTab, strComparisonOpKeyForMainTab);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.KeyForDetailTab) == true)
{
string strComparisonOpKeyForDetailTab = objvViewInfoCond.dicFldComparisonOp[convViewInfo.KeyForDetailTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.KeyForDetailTab, objvViewInfoCond.KeyForDetailTab, strComparisonOpKeyForDetailTab);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.IsNeedSort) == true)
{
if (objvViewInfoCond.IsNeedSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewInfo.IsNeedSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewInfo.IsNeedSort);
}
}
if (objvViewInfoCond.IsUpdated(convViewInfo.IsNeedTransCode) == true)
{
if (objvViewInfoCond.IsNeedTransCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewInfo.IsNeedTransCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewInfo.IsNeedTransCode);
}
}
if (objvViewInfoCond.IsUpdated(convViewInfo.IsNeedSetExportFld) == true)
{
if (objvViewInfoCond.IsNeedSetExportFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewInfo.IsNeedSetExportFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewInfo.IsNeedSetExportFld);
}
}
if (objvViewInfoCond.IsUpdated(convViewInfo.UserId) == true)
{
string strComparisonOpUserId = objvViewInfoCond.dicFldComparisonOp[convViewInfo.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.UserId, objvViewInfoCond.UserId, strComparisonOpUserId);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.PrjId) == true)
{
string strComparisonOpPrjId = objvViewInfoCond.dicFldComparisonOp[convViewInfo.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.PrjId, objvViewInfoCond.PrjId, strComparisonOpPrjId);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.PrjName) == true)
{
string strComparisonOpPrjName = objvViewInfoCond.dicFldComparisonOp[convViewInfo.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.PrjName, objvViewInfoCond.PrjName, strComparisonOpPrjName);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.ViewFunction) == true)
{
string strComparisonOpViewFunction = objvViewInfoCond.dicFldComparisonOp[convViewInfo.ViewFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.ViewFunction, objvViewInfoCond.ViewFunction, strComparisonOpViewFunction);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.ViewDetail) == true)
{
string strComparisonOpViewDetail = objvViewInfoCond.dicFldComparisonOp[convViewInfo.ViewDetail];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.ViewDetail, objvViewInfoCond.ViewDetail, strComparisonOpViewDetail);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.DefaMenuName) == true)
{
string strComparisonOpDefaMenuName = objvViewInfoCond.dicFldComparisonOp[convViewInfo.DefaMenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.DefaMenuName, objvViewInfoCond.DefaMenuName, strComparisonOpDefaMenuName);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.DetailTabId) == true)
{
string strComparisonOpDetailTabId = objvViewInfoCond.dicFldComparisonOp[convViewInfo.DetailTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.DetailTabId, objvViewInfoCond.DetailTabId, strComparisonOpDetailTabId);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.FileName) == true)
{
string strComparisonOpFileName = objvViewInfoCond.dicFldComparisonOp[convViewInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.FileName, objvViewInfoCond.FileName, strComparisonOpFileName);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.FilePath) == true)
{
string strComparisonOpFilePath = objvViewInfoCond.dicFldComparisonOp[convViewInfo.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.FilePath, objvViewInfoCond.FilePath, strComparisonOpFilePath);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.MainTabId) == true)
{
string strComparisonOpMainTabId = objvViewInfoCond.dicFldComparisonOp[convViewInfo.MainTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.MainTabId, objvViewInfoCond.MainTabId, strComparisonOpMainTabId);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.ViewCnName) == true)
{
string strComparisonOpViewCnName = objvViewInfoCond.dicFldComparisonOp[convViewInfo.ViewCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.ViewCnName, objvViewInfoCond.ViewCnName, strComparisonOpViewCnName);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.ViewGroupId) == true)
{
string strComparisonOpViewGroupId = objvViewInfoCond.dicFldComparisonOp[convViewInfo.ViewGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.ViewGroupId, objvViewInfoCond.ViewGroupId, strComparisonOpViewGroupId);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.ViewGroupName) == true)
{
string strComparisonOpViewGroupName = objvViewInfoCond.dicFldComparisonOp[convViewInfo.ViewGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.ViewGroupName, objvViewInfoCond.ViewGroupName, strComparisonOpViewGroupName);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.InSqlDsTypeId) == true)
{
string strComparisonOpInSqlDsTypeId = objvViewInfoCond.dicFldComparisonOp[convViewInfo.InSqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.InSqlDsTypeId, objvViewInfoCond.InSqlDsTypeId, strComparisonOpInSqlDsTypeId);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.OutSqlDsTypeId) == true)
{
string strComparisonOpOutSqlDsTypeId = objvViewInfoCond.dicFldComparisonOp[convViewInfo.OutSqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.OutSqlDsTypeId, objvViewInfoCond.OutSqlDsTypeId, strComparisonOpOutSqlDsTypeId);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.GeneCodeDate) == true)
{
string strComparisonOpGeneCodeDate = objvViewInfoCond.dicFldComparisonOp[convViewInfo.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.GeneCodeDate, objvViewInfoCond.GeneCodeDate, strComparisonOpGeneCodeDate);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.TaskId) == true)
{
string strComparisonOpTaskId = objvViewInfoCond.dicFldComparisonOp[convViewInfo.TaskId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.TaskId, objvViewInfoCond.TaskId, strComparisonOpTaskId);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.KeyId4Test) == true)
{
string strComparisonOpKeyId4Test = objvViewInfoCond.dicFldComparisonOp[convViewInfo.KeyId4Test];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.KeyId4Test, objvViewInfoCond.KeyId4Test, strComparisonOpKeyId4Test);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.ViewMasterId) == true)
{
string strComparisonOpViewMasterId = objvViewInfoCond.dicFldComparisonOp[convViewInfo.ViewMasterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.ViewMasterId, objvViewInfoCond.ViewMasterId, strComparisonOpViewMasterId);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.ViewMasterName) == true)
{
string strComparisonOpViewMasterName = objvViewInfoCond.dicFldComparisonOp[convViewInfo.ViewMasterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.ViewMasterName, objvViewInfoCond.ViewMasterName, strComparisonOpViewMasterName);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.UpdDate) == true)
{
string strComparisonOpUpdDate = objvViewInfoCond.dicFldComparisonOp[convViewInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.UpdDate, objvViewInfoCond.UpdDate, strComparisonOpUpdDate);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvViewInfoCond.dicFldComparisonOp[convViewInfo.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.UpdUserId, objvViewInfoCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.Memo) == true)
{
string strComparisonOpMemo = objvViewInfoCond.dicFldComparisonOp[convViewInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.Memo, objvViewInfoCond.Memo, strComparisonOpMemo);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.MainTabName) == true)
{
string strComparisonOpMainTabName = objvViewInfoCond.dicFldComparisonOp[convViewInfo.MainTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.MainTabName, objvViewInfoCond.MainTabName, strComparisonOpMainTabName);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.DetailTabName) == true)
{
string strComparisonOpDetailTabName = objvViewInfoCond.dicFldComparisonOp[convViewInfo.DetailTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.DetailTabName, objvViewInfoCond.DetailTabName, strComparisonOpDetailTabName);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.MainTabKeyFld) == true)
{
string strComparisonOpMainTabKeyFld = objvViewInfoCond.dicFldComparisonOp[convViewInfo.MainTabKeyFld];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.MainTabKeyFld, objvViewInfoCond.MainTabKeyFld, strComparisonOpMainTabKeyFld);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.RegionNum) == true)
{
string strComparisonOpRegionNum = objvViewInfoCond.dicFldComparisonOp[convViewInfo.RegionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convViewInfo.RegionNum, objvViewInfoCond.RegionNum, strComparisonOpRegionNum);
}
if (objvViewInfoCond.IsUpdated(convViewInfo.DetailTabKeyFld) == true)
{
string strComparisonOpDetailTabKeyFld = objvViewInfoCond.dicFldComparisonOp[convViewInfo.DetailTabKeyFld];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo.DetailTabKeyFld, objvViewInfoCond.DetailTabKeyFld, strComparisonOpDetailTabKeyFld);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v界面(vViewInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvViewInfoWApi
{
private static readonly string mstrApiControllerName = "vViewInfoApi";

 public clsvViewInfoWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ViewId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v界面]...","0");
List<clsvViewInfoEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ViewId";
objDDL.DataTextField="ViewName";
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
public static void BindCbo_ApplicationTypeId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convViewInfo.ApplicationTypeId); 
List<clsvViewInfoEN> arrObjLst = clsvViewInfoWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN()
{
ApplicationTypeId = 0,
ApplicationTypeSimName = "选[v界面]..."
};
arrObjLstSel.Insert(0, objvViewInfoEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convViewInfo.ApplicationTypeId;
objComboBox.DisplayMember = convViewInfo.ApplicationTypeSimName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewInfoEN GetObjByViewId(string strViewId)
{
if (strViewId == "") return null;
string strAction = "GetObjByViewId";
clsvViewInfoEN objvViewInfoEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewId"] = strViewId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvViewInfoEN = JsonConvert.DeserializeObject<clsvViewInfoEN>(strJson);
return objvViewInfoEN;
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
public static clsvViewInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvViewInfoEN objvViewInfoEN;
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
objvViewInfoEN = JsonConvert.DeserializeObject<clsvViewInfoEN>(strJson);
return objvViewInfoEN;
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
 /// <param name = "strViewId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewInfoEN GetObjByViewIdCache(string strViewId,string strPrjId)
{
if (string.IsNullOrEmpty(strViewId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvViewInfoEN._CurrTabName, strPrjId);
List<clsvViewInfoEN> arrvViewInfoObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewInfoEN> arrvViewInfoObjLst_Sel =
from objvViewInfoEN in arrvViewInfoObjLstCache
where objvViewInfoEN.ViewId == strViewId 
select objvViewInfoEN;
if (arrvViewInfoObjLst_Sel.Count() == 0)
{
   clsvViewInfoEN obj = clsvViewInfoWApi.GetObjByViewId(strViewId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvViewInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetViewNameByViewIdCache(string strViewId,string strPrjId)
{
if (string.IsNullOrEmpty(strViewId) == true) return "";
//初始化列表缓存
List<clsvViewInfoEN> arrvViewInfoObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewInfoEN> arrvViewInfoObjLst_Sel1 =
from objvViewInfoEN in arrvViewInfoObjLstCache
where objvViewInfoEN.ViewId == strViewId 
select objvViewInfoEN;
List <clsvViewInfoEN> arrvViewInfoObjLst_Sel = new List<clsvViewInfoEN>();
foreach (clsvViewInfoEN obj in arrvViewInfoObjLst_Sel1)
{
arrvViewInfoObjLst_Sel.Add(obj);
}
if (arrvViewInfoObjLst_Sel.Count > 0)
{
return arrvViewInfoObjLst_Sel[0].ViewName;
}
string strErrMsgForGetObjById = string.Format("在vViewInfo对象缓存列表中,找不到记录[ViewId = {0}](函数:{1})", strViewId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvViewInfoBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByViewIdCache(string strViewId,string strPrjId)
{
if (string.IsNullOrEmpty(strViewId) == true) return "";
//初始化列表缓存
List<clsvViewInfoEN> arrvViewInfoObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewInfoEN> arrvViewInfoObjLst_Sel1 =
from objvViewInfoEN in arrvViewInfoObjLstCache
where objvViewInfoEN.ViewId == strViewId 
select objvViewInfoEN;
List <clsvViewInfoEN> arrvViewInfoObjLst_Sel = new List<clsvViewInfoEN>();
foreach (clsvViewInfoEN obj in arrvViewInfoObjLst_Sel1)
{
arrvViewInfoObjLst_Sel.Add(obj);
}
if (arrvViewInfoObjLst_Sel.Count > 0)
{
return arrvViewInfoObjLst_Sel[0].ViewName;
}
string strErrMsgForGetObjById = string.Format("在vViewInfo对象缓存列表中,找不到记录的相关名称[ViewId = {0}](函数:{1})", strViewId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvViewInfoBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewInfoEN>>(strJson);
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
 /// <param name = "arrViewId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewInfoEN> GetObjLstByViewIdLst(List<string> arrViewId)
{
 List<clsvViewInfoEN> arrObjLst; 
string strAction = "GetObjLstByViewIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewInfoEN>>(strJson);
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
 /// <param name = "arrViewId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvViewInfoEN> GetObjLstByViewIdLstCache(List<string> arrViewId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvViewInfoEN._CurrTabName, strPrjId);
List<clsvViewInfoEN> arrvViewInfoObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewInfoEN> arrvViewInfoObjLst_Sel =
from objvViewInfoEN in arrvViewInfoObjLstCache
where arrViewId.Contains(objvViewInfoEN.ViewId)
select objvViewInfoEN;
return arrvViewInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewInfoEN>>(strJson);
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
public static List<clsvViewInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewInfoEN>>(strJson);
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
public static List<clsvViewInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewInfoEN>>(strJson);
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
public static List<clsvViewInfoEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewInfoEN>>(strJson);
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
public static bool IsExist(string strViewId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewId"] = strViewId
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
 /// <param name = "objvViewInfoENS">源对象</param>
 /// <param name = "objvViewInfoENT">目标对象</param>
 public static void CopyTo(clsvViewInfoEN objvViewInfoENS, clsvViewInfoEN objvViewInfoENT)
{
try
{
objvViewInfoENT.ViewId = objvViewInfoENS.ViewId; //界面Id
objvViewInfoENT.TitleStyleId = objvViewInfoENS.TitleStyleId; //标题类型Id
objvViewInfoENT.TitleStyleName = objvViewInfoENS.TitleStyleName; //标题类型名
objvViewInfoENT.DgStyleId = objvViewInfoENS.DgStyleId; //DG模式ID
objvViewInfoENT.DgStyleName = objvViewInfoENS.DgStyleName; //DG模式名
objvViewInfoENT.ViewName = objvViewInfoENS.ViewName; //界面名称
objvViewInfoENT.ApplicationTypeId = objvViewInfoENS.ApplicationTypeId; //应用程序类型ID
objvViewInfoENT.ApplicationTypeSimName = objvViewInfoENS.ApplicationTypeSimName; //应用程序类型简称
objvViewInfoENT.FuncModuleAgcId = objvViewInfoENS.FuncModuleAgcId; //功能模块Id
objvViewInfoENT.FuncModuleName = objvViewInfoENS.FuncModuleName; //功能模块名称
objvViewInfoENT.FuncModuleEnName = objvViewInfoENS.FuncModuleEnName; //功能模块英文名称
objvViewInfoENT.DataBaseName = objvViewInfoENS.DataBaseName; //数据库名
objvViewInfoENT.KeyForMainTab = objvViewInfoENS.KeyForMainTab; //主表关键字
objvViewInfoENT.KeyForDetailTab = objvViewInfoENS.KeyForDetailTab; //明细表关键字
objvViewInfoENT.IsNeedSort = objvViewInfoENS.IsNeedSort; //是否需要排序
objvViewInfoENT.IsNeedTransCode = objvViewInfoENS.IsNeedTransCode; //是否需要转换代码
objvViewInfoENT.IsNeedSetExportFld = objvViewInfoENS.IsNeedSetExportFld; //是否需要设置导出字段
objvViewInfoENT.UserId = objvViewInfoENS.UserId; //用户Id
objvViewInfoENT.PrjId = objvViewInfoENS.PrjId; //工程Id
objvViewInfoENT.PrjName = objvViewInfoENS.PrjName; //工程名称
objvViewInfoENT.ViewFunction = objvViewInfoENS.ViewFunction; //界面功能
objvViewInfoENT.ViewDetail = objvViewInfoENS.ViewDetail; //界面说明
objvViewInfoENT.DefaMenuName = objvViewInfoENS.DefaMenuName; //缺省菜单名
objvViewInfoENT.DetailTabId = objvViewInfoENS.DetailTabId; //明细表ID
objvViewInfoENT.FileName = objvViewInfoENS.FileName; //文件名
objvViewInfoENT.FilePath = objvViewInfoENS.FilePath; //文件路径
objvViewInfoENT.MainTabId = objvViewInfoENS.MainTabId; //主表ID
objvViewInfoENT.ViewCnName = objvViewInfoENS.ViewCnName; //视图中文名
objvViewInfoENT.ViewGroupId = objvViewInfoENS.ViewGroupId; //界面组ID
objvViewInfoENT.ViewGroupName = objvViewInfoENS.ViewGroupName; //界面组名称
objvViewInfoENT.InSqlDsTypeId = objvViewInfoENS.InSqlDsTypeId; //输入数据源类型
objvViewInfoENT.OutSqlDsTypeId = objvViewInfoENS.OutSqlDsTypeId; //输出数据源类型
objvViewInfoENT.GeneCodeDate = objvViewInfoENS.GeneCodeDate; //生成代码日期
objvViewInfoENT.TaskId = objvViewInfoENS.TaskId; //任务Id
objvViewInfoENT.KeyId4Test = objvViewInfoENS.KeyId4Test; //测试关键字Id
objvViewInfoENT.ViewMasterId = objvViewInfoENS.ViewMasterId; //界面母版Id
objvViewInfoENT.ViewMasterName = objvViewInfoENS.ViewMasterName; //界面母版名
objvViewInfoENT.UpdDate = objvViewInfoENS.UpdDate; //修改日期
objvViewInfoENT.UpdUserId = objvViewInfoENS.UpdUserId; //修改用户Id
objvViewInfoENT.Memo = objvViewInfoENS.Memo; //说明
objvViewInfoENT.MainTabName = objvViewInfoENS.MainTabName; //主表
objvViewInfoENT.DetailTabName = objvViewInfoENS.DetailTabName; //详细表
objvViewInfoENT.MainTabKeyFld = objvViewInfoENS.MainTabKeyFld; //主表关键字
objvViewInfoENT.RegionNum = objvViewInfoENS.RegionNum; //区域数
objvViewInfoENT.DetailTabKeyFld = objvViewInfoENS.DetailTabKeyFld; //详细表关键字
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
public static DataTable ToDataTable(List<clsvViewInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvViewInfoEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvViewInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvViewInfoEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvViewInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvViewInfoEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvViewInfoWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvViewInfoWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvViewInfoEN._CurrTabName, strPrjId);
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
public static List<clsvViewInfoEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvViewInfoWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvViewInfoWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvViewInfoEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvViewInfoEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convViewInfo.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvViewInfoEN._CurrTabName, strPrjId);
List<clsvViewInfoEN> arrvViewInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvViewInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewInfoEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvViewInfoEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvViewInfoWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvViewInfoWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvViewInfoEN._CurrTabName, strPrjId);
List<clsvViewInfoEN> arrvViewInfoObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvViewInfoObjLstCache = CacheHelper.Get<List<clsvViewInfoEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvViewInfoObjLstCache = CacheHelper.Get<List<clsvViewInfoEN>>(strKey);
}
return arrvViewInfoObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvViewInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convViewInfo.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.TitleStyleId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.TitleStyleName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.DgStyleId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.DgStyleName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewInfo.ApplicationTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.DataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.KeyForMainTab, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.KeyForDetailTab, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.IsNeedSort, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewInfo.IsNeedTransCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewInfo.IsNeedSetExportFld, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewInfo.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.ViewFunction, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.ViewDetail, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.DefaMenuName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.DetailTabId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.MainTabId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.ViewCnName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.ViewGroupId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.ViewGroupName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.InSqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.OutSqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.GeneCodeDate, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.TaskId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.KeyId4Test, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.ViewMasterId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.ViewMasterName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.MainTabName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.DetailTabName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.MainTabKeyFld, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo.RegionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewInfo.DetailTabKeyFld, Type.GetType("System.String"));
foreach (clsvViewInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convViewInfo.ViewId] = objInFor[convViewInfo.ViewId];
objDR[convViewInfo.TitleStyleId] = objInFor[convViewInfo.TitleStyleId];
objDR[convViewInfo.TitleStyleName] = objInFor[convViewInfo.TitleStyleName];
objDR[convViewInfo.DgStyleId] = objInFor[convViewInfo.DgStyleId];
objDR[convViewInfo.DgStyleName] = objInFor[convViewInfo.DgStyleName];
objDR[convViewInfo.ViewName] = objInFor[convViewInfo.ViewName];
objDR[convViewInfo.ApplicationTypeId] = objInFor[convViewInfo.ApplicationTypeId];
objDR[convViewInfo.ApplicationTypeSimName] = objInFor[convViewInfo.ApplicationTypeSimName];
objDR[convViewInfo.FuncModuleAgcId] = objInFor[convViewInfo.FuncModuleAgcId];
objDR[convViewInfo.FuncModuleName] = objInFor[convViewInfo.FuncModuleName];
objDR[convViewInfo.FuncModuleEnName] = objInFor[convViewInfo.FuncModuleEnName];
objDR[convViewInfo.DataBaseName] = objInFor[convViewInfo.DataBaseName];
objDR[convViewInfo.KeyForMainTab] = objInFor[convViewInfo.KeyForMainTab];
objDR[convViewInfo.KeyForDetailTab] = objInFor[convViewInfo.KeyForDetailTab];
objDR[convViewInfo.IsNeedSort] = objInFor[convViewInfo.IsNeedSort];
objDR[convViewInfo.IsNeedTransCode] = objInFor[convViewInfo.IsNeedTransCode];
objDR[convViewInfo.IsNeedSetExportFld] = objInFor[convViewInfo.IsNeedSetExportFld];
objDR[convViewInfo.UserId] = objInFor[convViewInfo.UserId];
objDR[convViewInfo.PrjId] = objInFor[convViewInfo.PrjId];
objDR[convViewInfo.PrjName] = objInFor[convViewInfo.PrjName];
objDR[convViewInfo.ViewFunction] = objInFor[convViewInfo.ViewFunction];
objDR[convViewInfo.ViewDetail] = objInFor[convViewInfo.ViewDetail];
objDR[convViewInfo.DefaMenuName] = objInFor[convViewInfo.DefaMenuName];
objDR[convViewInfo.DetailTabId] = objInFor[convViewInfo.DetailTabId];
objDR[convViewInfo.FileName] = objInFor[convViewInfo.FileName];
objDR[convViewInfo.FilePath] = objInFor[convViewInfo.FilePath];
objDR[convViewInfo.MainTabId] = objInFor[convViewInfo.MainTabId];
objDR[convViewInfo.ViewCnName] = objInFor[convViewInfo.ViewCnName];
objDR[convViewInfo.ViewGroupId] = objInFor[convViewInfo.ViewGroupId];
objDR[convViewInfo.ViewGroupName] = objInFor[convViewInfo.ViewGroupName];
objDR[convViewInfo.InSqlDsTypeId] = objInFor[convViewInfo.InSqlDsTypeId];
objDR[convViewInfo.OutSqlDsTypeId] = objInFor[convViewInfo.OutSqlDsTypeId];
objDR[convViewInfo.GeneCodeDate] = objInFor[convViewInfo.GeneCodeDate];
objDR[convViewInfo.TaskId] = objInFor[convViewInfo.TaskId];
objDR[convViewInfo.KeyId4Test] = objInFor[convViewInfo.KeyId4Test];
objDR[convViewInfo.ViewMasterId] = objInFor[convViewInfo.ViewMasterId];
objDR[convViewInfo.ViewMasterName] = objInFor[convViewInfo.ViewMasterName];
objDR[convViewInfo.UpdDate] = objInFor[convViewInfo.UpdDate];
objDR[convViewInfo.UpdUserId] = objInFor[convViewInfo.UpdUserId];
objDR[convViewInfo.Memo] = objInFor[convViewInfo.Memo];
objDR[convViewInfo.MainTabName] = objInFor[convViewInfo.MainTabName];
objDR[convViewInfo.DetailTabName] = objInFor[convViewInfo.DetailTabName];
objDR[convViewInfo.MainTabKeyFld] = objInFor[convViewInfo.MainTabKeyFld];
objDR[convViewInfo.RegionNum] = objInFor[convViewInfo.RegionNum];
objDR[convViewInfo.DetailTabKeyFld] = objInFor[convViewInfo.DetailTabKeyFld];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}