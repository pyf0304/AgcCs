
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewInfo4GeneCodeWApi
 表名:vViewInfo4GeneCode(00050283)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:12
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
public static class  clsvViewInfo4GeneCodeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewId">界面Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewId, 8, convViewInfo4GeneCode.ViewId);
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convViewInfo4GeneCode.ViewId);
objvViewInfo4GeneCodeEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.ViewId) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.ViewId, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.ViewId] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTitleStyleId">标题类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetTitleStyleId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strTitleStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTitleStyleId, 8, convViewInfo4GeneCode.TitleStyleId);
objvViewInfo4GeneCodeEN.TitleStyleId = strTitleStyleId; //标题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.TitleStyleId) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.TitleStyleId, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.TitleStyleId] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTitleStyleName">标题类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetTitleStyleName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strTitleStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTitleStyleName, 20, convViewInfo4GeneCode.TitleStyleName);
objvViewInfo4GeneCodeEN.TitleStyleName = strTitleStyleName; //标题类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.TitleStyleName) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.TitleStyleName, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.TitleStyleName] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDgStyleId">DG模式ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetDgStyleId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strDgStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDgStyleId, 4, convViewInfo4GeneCode.DgStyleId);
objvViewInfo4GeneCodeEN.DgStyleId = strDgStyleId; //DG模式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.DgStyleId) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.DgStyleId, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.DgStyleId] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDgStyleName">DG模式名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetDgStyleName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strDgStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDgStyleName, 30, convViewInfo4GeneCode.DgStyleName);
objvViewInfo4GeneCodeEN.DgStyleName = strDgStyleName; //DG模式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.DgStyleName) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.DgStyleName, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.DgStyleName] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strVersionGeneCode">生成代码版本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetVersionGeneCode(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strVersionGeneCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVersionGeneCode, 30, convViewInfo4GeneCode.VersionGeneCode);
objvViewInfo4GeneCodeEN.VersionGeneCode = strVersionGeneCode; //生成代码版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.VersionGeneCode) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.VersionGeneCode, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.VersionGeneCode] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewName">界面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, convViewInfo4GeneCode.ViewName);
clsCheckSql.CheckFieldLen(strViewName, 100, convViewInfo4GeneCode.ViewName);
objvViewInfo4GeneCodeEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.ViewName) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.ViewName, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.ViewName] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intViewTypeCode">界面类型码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewTypeCode(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, int intViewTypeCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intViewTypeCode, convViewInfo4GeneCode.ViewTypeCode);
objvViewInfo4GeneCodeEN.ViewTypeCode = intViewTypeCode; //界面类型码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.ViewTypeCode) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.ViewTypeCode, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.ViewTypeCode] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewTypeName">界面类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewTypeName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewTypeName, 40, convViewInfo4GeneCode.ViewTypeName);
objvViewInfo4GeneCodeEN.ViewTypeName = strViewTypeName; //界面类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.ViewTypeName) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.ViewTypeName, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.ViewTypeName] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetApplicationTypeId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, int intApplicationTypeId, string strComparisonOp="")
	{
objvViewInfo4GeneCodeEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.ApplicationTypeId) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.ApplicationTypeId, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.ApplicationTypeId] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetApplicationTypeName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convViewInfo4GeneCode.ApplicationTypeName);
objvViewInfo4GeneCodeEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.ApplicationTypeName) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.ApplicationTypeName, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.ApplicationTypeName] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetFuncModuleAgcId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convViewInfo4GeneCode.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convViewInfo4GeneCode.FuncModuleAgcId);
objvViewInfo4GeneCodeEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.FuncModuleAgcId) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.FuncModuleAgcId, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.FuncModuleAgcId] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetFuncModuleName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convViewInfo4GeneCode.FuncModuleName);
objvViewInfo4GeneCodeEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.FuncModuleName) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.FuncModuleName, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.FuncModuleName] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">功能模块英文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetFuncModuleEnName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convViewInfo4GeneCode.FuncModuleEnName);
objvViewInfo4GeneCodeEN.FuncModuleEnName = strFuncModuleEnName; //功能模块英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.FuncModuleEnName) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.FuncModuleEnName, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.FuncModuleEnName] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseName">数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetDataBaseName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convViewInfo4GeneCode.DataBaseName);
objvViewInfo4GeneCodeEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.DataBaseName) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.DataBaseName, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.DataBaseName] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyForMainTab">主表关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetKeyForMainTab(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strKeyForMainTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyForMainTab, 50, convViewInfo4GeneCode.KeyForMainTab);
objvViewInfo4GeneCodeEN.KeyForMainTab = strKeyForMainTab; //主表关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.KeyForMainTab) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.KeyForMainTab, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.KeyForMainTab] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyForDetailTab">明细表关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetKeyForDetailTab(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strKeyForDetailTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyForDetailTab, 50, convViewInfo4GeneCode.KeyForDetailTab);
objvViewInfo4GeneCodeEN.KeyForDetailTab = strKeyForDetailTab; //明细表关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.KeyForDetailTab) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.KeyForDetailTab, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.KeyForDetailTab] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedSort">是否需要排序</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetIsNeedSort(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, bool bolIsNeedSort, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedSort, convViewInfo4GeneCode.IsNeedSort);
objvViewInfo4GeneCodeEN.IsNeedSort = bolIsNeedSort; //是否需要排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.IsNeedSort) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.IsNeedSort, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.IsNeedSort] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedTransCode">是否需要转换代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetIsNeedTransCode(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, bool bolIsNeedTransCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedTransCode, convViewInfo4GeneCode.IsNeedTransCode);
objvViewInfo4GeneCodeEN.IsNeedTransCode = bolIsNeedTransCode; //是否需要转换代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.IsNeedTransCode) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.IsNeedTransCode, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.IsNeedTransCode] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetUserId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convViewInfo4GeneCode.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convViewInfo4GeneCode.UserId);
objvViewInfo4GeneCodeEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.UserId) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.UserId, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.UserId] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetPrjId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convViewInfo4GeneCode.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewInfo4GeneCode.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewInfo4GeneCode.PrjId);
objvViewInfo4GeneCodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.PrjId) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.PrjId, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.PrjId] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetPrjName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convViewInfo4GeneCode.PrjName);
objvViewInfo4GeneCodeEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.PrjName) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.PrjName, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.PrjName] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewFunction">界面功能</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewFunction(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewFunction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewFunction, 100, convViewInfo4GeneCode.ViewFunction);
objvViewInfo4GeneCodeEN.ViewFunction = strViewFunction; //界面功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.ViewFunction) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.ViewFunction, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.ViewFunction] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewDetail">界面说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewDetail(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewDetail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewDetail, 1000, convViewInfo4GeneCode.ViewDetail);
objvViewInfo4GeneCodeEN.ViewDetail = strViewDetail; //界面说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.ViewDetail) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.ViewDetail, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.ViewDetail] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaMenuName">缺省菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetDefaMenuName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strDefaMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaMenuName, convViewInfo4GeneCode.DefaMenuName);
clsCheckSql.CheckFieldLen(strDefaMenuName, 100, convViewInfo4GeneCode.DefaMenuName);
objvViewInfo4GeneCodeEN.DefaMenuName = strDefaMenuName; //缺省菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.DefaMenuName) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.DefaMenuName, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.DefaMenuName] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDetailTabId">明细表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetDetailTabId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strDetailTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDetailTabId, 8, convViewInfo4GeneCode.DetailTabId);
objvViewInfo4GeneCodeEN.DetailTabId = strDetailTabId; //明细表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.DetailTabId) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.DetailTabId, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.DetailTabId] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetFileName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convViewInfo4GeneCode.FileName);
clsCheckSql.CheckFieldLen(strFileName, 150, convViewInfo4GeneCode.FileName);
objvViewInfo4GeneCodeEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.FileName) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.FileName, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.FileName] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilePath">文件路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetFilePath(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convViewInfo4GeneCode.FilePath);
clsCheckSql.CheckFieldLen(strFilePath, 500, convViewInfo4GeneCode.FilePath);
objvViewInfo4GeneCodeEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.FilePath) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.FilePath, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.FilePath] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMainTabId">主表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetMainTabId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strMainTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMainTabId, 8, convViewInfo4GeneCode.MainTabId);
objvViewInfo4GeneCodeEN.MainTabId = strMainTabId; //主表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.MainTabId) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.MainTabId, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.MainTabId] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewCnName">视图中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewCnName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewCnName, convViewInfo4GeneCode.ViewCnName);
clsCheckSql.CheckFieldLen(strViewCnName, 100, convViewInfo4GeneCode.ViewCnName);
objvViewInfo4GeneCodeEN.ViewCnName = strViewCnName; //视图中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.ViewCnName) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.ViewCnName, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.ViewCnName] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewGroupId">界面组ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewGroupId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewGroupId, 8, convViewInfo4GeneCode.ViewGroupId);
clsCheckSql.CheckFieldForeignKey(strViewGroupId, 8, convViewInfo4GeneCode.ViewGroupId);
objvViewInfo4GeneCodeEN.ViewGroupId = strViewGroupId; //界面组ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.ViewGroupId) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.ViewGroupId, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.ViewGroupId] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewGroupName">界面组名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewGroupName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewGroupName, 30, convViewInfo4GeneCode.ViewGroupName);
objvViewInfo4GeneCodeEN.ViewGroupName = strViewGroupName; //界面组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.ViewGroupName) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.ViewGroupName, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.ViewGroupName] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strInSqlDsTypeId">输入数据源类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetInSqlDsTypeId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strInSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInSqlDsTypeId, 2, convViewInfo4GeneCode.InSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strInSqlDsTypeId, 2, convViewInfo4GeneCode.InSqlDsTypeId);
objvViewInfo4GeneCodeEN.InSqlDsTypeId = strInSqlDsTypeId; //输入数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.InSqlDsTypeId) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.InSqlDsTypeId, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.InSqlDsTypeId] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutSqlDsTypeId">输出数据源类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetOutSqlDsTypeId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strOutSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutSqlDsTypeId, 2, convViewInfo4GeneCode.OutSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strOutSqlDsTypeId, 2, convViewInfo4GeneCode.OutSqlDsTypeId);
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = strOutSqlDsTypeId; //输出数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.OutSqlDsTypeId) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.OutSqlDsTypeId, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.OutSqlDsTypeId] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strGeneCodeDate">生成代码日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetGeneCodeDate(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strGeneCodeDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convViewInfo4GeneCode.GeneCodeDate);
objvViewInfo4GeneCodeEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.GeneCodeDate) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.GeneCodeDate, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.GeneCodeDate] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intRegionNum">区域数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetRegionNum(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, int intRegionNum, string strComparisonOp="")
	{
objvViewInfo4GeneCodeEN.RegionNum = intRegionNum; //区域数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.RegionNum) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.RegionNum, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.RegionNum] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetUpdDate(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewInfo4GeneCode.UpdDate);
objvViewInfo4GeneCodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.UpdDate) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.UpdDate, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.UpdDate] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMainTabName">主表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetMainTabName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strMainTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMainTabName, 100, convViewInfo4GeneCode.MainTabName);
objvViewInfo4GeneCodeEN.MainTabName = strMainTabName; //主表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.MainTabName) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.MainTabName, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.MainTabName] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDetailTabName">详细表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetDetailTabName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strDetailTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDetailTabName, 40, convViewInfo4GeneCode.DetailTabName);
objvViewInfo4GeneCodeEN.DetailTabName = strDetailTabName; //详细表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.DetailTabName) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.DetailTabName, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.DetailTabName] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMainTabKeyFld">主表关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetMainTabKeyFld(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strMainTabKeyFld, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMainTabKeyFld, 50, convViewInfo4GeneCode.MainTabKeyFld);
objvViewInfo4GeneCodeEN.MainTabKeyFld = strMainTabKeyFld; //主表关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.MainTabKeyFld) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.MainTabKeyFld, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.MainTabKeyFld] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDetailTabKeyFld">详细表关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetDetailTabKeyFld(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strDetailTabKeyFld, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDetailTabKeyFld, 50, convViewInfo4GeneCode.DetailTabKeyFld);
objvViewInfo4GeneCodeEN.DetailTabKeyFld = strDetailTabKeyFld; //详细表关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.DetailTabKeyFld) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.DetailTabKeyFld, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.DetailTabKeyFld] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId4GeneCode">UserId4GeneCode</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetUserId4GeneCode(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strUserId4GeneCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId4GeneCode, 18, convViewInfo4GeneCode.UserId4GeneCode);
objvViewInfo4GeneCodeEN.UserId4GeneCode = strUserId4GeneCode; //UserId4GeneCode
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewInfo4GeneCodeEN.dicFldComparisonOp.ContainsKey(convViewInfo4GeneCode.UserId4GeneCode) == false)
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp.Add(convViewInfo4GeneCode.UserId4GeneCode, strComparisonOp);
}
else
{
objvViewInfo4GeneCodeEN.dicFldComparisonOp[convViewInfo4GeneCode.UserId4GeneCode] = strComparisonOp;
}
}
return objvViewInfo4GeneCodeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.ViewId) == true)
{
string strComparisonOpViewId = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.ViewId, objvViewInfo4GeneCodeCond.ViewId, strComparisonOpViewId);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.TitleStyleId) == true)
{
string strComparisonOpTitleStyleId = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.TitleStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.TitleStyleId, objvViewInfo4GeneCodeCond.TitleStyleId, strComparisonOpTitleStyleId);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.TitleStyleName) == true)
{
string strComparisonOpTitleStyleName = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.TitleStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.TitleStyleName, objvViewInfo4GeneCodeCond.TitleStyleName, strComparisonOpTitleStyleName);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.DgStyleId) == true)
{
string strComparisonOpDgStyleId = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.DgStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.DgStyleId, objvViewInfo4GeneCodeCond.DgStyleId, strComparisonOpDgStyleId);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.DgStyleName) == true)
{
string strComparisonOpDgStyleName = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.DgStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.DgStyleName, objvViewInfo4GeneCodeCond.DgStyleName, strComparisonOpDgStyleName);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.VersionGeneCode) == true)
{
string strComparisonOpVersionGeneCode = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.VersionGeneCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.VersionGeneCode, objvViewInfo4GeneCodeCond.VersionGeneCode, strComparisonOpVersionGeneCode);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.ViewName) == true)
{
string strComparisonOpViewName = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.ViewName, objvViewInfo4GeneCodeCond.ViewName, strComparisonOpViewName);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.ViewTypeCode) == true)
{
string strComparisonOpViewTypeCode = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.ViewTypeCode];
strWhereCond += string.Format(" And {0} {2} {1}", convViewInfo4GeneCode.ViewTypeCode, objvViewInfo4GeneCodeCond.ViewTypeCode, strComparisonOpViewTypeCode);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.ViewTypeName) == true)
{
string strComparisonOpViewTypeName = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.ViewTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.ViewTypeName, objvViewInfo4GeneCodeCond.ViewTypeName, strComparisonOpViewTypeName);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewInfo4GeneCode.ApplicationTypeId, objvViewInfo4GeneCodeCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.ApplicationTypeName, objvViewInfo4GeneCodeCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.FuncModuleAgcId, objvViewInfo4GeneCodeCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.FuncModuleName, objvViewInfo4GeneCodeCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.FuncModuleEnName, objvViewInfo4GeneCodeCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.DataBaseName, objvViewInfo4GeneCodeCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.KeyForMainTab) == true)
{
string strComparisonOpKeyForMainTab = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.KeyForMainTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.KeyForMainTab, objvViewInfo4GeneCodeCond.KeyForMainTab, strComparisonOpKeyForMainTab);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.KeyForDetailTab) == true)
{
string strComparisonOpKeyForDetailTab = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.KeyForDetailTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.KeyForDetailTab, objvViewInfo4GeneCodeCond.KeyForDetailTab, strComparisonOpKeyForDetailTab);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.IsNeedSort) == true)
{
if (objvViewInfo4GeneCodeCond.IsNeedSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewInfo4GeneCode.IsNeedSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewInfo4GeneCode.IsNeedSort);
}
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.IsNeedTransCode) == true)
{
if (objvViewInfo4GeneCodeCond.IsNeedTransCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewInfo4GeneCode.IsNeedTransCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewInfo4GeneCode.IsNeedTransCode);
}
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.UserId) == true)
{
string strComparisonOpUserId = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.UserId, objvViewInfo4GeneCodeCond.UserId, strComparisonOpUserId);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.PrjId) == true)
{
string strComparisonOpPrjId = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.PrjId, objvViewInfo4GeneCodeCond.PrjId, strComparisonOpPrjId);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.PrjName) == true)
{
string strComparisonOpPrjName = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.PrjName, objvViewInfo4GeneCodeCond.PrjName, strComparisonOpPrjName);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.ViewFunction) == true)
{
string strComparisonOpViewFunction = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.ViewFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.ViewFunction, objvViewInfo4GeneCodeCond.ViewFunction, strComparisonOpViewFunction);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.ViewDetail) == true)
{
string strComparisonOpViewDetail = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.ViewDetail];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.ViewDetail, objvViewInfo4GeneCodeCond.ViewDetail, strComparisonOpViewDetail);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.DefaMenuName) == true)
{
string strComparisonOpDefaMenuName = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.DefaMenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.DefaMenuName, objvViewInfo4GeneCodeCond.DefaMenuName, strComparisonOpDefaMenuName);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.DetailTabId) == true)
{
string strComparisonOpDetailTabId = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.DetailTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.DetailTabId, objvViewInfo4GeneCodeCond.DetailTabId, strComparisonOpDetailTabId);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.FileName) == true)
{
string strComparisonOpFileName = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.FileName, objvViewInfo4GeneCodeCond.FileName, strComparisonOpFileName);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.FilePath) == true)
{
string strComparisonOpFilePath = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.FilePath, objvViewInfo4GeneCodeCond.FilePath, strComparisonOpFilePath);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.MainTabId) == true)
{
string strComparisonOpMainTabId = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.MainTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.MainTabId, objvViewInfo4GeneCodeCond.MainTabId, strComparisonOpMainTabId);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.ViewCnName) == true)
{
string strComparisonOpViewCnName = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.ViewCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.ViewCnName, objvViewInfo4GeneCodeCond.ViewCnName, strComparisonOpViewCnName);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.ViewGroupId) == true)
{
string strComparisonOpViewGroupId = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.ViewGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.ViewGroupId, objvViewInfo4GeneCodeCond.ViewGroupId, strComparisonOpViewGroupId);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.ViewGroupName) == true)
{
string strComparisonOpViewGroupName = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.ViewGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.ViewGroupName, objvViewInfo4GeneCodeCond.ViewGroupName, strComparisonOpViewGroupName);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.InSqlDsTypeId) == true)
{
string strComparisonOpInSqlDsTypeId = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.InSqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.InSqlDsTypeId, objvViewInfo4GeneCodeCond.InSqlDsTypeId, strComparisonOpInSqlDsTypeId);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.OutSqlDsTypeId) == true)
{
string strComparisonOpOutSqlDsTypeId = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.OutSqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.OutSqlDsTypeId, objvViewInfo4GeneCodeCond.OutSqlDsTypeId, strComparisonOpOutSqlDsTypeId);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.GeneCodeDate) == true)
{
string strComparisonOpGeneCodeDate = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.GeneCodeDate, objvViewInfo4GeneCodeCond.GeneCodeDate, strComparisonOpGeneCodeDate);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.RegionNum) == true)
{
string strComparisonOpRegionNum = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.RegionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convViewInfo4GeneCode.RegionNum, objvViewInfo4GeneCodeCond.RegionNum, strComparisonOpRegionNum);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.UpdDate) == true)
{
string strComparisonOpUpdDate = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.UpdDate, objvViewInfo4GeneCodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.MainTabName) == true)
{
string strComparisonOpMainTabName = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.MainTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.MainTabName, objvViewInfo4GeneCodeCond.MainTabName, strComparisonOpMainTabName);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.DetailTabName) == true)
{
string strComparisonOpDetailTabName = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.DetailTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.DetailTabName, objvViewInfo4GeneCodeCond.DetailTabName, strComparisonOpDetailTabName);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.MainTabKeyFld) == true)
{
string strComparisonOpMainTabKeyFld = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.MainTabKeyFld];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.MainTabKeyFld, objvViewInfo4GeneCodeCond.MainTabKeyFld, strComparisonOpMainTabKeyFld);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.DetailTabKeyFld) == true)
{
string strComparisonOpDetailTabKeyFld = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.DetailTabKeyFld];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.DetailTabKeyFld, objvViewInfo4GeneCodeCond.DetailTabKeyFld, strComparisonOpDetailTabKeyFld);
}
if (objvViewInfo4GeneCodeCond.IsUpdated(convViewInfo4GeneCode.UserId4GeneCode) == true)
{
string strComparisonOpUserId4GeneCode = objvViewInfo4GeneCodeCond.dicFldComparisonOp[convViewInfo4GeneCode.UserId4GeneCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewInfo4GeneCode.UserId4GeneCode, objvViewInfo4GeneCodeCond.UserId4GeneCode, strComparisonOpUserId4GeneCode);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vViewInfo4GeneCode(vViewInfo4GeneCode)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvViewInfo4GeneCodeWApi
{
private static readonly string mstrApiControllerName = "vViewInfo4GeneCodeApi";

 public clsvViewInfo4GeneCodeWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vViewInfo4GeneCode]...","0");
List<clsvViewInfo4GeneCodeEN> arrObjLst = GetObjLst("1=1");
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
public static void BindCbo_ViewId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convViewInfo4GeneCode.ViewId); 
List<clsvViewInfo4GeneCodeEN> arrObjLst = clsvViewInfo4GeneCodeWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN()
{
ViewId = "0",
ViewName = "选[vViewInfo4GeneCode]..."
};
arrObjLstSel.Insert(0, objvViewInfo4GeneCodeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convViewInfo4GeneCode.ViewId;
objComboBox.DisplayMember = convViewInfo4GeneCode.ViewName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewInfo4GeneCodeEN GetObjByViewId(string strViewId)
{
if (strViewId == "") return null;
string strAction = "GetObjByViewId";
clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN;
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
objvViewInfo4GeneCodeEN = JsonConvert.DeserializeObject<clsvViewInfo4GeneCodeEN>(strJson);
return objvViewInfo4GeneCodeEN;
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
public static clsvViewInfo4GeneCodeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN;
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
objvViewInfo4GeneCodeEN = JsonConvert.DeserializeObject<clsvViewInfo4GeneCodeEN>(strJson);
return objvViewInfo4GeneCodeEN;
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
//该表没有使用Cache,不需要生成[GetViewNameByViewIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewInfo4GeneCodeEN> GetObjLst(string strWhereCond)
{
 List<clsvViewInfo4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewInfo4GeneCodeEN>>(strJson);
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
public static List<clsvViewInfo4GeneCodeEN> GetObjLstByViewIdLst(List<string> arrViewId)
{
 List<clsvViewInfo4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewInfo4GeneCodeEN>>(strJson);
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
public static List<clsvViewInfo4GeneCodeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvViewInfo4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewInfo4GeneCodeEN>>(strJson);
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
public static List<clsvViewInfo4GeneCodeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvViewInfo4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewInfo4GeneCodeEN>>(strJson);
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
public static List<clsvViewInfo4GeneCodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvViewInfo4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewInfo4GeneCodeEN>>(strJson);
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
public static List<clsvViewInfo4GeneCodeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvViewInfo4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewInfo4GeneCodeEN>>(strJson);
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
 /// <param name = "objvViewInfo4GeneCodeENS">源对象</param>
 /// <param name = "objvViewInfo4GeneCodeENT">目标对象</param>
 public static void CopyTo(clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeENS, clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeENT)
{
try
{
objvViewInfo4GeneCodeENT.ViewId = objvViewInfo4GeneCodeENS.ViewId; //界面Id
objvViewInfo4GeneCodeENT.TitleStyleId = objvViewInfo4GeneCodeENS.TitleStyleId; //标题类型Id
objvViewInfo4GeneCodeENT.TitleStyleName = objvViewInfo4GeneCodeENS.TitleStyleName; //标题类型名
objvViewInfo4GeneCodeENT.DgStyleId = objvViewInfo4GeneCodeENS.DgStyleId; //DG模式ID
objvViewInfo4GeneCodeENT.DgStyleName = objvViewInfo4GeneCodeENS.DgStyleName; //DG模式名
objvViewInfo4GeneCodeENT.VersionGeneCode = objvViewInfo4GeneCodeENS.VersionGeneCode; //生成代码版本
objvViewInfo4GeneCodeENT.ViewName = objvViewInfo4GeneCodeENS.ViewName; //界面名称
objvViewInfo4GeneCodeENT.ViewTypeCode = objvViewInfo4GeneCodeENS.ViewTypeCode; //界面类型码
objvViewInfo4GeneCodeENT.ViewTypeName = objvViewInfo4GeneCodeENS.ViewTypeName; //界面类型名称
objvViewInfo4GeneCodeENT.ApplicationTypeId = objvViewInfo4GeneCodeENS.ApplicationTypeId; //应用程序类型ID
objvViewInfo4GeneCodeENT.ApplicationTypeName = objvViewInfo4GeneCodeENS.ApplicationTypeName; //应用程序类型名称
objvViewInfo4GeneCodeENT.FuncModuleAgcId = objvViewInfo4GeneCodeENS.FuncModuleAgcId; //功能模块Id
objvViewInfo4GeneCodeENT.FuncModuleName = objvViewInfo4GeneCodeENS.FuncModuleName; //功能模块名称
objvViewInfo4GeneCodeENT.FuncModuleEnName = objvViewInfo4GeneCodeENS.FuncModuleEnName; //功能模块英文名称
objvViewInfo4GeneCodeENT.DataBaseName = objvViewInfo4GeneCodeENS.DataBaseName; //数据库名
objvViewInfo4GeneCodeENT.KeyForMainTab = objvViewInfo4GeneCodeENS.KeyForMainTab; //主表关键字
objvViewInfo4GeneCodeENT.KeyForDetailTab = objvViewInfo4GeneCodeENS.KeyForDetailTab; //明细表关键字
objvViewInfo4GeneCodeENT.IsNeedSort = objvViewInfo4GeneCodeENS.IsNeedSort; //是否需要排序
objvViewInfo4GeneCodeENT.IsNeedTransCode = objvViewInfo4GeneCodeENS.IsNeedTransCode; //是否需要转换代码
objvViewInfo4GeneCodeENT.UserId = objvViewInfo4GeneCodeENS.UserId; //用户Id
objvViewInfo4GeneCodeENT.PrjId = objvViewInfo4GeneCodeENS.PrjId; //工程Id
objvViewInfo4GeneCodeENT.PrjName = objvViewInfo4GeneCodeENS.PrjName; //工程名称
objvViewInfo4GeneCodeENT.ViewFunction = objvViewInfo4GeneCodeENS.ViewFunction; //界面功能
objvViewInfo4GeneCodeENT.ViewDetail = objvViewInfo4GeneCodeENS.ViewDetail; //界面说明
objvViewInfo4GeneCodeENT.DefaMenuName = objvViewInfo4GeneCodeENS.DefaMenuName; //缺省菜单名
objvViewInfo4GeneCodeENT.DetailTabId = objvViewInfo4GeneCodeENS.DetailTabId; //明细表ID
objvViewInfo4GeneCodeENT.FileName = objvViewInfo4GeneCodeENS.FileName; //文件名
objvViewInfo4GeneCodeENT.FilePath = objvViewInfo4GeneCodeENS.FilePath; //文件路径
objvViewInfo4GeneCodeENT.MainTabId = objvViewInfo4GeneCodeENS.MainTabId; //主表ID
objvViewInfo4GeneCodeENT.ViewCnName = objvViewInfo4GeneCodeENS.ViewCnName; //视图中文名
objvViewInfo4GeneCodeENT.ViewGroupId = objvViewInfo4GeneCodeENS.ViewGroupId; //界面组ID
objvViewInfo4GeneCodeENT.ViewGroupName = objvViewInfo4GeneCodeENS.ViewGroupName; //界面组名称
objvViewInfo4GeneCodeENT.InSqlDsTypeId = objvViewInfo4GeneCodeENS.InSqlDsTypeId; //输入数据源类型
objvViewInfo4GeneCodeENT.OutSqlDsTypeId = objvViewInfo4GeneCodeENS.OutSqlDsTypeId; //输出数据源类型
objvViewInfo4GeneCodeENT.GeneCodeDate = objvViewInfo4GeneCodeENS.GeneCodeDate; //生成代码日期
objvViewInfo4GeneCodeENT.RegionNum = objvViewInfo4GeneCodeENS.RegionNum; //区域数
objvViewInfo4GeneCodeENT.UpdDate = objvViewInfo4GeneCodeENS.UpdDate; //修改日期
objvViewInfo4GeneCodeENT.MainTabName = objvViewInfo4GeneCodeENS.MainTabName; //主表
objvViewInfo4GeneCodeENT.DetailTabName = objvViewInfo4GeneCodeENS.DetailTabName; //详细表
objvViewInfo4GeneCodeENT.MainTabKeyFld = objvViewInfo4GeneCodeENS.MainTabKeyFld; //主表关键字
objvViewInfo4GeneCodeENT.DetailTabKeyFld = objvViewInfo4GeneCodeENS.DetailTabKeyFld; //详细表关键字
objvViewInfo4GeneCodeENT.UserId4GeneCode = objvViewInfo4GeneCodeENS.UserId4GeneCode; //UserId4GeneCode
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
public static DataTable ToDataTable(List<clsvViewInfo4GeneCodeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvViewInfo4GeneCodeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvViewInfo4GeneCodeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvViewInfo4GeneCodeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvViewInfo4GeneCodeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvViewInfo4GeneCodeEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvViewInfo4GeneCodeWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvViewInfo4GeneCodeWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvViewInfo4GeneCodeEN._CurrTabName, strPrjId);
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
public static DataTable GetDataTableByObjLst(List<clsvViewInfo4GeneCodeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convViewInfo4GeneCode.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.TitleStyleId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.TitleStyleName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.DgStyleId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.DgStyleName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.VersionGeneCode, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.ViewTypeCode, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewInfo4GeneCode.ViewTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewInfo4GeneCode.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.DataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.KeyForMainTab, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.KeyForDetailTab, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.IsNeedSort, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewInfo4GeneCode.IsNeedTransCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewInfo4GeneCode.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.ViewFunction, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.ViewDetail, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.DefaMenuName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.DetailTabId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.MainTabId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.ViewCnName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.ViewGroupId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.ViewGroupName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.InSqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.OutSqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.GeneCodeDate, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.RegionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewInfo4GeneCode.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.MainTabName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.DetailTabName, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.MainTabKeyFld, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.DetailTabKeyFld, Type.GetType("System.String"));
objDT.Columns.Add(convViewInfo4GeneCode.UserId4GeneCode, Type.GetType("System.String"));
foreach (clsvViewInfo4GeneCodeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convViewInfo4GeneCode.ViewId] = objInFor[convViewInfo4GeneCode.ViewId];
objDR[convViewInfo4GeneCode.TitleStyleId] = objInFor[convViewInfo4GeneCode.TitleStyleId];
objDR[convViewInfo4GeneCode.TitleStyleName] = objInFor[convViewInfo4GeneCode.TitleStyleName];
objDR[convViewInfo4GeneCode.DgStyleId] = objInFor[convViewInfo4GeneCode.DgStyleId];
objDR[convViewInfo4GeneCode.DgStyleName] = objInFor[convViewInfo4GeneCode.DgStyleName];
objDR[convViewInfo4GeneCode.VersionGeneCode] = objInFor[convViewInfo4GeneCode.VersionGeneCode];
objDR[convViewInfo4GeneCode.ViewName] = objInFor[convViewInfo4GeneCode.ViewName];
objDR[convViewInfo4GeneCode.ViewTypeCode] = objInFor[convViewInfo4GeneCode.ViewTypeCode];
objDR[convViewInfo4GeneCode.ViewTypeName] = objInFor[convViewInfo4GeneCode.ViewTypeName];
objDR[convViewInfo4GeneCode.ApplicationTypeId] = objInFor[convViewInfo4GeneCode.ApplicationTypeId];
objDR[convViewInfo4GeneCode.ApplicationTypeName] = objInFor[convViewInfo4GeneCode.ApplicationTypeName];
objDR[convViewInfo4GeneCode.FuncModuleAgcId] = objInFor[convViewInfo4GeneCode.FuncModuleAgcId];
objDR[convViewInfo4GeneCode.FuncModuleName] = objInFor[convViewInfo4GeneCode.FuncModuleName];
objDR[convViewInfo4GeneCode.FuncModuleEnName] = objInFor[convViewInfo4GeneCode.FuncModuleEnName];
objDR[convViewInfo4GeneCode.DataBaseName] = objInFor[convViewInfo4GeneCode.DataBaseName];
objDR[convViewInfo4GeneCode.KeyForMainTab] = objInFor[convViewInfo4GeneCode.KeyForMainTab];
objDR[convViewInfo4GeneCode.KeyForDetailTab] = objInFor[convViewInfo4GeneCode.KeyForDetailTab];
objDR[convViewInfo4GeneCode.IsNeedSort] = objInFor[convViewInfo4GeneCode.IsNeedSort];
objDR[convViewInfo4GeneCode.IsNeedTransCode] = objInFor[convViewInfo4GeneCode.IsNeedTransCode];
objDR[convViewInfo4GeneCode.UserId] = objInFor[convViewInfo4GeneCode.UserId];
objDR[convViewInfo4GeneCode.PrjId] = objInFor[convViewInfo4GeneCode.PrjId];
objDR[convViewInfo4GeneCode.PrjName] = objInFor[convViewInfo4GeneCode.PrjName];
objDR[convViewInfo4GeneCode.ViewFunction] = objInFor[convViewInfo4GeneCode.ViewFunction];
objDR[convViewInfo4GeneCode.ViewDetail] = objInFor[convViewInfo4GeneCode.ViewDetail];
objDR[convViewInfo4GeneCode.DefaMenuName] = objInFor[convViewInfo4GeneCode.DefaMenuName];
objDR[convViewInfo4GeneCode.DetailTabId] = objInFor[convViewInfo4GeneCode.DetailTabId];
objDR[convViewInfo4GeneCode.FileName] = objInFor[convViewInfo4GeneCode.FileName];
objDR[convViewInfo4GeneCode.FilePath] = objInFor[convViewInfo4GeneCode.FilePath];
objDR[convViewInfo4GeneCode.MainTabId] = objInFor[convViewInfo4GeneCode.MainTabId];
objDR[convViewInfo4GeneCode.ViewCnName] = objInFor[convViewInfo4GeneCode.ViewCnName];
objDR[convViewInfo4GeneCode.ViewGroupId] = objInFor[convViewInfo4GeneCode.ViewGroupId];
objDR[convViewInfo4GeneCode.ViewGroupName] = objInFor[convViewInfo4GeneCode.ViewGroupName];
objDR[convViewInfo4GeneCode.InSqlDsTypeId] = objInFor[convViewInfo4GeneCode.InSqlDsTypeId];
objDR[convViewInfo4GeneCode.OutSqlDsTypeId] = objInFor[convViewInfo4GeneCode.OutSqlDsTypeId];
objDR[convViewInfo4GeneCode.GeneCodeDate] = objInFor[convViewInfo4GeneCode.GeneCodeDate];
objDR[convViewInfo4GeneCode.RegionNum] = objInFor[convViewInfo4GeneCode.RegionNum];
objDR[convViewInfo4GeneCode.UpdDate] = objInFor[convViewInfo4GeneCode.UpdDate];
objDR[convViewInfo4GeneCode.MainTabName] = objInFor[convViewInfo4GeneCode.MainTabName];
objDR[convViewInfo4GeneCode.DetailTabName] = objInFor[convViewInfo4GeneCode.DetailTabName];
objDR[convViewInfo4GeneCode.MainTabKeyFld] = objInFor[convViewInfo4GeneCode.MainTabKeyFld];
objDR[convViewInfo4GeneCode.DetailTabKeyFld] = objInFor[convViewInfo4GeneCode.DetailTabKeyFld];
objDR[convViewInfo4GeneCode.UserId4GeneCode] = objInFor[convViewInfo4GeneCode.UserId4GeneCode];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}