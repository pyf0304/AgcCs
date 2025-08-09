
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewInfo4GeneCodeBL
 表名:vViewInfo4GeneCode(00050283)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:43
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
public static class  clsvViewInfo4GeneCodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewInfo4GeneCodeEN GetObj(this K_ViewId_vViewInfo4GeneCode myKey)
{
clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = clsvViewInfo4GeneCodeBL.vViewInfo4GeneCodeDA.GetObjByViewId(myKey.Value);
return objvViewInfo4GeneCodeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, convViewInfo4GeneCode.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convViewInfo4GeneCode.ViewId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetTitleStyleId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strTitleStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTitleStyleId, 8, convViewInfo4GeneCode.TitleStyleId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetTitleStyleName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strTitleStyleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTitleStyleName, 20, convViewInfo4GeneCode.TitleStyleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetDgStyleId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strDgStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDgStyleId, 4, convViewInfo4GeneCode.DgStyleId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetDgStyleName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strDgStyleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDgStyleName, 30, convViewInfo4GeneCode.DgStyleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetVersionGeneCode(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strVersionGeneCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionGeneCode, 30, convViewInfo4GeneCode.VersionGeneCode);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, convViewInfo4GeneCode.ViewName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, convViewInfo4GeneCode.ViewName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewTypeName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewTypeName, 40, convViewInfo4GeneCode.ViewTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetApplicationTypeId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, int? intApplicationTypeId, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetApplicationTypeName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strApplicationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convViewInfo4GeneCode.ApplicationTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetFuncModuleAgcId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convViewInfo4GeneCode.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convViewInfo4GeneCode.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetFuncModuleName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convViewInfo4GeneCode.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetFuncModuleEnName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convViewInfo4GeneCode.FuncModuleEnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetDataBaseName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convViewInfo4GeneCode.DataBaseName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetKeyForMainTab(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strKeyForMainTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyForMainTab, 50, convViewInfo4GeneCode.KeyForMainTab);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetKeyForDetailTab(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strKeyForDetailTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyForDetailTab, 50, convViewInfo4GeneCode.KeyForDetailTab);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetUserId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convViewInfo4GeneCode.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convViewInfo4GeneCode.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetPrjId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convViewInfo4GeneCode.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewInfo4GeneCode.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewInfo4GeneCode.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetPrjName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convViewInfo4GeneCode.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewFunction(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewFunction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewFunction, 100, convViewInfo4GeneCode.ViewFunction);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewDetail(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewDetail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewDetail, 1000, convViewInfo4GeneCode.ViewDetail);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetDefaMenuName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strDefaMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaMenuName, convViewInfo4GeneCode.DefaMenuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaMenuName, 100, convViewInfo4GeneCode.DefaMenuName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetDetailTabId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strDetailTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDetailTabId, 8, convViewInfo4GeneCode.DetailTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetFileName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convViewInfo4GeneCode.FileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, convViewInfo4GeneCode.FileName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetFilePath(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convViewInfo4GeneCode.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, convViewInfo4GeneCode.FilePath);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetMainTabId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strMainTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMainTabId, 8, convViewInfo4GeneCode.MainTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewCnName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewCnName, convViewInfo4GeneCode.ViewCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewCnName, 100, convViewInfo4GeneCode.ViewCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewGroupId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewGroupId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewGroupId, 8, convViewInfo4GeneCode.ViewGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewGroupId, 8, convViewInfo4GeneCode.ViewGroupId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetViewGroupName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strViewGroupName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewGroupName, 30, convViewInfo4GeneCode.ViewGroupName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetInSqlDsTypeId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strInSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInSqlDsTypeId, 2, convViewInfo4GeneCode.InSqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInSqlDsTypeId, 2, convViewInfo4GeneCode.InSqlDsTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetOutSqlDsTypeId(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strOutSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutSqlDsTypeId, 2, convViewInfo4GeneCode.OutSqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOutSqlDsTypeId, 2, convViewInfo4GeneCode.OutSqlDsTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetGeneCodeDate(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strGeneCodeDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convViewInfo4GeneCode.GeneCodeDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetRegionNum(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, int? intRegionNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetUpdDate(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewInfo4GeneCode.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetMainTabName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strMainTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMainTabName, 100, convViewInfo4GeneCode.MainTabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetDetailTabName(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strDetailTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDetailTabName, 40, convViewInfo4GeneCode.DetailTabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetMainTabKeyFld(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strMainTabKeyFld, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMainTabKeyFld, 50, convViewInfo4GeneCode.MainTabKeyFld);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetDetailTabKeyFld(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strDetailTabKeyFld, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDetailTabKeyFld, 50, convViewInfo4GeneCode.DetailTabKeyFld);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfo4GeneCodeEN SetUserId4GeneCode(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN, string strUserId4GeneCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId4GeneCode, 18, convViewInfo4GeneCode.UserId4GeneCode);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeENS">源对象</param>
 /// <param name = "objvViewInfo4GeneCodeENT">目标对象</param>
 public static void CopyTo(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeENS, clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeENT)
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
 /// <param name = "objvViewInfo4GeneCodeENS">源对象</param>
 /// <returns>目标对象=>clsvViewInfo4GeneCodeEN:objvViewInfo4GeneCodeENT</returns>
 public static clsvViewInfo4GeneCodeEN CopyTo(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeENS)
{
try
{
 clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeENT = new clsvViewInfo4GeneCodeEN()
{
ViewId = objvViewInfo4GeneCodeENS.ViewId, //界面Id
TitleStyleId = objvViewInfo4GeneCodeENS.TitleStyleId, //标题类型Id
TitleStyleName = objvViewInfo4GeneCodeENS.TitleStyleName, //标题类型名
DgStyleId = objvViewInfo4GeneCodeENS.DgStyleId, //DG模式ID
DgStyleName = objvViewInfo4GeneCodeENS.DgStyleName, //DG模式名
VersionGeneCode = objvViewInfo4GeneCodeENS.VersionGeneCode, //生成代码版本
ViewName = objvViewInfo4GeneCodeENS.ViewName, //界面名称
ViewTypeCode = objvViewInfo4GeneCodeENS.ViewTypeCode, //界面类型码
ViewTypeName = objvViewInfo4GeneCodeENS.ViewTypeName, //界面类型名称
ApplicationTypeId = objvViewInfo4GeneCodeENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeName = objvViewInfo4GeneCodeENS.ApplicationTypeName, //应用程序类型名称
FuncModuleAgcId = objvViewInfo4GeneCodeENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvViewInfo4GeneCodeENS.FuncModuleName, //功能模块名称
FuncModuleEnName = objvViewInfo4GeneCodeENS.FuncModuleEnName, //功能模块英文名称
DataBaseName = objvViewInfo4GeneCodeENS.DataBaseName, //数据库名
KeyForMainTab = objvViewInfo4GeneCodeENS.KeyForMainTab, //主表关键字
KeyForDetailTab = objvViewInfo4GeneCodeENS.KeyForDetailTab, //明细表关键字
IsNeedSort = objvViewInfo4GeneCodeENS.IsNeedSort, //是否需要排序
IsNeedTransCode = objvViewInfo4GeneCodeENS.IsNeedTransCode, //是否需要转换代码
UserId = objvViewInfo4GeneCodeENS.UserId, //用户Id
PrjId = objvViewInfo4GeneCodeENS.PrjId, //工程Id
PrjName = objvViewInfo4GeneCodeENS.PrjName, //工程名称
ViewFunction = objvViewInfo4GeneCodeENS.ViewFunction, //界面功能
ViewDetail = objvViewInfo4GeneCodeENS.ViewDetail, //界面说明
DefaMenuName = objvViewInfo4GeneCodeENS.DefaMenuName, //缺省菜单名
DetailTabId = objvViewInfo4GeneCodeENS.DetailTabId, //明细表ID
FileName = objvViewInfo4GeneCodeENS.FileName, //文件名
FilePath = objvViewInfo4GeneCodeENS.FilePath, //文件路径
MainTabId = objvViewInfo4GeneCodeENS.MainTabId, //主表ID
ViewCnName = objvViewInfo4GeneCodeENS.ViewCnName, //视图中文名
ViewGroupId = objvViewInfo4GeneCodeENS.ViewGroupId, //界面组ID
ViewGroupName = objvViewInfo4GeneCodeENS.ViewGroupName, //界面组名称
InSqlDsTypeId = objvViewInfo4GeneCodeENS.InSqlDsTypeId, //输入数据源类型
OutSqlDsTypeId = objvViewInfo4GeneCodeENS.OutSqlDsTypeId, //输出数据源类型
GeneCodeDate = objvViewInfo4GeneCodeENS.GeneCodeDate, //生成代码日期
RegionNum = objvViewInfo4GeneCodeENS.RegionNum, //区域数
UpdDate = objvViewInfo4GeneCodeENS.UpdDate, //修改日期
MainTabName = objvViewInfo4GeneCodeENS.MainTabName, //主表
DetailTabName = objvViewInfo4GeneCodeENS.DetailTabName, //详细表
MainTabKeyFld = objvViewInfo4GeneCodeENS.MainTabKeyFld, //主表关键字
DetailTabKeyFld = objvViewInfo4GeneCodeENS.DetailTabKeyFld, //详细表关键字
UserId4GeneCode = objvViewInfo4GeneCodeENS.UserId4GeneCode, //UserId4GeneCode
};
 return objvViewInfo4GeneCodeENT;
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
public static void CheckProperty4Condition(this clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN)
{
 clsvViewInfo4GeneCodeBL.vViewInfo4GeneCodeDA.CheckProperty4Condition(objvViewInfo4GeneCodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vViewInfo4GeneCode
{
public virtual bool UpdRelaTabDate(string strViewId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vViewInfo4GeneCode(vViewInfo4GeneCode)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvViewInfo4GeneCodeBL
{
public static RelatedActions_vViewInfo4GeneCode relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvViewInfo4GeneCodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvViewInfo4GeneCodeDA vViewInfo4GeneCodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvViewInfo4GeneCodeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvViewInfo4GeneCodeBL()
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
if (string.IsNullOrEmpty(clsvViewInfo4GeneCodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewInfo4GeneCodeEN._ConnectString);
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
public static DataTable GetDataTable_vViewInfo4GeneCode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewInfo4GeneCodeDA.GetDataTable_vViewInfo4GeneCode(strWhereCond);
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
objDT = vViewInfo4GeneCodeDA.GetDataTable(strWhereCond);
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
objDT = vViewInfo4GeneCodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vViewInfo4GeneCodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vViewInfo4GeneCodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vViewInfo4GeneCodeDA.GetDataTable_Top(objTopPara);
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
objDT = vViewInfo4GeneCodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vViewInfo4GeneCodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vViewInfo4GeneCodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvViewInfo4GeneCodeEN> GetObjLstByViewIdLst(List<string> arrViewIdLst)
{
List<clsvViewInfo4GeneCodeEN> arrObjLst = new List<clsvViewInfo4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewIdLst, true);
 string strWhereCond = string.Format("ViewId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
try
{
objvViewInfo4GeneCodeEN.ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id
objvViewInfo4GeneCodeEN.TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfo4GeneCodeEN.TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfo4GeneCodeEN.DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfo4GeneCodeEN.DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfo4GeneCodeEN.VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvViewInfo4GeneCodeEN.ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称
objvViewInfo4GeneCodeEN.ViewTypeCode = Int32.Parse(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewInfo4GeneCodeEN.ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewInfo4GeneCodeEN.ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfo4GeneCodeEN.ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewInfo4GeneCodeEN.FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfo4GeneCodeEN.FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfo4GeneCodeEN.FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfo4GeneCodeEN.DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名
objvViewInfo4GeneCodeEN.KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfo4GeneCodeEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfo4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfo4GeneCodeEN.UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id
objvViewInfo4GeneCodeEN.PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id
objvViewInfo4GeneCodeEN.PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称
objvViewInfo4GeneCodeEN.ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能
objvViewInfo4GeneCodeEN.ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明
objvViewInfo4GeneCodeEN.DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfo4GeneCodeEN.DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfo4GeneCodeEN.FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名
objvViewInfo4GeneCodeEN.FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径
objvViewInfo4GeneCodeEN.MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID
objvViewInfo4GeneCodeEN.ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfo4GeneCodeEN.ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfo4GeneCodeEN.ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfo4GeneCodeEN.InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfo4GeneCodeEN.GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfo4GeneCodeEN.RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数
objvViewInfo4GeneCodeEN.UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvViewInfo4GeneCodeEN.MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表
objvViewInfo4GeneCodeEN.DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表
objvViewInfo4GeneCodeEN.MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字
objvViewInfo4GeneCodeEN.UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfo4GeneCodeEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfo4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvViewInfo4GeneCodeEN> GetObjLstByViewIdLstCache(List<string> arrViewIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvViewInfo4GeneCodeEN._CurrTabName, strPrjId);
List<clsvViewInfo4GeneCodeEN> arrvViewInfo4GeneCodeObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewInfo4GeneCodeEN> arrvViewInfo4GeneCodeObjLst_Sel =
arrvViewInfo4GeneCodeObjLstCache
.Where(x => arrViewIdLst.Contains(x.ViewId));
return arrvViewInfo4GeneCodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewInfo4GeneCodeEN> GetObjLst(string strWhereCond)
{
List<clsvViewInfo4GeneCodeEN> arrObjLst = new List<clsvViewInfo4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
try
{
objvViewInfo4GeneCodeEN.ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id
objvViewInfo4GeneCodeEN.TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfo4GeneCodeEN.TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfo4GeneCodeEN.DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfo4GeneCodeEN.DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfo4GeneCodeEN.VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvViewInfo4GeneCodeEN.ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称
objvViewInfo4GeneCodeEN.ViewTypeCode = Int32.Parse(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewInfo4GeneCodeEN.ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewInfo4GeneCodeEN.ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfo4GeneCodeEN.ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewInfo4GeneCodeEN.FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfo4GeneCodeEN.FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfo4GeneCodeEN.FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfo4GeneCodeEN.DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名
objvViewInfo4GeneCodeEN.KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfo4GeneCodeEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfo4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfo4GeneCodeEN.UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id
objvViewInfo4GeneCodeEN.PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id
objvViewInfo4GeneCodeEN.PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称
objvViewInfo4GeneCodeEN.ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能
objvViewInfo4GeneCodeEN.ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明
objvViewInfo4GeneCodeEN.DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfo4GeneCodeEN.DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfo4GeneCodeEN.FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名
objvViewInfo4GeneCodeEN.FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径
objvViewInfo4GeneCodeEN.MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID
objvViewInfo4GeneCodeEN.ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfo4GeneCodeEN.ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfo4GeneCodeEN.ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfo4GeneCodeEN.InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfo4GeneCodeEN.GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfo4GeneCodeEN.RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数
objvViewInfo4GeneCodeEN.UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvViewInfo4GeneCodeEN.MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表
objvViewInfo4GeneCodeEN.DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表
objvViewInfo4GeneCodeEN.MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字
objvViewInfo4GeneCodeEN.UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfo4GeneCodeEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfo4GeneCodeEN);
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
public static List<clsvViewInfo4GeneCodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewInfo4GeneCodeEN> arrObjLst = new List<clsvViewInfo4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
try
{
objvViewInfo4GeneCodeEN.ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id
objvViewInfo4GeneCodeEN.TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfo4GeneCodeEN.TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfo4GeneCodeEN.DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfo4GeneCodeEN.DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfo4GeneCodeEN.VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvViewInfo4GeneCodeEN.ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称
objvViewInfo4GeneCodeEN.ViewTypeCode = Int32.Parse(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewInfo4GeneCodeEN.ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewInfo4GeneCodeEN.ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfo4GeneCodeEN.ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewInfo4GeneCodeEN.FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfo4GeneCodeEN.FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfo4GeneCodeEN.FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfo4GeneCodeEN.DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名
objvViewInfo4GeneCodeEN.KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfo4GeneCodeEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfo4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfo4GeneCodeEN.UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id
objvViewInfo4GeneCodeEN.PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id
objvViewInfo4GeneCodeEN.PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称
objvViewInfo4GeneCodeEN.ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能
objvViewInfo4GeneCodeEN.ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明
objvViewInfo4GeneCodeEN.DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfo4GeneCodeEN.DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfo4GeneCodeEN.FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名
objvViewInfo4GeneCodeEN.FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径
objvViewInfo4GeneCodeEN.MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID
objvViewInfo4GeneCodeEN.ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfo4GeneCodeEN.ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfo4GeneCodeEN.ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfo4GeneCodeEN.InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfo4GeneCodeEN.GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfo4GeneCodeEN.RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数
objvViewInfo4GeneCodeEN.UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvViewInfo4GeneCodeEN.MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表
objvViewInfo4GeneCodeEN.DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表
objvViewInfo4GeneCodeEN.MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字
objvViewInfo4GeneCodeEN.UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfo4GeneCodeEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfo4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvViewInfo4GeneCodeEN> GetSubObjLstCache(clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeCond)
{
 string strPrjId = objvViewInfo4GeneCodeCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvViewInfo4GeneCodeBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvViewInfo4GeneCodeEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewInfo4GeneCodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewInfo4GeneCode._AttributeName)
{
if (objvViewInfo4GeneCodeCond.IsUpdated(strFldName) == false) continue;
if (objvViewInfo4GeneCodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewInfo4GeneCodeCond[strFldName].ToString());
}
else
{
if (objvViewInfo4GeneCodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewInfo4GeneCodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewInfo4GeneCodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewInfo4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewInfo4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewInfo4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewInfo4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewInfo4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewInfo4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewInfo4GeneCodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewInfo4GeneCodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewInfo4GeneCodeCond[strFldName]));
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
public static List<clsvViewInfo4GeneCodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvViewInfo4GeneCodeEN> arrObjLst = new List<clsvViewInfo4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
try
{
objvViewInfo4GeneCodeEN.ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id
objvViewInfo4GeneCodeEN.TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfo4GeneCodeEN.TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfo4GeneCodeEN.DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfo4GeneCodeEN.DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfo4GeneCodeEN.VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvViewInfo4GeneCodeEN.ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称
objvViewInfo4GeneCodeEN.ViewTypeCode = Int32.Parse(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewInfo4GeneCodeEN.ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewInfo4GeneCodeEN.ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfo4GeneCodeEN.ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewInfo4GeneCodeEN.FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfo4GeneCodeEN.FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfo4GeneCodeEN.FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfo4GeneCodeEN.DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名
objvViewInfo4GeneCodeEN.KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfo4GeneCodeEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfo4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfo4GeneCodeEN.UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id
objvViewInfo4GeneCodeEN.PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id
objvViewInfo4GeneCodeEN.PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称
objvViewInfo4GeneCodeEN.ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能
objvViewInfo4GeneCodeEN.ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明
objvViewInfo4GeneCodeEN.DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfo4GeneCodeEN.DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfo4GeneCodeEN.FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名
objvViewInfo4GeneCodeEN.FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径
objvViewInfo4GeneCodeEN.MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID
objvViewInfo4GeneCodeEN.ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfo4GeneCodeEN.ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfo4GeneCodeEN.ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfo4GeneCodeEN.InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfo4GeneCodeEN.GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfo4GeneCodeEN.RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数
objvViewInfo4GeneCodeEN.UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvViewInfo4GeneCodeEN.MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表
objvViewInfo4GeneCodeEN.DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表
objvViewInfo4GeneCodeEN.MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字
objvViewInfo4GeneCodeEN.UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfo4GeneCodeEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfo4GeneCodeEN);
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
public static List<clsvViewInfo4GeneCodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvViewInfo4GeneCodeEN> arrObjLst = new List<clsvViewInfo4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
try
{
objvViewInfo4GeneCodeEN.ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id
objvViewInfo4GeneCodeEN.TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfo4GeneCodeEN.TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfo4GeneCodeEN.DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfo4GeneCodeEN.DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfo4GeneCodeEN.VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvViewInfo4GeneCodeEN.ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称
objvViewInfo4GeneCodeEN.ViewTypeCode = Int32.Parse(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewInfo4GeneCodeEN.ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewInfo4GeneCodeEN.ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfo4GeneCodeEN.ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewInfo4GeneCodeEN.FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfo4GeneCodeEN.FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfo4GeneCodeEN.FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfo4GeneCodeEN.DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名
objvViewInfo4GeneCodeEN.KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfo4GeneCodeEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfo4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfo4GeneCodeEN.UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id
objvViewInfo4GeneCodeEN.PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id
objvViewInfo4GeneCodeEN.PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称
objvViewInfo4GeneCodeEN.ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能
objvViewInfo4GeneCodeEN.ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明
objvViewInfo4GeneCodeEN.DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfo4GeneCodeEN.DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfo4GeneCodeEN.FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名
objvViewInfo4GeneCodeEN.FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径
objvViewInfo4GeneCodeEN.MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID
objvViewInfo4GeneCodeEN.ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfo4GeneCodeEN.ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfo4GeneCodeEN.ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfo4GeneCodeEN.InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfo4GeneCodeEN.GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfo4GeneCodeEN.RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数
objvViewInfo4GeneCodeEN.UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvViewInfo4GeneCodeEN.MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表
objvViewInfo4GeneCodeEN.DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表
objvViewInfo4GeneCodeEN.MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字
objvViewInfo4GeneCodeEN.UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfo4GeneCodeEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfo4GeneCodeEN);
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
List<clsvViewInfo4GeneCodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvViewInfo4GeneCodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewInfo4GeneCodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvViewInfo4GeneCodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvViewInfo4GeneCodeEN> arrObjLst = new List<clsvViewInfo4GeneCodeEN>(); 
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
	clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
try
{
objvViewInfo4GeneCodeEN.ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id
objvViewInfo4GeneCodeEN.TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfo4GeneCodeEN.TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfo4GeneCodeEN.DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfo4GeneCodeEN.DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfo4GeneCodeEN.VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvViewInfo4GeneCodeEN.ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称
objvViewInfo4GeneCodeEN.ViewTypeCode = Int32.Parse(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewInfo4GeneCodeEN.ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewInfo4GeneCodeEN.ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfo4GeneCodeEN.ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewInfo4GeneCodeEN.FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfo4GeneCodeEN.FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfo4GeneCodeEN.FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfo4GeneCodeEN.DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名
objvViewInfo4GeneCodeEN.KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfo4GeneCodeEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfo4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfo4GeneCodeEN.UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id
objvViewInfo4GeneCodeEN.PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id
objvViewInfo4GeneCodeEN.PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称
objvViewInfo4GeneCodeEN.ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能
objvViewInfo4GeneCodeEN.ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明
objvViewInfo4GeneCodeEN.DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfo4GeneCodeEN.DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfo4GeneCodeEN.FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名
objvViewInfo4GeneCodeEN.FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径
objvViewInfo4GeneCodeEN.MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID
objvViewInfo4GeneCodeEN.ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfo4GeneCodeEN.ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfo4GeneCodeEN.ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfo4GeneCodeEN.InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfo4GeneCodeEN.GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfo4GeneCodeEN.RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数
objvViewInfo4GeneCodeEN.UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvViewInfo4GeneCodeEN.MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表
objvViewInfo4GeneCodeEN.DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表
objvViewInfo4GeneCodeEN.MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字
objvViewInfo4GeneCodeEN.UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfo4GeneCodeEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfo4GeneCodeEN);
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
public static List<clsvViewInfo4GeneCodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvViewInfo4GeneCodeEN> arrObjLst = new List<clsvViewInfo4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
try
{
objvViewInfo4GeneCodeEN.ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id
objvViewInfo4GeneCodeEN.TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfo4GeneCodeEN.TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfo4GeneCodeEN.DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfo4GeneCodeEN.DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfo4GeneCodeEN.VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvViewInfo4GeneCodeEN.ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称
objvViewInfo4GeneCodeEN.ViewTypeCode = Int32.Parse(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewInfo4GeneCodeEN.ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewInfo4GeneCodeEN.ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfo4GeneCodeEN.ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewInfo4GeneCodeEN.FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfo4GeneCodeEN.FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfo4GeneCodeEN.FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfo4GeneCodeEN.DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名
objvViewInfo4GeneCodeEN.KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfo4GeneCodeEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfo4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfo4GeneCodeEN.UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id
objvViewInfo4GeneCodeEN.PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id
objvViewInfo4GeneCodeEN.PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称
objvViewInfo4GeneCodeEN.ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能
objvViewInfo4GeneCodeEN.ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明
objvViewInfo4GeneCodeEN.DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfo4GeneCodeEN.DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfo4GeneCodeEN.FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名
objvViewInfo4GeneCodeEN.FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径
objvViewInfo4GeneCodeEN.MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID
objvViewInfo4GeneCodeEN.ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfo4GeneCodeEN.ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfo4GeneCodeEN.ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfo4GeneCodeEN.InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfo4GeneCodeEN.GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfo4GeneCodeEN.RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数
objvViewInfo4GeneCodeEN.UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvViewInfo4GeneCodeEN.MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表
objvViewInfo4GeneCodeEN.DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表
objvViewInfo4GeneCodeEN.MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字
objvViewInfo4GeneCodeEN.UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfo4GeneCodeEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfo4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewInfo4GeneCodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvViewInfo4GeneCodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvViewInfo4GeneCodeEN> arrObjLst = new List<clsvViewInfo4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
try
{
objvViewInfo4GeneCodeEN.ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id
objvViewInfo4GeneCodeEN.TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfo4GeneCodeEN.TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfo4GeneCodeEN.DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfo4GeneCodeEN.DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfo4GeneCodeEN.VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvViewInfo4GeneCodeEN.ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称
objvViewInfo4GeneCodeEN.ViewTypeCode = Int32.Parse(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewInfo4GeneCodeEN.ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewInfo4GeneCodeEN.ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfo4GeneCodeEN.ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewInfo4GeneCodeEN.FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfo4GeneCodeEN.FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfo4GeneCodeEN.FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfo4GeneCodeEN.DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名
objvViewInfo4GeneCodeEN.KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfo4GeneCodeEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfo4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfo4GeneCodeEN.UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id
objvViewInfo4GeneCodeEN.PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id
objvViewInfo4GeneCodeEN.PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称
objvViewInfo4GeneCodeEN.ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能
objvViewInfo4GeneCodeEN.ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明
objvViewInfo4GeneCodeEN.DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfo4GeneCodeEN.DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfo4GeneCodeEN.FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名
objvViewInfo4GeneCodeEN.FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径
objvViewInfo4GeneCodeEN.MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID
objvViewInfo4GeneCodeEN.ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfo4GeneCodeEN.ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfo4GeneCodeEN.ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfo4GeneCodeEN.InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfo4GeneCodeEN.GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfo4GeneCodeEN.RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数
objvViewInfo4GeneCodeEN.UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvViewInfo4GeneCodeEN.MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表
objvViewInfo4GeneCodeEN.DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表
objvViewInfo4GeneCodeEN.MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字
objvViewInfo4GeneCodeEN.UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfo4GeneCodeEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfo4GeneCodeEN);
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
public static List<clsvViewInfo4GeneCodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvViewInfo4GeneCodeEN> arrObjLst = new List<clsvViewInfo4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
try
{
objvViewInfo4GeneCodeEN.ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id
objvViewInfo4GeneCodeEN.TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfo4GeneCodeEN.TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfo4GeneCodeEN.DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfo4GeneCodeEN.DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfo4GeneCodeEN.VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvViewInfo4GeneCodeEN.ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称
objvViewInfo4GeneCodeEN.ViewTypeCode = Int32.Parse(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewInfo4GeneCodeEN.ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewInfo4GeneCodeEN.ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfo4GeneCodeEN.ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewInfo4GeneCodeEN.FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfo4GeneCodeEN.FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfo4GeneCodeEN.FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfo4GeneCodeEN.DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名
objvViewInfo4GeneCodeEN.KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfo4GeneCodeEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfo4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfo4GeneCodeEN.UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id
objvViewInfo4GeneCodeEN.PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id
objvViewInfo4GeneCodeEN.PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称
objvViewInfo4GeneCodeEN.ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能
objvViewInfo4GeneCodeEN.ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明
objvViewInfo4GeneCodeEN.DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfo4GeneCodeEN.DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfo4GeneCodeEN.FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名
objvViewInfo4GeneCodeEN.FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径
objvViewInfo4GeneCodeEN.MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID
objvViewInfo4GeneCodeEN.ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfo4GeneCodeEN.ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfo4GeneCodeEN.ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfo4GeneCodeEN.InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfo4GeneCodeEN.GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfo4GeneCodeEN.RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数
objvViewInfo4GeneCodeEN.UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvViewInfo4GeneCodeEN.MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表
objvViewInfo4GeneCodeEN.DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表
objvViewInfo4GeneCodeEN.MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字
objvViewInfo4GeneCodeEN.UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfo4GeneCodeEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfo4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewInfo4GeneCodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvViewInfo4GeneCodeEN> arrObjLst = new List<clsvViewInfo4GeneCodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
try
{
objvViewInfo4GeneCodeEN.ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id
objvViewInfo4GeneCodeEN.TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfo4GeneCodeEN.TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfo4GeneCodeEN.DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfo4GeneCodeEN.DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfo4GeneCodeEN.VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvViewInfo4GeneCodeEN.ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称
objvViewInfo4GeneCodeEN.ViewTypeCode = Int32.Parse(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewInfo4GeneCodeEN.ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewInfo4GeneCodeEN.ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfo4GeneCodeEN.ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewInfo4GeneCodeEN.FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfo4GeneCodeEN.FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfo4GeneCodeEN.FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfo4GeneCodeEN.DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名
objvViewInfo4GeneCodeEN.KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfo4GeneCodeEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfo4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfo4GeneCodeEN.UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id
objvViewInfo4GeneCodeEN.PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id
objvViewInfo4GeneCodeEN.PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称
objvViewInfo4GeneCodeEN.ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能
objvViewInfo4GeneCodeEN.ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明
objvViewInfo4GeneCodeEN.DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfo4GeneCodeEN.DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfo4GeneCodeEN.FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名
objvViewInfo4GeneCodeEN.FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径
objvViewInfo4GeneCodeEN.MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID
objvViewInfo4GeneCodeEN.ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfo4GeneCodeEN.ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfo4GeneCodeEN.ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfo4GeneCodeEN.InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfo4GeneCodeEN.GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfo4GeneCodeEN.RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数
objvViewInfo4GeneCodeEN.UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvViewInfo4GeneCodeEN.MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表
objvViewInfo4GeneCodeEN.DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表
objvViewInfo4GeneCodeEN.MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字
objvViewInfo4GeneCodeEN.UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfo4GeneCodeEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfo4GeneCodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvViewInfo4GeneCode(ref clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN)
{
bool bolResult = vViewInfo4GeneCodeDA.GetvViewInfo4GeneCode(ref objvViewInfo4GeneCodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewInfo4GeneCodeEN GetObjByViewId(string strViewId)
{
if (strViewId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strViewId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strViewId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strViewId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = vViewInfo4GeneCodeDA.GetObjByViewId(strViewId);
return objvViewInfo4GeneCodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvViewInfo4GeneCodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = vViewInfo4GeneCodeDA.GetFirstObj(strWhereCond);
 return objvViewInfo4GeneCodeEN;
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
public static clsvViewInfo4GeneCodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = vViewInfo4GeneCodeDA.GetObjByDataRow(objRow);
 return objvViewInfo4GeneCodeEN;
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
public static clsvViewInfo4GeneCodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = vViewInfo4GeneCodeDA.GetObjByDataRow(objRow);
 return objvViewInfo4GeneCodeEN;
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
 /// <param name = "strViewId">所给的关键字</param>
 /// <param name = "lstvViewInfo4GeneCodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewInfo4GeneCodeEN GetObjByViewIdFromList(string strViewId, List<clsvViewInfo4GeneCodeEN> lstvViewInfo4GeneCodeObjLst)
{
foreach (clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN in lstvViewInfo4GeneCodeObjLst)
{
if (objvViewInfo4GeneCodeEN.ViewId == strViewId)
{
return objvViewInfo4GeneCodeEN;
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
 string strViewId;
 try
 {
 strViewId = new clsvViewInfo4GeneCodeDA().GetFirstID(strWhereCond);
 return strViewId;
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
 arrList = vViewInfo4GeneCodeDA.GetID(strWhereCond);
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
bool bolIsExist = vViewInfo4GeneCodeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strViewId)
{
if (string.IsNullOrEmpty(strViewId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strViewId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vViewInfo4GeneCodeDA.IsExist(strViewId);
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
 bolIsExist = clsvViewInfo4GeneCodeDA.IsExistTable();
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
 bolIsExist = vViewInfo4GeneCodeDA.IsExistTable(strTabName);
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
 /// <param name = "objvViewInfo4GeneCodeEN">源简化对象</param>
 public static void SetUpdFlag(clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN)
{
try
{
objvViewInfo4GeneCodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvViewInfo4GeneCodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convViewInfo4GeneCode.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.ViewId = objvViewInfo4GeneCodeEN.ViewId; //界面Id
}
if (arrFldSet.Contains(convViewInfo4GeneCode.TitleStyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.TitleStyleId = objvViewInfo4GeneCodeEN.TitleStyleId == "[null]" ? null :  objvViewInfo4GeneCodeEN.TitleStyleId; //标题类型Id
}
if (arrFldSet.Contains(convViewInfo4GeneCode.TitleStyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.TitleStyleName = objvViewInfo4GeneCodeEN.TitleStyleName == "[null]" ? null :  objvViewInfo4GeneCodeEN.TitleStyleName; //标题类型名
}
if (arrFldSet.Contains(convViewInfo4GeneCode.DgStyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.DgStyleId = objvViewInfo4GeneCodeEN.DgStyleId == "[null]" ? null :  objvViewInfo4GeneCodeEN.DgStyleId; //DG模式ID
}
if (arrFldSet.Contains(convViewInfo4GeneCode.DgStyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.DgStyleName = objvViewInfo4GeneCodeEN.DgStyleName == "[null]" ? null :  objvViewInfo4GeneCodeEN.DgStyleName; //DG模式名
}
if (arrFldSet.Contains(convViewInfo4GeneCode.VersionGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.VersionGeneCode = objvViewInfo4GeneCodeEN.VersionGeneCode == "[null]" ? null :  objvViewInfo4GeneCodeEN.VersionGeneCode; //生成代码版本
}
if (arrFldSet.Contains(convViewInfo4GeneCode.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.ViewName = objvViewInfo4GeneCodeEN.ViewName; //界面名称
}
if (arrFldSet.Contains(convViewInfo4GeneCode.ViewTypeCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.ViewTypeCode = objvViewInfo4GeneCodeEN.ViewTypeCode; //界面类型码
}
if (arrFldSet.Contains(convViewInfo4GeneCode.ViewTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.ViewTypeName = objvViewInfo4GeneCodeEN.ViewTypeName == "[null]" ? null :  objvViewInfo4GeneCodeEN.ViewTypeName; //界面类型名称
}
if (arrFldSet.Contains(convViewInfo4GeneCode.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.ApplicationTypeId = objvViewInfo4GeneCodeEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convViewInfo4GeneCode.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.ApplicationTypeName = objvViewInfo4GeneCodeEN.ApplicationTypeName == "[null]" ? null :  objvViewInfo4GeneCodeEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(convViewInfo4GeneCode.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.FuncModuleAgcId = objvViewInfo4GeneCodeEN.FuncModuleAgcId == "[null]" ? null :  objvViewInfo4GeneCodeEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convViewInfo4GeneCode.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.FuncModuleName = objvViewInfo4GeneCodeEN.FuncModuleName == "[null]" ? null :  objvViewInfo4GeneCodeEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convViewInfo4GeneCode.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.FuncModuleEnName = objvViewInfo4GeneCodeEN.FuncModuleEnName == "[null]" ? null :  objvViewInfo4GeneCodeEN.FuncModuleEnName; //功能模块英文名称
}
if (arrFldSet.Contains(convViewInfo4GeneCode.DataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.DataBaseName = objvViewInfo4GeneCodeEN.DataBaseName == "[null]" ? null :  objvViewInfo4GeneCodeEN.DataBaseName; //数据库名
}
if (arrFldSet.Contains(convViewInfo4GeneCode.KeyForMainTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.KeyForMainTab = objvViewInfo4GeneCodeEN.KeyForMainTab == "[null]" ? null :  objvViewInfo4GeneCodeEN.KeyForMainTab; //主表关键字
}
if (arrFldSet.Contains(convViewInfo4GeneCode.KeyForDetailTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.KeyForDetailTab = objvViewInfo4GeneCodeEN.KeyForDetailTab == "[null]" ? null :  objvViewInfo4GeneCodeEN.KeyForDetailTab; //明细表关键字
}
if (arrFldSet.Contains(convViewInfo4GeneCode.IsNeedSort, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.IsNeedSort = objvViewInfo4GeneCodeEN.IsNeedSort; //是否需要排序
}
if (arrFldSet.Contains(convViewInfo4GeneCode.IsNeedTransCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.IsNeedTransCode = objvViewInfo4GeneCodeEN.IsNeedTransCode; //是否需要转换代码
}
if (arrFldSet.Contains(convViewInfo4GeneCode.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.UserId = objvViewInfo4GeneCodeEN.UserId; //用户Id
}
if (arrFldSet.Contains(convViewInfo4GeneCode.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.PrjId = objvViewInfo4GeneCodeEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convViewInfo4GeneCode.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.PrjName = objvViewInfo4GeneCodeEN.PrjName == "[null]" ? null :  objvViewInfo4GeneCodeEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convViewInfo4GeneCode.ViewFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.ViewFunction = objvViewInfo4GeneCodeEN.ViewFunction == "[null]" ? null :  objvViewInfo4GeneCodeEN.ViewFunction; //界面功能
}
if (arrFldSet.Contains(convViewInfo4GeneCode.ViewDetail, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.ViewDetail = objvViewInfo4GeneCodeEN.ViewDetail == "[null]" ? null :  objvViewInfo4GeneCodeEN.ViewDetail; //界面说明
}
if (arrFldSet.Contains(convViewInfo4GeneCode.DefaMenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.DefaMenuName = objvViewInfo4GeneCodeEN.DefaMenuName; //缺省菜单名
}
if (arrFldSet.Contains(convViewInfo4GeneCode.DetailTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.DetailTabId = objvViewInfo4GeneCodeEN.DetailTabId == "[null]" ? null :  objvViewInfo4GeneCodeEN.DetailTabId; //明细表ID
}
if (arrFldSet.Contains(convViewInfo4GeneCode.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.FileName = objvViewInfo4GeneCodeEN.FileName; //文件名
}
if (arrFldSet.Contains(convViewInfo4GeneCode.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.FilePath = objvViewInfo4GeneCodeEN.FilePath; //文件路径
}
if (arrFldSet.Contains(convViewInfo4GeneCode.MainTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.MainTabId = objvViewInfo4GeneCodeEN.MainTabId == "[null]" ? null :  objvViewInfo4GeneCodeEN.MainTabId; //主表ID
}
if (arrFldSet.Contains(convViewInfo4GeneCode.ViewCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.ViewCnName = objvViewInfo4GeneCodeEN.ViewCnName; //视图中文名
}
if (arrFldSet.Contains(convViewInfo4GeneCode.ViewGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.ViewGroupId = objvViewInfo4GeneCodeEN.ViewGroupId == "[null]" ? null :  objvViewInfo4GeneCodeEN.ViewGroupId; //界面组ID
}
if (arrFldSet.Contains(convViewInfo4GeneCode.ViewGroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.ViewGroupName = objvViewInfo4GeneCodeEN.ViewGroupName == "[null]" ? null :  objvViewInfo4GeneCodeEN.ViewGroupName; //界面组名称
}
if (arrFldSet.Contains(convViewInfo4GeneCode.InSqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.InSqlDsTypeId = objvViewInfo4GeneCodeEN.InSqlDsTypeId == "[null]" ? null :  objvViewInfo4GeneCodeEN.InSqlDsTypeId; //输入数据源类型
}
if (arrFldSet.Contains(convViewInfo4GeneCode.OutSqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objvViewInfo4GeneCodeEN.OutSqlDsTypeId == "[null]" ? null :  objvViewInfo4GeneCodeEN.OutSqlDsTypeId; //输出数据源类型
}
if (arrFldSet.Contains(convViewInfo4GeneCode.GeneCodeDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.GeneCodeDate = objvViewInfo4GeneCodeEN.GeneCodeDate == "[null]" ? null :  objvViewInfo4GeneCodeEN.GeneCodeDate; //生成代码日期
}
if (arrFldSet.Contains(convViewInfo4GeneCode.RegionNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.RegionNum = objvViewInfo4GeneCodeEN.RegionNum; //区域数
}
if (arrFldSet.Contains(convViewInfo4GeneCode.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.UpdDate = objvViewInfo4GeneCodeEN.UpdDate == "[null]" ? null :  objvViewInfo4GeneCodeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convViewInfo4GeneCode.MainTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.MainTabName = objvViewInfo4GeneCodeEN.MainTabName == "[null]" ? null :  objvViewInfo4GeneCodeEN.MainTabName; //主表
}
if (arrFldSet.Contains(convViewInfo4GeneCode.DetailTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.DetailTabName = objvViewInfo4GeneCodeEN.DetailTabName == "[null]" ? null :  objvViewInfo4GeneCodeEN.DetailTabName; //详细表
}
if (arrFldSet.Contains(convViewInfo4GeneCode.MainTabKeyFld, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.MainTabKeyFld = objvViewInfo4GeneCodeEN.MainTabKeyFld == "[null]" ? null :  objvViewInfo4GeneCodeEN.MainTabKeyFld; //主表关键字
}
if (arrFldSet.Contains(convViewInfo4GeneCode.DetailTabKeyFld, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.DetailTabKeyFld = objvViewInfo4GeneCodeEN.DetailTabKeyFld == "[null]" ? null :  objvViewInfo4GeneCodeEN.DetailTabKeyFld; //详细表关键字
}
if (arrFldSet.Contains(convViewInfo4GeneCode.UserId4GeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfo4GeneCodeEN.UserId4GeneCode = objvViewInfo4GeneCodeEN.UserId4GeneCode == "[null]" ? null :  objvViewInfo4GeneCodeEN.UserId4GeneCode; //UserId4GeneCode
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
 /// <param name = "objvViewInfo4GeneCodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN)
{
try
{
if (objvViewInfo4GeneCodeEN.TitleStyleId == "[null]") objvViewInfo4GeneCodeEN.TitleStyleId = null; //标题类型Id
if (objvViewInfo4GeneCodeEN.TitleStyleName == "[null]") objvViewInfo4GeneCodeEN.TitleStyleName = null; //标题类型名
if (objvViewInfo4GeneCodeEN.DgStyleId == "[null]") objvViewInfo4GeneCodeEN.DgStyleId = null; //DG模式ID
if (objvViewInfo4GeneCodeEN.DgStyleName == "[null]") objvViewInfo4GeneCodeEN.DgStyleName = null; //DG模式名
if (objvViewInfo4GeneCodeEN.VersionGeneCode == "[null]") objvViewInfo4GeneCodeEN.VersionGeneCode = null; //生成代码版本
if (objvViewInfo4GeneCodeEN.ViewTypeName == "[null]") objvViewInfo4GeneCodeEN.ViewTypeName = null; //界面类型名称
if (objvViewInfo4GeneCodeEN.ApplicationTypeName == "[null]") objvViewInfo4GeneCodeEN.ApplicationTypeName = null; //应用程序类型名称
if (objvViewInfo4GeneCodeEN.FuncModuleAgcId == "[null]") objvViewInfo4GeneCodeEN.FuncModuleAgcId = null; //功能模块Id
if (objvViewInfo4GeneCodeEN.FuncModuleName == "[null]") objvViewInfo4GeneCodeEN.FuncModuleName = null; //功能模块名称
if (objvViewInfo4GeneCodeEN.FuncModuleEnName == "[null]") objvViewInfo4GeneCodeEN.FuncModuleEnName = null; //功能模块英文名称
if (objvViewInfo4GeneCodeEN.DataBaseName == "[null]") objvViewInfo4GeneCodeEN.DataBaseName = null; //数据库名
if (objvViewInfo4GeneCodeEN.KeyForMainTab == "[null]") objvViewInfo4GeneCodeEN.KeyForMainTab = null; //主表关键字
if (objvViewInfo4GeneCodeEN.KeyForDetailTab == "[null]") objvViewInfo4GeneCodeEN.KeyForDetailTab = null; //明细表关键字
if (objvViewInfo4GeneCodeEN.PrjName == "[null]") objvViewInfo4GeneCodeEN.PrjName = null; //工程名称
if (objvViewInfo4GeneCodeEN.ViewFunction == "[null]") objvViewInfo4GeneCodeEN.ViewFunction = null; //界面功能
if (objvViewInfo4GeneCodeEN.ViewDetail == "[null]") objvViewInfo4GeneCodeEN.ViewDetail = null; //界面说明
if (objvViewInfo4GeneCodeEN.DetailTabId == "[null]") objvViewInfo4GeneCodeEN.DetailTabId = null; //明细表ID
if (objvViewInfo4GeneCodeEN.MainTabId == "[null]") objvViewInfo4GeneCodeEN.MainTabId = null; //主表ID
if (objvViewInfo4GeneCodeEN.ViewGroupId == "[null]") objvViewInfo4GeneCodeEN.ViewGroupId = null; //界面组ID
if (objvViewInfo4GeneCodeEN.ViewGroupName == "[null]") objvViewInfo4GeneCodeEN.ViewGroupName = null; //界面组名称
if (objvViewInfo4GeneCodeEN.InSqlDsTypeId == "[null]") objvViewInfo4GeneCodeEN.InSqlDsTypeId = null; //输入数据源类型
if (objvViewInfo4GeneCodeEN.OutSqlDsTypeId == "[null]") objvViewInfo4GeneCodeEN.OutSqlDsTypeId = null; //输出数据源类型
if (objvViewInfo4GeneCodeEN.GeneCodeDate == "[null]") objvViewInfo4GeneCodeEN.GeneCodeDate = null; //生成代码日期
if (objvViewInfo4GeneCodeEN.UpdDate == "[null]") objvViewInfo4GeneCodeEN.UpdDate = null; //修改日期
if (objvViewInfo4GeneCodeEN.MainTabName == "[null]") objvViewInfo4GeneCodeEN.MainTabName = null; //主表
if (objvViewInfo4GeneCodeEN.DetailTabName == "[null]") objvViewInfo4GeneCodeEN.DetailTabName = null; //详细表
if (objvViewInfo4GeneCodeEN.MainTabKeyFld == "[null]") objvViewInfo4GeneCodeEN.MainTabKeyFld = null; //主表关键字
if (objvViewInfo4GeneCodeEN.DetailTabKeyFld == "[null]") objvViewInfo4GeneCodeEN.DetailTabKeyFld = null; //详细表关键字
if (objvViewInfo4GeneCodeEN.UserId4GeneCode == "[null]") objvViewInfo4GeneCodeEN.UserId4GeneCode = null; //UserId4GeneCode
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
public static void CheckProperty4Condition(clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN)
{
 vViewInfo4GeneCodeDA.CheckProperty4Condition(objvViewInfo4GeneCodeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_ViewId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convViewInfo4GeneCode.ViewId); 
List<clsvViewInfo4GeneCodeEN> arrObjLst = clsvViewInfo4GeneCodeBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_ViewId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vViewInfo4GeneCode]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convViewInfo4GeneCode.ViewId); 
IEnumerable<clsvViewInfo4GeneCodeEN> arrObjLst = clsvViewInfo4GeneCodeBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = convViewInfo4GeneCode.ViewId;
objDDL.DataTextField = convViewInfo4GeneCode.ViewName;
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
public static void BindDdl_ViewIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vViewInfo4GeneCode]...","0");
List<clsvViewInfo4GeneCodeEN> arrvViewInfo4GeneCodeObjLst = GetAllvViewInfo4GeneCodeObjLstCache(strPrjId); 
objDDL.DataValueField = convViewInfo4GeneCode.ViewId;
objDDL.DataTextField = convViewInfo4GeneCode.ViewName;
objDDL.DataSource = arrvViewInfo4GeneCodeObjLst;
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
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsLog4GeneViewCodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsLog4GeneViewCodeBL没有刷新缓存机制(clsLog4GeneViewCodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewId");
//if (arrvViewInfo4GeneCodeObjLstCache == null)
//{
//arrvViewInfo4GeneCodeObjLstCache = vViewInfo4GeneCodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strViewId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewInfo4GeneCodeEN GetObjByViewIdCache(string strViewId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvViewInfo4GeneCodeEN._CurrTabName, strPrjId);
List<clsvViewInfo4GeneCodeEN> arrvViewInfo4GeneCodeObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewInfo4GeneCodeEN> arrvViewInfo4GeneCodeObjLst_Sel =
arrvViewInfo4GeneCodeObjLstCache
.Where(x=> x.ViewId == strViewId 
);
if (arrvViewInfo4GeneCodeObjLst_Sel.Count() == 0)
{
   clsvViewInfo4GeneCodeEN obj = clsvViewInfo4GeneCodeBL.GetObjByViewId(strViewId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strViewId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvViewInfo4GeneCodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetViewNameByViewIdCache(string strViewId, string strPrjId)
{
if (string.IsNullOrEmpty(strViewId) == true) return "";
//获取缓存中的对象列表
clsvViewInfo4GeneCodeEN objvViewInfo4GeneCode = GetObjByViewIdCache(strViewId, strPrjId);
if (objvViewInfo4GeneCode == null) return "";
return objvViewInfo4GeneCode.ViewName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByViewIdCache(string strViewId, string strPrjId)
{
if (string.IsNullOrEmpty(strViewId) == true) return "";
//获取缓存中的对象列表
clsvViewInfo4GeneCodeEN objvViewInfo4GeneCode = GetObjByViewIdCache(strViewId, strPrjId);
if (objvViewInfo4GeneCode == null) return "";
return objvViewInfo4GeneCode.ViewName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewInfo4GeneCodeEN> GetAllvViewInfo4GeneCodeObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvViewInfo4GeneCodeEN> arrvViewInfo4GeneCodeObjLstCache = GetObjLstCache(strPrjId); 
return arrvViewInfo4GeneCodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewInfo4GeneCodeEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvViewInfo4GeneCodeEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvViewInfo4GeneCodeEN> arrvViewInfo4GeneCodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvViewInfo4GeneCodeObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvViewInfo4GeneCodeEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvViewInfo4GeneCodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvViewInfo4GeneCodeEN._RefreshTimeLst.Count == 0) return "";
return clsvViewInfo4GeneCodeEN._RefreshTimeLst[clsvViewInfo4GeneCodeEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strViewId, string strPrjId)
{
if (strInFldName != convViewInfo4GeneCode.ViewId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convViewInfo4GeneCode._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convViewInfo4GeneCode._AttributeName));
throw new Exception(strMsg);
}
var objvViewInfo4GeneCode = clsvViewInfo4GeneCodeBL.GetObjByViewIdCache(strViewId, strPrjId);
if (objvViewInfo4GeneCode == null) return "";
return objvViewInfo4GeneCode[strOutFldName].ToString();
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
int intRecCount = clsvViewInfo4GeneCodeDA.GetRecCount(strTabName);
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
int intRecCount = clsvViewInfo4GeneCodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvViewInfo4GeneCodeDA.GetRecCount();
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
int intRecCount = clsvViewInfo4GeneCodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeCond)
{
 string strPrjId = objvViewInfo4GeneCodeCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvViewInfo4GeneCodeBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvViewInfo4GeneCodeEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewInfo4GeneCodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewInfo4GeneCode._AttributeName)
{
if (objvViewInfo4GeneCodeCond.IsUpdated(strFldName) == false) continue;
if (objvViewInfo4GeneCodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewInfo4GeneCodeCond[strFldName].ToString());
}
else
{
if (objvViewInfo4GeneCodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewInfo4GeneCodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewInfo4GeneCodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewInfo4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewInfo4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewInfo4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewInfo4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewInfo4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewInfo4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewInfo4GeneCodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewInfo4GeneCodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewInfo4GeneCodeCond[strFldName]));
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
 List<string> arrList = clsvViewInfo4GeneCodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vViewInfo4GeneCodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vViewInfo4GeneCodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}