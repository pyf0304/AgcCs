
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewTypeCodeTabWApi
 表名:ViewTypeCodeTab(00050104)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:34
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
public static class  clsViewTypeCodeTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intViewTypeCode">界面类型码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetViewTypeCode(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, int intViewTypeCode, string strComparisonOp="")
	{
objViewTypeCodeTabEN.ViewTypeCode = intViewTypeCode; //界面类型码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.ViewTypeCode) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.ViewTypeCode, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.ViewTypeCode] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewTypeName">界面类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetViewTypeName(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strViewTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewTypeName, conViewTypeCodeTab.ViewTypeName);
clsCheckSql.CheckFieldLen(strViewTypeName, 40, conViewTypeCodeTab.ViewTypeName);
objViewTypeCodeTabEN.ViewTypeName = strViewTypeName; //界面类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.ViewTypeName) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.ViewTypeName, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.ViewTypeName] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewTypeENName">ViewTypeENName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetViewTypeENName(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strViewTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewTypeENName, 40, conViewTypeCodeTab.ViewTypeENName);
objViewTypeCodeTabEN.ViewTypeENName = strViewTypeENName; //ViewTypeENName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.ViewTypeENName) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.ViewTypeENName, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.ViewTypeENName] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsWinApp">IsWinApp</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsWinApp(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsWinApp, string strComparisonOp="")
	{
objViewTypeCodeTabEN.IsWinApp = bolIsWinApp; //IsWinApp
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsWinApp) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsWinApp, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsWinApp] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsMobileApp">是否移动终端应用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsMobileApp(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsMobileApp, string strComparisonOp="")
	{
objViewTypeCodeTabEN.IsMobileApp = bolIsMobileApp; //是否移动终端应用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsMobileApp) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsMobileApp, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsMobileApp] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsWebApp">IsWebApp</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsWebApp(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsWebApp, string strComparisonOp="")
	{
objViewTypeCodeTabEN.IsWebApp = bolIsWebApp; //IsWebApp
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsWebApp) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsWebApp, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsWebApp] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewFunction">界面功能</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetViewFunction(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strViewFunction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewFunction, 100, conViewTypeCodeTab.ViewFunction);
objViewTypeCodeTabEN.ViewFunction = strViewFunction; //界面功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.ViewFunction) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.ViewFunction, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.ViewFunction] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strOptProcess">操作流程</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetOptProcess(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strOptProcess, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptProcess, 1000, conViewTypeCodeTab.OptProcess);
objViewTypeCodeTabEN.OptProcess = strOptProcess; //操作流程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.OptProcess) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.OptProcess, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.OptProcess] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewDetail">界面说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetViewDetail(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strViewDetail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewDetail, 1000, conViewTypeCodeTab.ViewDetail);
objViewTypeCodeTabEN.ViewDetail = strViewDetail; //界面说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.ViewDetail) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.ViewDetail, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.ViewDetail] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetApplicationTypeId(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conViewTypeCodeTab.ApplicationTypeId);
objViewTypeCodeTabEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.ApplicationTypeId) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.ApplicationTypeId, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.ApplicationTypeId] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveAdd">是否有添加</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveAdd(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveAdd, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveAdd, conViewTypeCodeTab.IsHaveAdd);
objViewTypeCodeTabEN.IsHaveAdd = bolIsHaveAdd; //是否有添加
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveAdd) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveAdd, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveAdd] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveUpdate">是否有修改</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveUpdate(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveUpdate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveUpdate, conViewTypeCodeTab.IsHaveUpdate);
objViewTypeCodeTabEN.IsHaveUpdate = bolIsHaveUpdate; //是否有修改
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveUpdate) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveUpdate, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveUpdate] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveDel">是否有删除</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveDel(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveDel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveDel, conViewTypeCodeTab.IsHaveDel);
objViewTypeCodeTabEN.IsHaveDel = bolIsHaveDel; //是否有删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveDel) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveDel, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveDel] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveQuery">是否有查询</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveQuery(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveQuery, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveQuery, conViewTypeCodeTab.IsHaveQuery);
objViewTypeCodeTabEN.IsHaveQuery = bolIsHaveQuery; //是否有查询
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveQuery) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveQuery, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveQuery] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveExcelExport">是否EXCEL导出</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveExcelExport(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveExcelExport, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveExcelExport, conViewTypeCodeTab.IsHaveExcelExport);
objViewTypeCodeTabEN.IsHaveExcelExport = bolIsHaveExcelExport; //是否EXCEL导出
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveExcelExport) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveExcelExport, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveExcelExport] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveSetExportExcel">是否有设置EXCEL导出</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveSetExportExcel(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveSetExportExcel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveSetExportExcel, conViewTypeCodeTab.IsHaveSetExportExcel);
objViewTypeCodeTabEN.IsHaveSetExportExcel = bolIsHaveSetExportExcel; //是否有设置EXCEL导出
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveSetExportExcel) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveSetExportExcel, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveSetExportExcel] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveDetail">是否有详细</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveDetail(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveDetail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveDetail, conViewTypeCodeTab.IsHaveDetail);
objViewTypeCodeTabEN.IsHaveDetail = bolIsHaveDetail; //是否有详细
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveDetail) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveDetail, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveDetail] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveExeAdd">是否有调用添加</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveExeAdd(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveExeAdd, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveExeAdd, conViewTypeCodeTab.IsHaveExeAdd);
objViewTypeCodeTabEN.IsHaveExeAdd = bolIsHaveExeAdd; //是否有调用添加
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveExeAdd) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveExeAdd, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveExeAdd] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveExeUpdate">是否有调用修改</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveExeUpdate(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveExeUpdate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveExeUpdate, conViewTypeCodeTab.IsHaveExeUpdate);
objViewTypeCodeTabEN.IsHaveExeUpdate = bolIsHaveExeUpdate; //是否有调用修改
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveExeUpdate) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveExeUpdate, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveExeUpdate] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveMainView">是否有主界面</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveMainView(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveMainView, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveMainView, conViewTypeCodeTab.IsHaveMainView);
objViewTypeCodeTabEN.IsHaveMainView = bolIsHaveMainView; //是否有主界面
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveMainView) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveMainView, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveMainView] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveSubView">是否有子界面</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveSubView(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveSubView, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveSubView, conViewTypeCodeTab.IsHaveSubView);
objViewTypeCodeTabEN.IsHaveSubView = bolIsHaveSubView; //是否有子界面
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveSubView) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveSubView, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveSubView] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetOrderNum(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, int intOrderNum, string strComparisonOp="")
	{
objViewTypeCodeTabEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.OrderNum) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.OrderNum, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.OrderNum] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsUsed">IsUsed</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsUsed(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsUsed, string strComparisonOp="")
	{
objViewTypeCodeTabEN.IsUsed = bolIsUsed; //IsUsed
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsUsed) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsUsed, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsUsed] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewTypeCodeTabEN objViewTypeCodeTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.ViewTypeCode) == true)
{
string strComparisonOpViewTypeCode = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.ViewTypeCode];
strWhereCond += string.Format(" And {0} {2} {1}", conViewTypeCodeTab.ViewTypeCode, objViewTypeCodeTabCond.ViewTypeCode, strComparisonOpViewTypeCode);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.ViewTypeName) == true)
{
string strComparisonOpViewTypeName = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.ViewTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewTypeCodeTab.ViewTypeName, objViewTypeCodeTabCond.ViewTypeName, strComparisonOpViewTypeName);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.ViewTypeENName) == true)
{
string strComparisonOpViewTypeENName = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.ViewTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewTypeCodeTab.ViewTypeENName, objViewTypeCodeTabCond.ViewTypeENName, strComparisonOpViewTypeENName);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsWinApp) == true)
{
if (objViewTypeCodeTabCond.IsWinApp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsWinApp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsWinApp);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsMobileApp) == true)
{
if (objViewTypeCodeTabCond.IsMobileApp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsMobileApp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsMobileApp);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsWebApp) == true)
{
if (objViewTypeCodeTabCond.IsWebApp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsWebApp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsWebApp);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.ViewFunction) == true)
{
string strComparisonOpViewFunction = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.ViewFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewTypeCodeTab.ViewFunction, objViewTypeCodeTabCond.ViewFunction, strComparisonOpViewFunction);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.OptProcess) == true)
{
string strComparisonOpOptProcess = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.OptProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewTypeCodeTab.OptProcess, objViewTypeCodeTabCond.OptProcess, strComparisonOpOptProcess);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.ViewDetail) == true)
{
string strComparisonOpViewDetail = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.ViewDetail];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewTypeCodeTab.ViewDetail, objViewTypeCodeTabCond.ViewDetail, strComparisonOpViewDetail);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewTypeCodeTab.ApplicationTypeId, objViewTypeCodeTabCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveAdd) == true)
{
if (objViewTypeCodeTabCond.IsHaveAdd == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveAdd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveAdd);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveUpdate) == true)
{
if (objViewTypeCodeTabCond.IsHaveUpdate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveUpdate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveUpdate);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveDel) == true)
{
if (objViewTypeCodeTabCond.IsHaveDel == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveDel);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveDel);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveQuery) == true)
{
if (objViewTypeCodeTabCond.IsHaveQuery == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveQuery);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveQuery);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveExcelExport) == true)
{
if (objViewTypeCodeTabCond.IsHaveExcelExport == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveExcelExport);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveExcelExport);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveSetExportExcel) == true)
{
if (objViewTypeCodeTabCond.IsHaveSetExportExcel == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveSetExportExcel);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveSetExportExcel);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveDetail) == true)
{
if (objViewTypeCodeTabCond.IsHaveDetail == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveDetail);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveDetail);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveExeAdd) == true)
{
if (objViewTypeCodeTabCond.IsHaveExeAdd == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveExeAdd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveExeAdd);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveExeUpdate) == true)
{
if (objViewTypeCodeTabCond.IsHaveExeUpdate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveExeUpdate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveExeUpdate);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveMainView) == true)
{
if (objViewTypeCodeTabCond.IsHaveMainView == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveMainView);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveMainView);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveSubView) == true)
{
if (objViewTypeCodeTabCond.IsHaveSubView == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveSubView);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveSubView);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.OrderNum) == true)
{
string strComparisonOpOrderNum = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conViewTypeCodeTab.OrderNum, objViewTypeCodeTabCond.OrderNum, strComparisonOpOrderNum);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsUsed) == true)
{
if (objViewTypeCodeTabCond.IsUsed == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsUsed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsUsed);
}
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
 if (objViewTypeCodeTabEN.ViewTypeCode == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objViewTypeCodeTabEN.sfUpdFldSetStr = objViewTypeCodeTabEN.getsfUpdFldSetStr();
clsViewTypeCodeTabWApi.CheckPropertyNew(objViewTypeCodeTabEN); 
bool bolResult = clsViewTypeCodeTabWApi.UpdateRecord(objViewTypeCodeTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabWApi.ReFreshCache();
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
 /// 获取唯一性条件串--ViewTypeCodeTab(界面类型码), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewTypeName_ApplicationTypeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewTypeCodeTabEN == null) return "";
if (objViewTypeCodeTabEN.ViewTypeCode == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewTypeName = '{0}'", objViewTypeCodeTabEN.ViewTypeName);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewTypeCodeTabEN.ApplicationTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewTypeCode !=  {0}", objViewTypeCodeTabEN.ViewTypeCode);
 sbCondition.AppendFormat(" and ViewTypeName = '{0}'", objViewTypeCodeTabEN.ViewTypeName);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewTypeCodeTabEN.ApplicationTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
try
{
clsViewTypeCodeTabWApi.CheckPropertyNew(objViewTypeCodeTabEN); 
bool bolResult = clsViewTypeCodeTabWApi.AddNewRecord(objViewTypeCodeTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabWApi.ReFreshCache();
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
 /// <param name = "objViewTypeCodeTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strWhereCond)
{
try
{
clsViewTypeCodeTabWApi.CheckPropertyNew(objViewTypeCodeTabEN); 
bool bolResult = clsViewTypeCodeTabWApi.UpdateWithCondition(objViewTypeCodeTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabWApi.ReFreshCache();
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public enum enumViewTypeCodeTab : int
{
[Description("单表插入")]
Table_Insert_1 = 1,
[Description("单表修改")]
Table_Update_2 = 2,
[Description("单表查询")]
Table_Query_3 = 3,
[Description("单表的QUDI")]
Table_QUDI_4 = 4,
[Description("单表的查询插入")]
Table_QI_5 = 5,
[Description("单表的查询修改")]
Table_QU_6 = 6,
[Description("单表的查询删除")]
Table_QD_7 = 7,
[Description("单表插入修改")]
Table_UI_9 = 9,
[Description("单表组合界面_ListView")]
Table_QD_InvokeUI_ListView_11 = 11,
[Description("列表界面")]
Table_List_14 = 14,
[Description("详细信息界面")]
Table_Detail_17 = 17,
[Description("界面查询修改删除")]
Table_QUD_18 = 18,
[Description("单表组合界面_GridView")]
Table_QD_InvokeUI_GridView_20 = 20,
[Description("单表的QUDI4Android")]
Table_QUDI4Android_21 = 21,
[Description("单表的CRUD4Mvc")]
Table_CRUD4Mvc_22 = 22,
[Description("单表的CRUD4ISO")]
Table_CRUD4ISO_23 = 23,
[Description("单表的CRUD4Spa")]
Table_CRUD4Spa_24 = 24,
[Description("单表的CRUD4MvcAjax")]
Table_CRUD4MvcAjax_25 = 25,
[Description("单表的CRUD4Mvc_TS")]
Table_CRUD4Mvc_TS_26 = 26,
[Description("单表的CRUD4Node")]
Table_CRUD4Node_27 = 27,
[Description("单表的CRUD4Relation")]
Table_CRUD4Relation_28 = 28,
[Description("单表的CRUD4JsRj")]
Table_CRUD4JsRj_29 = 29,
[Description("单表的CRUD4Spa_UT")]
Table_CRUD4Spa_UT_30 = 30,
[Description("单表的CRUD4Vue")]
Table_CRUD4Vue_31 = 31,
}
 /// <summary>
 /// 界面类型码(ViewTypeCodeTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsViewTypeCodeTabWApi
{
private static readonly string mstrApiControllerName = "ViewTypeCodeTabApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsViewTypeCodeTabWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ViewTypeCode(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面类型码]...","0");
List<clsViewTypeCodeTabEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ViewTypeCode";
objDDL.DataTextField="ViewTypeName";
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

public static void BindCbo_ViewTypeCode(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conViewTypeCodeTab.ViewTypeCode); 
List<clsViewTypeCodeTabEN> arrObjLst = clsViewTypeCodeTabWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN()
{
ViewTypeCode = 0,
ViewTypeName = "选[界面类型码]..."
};
arrObjLst.Insert(0, objViewTypeCodeTabEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conViewTypeCodeTab.ViewTypeCode;
objComboBox.DisplayMember = conViewTypeCodeTab.ViewTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
if (!Object.Equals(null, objViewTypeCodeTabEN.ViewTypeName) && GetStrLen(objViewTypeCodeTabEN.ViewTypeName) > 40)
{
 throw new Exception("字段[界面类型名称]的长度不能超过40!");
}
if (!Object.Equals(null, objViewTypeCodeTabEN.ViewTypeENName) && GetStrLen(objViewTypeCodeTabEN.ViewTypeENName) > 40)
{
 throw new Exception("字段[ViewTypeENName]的长度不能超过40!");
}
if (!Object.Equals(null, objViewTypeCodeTabEN.ViewFunction) && GetStrLen(objViewTypeCodeTabEN.ViewFunction) > 100)
{
 throw new Exception("字段[界面功能]的长度不能超过100!");
}
if (!Object.Equals(null, objViewTypeCodeTabEN.OptProcess) && GetStrLen(objViewTypeCodeTabEN.OptProcess) > 1000)
{
 throw new Exception("字段[操作流程]的长度不能超过1000!");
}
if (!Object.Equals(null, objViewTypeCodeTabEN.ViewDetail) && GetStrLen(objViewTypeCodeTabEN.ViewDetail) > 1000)
{
 throw new Exception("字段[界面说明]的长度不能超过1000!");
}
 objViewTypeCodeTabEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "intViewTypeCode">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewTypeCodeTabEN GetObjByViewTypeCode(int intViewTypeCode)
{
if (intViewTypeCode == 0) return null;
string strAction = "GetObjByViewTypeCode";
clsViewTypeCodeTabEN objViewTypeCodeTabEN;
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
objViewTypeCodeTabEN = JsonConvert.DeserializeObject<clsViewTypeCodeTabEN>(strJson);
return objViewTypeCodeTabEN;
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
public static clsViewTypeCodeTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsViewTypeCodeTabEN objViewTypeCodeTabEN;
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
objViewTypeCodeTabEN = JsonConvert.DeserializeObject<clsViewTypeCodeTabEN>(strJson);
return objViewTypeCodeTabEN;
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
public static clsViewTypeCodeTabEN GetObjByViewTypeCodeCache(int intViewTypeCode)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsViewTypeCodeTabEN._CurrTabName);
List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLstCache = GetObjLstCache();
IEnumerable <clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst_Sel =
from objViewTypeCodeTabEN in arrViewTypeCodeTabObjLstCache
where objViewTypeCodeTabEN.ViewTypeCode == intViewTypeCode 
select objViewTypeCodeTabEN;
if (arrViewTypeCodeTabObjLst_Sel.Count() == 0)
{
   clsViewTypeCodeTabEN obj = clsViewTypeCodeTabWApi.GetObjByViewTypeCode(intViewTypeCode);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrViewTypeCodeTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intViewTypeCode">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetViewTypeNameByViewTypeCodeCache(int intViewTypeCode)
{
//初始化列表缓存
List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLstCache = GetObjLstCache();
IEnumerable <clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst_Sel1 =
from objViewTypeCodeTabEN in arrViewTypeCodeTabObjLstCache
where objViewTypeCodeTabEN.ViewTypeCode == intViewTypeCode 
select objViewTypeCodeTabEN;
List <clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst_Sel = new List<clsViewTypeCodeTabEN>();
foreach (clsViewTypeCodeTabEN obj in arrViewTypeCodeTabObjLst_Sel1)
{
arrViewTypeCodeTabObjLst_Sel.Add(obj);
}
if (arrViewTypeCodeTabObjLst_Sel.Count > 0)
{
return arrViewTypeCodeTabObjLst_Sel[0].ViewTypeName;
}
string strErrMsgForGetObjById = string.Format("在ViewTypeCodeTab对象缓存列表中,找不到记录[ViewTypeCode = {0}](函数:{1})", intViewTypeCode, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsViewTypeCodeTabBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intViewTypeCode">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByViewTypeCodeCache(int intViewTypeCode)
{
//初始化列表缓存
List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLstCache = GetObjLstCache();
IEnumerable <clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst_Sel1 =
from objViewTypeCodeTabEN in arrViewTypeCodeTabObjLstCache
where objViewTypeCodeTabEN.ViewTypeCode == intViewTypeCode 
select objViewTypeCodeTabEN;
List <clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst_Sel = new List<clsViewTypeCodeTabEN>();
foreach (clsViewTypeCodeTabEN obj in arrViewTypeCodeTabObjLst_Sel1)
{
arrViewTypeCodeTabObjLst_Sel.Add(obj);
}
if (arrViewTypeCodeTabObjLst_Sel.Count > 0)
{
return arrViewTypeCodeTabObjLst_Sel[0].ViewTypeName;
}
string strErrMsgForGetObjById = string.Format("在ViewTypeCodeTab对象缓存列表中,找不到记录的相关名称[ViewTypeCode = {0}](函数:{1})", intViewTypeCode, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsViewTypeCodeTabBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewTypeCodeTabEN> GetObjLst(string strWhereCond)
{
 List<clsViewTypeCodeTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewTypeCodeTabEN>>(strJson);
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
public static List<clsViewTypeCodeTabEN> GetObjLstByViewTypeCodeLst(List<int> arrViewTypeCode)
{
 List<clsViewTypeCodeTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewTypeCodeTabEN>>(strJson);
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
public static IEnumerable<clsViewTypeCodeTabEN> GetObjLstByViewTypeCodeLstCache(List<int> arrViewTypeCode)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsViewTypeCodeTabEN._CurrTabName);
List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLstCache = GetObjLstCache();
IEnumerable <clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst_Sel =
from objViewTypeCodeTabEN in arrViewTypeCodeTabObjLstCache
where arrViewTypeCode.Contains(objViewTypeCodeTabEN.ViewTypeCode)
select objViewTypeCodeTabEN;
return arrViewTypeCodeTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewTypeCodeTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsViewTypeCodeTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewTypeCodeTabEN>>(strJson);
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
public static List<clsViewTypeCodeTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsViewTypeCodeTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewTypeCodeTabEN>>(strJson);
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
public static List<clsViewTypeCodeTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsViewTypeCodeTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewTypeCodeTabEN>>(strJson);
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
public static List<clsViewTypeCodeTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsViewTypeCodeTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewTypeCodeTabEN>>(strJson);
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
public static int DelRecord(int intViewTypeCode)
{
string strAction = "DelRecord";
try
{
 clsViewTypeCodeTabEN objViewTypeCodeTabEN = clsViewTypeCodeTabWApi.GetObjByViewTypeCode(intViewTypeCode);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, intViewTypeCode.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsViewTypeCodeTabWApi.ReFreshCache();
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
public static int DelViewTypeCodeTabs(List<string> arrViewTypeCode)
{
string strAction = "DelViewTypeCodeTabs";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewTypeCode);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsViewTypeCodeTabWApi.ReFreshCache();
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
public static int DelViewTypeCodeTabsByCond(string strWhereCond)
{
string strAction = "DelViewTypeCodeTabsByCond";
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
public static bool AddNewRecord(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewTypeCodeTabEN>(objViewTypeCodeTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabWApi.ReFreshCache();
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
 /// <param name = "objViewTypeCodeTabEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewTypeCodeTabEN>(objViewTypeCodeTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabWApi.ReFreshCache();
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
public static bool UpdateRecord(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
if (string.IsNullOrEmpty(objViewTypeCodeTabEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewTypeCodeTabEN.ViewTypeCode, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewTypeCodeTabEN>(objViewTypeCodeTabEN);
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
 /// <param name = "objViewTypeCodeTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objViewTypeCodeTabEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewTypeCodeTabEN.ViewTypeCode, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewTypeCodeTabEN.ViewTypeCode, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewTypeCodeTabEN>(objViewTypeCodeTabEN);
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
 /// <param name = "objViewTypeCodeTabENS">源对象</param>
 /// <param name = "objViewTypeCodeTabENT">目标对象</param>
 public static void CopyTo(clsViewTypeCodeTabEN objViewTypeCodeTabENS, clsViewTypeCodeTabEN objViewTypeCodeTabENT)
{
try
{
objViewTypeCodeTabENT.ViewTypeCode = objViewTypeCodeTabENS.ViewTypeCode; //界面类型码
objViewTypeCodeTabENT.ViewTypeName = objViewTypeCodeTabENS.ViewTypeName; //界面类型名称
objViewTypeCodeTabENT.ViewTypeENName = objViewTypeCodeTabENS.ViewTypeENName; //ViewTypeENName
objViewTypeCodeTabENT.IsWinApp = objViewTypeCodeTabENS.IsWinApp; //IsWinApp
objViewTypeCodeTabENT.IsMobileApp = objViewTypeCodeTabENS.IsMobileApp; //是否移动终端应用
objViewTypeCodeTabENT.IsWebApp = objViewTypeCodeTabENS.IsWebApp; //IsWebApp
objViewTypeCodeTabENT.ViewFunction = objViewTypeCodeTabENS.ViewFunction; //界面功能
objViewTypeCodeTabENT.OptProcess = objViewTypeCodeTabENS.OptProcess; //操作流程
objViewTypeCodeTabENT.ViewDetail = objViewTypeCodeTabENS.ViewDetail; //界面说明
objViewTypeCodeTabENT.ApplicationTypeId = objViewTypeCodeTabENS.ApplicationTypeId; //应用程序类型ID
objViewTypeCodeTabENT.IsHaveAdd = objViewTypeCodeTabENS.IsHaveAdd; //是否有添加
objViewTypeCodeTabENT.IsHaveUpdate = objViewTypeCodeTabENS.IsHaveUpdate; //是否有修改
objViewTypeCodeTabENT.IsHaveDel = objViewTypeCodeTabENS.IsHaveDel; //是否有删除
objViewTypeCodeTabENT.IsHaveQuery = objViewTypeCodeTabENS.IsHaveQuery; //是否有查询
objViewTypeCodeTabENT.IsHaveExcelExport = objViewTypeCodeTabENS.IsHaveExcelExport; //是否EXCEL导出
objViewTypeCodeTabENT.IsHaveSetExportExcel = objViewTypeCodeTabENS.IsHaveSetExportExcel; //是否有设置EXCEL导出
objViewTypeCodeTabENT.IsHaveDetail = objViewTypeCodeTabENS.IsHaveDetail; //是否有详细
objViewTypeCodeTabENT.IsHaveExeAdd = objViewTypeCodeTabENS.IsHaveExeAdd; //是否有调用添加
objViewTypeCodeTabENT.IsHaveExeUpdate = objViewTypeCodeTabENS.IsHaveExeUpdate; //是否有调用修改
objViewTypeCodeTabENT.IsHaveMainView = objViewTypeCodeTabENS.IsHaveMainView; //是否有主界面
objViewTypeCodeTabENT.IsHaveSubView = objViewTypeCodeTabENS.IsHaveSubView; //是否有子界面
objViewTypeCodeTabENT.OrderNum = objViewTypeCodeTabENS.OrderNum; //序号
objViewTypeCodeTabENT.IsUsed = objViewTypeCodeTabENS.IsUsed; //IsUsed
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
public static DataTable ToDataTable(List<clsViewTypeCodeTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsViewTypeCodeTabEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsViewTypeCodeTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsViewTypeCodeTabEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsViewTypeCodeTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsViewTypeCodeTabEN._AttributeName)
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
string strKey = string.Format("{0}", clsViewTypeCodeTabEN._CurrTabName);
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
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsViewTypeCodeTabWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsViewTypeCodeTabEN._CurrTabName);
CacheHelper.Remove(strKey);
clsViewTypeCodeTabWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewTypeCodeTabEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsViewTypeCodeTabEN._CurrTabName;
List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrViewTypeCodeTabObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsViewTypeCodeTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conViewTypeCodeTab.ViewTypeCode, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewTypeCodeTab.ViewTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conViewTypeCodeTab.ViewTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(conViewTypeCodeTab.IsWinApp, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewTypeCodeTab.IsMobileApp, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewTypeCodeTab.IsWebApp, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewTypeCodeTab.ViewFunction, Type.GetType("System.String"));
objDT.Columns.Add(conViewTypeCodeTab.OptProcess, Type.GetType("System.String"));
objDT.Columns.Add(conViewTypeCodeTab.ViewDetail, Type.GetType("System.String"));
objDT.Columns.Add(conViewTypeCodeTab.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewTypeCodeTab.IsHaveAdd, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewTypeCodeTab.IsHaveUpdate, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewTypeCodeTab.IsHaveDel, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewTypeCodeTab.IsHaveQuery, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewTypeCodeTab.IsHaveExcelExport, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewTypeCodeTab.IsHaveSetExportExcel, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewTypeCodeTab.IsHaveDetail, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewTypeCodeTab.IsHaveExeAdd, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewTypeCodeTab.IsHaveExeUpdate, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewTypeCodeTab.IsHaveMainView, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewTypeCodeTab.IsHaveSubView, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewTypeCodeTab.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewTypeCodeTab.IsUsed, Type.GetType("System.Boolean"));
foreach (clsViewTypeCodeTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conViewTypeCodeTab.ViewTypeCode] = objInFor[conViewTypeCodeTab.ViewTypeCode];
objDR[conViewTypeCodeTab.ViewTypeName] = objInFor[conViewTypeCodeTab.ViewTypeName];
objDR[conViewTypeCodeTab.ViewTypeENName] = objInFor[conViewTypeCodeTab.ViewTypeENName];
objDR[conViewTypeCodeTab.IsWinApp] = objInFor[conViewTypeCodeTab.IsWinApp];
objDR[conViewTypeCodeTab.IsMobileApp] = objInFor[conViewTypeCodeTab.IsMobileApp];
objDR[conViewTypeCodeTab.IsWebApp] = objInFor[conViewTypeCodeTab.IsWebApp];
objDR[conViewTypeCodeTab.ViewFunction] = objInFor[conViewTypeCodeTab.ViewFunction];
objDR[conViewTypeCodeTab.OptProcess] = objInFor[conViewTypeCodeTab.OptProcess];
objDR[conViewTypeCodeTab.ViewDetail] = objInFor[conViewTypeCodeTab.ViewDetail];
objDR[conViewTypeCodeTab.ApplicationTypeId] = objInFor[conViewTypeCodeTab.ApplicationTypeId];
objDR[conViewTypeCodeTab.IsHaveAdd] = objInFor[conViewTypeCodeTab.IsHaveAdd];
objDR[conViewTypeCodeTab.IsHaveUpdate] = objInFor[conViewTypeCodeTab.IsHaveUpdate];
objDR[conViewTypeCodeTab.IsHaveDel] = objInFor[conViewTypeCodeTab.IsHaveDel];
objDR[conViewTypeCodeTab.IsHaveQuery] = objInFor[conViewTypeCodeTab.IsHaveQuery];
objDR[conViewTypeCodeTab.IsHaveExcelExport] = objInFor[conViewTypeCodeTab.IsHaveExcelExport];
objDR[conViewTypeCodeTab.IsHaveSetExportExcel] = objInFor[conViewTypeCodeTab.IsHaveSetExportExcel];
objDR[conViewTypeCodeTab.IsHaveDetail] = objInFor[conViewTypeCodeTab.IsHaveDetail];
objDR[conViewTypeCodeTab.IsHaveExeAdd] = objInFor[conViewTypeCodeTab.IsHaveExeAdd];
objDR[conViewTypeCodeTab.IsHaveExeUpdate] = objInFor[conViewTypeCodeTab.IsHaveExeUpdate];
objDR[conViewTypeCodeTab.IsHaveMainView] = objInFor[conViewTypeCodeTab.IsHaveMainView];
objDR[conViewTypeCodeTab.IsHaveSubView] = objInFor[conViewTypeCodeTab.IsHaveSubView];
objDR[conViewTypeCodeTab.OrderNum] = objInFor[conViewTypeCodeTab.OrderNum];
objDR[conViewTypeCodeTab.IsUsed] = objInFor[conViewTypeCodeTab.IsUsed];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 界面类型码(ViewTypeCodeTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ViewTypeCodeTab : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
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
clsViewTypeCodeTabWApi.ReFreshThisCache();
}
}

}