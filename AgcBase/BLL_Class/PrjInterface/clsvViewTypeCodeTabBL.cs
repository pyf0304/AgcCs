
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewTypeCodeTabBL
 表名:vViewTypeCodeTab(00050133)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:46:57
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
public static class  clsvViewTypeCodeTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "intViewTypeCode">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewTypeCodeTabEN GetObj(this K_ViewTypeCode_vViewTypeCodeTab myKey)
{
clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = clsvViewTypeCodeTabBL.vViewTypeCodeTabDA.GetObjByViewTypeCode(myKey.Value);
return objvViewTypeCodeTabEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetViewTypeName(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, string strViewTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewTypeName, convViewTypeCodeTab.ViewTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewTypeName, 40, convViewTypeCodeTab.ViewTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetViewTypeENName(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, string strViewTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewTypeENName, 40, convViewTypeCodeTab.ViewTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetViewFunction(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, string strViewFunction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewFunction, 100, convViewTypeCodeTab.ViewFunction);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetOptProcess(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, string strOptProcess, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptProcess, 1000, convViewTypeCodeTab.OptProcess);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetViewDetail(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, string strViewDetail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewDetail, 1000, convViewTypeCodeTab.ViewDetail);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetApplicationTypeName(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, convViewTypeCodeTab.ApplicationTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convViewTypeCodeTab.ApplicationTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewTypeCodeTabEN SetOrderNum(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN, int? intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要设置字段值的实体对象</param>
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabENS">源对象</param>
 /// <param name = "objvViewTypeCodeTabENT">目标对象</param>
 public static void CopyTo(this clsvViewTypeCodeTabEN objvViewTypeCodeTabENS, clsvViewTypeCodeTabEN objvViewTypeCodeTabENT)
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
 /// <param name = "objvViewTypeCodeTabENS">源对象</param>
 /// <returns>目标对象=>clsvViewTypeCodeTabEN:objvViewTypeCodeTabENT</returns>
 public static clsvViewTypeCodeTabEN CopyTo(this clsvViewTypeCodeTabEN objvViewTypeCodeTabENS)
{
try
{
 clsvViewTypeCodeTabEN objvViewTypeCodeTabENT = new clsvViewTypeCodeTabEN()
{
ViewTypeCode = objvViewTypeCodeTabENS.ViewTypeCode, //界面类型码
ViewTypeName = objvViewTypeCodeTabENS.ViewTypeName, //界面类型名称
ViewTypeENName = objvViewTypeCodeTabENS.ViewTypeENName, //ViewTypeENName
IsWinApp = objvViewTypeCodeTabENS.IsWinApp, //IsWinApp
IsMobileApp = objvViewTypeCodeTabENS.IsMobileApp, //是否移动终端应用
IsWebApp = objvViewTypeCodeTabENS.IsWebApp, //IsWebApp
ViewFunction = objvViewTypeCodeTabENS.ViewFunction, //界面功能
OptProcess = objvViewTypeCodeTabENS.OptProcess, //操作流程
ViewDetail = objvViewTypeCodeTabENS.ViewDetail, //界面说明
ApplicationTypeId = objvViewTypeCodeTabENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeName = objvViewTypeCodeTabENS.ApplicationTypeName, //应用程序类型名称
IsHaveAdd = objvViewTypeCodeTabENS.IsHaveAdd, //是否有添加
IsHaveUpdate = objvViewTypeCodeTabENS.IsHaveUpdate, //是否有修改
IsHaveDel = objvViewTypeCodeTabENS.IsHaveDel, //是否有删除
IsHaveQuery = objvViewTypeCodeTabENS.IsHaveQuery, //是否有查询
IsHaveExcelExport = objvViewTypeCodeTabENS.IsHaveExcelExport, //是否EXCEL导出
IsHaveSetExportExcel = objvViewTypeCodeTabENS.IsHaveSetExportExcel, //是否有设置EXCEL导出
IsHaveDetail = objvViewTypeCodeTabENS.IsHaveDetail, //是否有详细
IsHaveExeAdd = objvViewTypeCodeTabENS.IsHaveExeAdd, //是否有调用添加
IsHaveExeUpdate = objvViewTypeCodeTabENS.IsHaveExeUpdate, //是否有调用修改
IsHaveMainView = objvViewTypeCodeTabENS.IsHaveMainView, //是否有主界面
IsHaveSubView = objvViewTypeCodeTabENS.IsHaveSubView, //是否有子界面
OrderNum = objvViewTypeCodeTabENS.OrderNum, //序号
IsUsed = objvViewTypeCodeTabENS.IsUsed, //IsUsed
};
 return objvViewTypeCodeTabENT;
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
public static void CheckProperty4Condition(this clsvViewTypeCodeTabEN objvViewTypeCodeTabEN)
{
 clsvViewTypeCodeTabBL.vViewTypeCodeTabDA.CheckProperty4Condition(objvViewTypeCodeTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vViewTypeCodeTab
{
public virtual bool UpdRelaTabDate(int intViewTypeCode, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v界面类型码(vViewTypeCodeTab)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvViewTypeCodeTabBL
{
public static RelatedActions_vViewTypeCodeTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvViewTypeCodeTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvViewTypeCodeTabDA vViewTypeCodeTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvViewTypeCodeTabDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvViewTypeCodeTabBL()
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
if (string.IsNullOrEmpty(clsvViewTypeCodeTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewTypeCodeTabEN._ConnectString);
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
public static DataTable GetDataTable_vViewTypeCodeTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewTypeCodeTabDA.GetDataTable_vViewTypeCodeTab(strWhereCond);
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
objDT = vViewTypeCodeTabDA.GetDataTable(strWhereCond);
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
objDT = vViewTypeCodeTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vViewTypeCodeTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vViewTypeCodeTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vViewTypeCodeTabDA.GetDataTable_Top(objTopPara);
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
objDT = vViewTypeCodeTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vViewTypeCodeTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vViewTypeCodeTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewTypeCodeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvViewTypeCodeTabEN> GetObjLstByViewTypeCodeLst(List<int> arrViewTypeCodeLst)
{
List<clsvViewTypeCodeTabEN> arrObjLst = new List<clsvViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewTypeCodeLst);
 string strWhereCond = string.Format("ViewTypeCode in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
try
{
objvViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewTypeCodeTabEN.ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewTypeCodeTabEN.ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objvViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objvViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objvViewTypeCodeTabEN.ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objvViewTypeCodeTabEN.OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objvViewTypeCodeTabEN.ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objvViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewTypeCodeTabEN.ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objvViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objvViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objvViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objvViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objvViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objvViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objvViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objvViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objvViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objvViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objvViewTypeCodeTabEN.OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objvViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewTypeCodeTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewTypeCodeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvViewTypeCodeTabEN> GetObjLstByViewTypeCodeLstCache(List<int> arrViewTypeCodeLst)
{
string strKey = string.Format("{0}", clsvViewTypeCodeTabEN._CurrTabName);
List<clsvViewTypeCodeTabEN> arrvViewTypeCodeTabObjLstCache = GetObjLstCache();
IEnumerable <clsvViewTypeCodeTabEN> arrvViewTypeCodeTabObjLst_Sel =
arrvViewTypeCodeTabObjLstCache
.Where(x => arrViewTypeCodeLst.Contains(x.ViewTypeCode));
return arrvViewTypeCodeTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewTypeCodeTabEN> GetObjLst(string strWhereCond)
{
List<clsvViewTypeCodeTabEN> arrObjLst = new List<clsvViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
try
{
objvViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewTypeCodeTabEN.ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewTypeCodeTabEN.ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objvViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objvViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objvViewTypeCodeTabEN.ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objvViewTypeCodeTabEN.OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objvViewTypeCodeTabEN.ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objvViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewTypeCodeTabEN.ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objvViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objvViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objvViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objvViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objvViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objvViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objvViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objvViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objvViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objvViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objvViewTypeCodeTabEN.OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objvViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewTypeCodeTabEN);
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
public static List<clsvViewTypeCodeTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewTypeCodeTabEN> arrObjLst = new List<clsvViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
try
{
objvViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewTypeCodeTabEN.ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewTypeCodeTabEN.ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objvViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objvViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objvViewTypeCodeTabEN.ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objvViewTypeCodeTabEN.OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objvViewTypeCodeTabEN.ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objvViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewTypeCodeTabEN.ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objvViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objvViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objvViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objvViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objvViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objvViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objvViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objvViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objvViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objvViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objvViewTypeCodeTabEN.OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objvViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewTypeCodeTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvViewTypeCodeTabEN> GetSubObjLstCache(clsvViewTypeCodeTabEN objvViewTypeCodeTabCond)
{
List<clsvViewTypeCodeTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvViewTypeCodeTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewTypeCodeTab._AttributeName)
{
if (objvViewTypeCodeTabCond.IsUpdated(strFldName) == false) continue;
if (objvViewTypeCodeTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewTypeCodeTabCond[strFldName].ToString());
}
else
{
if (objvViewTypeCodeTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewTypeCodeTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewTypeCodeTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewTypeCodeTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewTypeCodeTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewTypeCodeTabCond[strFldName]));
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
public static List<clsvViewTypeCodeTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvViewTypeCodeTabEN> arrObjLst = new List<clsvViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
try
{
objvViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewTypeCodeTabEN.ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewTypeCodeTabEN.ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objvViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objvViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objvViewTypeCodeTabEN.ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objvViewTypeCodeTabEN.OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objvViewTypeCodeTabEN.ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objvViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewTypeCodeTabEN.ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objvViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objvViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objvViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objvViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objvViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objvViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objvViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objvViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objvViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objvViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objvViewTypeCodeTabEN.OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objvViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewTypeCodeTabEN);
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
public static List<clsvViewTypeCodeTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvViewTypeCodeTabEN> arrObjLst = new List<clsvViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
try
{
objvViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewTypeCodeTabEN.ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewTypeCodeTabEN.ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objvViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objvViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objvViewTypeCodeTabEN.ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objvViewTypeCodeTabEN.OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objvViewTypeCodeTabEN.ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objvViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewTypeCodeTabEN.ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objvViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objvViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objvViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objvViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objvViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objvViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objvViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objvViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objvViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objvViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objvViewTypeCodeTabEN.OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objvViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewTypeCodeTabEN);
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
List<clsvViewTypeCodeTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvViewTypeCodeTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewTypeCodeTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvViewTypeCodeTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvViewTypeCodeTabEN> arrObjLst = new List<clsvViewTypeCodeTabEN>(); 
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
	clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
try
{
objvViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewTypeCodeTabEN.ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewTypeCodeTabEN.ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objvViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objvViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objvViewTypeCodeTabEN.ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objvViewTypeCodeTabEN.OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objvViewTypeCodeTabEN.ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objvViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewTypeCodeTabEN.ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objvViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objvViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objvViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objvViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objvViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objvViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objvViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objvViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objvViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objvViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objvViewTypeCodeTabEN.OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objvViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewTypeCodeTabEN);
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
public static List<clsvViewTypeCodeTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvViewTypeCodeTabEN> arrObjLst = new List<clsvViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
try
{
objvViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewTypeCodeTabEN.ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewTypeCodeTabEN.ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objvViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objvViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objvViewTypeCodeTabEN.ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objvViewTypeCodeTabEN.OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objvViewTypeCodeTabEN.ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objvViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewTypeCodeTabEN.ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objvViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objvViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objvViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objvViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objvViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objvViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objvViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objvViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objvViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objvViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objvViewTypeCodeTabEN.OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objvViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewTypeCodeTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewTypeCodeTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvViewTypeCodeTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvViewTypeCodeTabEN> arrObjLst = new List<clsvViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
try
{
objvViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewTypeCodeTabEN.ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewTypeCodeTabEN.ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objvViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objvViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objvViewTypeCodeTabEN.ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objvViewTypeCodeTabEN.OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objvViewTypeCodeTabEN.ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objvViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewTypeCodeTabEN.ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objvViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objvViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objvViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objvViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objvViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objvViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objvViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objvViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objvViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objvViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objvViewTypeCodeTabEN.OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objvViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewTypeCodeTabEN);
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
public static List<clsvViewTypeCodeTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvViewTypeCodeTabEN> arrObjLst = new List<clsvViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
try
{
objvViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewTypeCodeTabEN.ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewTypeCodeTabEN.ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objvViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objvViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objvViewTypeCodeTabEN.ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objvViewTypeCodeTabEN.OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objvViewTypeCodeTabEN.ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objvViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewTypeCodeTabEN.ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objvViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objvViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objvViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objvViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objvViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objvViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objvViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objvViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objvViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objvViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objvViewTypeCodeTabEN.OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objvViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewTypeCodeTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewTypeCodeTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvViewTypeCodeTabEN> arrObjLst = new List<clsvViewTypeCodeTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
try
{
objvViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewTypeCodeTabEN.ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewTypeCodeTabEN.ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objvViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objvViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objvViewTypeCodeTabEN.ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objvViewTypeCodeTabEN.OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objvViewTypeCodeTabEN.ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objvViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewTypeCodeTabEN.ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objvViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objvViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objvViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objvViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objvViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objvViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objvViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objvViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objvViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objvViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objvViewTypeCodeTabEN.OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objvViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewTypeCodeTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvViewTypeCodeTab(ref clsvViewTypeCodeTabEN objvViewTypeCodeTabEN)
{
bool bolResult = vViewTypeCodeTabDA.GetvViewTypeCodeTab(ref objvViewTypeCodeTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "intViewTypeCode">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewTypeCodeTabEN GetObjByViewTypeCode(int intViewTypeCode)
{
clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = vViewTypeCodeTabDA.GetObjByViewTypeCode(intViewTypeCode);
return objvViewTypeCodeTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvViewTypeCodeTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = vViewTypeCodeTabDA.GetFirstObj(strWhereCond);
 return objvViewTypeCodeTabEN;
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
public static clsvViewTypeCodeTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = vViewTypeCodeTabDA.GetObjByDataRow(objRow);
 return objvViewTypeCodeTabEN;
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
public static clsvViewTypeCodeTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = vViewTypeCodeTabDA.GetObjByDataRow(objRow);
 return objvViewTypeCodeTabEN;
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
 /// <param name = "intViewTypeCode">所给的关键字</param>
 /// <param name = "lstvViewTypeCodeTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewTypeCodeTabEN GetObjByViewTypeCodeFromList(int intViewTypeCode, List<clsvViewTypeCodeTabEN> lstvViewTypeCodeTabObjLst)
{
foreach (clsvViewTypeCodeTabEN objvViewTypeCodeTabEN in lstvViewTypeCodeTabObjLst)
{
if (objvViewTypeCodeTabEN.ViewTypeCode == intViewTypeCode)
{
return objvViewTypeCodeTabEN;
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
public static int GetFirstID_S(string strWhereCond) 
{
 int intViewTypeCode;
 try
 {
 intViewTypeCode = new clsvViewTypeCodeTabDA().GetFirstID(strWhereCond);
 return intViewTypeCode;
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
 arrList = vViewTypeCodeTabDA.GetID(strWhereCond);
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
bool bolIsExist = vViewTypeCodeTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "intViewTypeCode">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(int intViewTypeCode)
{
//检测记录是否存在
bool bolIsExist = vViewTypeCodeTabDA.IsExist(intViewTypeCode);
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
 bolIsExist = clsvViewTypeCodeTabDA.IsExistTable();
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
 bolIsExist = vViewTypeCodeTabDA.IsExistTable(strTabName);
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
 /// <param name = "objvViewTypeCodeTabEN">源简化对象</param>
 public static void SetUpdFlag(clsvViewTypeCodeTabEN objvViewTypeCodeTabEN)
{
try
{
objvViewTypeCodeTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvViewTypeCodeTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convViewTypeCodeTab.ViewTypeCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.ViewTypeCode = objvViewTypeCodeTabEN.ViewTypeCode; //界面类型码
}
if (arrFldSet.Contains(convViewTypeCodeTab.ViewTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.ViewTypeName = objvViewTypeCodeTabEN.ViewTypeName; //界面类型名称
}
if (arrFldSet.Contains(convViewTypeCodeTab.ViewTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.ViewTypeENName = objvViewTypeCodeTabEN.ViewTypeENName == "[null]" ? null :  objvViewTypeCodeTabEN.ViewTypeENName; //ViewTypeENName
}
if (arrFldSet.Contains(convViewTypeCodeTab.IsWinApp, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.IsWinApp = objvViewTypeCodeTabEN.IsWinApp; //IsWinApp
}
if (arrFldSet.Contains(convViewTypeCodeTab.IsMobileApp, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.IsMobileApp = objvViewTypeCodeTabEN.IsMobileApp; //是否移动终端应用
}
if (arrFldSet.Contains(convViewTypeCodeTab.IsWebApp, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.IsWebApp = objvViewTypeCodeTabEN.IsWebApp; //IsWebApp
}
if (arrFldSet.Contains(convViewTypeCodeTab.ViewFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.ViewFunction = objvViewTypeCodeTabEN.ViewFunction == "[null]" ? null :  objvViewTypeCodeTabEN.ViewFunction; //界面功能
}
if (arrFldSet.Contains(convViewTypeCodeTab.OptProcess, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.OptProcess = objvViewTypeCodeTabEN.OptProcess == "[null]" ? null :  objvViewTypeCodeTabEN.OptProcess; //操作流程
}
if (arrFldSet.Contains(convViewTypeCodeTab.ViewDetail, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.ViewDetail = objvViewTypeCodeTabEN.ViewDetail == "[null]" ? null :  objvViewTypeCodeTabEN.ViewDetail; //界面说明
}
if (arrFldSet.Contains(convViewTypeCodeTab.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.ApplicationTypeId = objvViewTypeCodeTabEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convViewTypeCodeTab.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.ApplicationTypeName = objvViewTypeCodeTabEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(convViewTypeCodeTab.IsHaveAdd, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.IsHaveAdd = objvViewTypeCodeTabEN.IsHaveAdd; //是否有添加
}
if (arrFldSet.Contains(convViewTypeCodeTab.IsHaveUpdate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.IsHaveUpdate = objvViewTypeCodeTabEN.IsHaveUpdate; //是否有修改
}
if (arrFldSet.Contains(convViewTypeCodeTab.IsHaveDel, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.IsHaveDel = objvViewTypeCodeTabEN.IsHaveDel; //是否有删除
}
if (arrFldSet.Contains(convViewTypeCodeTab.IsHaveQuery, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.IsHaveQuery = objvViewTypeCodeTabEN.IsHaveQuery; //是否有查询
}
if (arrFldSet.Contains(convViewTypeCodeTab.IsHaveExcelExport, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.IsHaveExcelExport = objvViewTypeCodeTabEN.IsHaveExcelExport; //是否EXCEL导出
}
if (arrFldSet.Contains(convViewTypeCodeTab.IsHaveSetExportExcel, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.IsHaveSetExportExcel = objvViewTypeCodeTabEN.IsHaveSetExportExcel; //是否有设置EXCEL导出
}
if (arrFldSet.Contains(convViewTypeCodeTab.IsHaveDetail, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.IsHaveDetail = objvViewTypeCodeTabEN.IsHaveDetail; //是否有详细
}
if (arrFldSet.Contains(convViewTypeCodeTab.IsHaveExeAdd, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.IsHaveExeAdd = objvViewTypeCodeTabEN.IsHaveExeAdd; //是否有调用添加
}
if (arrFldSet.Contains(convViewTypeCodeTab.IsHaveExeUpdate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.IsHaveExeUpdate = objvViewTypeCodeTabEN.IsHaveExeUpdate; //是否有调用修改
}
if (arrFldSet.Contains(convViewTypeCodeTab.IsHaveMainView, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.IsHaveMainView = objvViewTypeCodeTabEN.IsHaveMainView; //是否有主界面
}
if (arrFldSet.Contains(convViewTypeCodeTab.IsHaveSubView, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.IsHaveSubView = objvViewTypeCodeTabEN.IsHaveSubView; //是否有子界面
}
if (arrFldSet.Contains(convViewTypeCodeTab.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.OrderNum = objvViewTypeCodeTabEN.OrderNum; //序号
}
if (arrFldSet.Contains(convViewTypeCodeTab.IsUsed, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewTypeCodeTabEN.IsUsed = objvViewTypeCodeTabEN.IsUsed; //IsUsed
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
 /// <param name = "objvViewTypeCodeTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsvViewTypeCodeTabEN objvViewTypeCodeTabEN)
{
try
{
if (objvViewTypeCodeTabEN.ViewTypeENName == "[null]") objvViewTypeCodeTabEN.ViewTypeENName = null; //ViewTypeENName
if (objvViewTypeCodeTabEN.ViewFunction == "[null]") objvViewTypeCodeTabEN.ViewFunction = null; //界面功能
if (objvViewTypeCodeTabEN.OptProcess == "[null]") objvViewTypeCodeTabEN.OptProcess = null; //操作流程
if (objvViewTypeCodeTabEN.ViewDetail == "[null]") objvViewTypeCodeTabEN.ViewDetail = null; //界面说明
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
public static void CheckProperty4Condition(clsvViewTypeCodeTabEN objvViewTypeCodeTabEN)
{
 vViewTypeCodeTabDA.CheckProperty4Condition(objvViewTypeCodeTabEN);
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewTypeCode");
//if (arrvViewTypeCodeTabObjLstCache == null)
//{
//arrvViewTypeCodeTabObjLstCache = vViewTypeCodeTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "intViewTypeCode">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewTypeCodeTabEN GetObjByViewTypeCodeCache(int intViewTypeCode)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvViewTypeCodeTabEN._CurrTabName);
List<clsvViewTypeCodeTabEN> arrvViewTypeCodeTabObjLstCache = GetObjLstCache();
IEnumerable <clsvViewTypeCodeTabEN> arrvViewTypeCodeTabObjLst_Sel =
arrvViewTypeCodeTabObjLstCache
.Where(x=> x.ViewTypeCode == intViewTypeCode 
);
if (arrvViewTypeCodeTabObjLst_Sel.Count() == 0)
{
   clsvViewTypeCodeTabEN obj = clsvViewTypeCodeTabBL.GetObjByViewTypeCode(intViewTypeCode);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvViewTypeCodeTabObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewTypeCodeTabEN> GetAllvViewTypeCodeTabObjLstCache()
{
//获取缓存中的对象列表
List<clsvViewTypeCodeTabEN> arrvViewTypeCodeTabObjLstCache = GetObjLstCache(); 
return arrvViewTypeCodeTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewTypeCodeTabEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvViewTypeCodeTabEN._CurrTabName);
List<clsvViewTypeCodeTabEN> arrvViewTypeCodeTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvViewTypeCodeTabObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvViewTypeCodeTabEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvViewTypeCodeTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvViewTypeCodeTabEN._RefreshTimeLst.Count == 0) return "";
return clsvViewTypeCodeTabEN._RefreshTimeLst[clsvViewTypeCodeTabEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, int intViewTypeCode)
{
if (strInFldName != convViewTypeCodeTab.ViewTypeCode)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convViewTypeCodeTab._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convViewTypeCodeTab._AttributeName));
throw new Exception(strMsg);
}
var objvViewTypeCodeTab = clsvViewTypeCodeTabBL.GetObjByViewTypeCodeCache(intViewTypeCode);
if (objvViewTypeCodeTab == null) return "";
return objvViewTypeCodeTab[strOutFldName].ToString();
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
int intRecCount = clsvViewTypeCodeTabDA.GetRecCount(strTabName);
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
int intRecCount = clsvViewTypeCodeTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvViewTypeCodeTabDA.GetRecCount();
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
int intRecCount = clsvViewTypeCodeTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvViewTypeCodeTabEN objvViewTypeCodeTabCond)
{
List<clsvViewTypeCodeTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvViewTypeCodeTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewTypeCodeTab._AttributeName)
{
if (objvViewTypeCodeTabCond.IsUpdated(strFldName) == false) continue;
if (objvViewTypeCodeTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewTypeCodeTabCond[strFldName].ToString());
}
else
{
if (objvViewTypeCodeTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewTypeCodeTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewTypeCodeTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewTypeCodeTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewTypeCodeTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewTypeCodeTabCond[strFldName]));
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
 List<string> arrList = clsvViewTypeCodeTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vViewTypeCodeTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vViewTypeCodeTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}