
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewTypeCodeTabWApi
 表名:vViewTypeCodeTab(00050133)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:51:01
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
public static class  clsvViewTypeCodeTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intViewTypeCode">界面类型码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetViewTypeCode(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, int intViewTypeCode, string strComparisonOp="")
	{
objvViewTypeCodeTabEN.ViewTypeCode = intViewTypeCode; //界面类型码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.ViewTypeCode) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.ViewTypeCode, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.ViewTypeCode] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewTypeName">界面类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetViewTypeName(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, string strViewTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewTypeName, convViewTypeCodeTab.ViewTypeName);
clsCheckSql.CheckFieldLen(strViewTypeName, 40, convViewTypeCodeTab.ViewTypeName);
objvViewTypeCodeTabEN.ViewTypeName = strViewTypeName; //界面类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.ViewTypeName) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.ViewTypeName, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.ViewTypeName] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewTypeENName">ViewTypeENName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetViewTypeENName(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, string strViewTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewTypeENName, 40, convViewTypeCodeTab.ViewTypeENName);
objvViewTypeCodeTabEN.ViewTypeENName = strViewTypeENName; //ViewTypeENName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.ViewTypeENName) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.ViewTypeENName, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.ViewTypeENName] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsWinApp">IsWinApp</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetIsWinApp(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, bool bolIsWinApp, string strComparisonOp="")
	{
objvViewTypeCodeTabEN.IsWinApp = bolIsWinApp; //IsWinApp
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.IsWinApp) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.IsWinApp, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.IsWinApp] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsMobileApp">是否移动终端应用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetIsMobileApp(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, bool bolIsMobileApp, string strComparisonOp="")
	{
objvViewTypeCodeTabEN.IsMobileApp = bolIsMobileApp; //是否移动终端应用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.IsMobileApp) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.IsMobileApp, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.IsMobileApp] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsWebApp">IsWebApp</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetIsWebApp(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, bool bolIsWebApp, string strComparisonOp="")
	{
objvViewTypeCodeTabEN.IsWebApp = bolIsWebApp; //IsWebApp
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.IsWebApp) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.IsWebApp, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.IsWebApp] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewFunction">界面功能</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetViewFunction(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, string strViewFunction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewFunction, 100, convViewTypeCodeTab.ViewFunction);
objvViewTypeCodeTabEN.ViewFunction = strViewFunction; //界面功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.ViewFunction) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.ViewFunction, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.ViewFunction] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strOptProcess">操作流程</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetOptProcess(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, string strOptProcess, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptProcess, 1000, convViewTypeCodeTab.OptProcess);
objvViewTypeCodeTabEN.OptProcess = strOptProcess; //操作流程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.OptProcess) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.OptProcess, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.OptProcess] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewDetail">界面说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetViewDetail(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, string strViewDetail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewDetail, 1000, convViewTypeCodeTab.ViewDetail);
objvViewTypeCodeTabEN.ViewDetail = strViewDetail; //界面说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.ViewDetail) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.ViewDetail, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.ViewDetail] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetApplicationTypeId(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convViewTypeCodeTab.ApplicationTypeId);
objvViewTypeCodeTabEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.ApplicationTypeId) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.ApplicationTypeId, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.ApplicationTypeId] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetApplicationTypeName(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, convViewTypeCodeTab.ApplicationTypeName);
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convViewTypeCodeTab.ApplicationTypeName);
objvViewTypeCodeTabEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.ApplicationTypeName) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.ApplicationTypeName, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.ApplicationTypeName] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveAdd">是否有添加</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetIsHaveAdd(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, bool bolIsHaveAdd, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveAdd, convViewTypeCodeTab.IsHaveAdd);
objvViewTypeCodeTabEN.IsHaveAdd = bolIsHaveAdd; //是否有添加
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.IsHaveAdd) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.IsHaveAdd, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.IsHaveAdd] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveUpdate">是否有修改</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetIsHaveUpdate(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, bool bolIsHaveUpdate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveUpdate, convViewTypeCodeTab.IsHaveUpdate);
objvViewTypeCodeTabEN.IsHaveUpdate = bolIsHaveUpdate; //是否有修改
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.IsHaveUpdate) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.IsHaveUpdate, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.IsHaveUpdate] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveDel">是否有删除</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetIsHaveDel(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, bool bolIsHaveDel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveDel, convViewTypeCodeTab.IsHaveDel);
objvViewTypeCodeTabEN.IsHaveDel = bolIsHaveDel; //是否有删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.IsHaveDel) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.IsHaveDel, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.IsHaveDel] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveQuery">是否有查询</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetIsHaveQuery(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, bool bolIsHaveQuery, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveQuery, convViewTypeCodeTab.IsHaveQuery);
objvViewTypeCodeTabEN.IsHaveQuery = bolIsHaveQuery; //是否有查询
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.IsHaveQuery) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.IsHaveQuery, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.IsHaveQuery] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveExcelExport">是否EXCEL导出</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetIsHaveExcelExport(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, bool bolIsHaveExcelExport, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveExcelExport, convViewTypeCodeTab.IsHaveExcelExport);
objvViewTypeCodeTabEN.IsHaveExcelExport = bolIsHaveExcelExport; //是否EXCEL导出
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.IsHaveExcelExport) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.IsHaveExcelExport, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.IsHaveExcelExport] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveSetExportExcel">是否有设置EXCEL导出</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetIsHaveSetExportExcel(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, bool bolIsHaveSetExportExcel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveSetExportExcel, convViewTypeCodeTab.IsHaveSetExportExcel);
objvViewTypeCodeTabEN.IsHaveSetExportExcel = bolIsHaveSetExportExcel; //是否有设置EXCEL导出
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.IsHaveSetExportExcel) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.IsHaveSetExportExcel, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.IsHaveSetExportExcel] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveDetail">是否有详细</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetIsHaveDetail(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, bool bolIsHaveDetail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveDetail, convViewTypeCodeTab.IsHaveDetail);
objvViewTypeCodeTabEN.IsHaveDetail = bolIsHaveDetail; //是否有详细
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.IsHaveDetail) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.IsHaveDetail, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.IsHaveDetail] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveExeAdd">是否有调用添加</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetIsHaveExeAdd(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, bool bolIsHaveExeAdd, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveExeAdd, convViewTypeCodeTab.IsHaveExeAdd);
objvViewTypeCodeTabEN.IsHaveExeAdd = bolIsHaveExeAdd; //是否有调用添加
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.IsHaveExeAdd) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.IsHaveExeAdd, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.IsHaveExeAdd] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveExeUpdate">是否有调用修改</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetIsHaveExeUpdate(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, bool bolIsHaveExeUpdate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveExeUpdate, convViewTypeCodeTab.IsHaveExeUpdate);
objvViewTypeCodeTabEN.IsHaveExeUpdate = bolIsHaveExeUpdate; //是否有调用修改
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.IsHaveExeUpdate) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.IsHaveExeUpdate, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.IsHaveExeUpdate] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveMainView">是否有主界面</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetIsHaveMainView(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, bool bolIsHaveMainView, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveMainView, convViewTypeCodeTab.IsHaveMainView);
objvViewTypeCodeTabEN.IsHaveMainView = bolIsHaveMainView; //是否有主界面
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.IsHaveMainView) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.IsHaveMainView, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.IsHaveMainView] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveSubView">是否有子界面</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetIsHaveSubView(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, bool bolIsHaveSubView, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveSubView, convViewTypeCodeTab.IsHaveSubView);
objvViewTypeCodeTabEN.IsHaveSubView = bolIsHaveSubView; //是否有子界面
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.IsHaveSubView) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.IsHaveSubView, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.IsHaveSubView] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetOrderNum(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, int intOrderNum, string strComparisonOp="")
	{
objvViewTypeCodeTabEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.OrderNum) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.OrderNum, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.OrderNum] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsUsed">IsUsed</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetIsUsed(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, bool bolIsUsed, string strComparisonOp="")
	{
objvViewTypeCodeTabEN.IsUsed = bolIsUsed; //IsUsed
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(convViewTypeCodeTab.IsUsed) == false)
{
objvViewTypeCodeTabEN.dicFldComparisonOp.Add(convViewTypeCodeTab.IsUsed, strComparisonOp);
}
else
{
objvViewTypeCodeTabEN.dicFldComparisonOp[convViewTypeCodeTab.IsUsed] = strComparisonOp;
}
}
return objvViewTypeCodeTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewTypeCodeTabEN objvViewTypeCodeTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.ViewTypeCode) == true)
{
string strComparisonOpViewTypeCode = objvViewTypeCodeTabCond.dicFldComparisonOp[convViewTypeCodeTab.ViewTypeCode];
strWhereCond += string.Format(" And {0} {2} {1}", convViewTypeCodeTab.ViewTypeCode, objvViewTypeCodeTabCond.ViewTypeCode, strComparisonOpViewTypeCode);
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.ViewTypeName) == true)
{
string strComparisonOpViewTypeName = objvViewTypeCodeTabCond.dicFldComparisonOp[convViewTypeCodeTab.ViewTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewTypeCodeTab.ViewTypeName, objvViewTypeCodeTabCond.ViewTypeName, strComparisonOpViewTypeName);
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.ViewTypeENName) == true)
{
string strComparisonOpViewTypeENName = objvViewTypeCodeTabCond.dicFldComparisonOp[convViewTypeCodeTab.ViewTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewTypeCodeTab.ViewTypeENName, objvViewTypeCodeTabCond.ViewTypeENName, strComparisonOpViewTypeENName);
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.IsWinApp) == true)
{
if (objvViewTypeCodeTabCond.IsWinApp == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewTypeCodeTab.IsWinApp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewTypeCodeTab.IsWinApp);
}
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.IsMobileApp) == true)
{
if (objvViewTypeCodeTabCond.IsMobileApp == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewTypeCodeTab.IsMobileApp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewTypeCodeTab.IsMobileApp);
}
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.IsWebApp) == true)
{
if (objvViewTypeCodeTabCond.IsWebApp == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewTypeCodeTab.IsWebApp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewTypeCodeTab.IsWebApp);
}
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.ViewFunction) == true)
{
string strComparisonOpViewFunction = objvViewTypeCodeTabCond.dicFldComparisonOp[convViewTypeCodeTab.ViewFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewTypeCodeTab.ViewFunction, objvViewTypeCodeTabCond.ViewFunction, strComparisonOpViewFunction);
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.OptProcess) == true)
{
string strComparisonOpOptProcess = objvViewTypeCodeTabCond.dicFldComparisonOp[convViewTypeCodeTab.OptProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewTypeCodeTab.OptProcess, objvViewTypeCodeTabCond.OptProcess, strComparisonOpOptProcess);
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.ViewDetail) == true)
{
string strComparisonOpViewDetail = objvViewTypeCodeTabCond.dicFldComparisonOp[convViewTypeCodeTab.ViewDetail];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewTypeCodeTab.ViewDetail, objvViewTypeCodeTabCond.ViewDetail, strComparisonOpViewDetail);
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvViewTypeCodeTabCond.dicFldComparisonOp[convViewTypeCodeTab.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewTypeCodeTab.ApplicationTypeId, objvViewTypeCodeTabCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvViewTypeCodeTabCond.dicFldComparisonOp[convViewTypeCodeTab.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewTypeCodeTab.ApplicationTypeName, objvViewTypeCodeTabCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.IsHaveAdd) == true)
{
if (objvViewTypeCodeTabCond.IsHaveAdd == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewTypeCodeTab.IsHaveAdd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewTypeCodeTab.IsHaveAdd);
}
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.IsHaveUpdate) == true)
{
if (objvViewTypeCodeTabCond.IsHaveUpdate == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewTypeCodeTab.IsHaveUpdate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewTypeCodeTab.IsHaveUpdate);
}
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.IsHaveDel) == true)
{
if (objvViewTypeCodeTabCond.IsHaveDel == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewTypeCodeTab.IsHaveDel);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewTypeCodeTab.IsHaveDel);
}
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.IsHaveQuery) == true)
{
if (objvViewTypeCodeTabCond.IsHaveQuery == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewTypeCodeTab.IsHaveQuery);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewTypeCodeTab.IsHaveQuery);
}
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.IsHaveExcelExport) == true)
{
if (objvViewTypeCodeTabCond.IsHaveExcelExport == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewTypeCodeTab.IsHaveExcelExport);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewTypeCodeTab.IsHaveExcelExport);
}
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.IsHaveSetExportExcel) == true)
{
if (objvViewTypeCodeTabCond.IsHaveSetExportExcel == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewTypeCodeTab.IsHaveSetExportExcel);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewTypeCodeTab.IsHaveSetExportExcel);
}
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.IsHaveDetail) == true)
{
if (objvViewTypeCodeTabCond.IsHaveDetail == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewTypeCodeTab.IsHaveDetail);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewTypeCodeTab.IsHaveDetail);
}
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.IsHaveExeAdd) == true)
{
if (objvViewTypeCodeTabCond.IsHaveExeAdd == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewTypeCodeTab.IsHaveExeAdd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewTypeCodeTab.IsHaveExeAdd);
}
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.IsHaveExeUpdate) == true)
{
if (objvViewTypeCodeTabCond.IsHaveExeUpdate == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewTypeCodeTab.IsHaveExeUpdate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewTypeCodeTab.IsHaveExeUpdate);
}
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.IsHaveMainView) == true)
{
if (objvViewTypeCodeTabCond.IsHaveMainView == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewTypeCodeTab.IsHaveMainView);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewTypeCodeTab.IsHaveMainView);
}
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.IsHaveSubView) == true)
{
if (objvViewTypeCodeTabCond.IsHaveSubView == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewTypeCodeTab.IsHaveSubView);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewTypeCodeTab.IsHaveSubView);
}
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.OrderNum) == true)
{
string strComparisonOpOrderNum = objvViewTypeCodeTabCond.dicFldComparisonOp[convViewTypeCodeTab.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convViewTypeCodeTab.OrderNum, objvViewTypeCodeTabCond.OrderNum, strComparisonOpOrderNum);
}
if (objvViewTypeCodeTabCond.IsUpdated(convViewTypeCodeTab.IsUsed) == true)
{
if (objvViewTypeCodeTabCond.IsUsed == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewTypeCodeTab.IsUsed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewTypeCodeTab.IsUsed);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// v界面类型码(vViewTypeCodeTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvViewTypeCodeTabWApi
{
private static readonly string mstrApiControllerName = "vViewTypeCodeTabApi";

 public clsvViewTypeCodeTabWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "intViewTypeCode">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewTypeCodeTabEN GetObjByViewTypeCode(int intViewTypeCode)
{
if (intViewTypeCode == 0) return null;
string strAction = "GetObjByViewTypeCode";
clsvViewTypeCodeTabEN objvViewTypeCodeTabEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["intViewTypeCode"] = intViewTypeCode.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvViewTypeCodeTabEN = JsonConvert.DeserializeObject<clsvViewTypeCodeTabEN>(strJson);
return objvViewTypeCodeTabEN;
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
public static int GetFirstID(string strWhereCond)
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
return int.Parse(strReturnStr);
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
public static clsvViewTypeCodeTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvViewTypeCodeTabEN objvViewTypeCodeTabEN;
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
objvViewTypeCodeTabEN = JsonConvert.DeserializeObject<clsvViewTypeCodeTabEN>(strJson);
return objvViewTypeCodeTabEN;
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
 /// <param name = "intViewTypeCode">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewTypeCodeTabEN GetObjByViewTypeCodeCache(int intViewTypeCode)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvViewTypeCodeTabEN._CurrTabName);
List<clsvViewTypeCodeTabEN> arrvViewTypeCodeTabObjLstCache = GetObjLstCache();
IEnumerable <clsvViewTypeCodeTabEN> arrvViewTypeCodeTabObjLst_Sel =
from objvViewTypeCodeTabEN in arrvViewTypeCodeTabObjLstCache
where objvViewTypeCodeTabEN.ViewTypeCode == intViewTypeCode 
select objvViewTypeCodeTabEN;
if (arrvViewTypeCodeTabObjLst_Sel.Count() == 0)
{
   clsvViewTypeCodeTabEN obj = clsvViewTypeCodeTabWApi.GetObjByViewTypeCode(intViewTypeCode);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvViewTypeCodeTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewTypeCodeTabEN> GetObjLst(string strWhereCond)
{
 List<clsvViewTypeCodeTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewTypeCodeTabEN>>(strJson);
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
 /// <param name = "arrViewTypeCode">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewTypeCodeTabEN> GetObjLstByViewTypeCodeLst(List<int> arrViewTypeCode)
{
 List<clsvViewTypeCodeTabEN> arrObjLst; 
string strAction = "GetObjLstByViewTypeCodeLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewTypeCode);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewTypeCodeTabEN>>(strJson);
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
 /// <param name = "arrViewTypeCode">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvViewTypeCodeTabEN> GetObjLstByViewTypeCodeLstCache(List<int> arrViewTypeCode)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvViewTypeCodeTabEN._CurrTabName);
List<clsvViewTypeCodeTabEN> arrvViewTypeCodeTabObjLstCache = GetObjLstCache();
IEnumerable <clsvViewTypeCodeTabEN> arrvViewTypeCodeTabObjLst_Sel =
from objvViewTypeCodeTabEN in arrvViewTypeCodeTabObjLstCache
where arrViewTypeCode.Contains(objvViewTypeCodeTabEN.ViewTypeCode)
select objvViewTypeCodeTabEN;
return arrvViewTypeCodeTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewTypeCodeTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvViewTypeCodeTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewTypeCodeTabEN>>(strJson);
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
public static List<clsvViewTypeCodeTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvViewTypeCodeTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewTypeCodeTabEN>>(strJson);
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
public static List<clsvViewTypeCodeTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvViewTypeCodeTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewTypeCodeTabEN>>(strJson);
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
public static List<clsvViewTypeCodeTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvViewTypeCodeTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewTypeCodeTabEN>>(strJson);
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
public static bool IsExist(int intViewTypeCode)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["intViewTypeCode"] = intViewTypeCode.ToString()
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
 /// <param name = "objvViewTypeCodeTabENS">源对象</param>
 /// <param name = "objvViewTypeCodeTabENT">目标对象</param>
 public static void CopyTo(clsvViewTypeCodeTabEN objvViewTypeCodeTabENS, clsvViewTypeCodeTabEN objvViewTypeCodeTabENT)
{
try
{
objvViewTypeCodeTabENT.ViewTypeCode = objvViewTypeCodeTabENS.ViewTypeCode; //界面类型码
objvViewTypeCodeTabENT.ViewTypeName = objvViewTypeCodeTabENS.ViewTypeName; //界面类型名称
objvViewTypeCodeTabENT.ViewTypeENName = objvViewTypeCodeTabENS.ViewTypeENName; //ViewTypeENName
objvViewTypeCodeTabENT.IsWinApp = objvViewTypeCodeTabENS.IsWinApp; //IsWinApp
objvViewTypeCodeTabENT.IsMobileApp = objvViewTypeCodeTabENS.IsMobileApp; //是否移动终端应用
objvViewTypeCodeTabENT.IsWebApp = objvViewTypeCodeTabENS.IsWebApp; //IsWebApp
objvViewTypeCodeTabENT.ViewFunction = objvViewTypeCodeTabENS.ViewFunction; //界面功能
objvViewTypeCodeTabENT.OptProcess = objvViewTypeCodeTabENS.OptProcess; //操作流程
objvViewTypeCodeTabENT.ViewDetail = objvViewTypeCodeTabENS.ViewDetail; //界面说明
objvViewTypeCodeTabENT.ApplicationTypeId = objvViewTypeCodeTabENS.ApplicationTypeId; //应用程序类型ID
objvViewTypeCodeTabENT.ApplicationTypeName = objvViewTypeCodeTabENS.ApplicationTypeName; //应用程序类型名称
objvViewTypeCodeTabENT.IsHaveAdd = objvViewTypeCodeTabENS.IsHaveAdd; //是否有添加
objvViewTypeCodeTabENT.IsHaveUpdate = objvViewTypeCodeTabENS.IsHaveUpdate; //是否有修改
objvViewTypeCodeTabENT.IsHaveDel = objvViewTypeCodeTabENS.IsHaveDel; //是否有删除
objvViewTypeCodeTabENT.IsHaveQuery = objvViewTypeCodeTabENS.IsHaveQuery; //是否有查询
objvViewTypeCodeTabENT.IsHaveExcelExport = objvViewTypeCodeTabENS.IsHaveExcelExport; //是否EXCEL导出
objvViewTypeCodeTabENT.IsHaveSetExportExcel = objvViewTypeCodeTabENS.IsHaveSetExportExcel; //是否有设置EXCEL导出
objvViewTypeCodeTabENT.IsHaveDetail = objvViewTypeCodeTabENS.IsHaveDetail; //是否有详细
objvViewTypeCodeTabENT.IsHaveExeAdd = objvViewTypeCodeTabENS.IsHaveExeAdd; //是否有调用添加
objvViewTypeCodeTabENT.IsHaveExeUpdate = objvViewTypeCodeTabENS.IsHaveExeUpdate; //是否有调用修改
objvViewTypeCodeTabENT.IsHaveMainView = objvViewTypeCodeTabENS.IsHaveMainView; //是否有主界面
objvViewTypeCodeTabENT.IsHaveSubView = objvViewTypeCodeTabENS.IsHaveSubView; //是否有子界面
objvViewTypeCodeTabENT.OrderNum = objvViewTypeCodeTabENS.OrderNum; //序号
objvViewTypeCodeTabENT.IsUsed = objvViewTypeCodeTabENS.IsUsed; //IsUsed
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
public static DataTable ToDataTable(List<clsvViewTypeCodeTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvViewTypeCodeTabEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvViewTypeCodeTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvViewTypeCodeTabEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvViewTypeCodeTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvViewTypeCodeTabEN._AttributeName)
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
public static void ReFreshThisCache()
{

string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvViewTypeCodeTabEN._CurrTabName);
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
public static List<clsvViewTypeCodeTabEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvViewTypeCodeTabEN._CurrTabName;
List<clsvViewTypeCodeTabEN> arrvViewTypeCodeTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvViewTypeCodeTabObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvViewTypeCodeTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convViewTypeCodeTab.ViewTypeCode, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewTypeCodeTab.ViewTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewTypeCodeTab.ViewTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convViewTypeCodeTab.IsWinApp, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewTypeCodeTab.IsMobileApp, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewTypeCodeTab.IsWebApp, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewTypeCodeTab.ViewFunction, Type.GetType("System.String"));
objDT.Columns.Add(convViewTypeCodeTab.OptProcess, Type.GetType("System.String"));
objDT.Columns.Add(convViewTypeCodeTab.ViewDetail, Type.GetType("System.String"));
objDT.Columns.Add(convViewTypeCodeTab.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewTypeCodeTab.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewTypeCodeTab.IsHaveAdd, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewTypeCodeTab.IsHaveUpdate, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewTypeCodeTab.IsHaveDel, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewTypeCodeTab.IsHaveQuery, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewTypeCodeTab.IsHaveExcelExport, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewTypeCodeTab.IsHaveSetExportExcel, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewTypeCodeTab.IsHaveDetail, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewTypeCodeTab.IsHaveExeAdd, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewTypeCodeTab.IsHaveExeUpdate, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewTypeCodeTab.IsHaveMainView, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewTypeCodeTab.IsHaveSubView, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewTypeCodeTab.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewTypeCodeTab.IsUsed, Type.GetType("System.Boolean"));
foreach (clsvViewTypeCodeTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convViewTypeCodeTab.ViewTypeCode] = objInFor[convViewTypeCodeTab.ViewTypeCode];
objDR[convViewTypeCodeTab.ViewTypeName] = objInFor[convViewTypeCodeTab.ViewTypeName];
objDR[convViewTypeCodeTab.ViewTypeENName] = objInFor[convViewTypeCodeTab.ViewTypeENName];
objDR[convViewTypeCodeTab.IsWinApp] = objInFor[convViewTypeCodeTab.IsWinApp];
objDR[convViewTypeCodeTab.IsMobileApp] = objInFor[convViewTypeCodeTab.IsMobileApp];
objDR[convViewTypeCodeTab.IsWebApp] = objInFor[convViewTypeCodeTab.IsWebApp];
objDR[convViewTypeCodeTab.ViewFunction] = objInFor[convViewTypeCodeTab.ViewFunction];
objDR[convViewTypeCodeTab.OptProcess] = objInFor[convViewTypeCodeTab.OptProcess];
objDR[convViewTypeCodeTab.ViewDetail] = objInFor[convViewTypeCodeTab.ViewDetail];
objDR[convViewTypeCodeTab.ApplicationTypeId] = objInFor[convViewTypeCodeTab.ApplicationTypeId];
objDR[convViewTypeCodeTab.ApplicationTypeName] = objInFor[convViewTypeCodeTab.ApplicationTypeName];
objDR[convViewTypeCodeTab.IsHaveAdd] = objInFor[convViewTypeCodeTab.IsHaveAdd];
objDR[convViewTypeCodeTab.IsHaveUpdate] = objInFor[convViewTypeCodeTab.IsHaveUpdate];
objDR[convViewTypeCodeTab.IsHaveDel] = objInFor[convViewTypeCodeTab.IsHaveDel];
objDR[convViewTypeCodeTab.IsHaveQuery] = objInFor[convViewTypeCodeTab.IsHaveQuery];
objDR[convViewTypeCodeTab.IsHaveExcelExport] = objInFor[convViewTypeCodeTab.IsHaveExcelExport];
objDR[convViewTypeCodeTab.IsHaveSetExportExcel] = objInFor[convViewTypeCodeTab.IsHaveSetExportExcel];
objDR[convViewTypeCodeTab.IsHaveDetail] = objInFor[convViewTypeCodeTab.IsHaveDetail];
objDR[convViewTypeCodeTab.IsHaveExeAdd] = objInFor[convViewTypeCodeTab.IsHaveExeAdd];
objDR[convViewTypeCodeTab.IsHaveExeUpdate] = objInFor[convViewTypeCodeTab.IsHaveExeUpdate];
objDR[convViewTypeCodeTab.IsHaveMainView] = objInFor[convViewTypeCodeTab.IsHaveMainView];
objDR[convViewTypeCodeTab.IsHaveSubView] = objInFor[convViewTypeCodeTab.IsHaveSubView];
objDR[convViewTypeCodeTab.OrderNum] = objInFor[convViewTypeCodeTab.OrderNum];
objDR[convViewTypeCodeTab.IsUsed] = objInFor[convViewTypeCodeTab.IsUsed];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}