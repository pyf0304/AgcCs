
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewInfoBL
 表名:vViewInfo(00050157)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:04
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
public static class  clsvViewInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewInfoEN GetObj(this K_ViewId_vViewInfo myKey)
{
clsvViewInfoEN objvViewInfoEN = clsvViewInfoBL.vViewInfoDA.GetObjByViewId(myKey.Value);
return objvViewInfoEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewId(this clsvViewInfoEN objvViewInfoEN, string strViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, convViewInfo.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convViewInfo.ViewId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetTitleStyleId(this clsvViewInfoEN objvViewInfoEN, string strTitleStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTitleStyleId, 8, convViewInfo.TitleStyleId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetTitleStyleName(this clsvViewInfoEN objvViewInfoEN, string strTitleStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTitleStyleName, convViewInfo.TitleStyleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTitleStyleName, 20, convViewInfo.TitleStyleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetDgStyleId(this clsvViewInfoEN objvViewInfoEN, string strDgStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDgStyleId, 4, convViewInfo.DgStyleId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetDgStyleName(this clsvViewInfoEN objvViewInfoEN, string strDgStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDgStyleName, convViewInfo.DgStyleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDgStyleName, 30, convViewInfo.DgStyleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewName(this clsvViewInfoEN objvViewInfoEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, convViewInfo.ViewName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, convViewInfo.ViewName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetApplicationTypeSimName(this clsvViewInfoEN objvViewInfoEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convViewInfo.ApplicationTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetFuncModuleAgcId(this clsvViewInfoEN objvViewInfoEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convViewInfo.FuncModuleAgcId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convViewInfo.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convViewInfo.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetFuncModuleName(this clsvViewInfoEN objvViewInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convViewInfo.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convViewInfo.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetFuncModuleEnName(this clsvViewInfoEN objvViewInfoEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convViewInfo.FuncModuleEnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetDataBaseName(this clsvViewInfoEN objvViewInfoEN, string strDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convViewInfo.DataBaseName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetKeyForMainTab(this clsvViewInfoEN objvViewInfoEN, string strKeyForMainTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyForMainTab, 50, convViewInfo.KeyForMainTab);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetKeyForDetailTab(this clsvViewInfoEN objvViewInfoEN, string strKeyForDetailTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyForDetailTab, 50, convViewInfo.KeyForDetailTab);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetUserId(this clsvViewInfoEN objvViewInfoEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convViewInfo.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convViewInfo.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetPrjId(this clsvViewInfoEN objvViewInfoEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convViewInfo.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewInfo.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewInfo.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetPrjName(this clsvViewInfoEN objvViewInfoEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convViewInfo.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convViewInfo.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewFunction(this clsvViewInfoEN objvViewInfoEN, string strViewFunction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewFunction, 100, convViewInfo.ViewFunction);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewDetail(this clsvViewInfoEN objvViewInfoEN, string strViewDetail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewDetail, 1000, convViewInfo.ViewDetail);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetDefaMenuName(this clsvViewInfoEN objvViewInfoEN, string strDefaMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaMenuName, convViewInfo.DefaMenuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaMenuName, 100, convViewInfo.DefaMenuName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetDetailTabId(this clsvViewInfoEN objvViewInfoEN, string strDetailTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDetailTabId, 8, convViewInfo.DetailTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetFileName(this clsvViewInfoEN objvViewInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convViewInfo.FileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, convViewInfo.FileName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetFilePath(this clsvViewInfoEN objvViewInfoEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convViewInfo.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, convViewInfo.FilePath);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetMainTabId(this clsvViewInfoEN objvViewInfoEN, string strMainTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMainTabId, 8, convViewInfo.MainTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewCnName(this clsvViewInfoEN objvViewInfoEN, string strViewCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewCnName, 100, convViewInfo.ViewCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewGroupId(this clsvViewInfoEN objvViewInfoEN, string strViewGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewGroupId, convViewInfo.ViewGroupId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewGroupId, 8, convViewInfo.ViewGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewGroupId, 8, convViewInfo.ViewGroupId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewGroupName(this clsvViewInfoEN objvViewInfoEN, string strViewGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewGroupName, convViewInfo.ViewGroupName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewGroupName, 30, convViewInfo.ViewGroupName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetInSqlDsTypeId(this clsvViewInfoEN objvViewInfoEN, string strInSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInSqlDsTypeId, 2, convViewInfo.InSqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInSqlDsTypeId, 2, convViewInfo.InSqlDsTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetOutSqlDsTypeId(this clsvViewInfoEN objvViewInfoEN, string strOutSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutSqlDsTypeId, 2, convViewInfo.OutSqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOutSqlDsTypeId, 2, convViewInfo.OutSqlDsTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetGeneCodeDate(this clsvViewInfoEN objvViewInfoEN, string strGeneCodeDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convViewInfo.GeneCodeDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetTaskId(this clsvViewInfoEN objvViewInfoEN, string strTaskId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTaskId, 16, convViewInfo.TaskId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTaskId, 16, convViewInfo.TaskId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetKeyId4Test(this clsvViewInfoEN objvViewInfoEN, string strKeyId4Test, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyId4Test, 50, convViewInfo.KeyId4Test);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewMasterId(this clsvViewInfoEN objvViewInfoEN, string strViewMasterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewMasterId, 8, convViewInfo.ViewMasterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewMasterId, 8, convViewInfo.ViewMasterId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetViewMasterName(this clsvViewInfoEN objvViewInfoEN, string strViewMasterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewMasterName, 50, convViewInfo.ViewMasterName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetUpdDate(this clsvViewInfoEN objvViewInfoEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewInfo.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetUpdUserId(this clsvViewInfoEN objvViewInfoEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convViewInfo.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetMemo(this clsvViewInfoEN objvViewInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewInfo.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetMainTabName(this clsvViewInfoEN objvViewInfoEN, string strMainTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMainTabName, 100, convViewInfo.MainTabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetDetailTabName(this clsvViewInfoEN objvViewInfoEN, string strDetailTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDetailTabName, 40, convViewInfo.DetailTabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetMainTabKeyFld(this clsvViewInfoEN objvViewInfoEN, string strMainTabKeyFld, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMainTabKeyFld, 50, convViewInfo.MainTabKeyFld);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetRegionNum(this clsvViewInfoEN objvViewInfoEN, int? intRegionNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewInfoEN SetDetailTabKeyFld(this clsvViewInfoEN objvViewInfoEN, string strDetailTabKeyFld, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDetailTabKeyFld, 50, convViewInfo.DetailTabKeyFld);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvViewInfoENS">源对象</param>
 /// <param name = "objvViewInfoENT">目标对象</param>
 public static void CopyTo(this clsvViewInfoEN objvViewInfoENS, clsvViewInfoEN objvViewInfoENT)
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
 /// <param name = "objvViewInfoENS">源对象</param>
 /// <returns>目标对象=>clsvViewInfoEN:objvViewInfoENT</returns>
 public static clsvViewInfoEN CopyTo(this clsvViewInfoEN objvViewInfoENS)
{
try
{
 clsvViewInfoEN objvViewInfoENT = new clsvViewInfoEN()
{
ViewId = objvViewInfoENS.ViewId, //界面Id
TitleStyleId = objvViewInfoENS.TitleStyleId, //标题类型Id
TitleStyleName = objvViewInfoENS.TitleStyleName, //标题类型名
DgStyleId = objvViewInfoENS.DgStyleId, //DG模式ID
DgStyleName = objvViewInfoENS.DgStyleName, //DG模式名
ViewName = objvViewInfoENS.ViewName, //界面名称
ApplicationTypeId = objvViewInfoENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeSimName = objvViewInfoENS.ApplicationTypeSimName, //应用程序类型简称
FuncModuleAgcId = objvViewInfoENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvViewInfoENS.FuncModuleName, //功能模块名称
FuncModuleEnName = objvViewInfoENS.FuncModuleEnName, //功能模块英文名称
DataBaseName = objvViewInfoENS.DataBaseName, //数据库名
KeyForMainTab = objvViewInfoENS.KeyForMainTab, //主表关键字
KeyForDetailTab = objvViewInfoENS.KeyForDetailTab, //明细表关键字
IsNeedSort = objvViewInfoENS.IsNeedSort, //是否需要排序
IsNeedTransCode = objvViewInfoENS.IsNeedTransCode, //是否需要转换代码
IsNeedSetExportFld = objvViewInfoENS.IsNeedSetExportFld, //是否需要设置导出字段
UserId = objvViewInfoENS.UserId, //用户Id
PrjId = objvViewInfoENS.PrjId, //工程Id
PrjName = objvViewInfoENS.PrjName, //工程名称
ViewFunction = objvViewInfoENS.ViewFunction, //界面功能
ViewDetail = objvViewInfoENS.ViewDetail, //界面说明
DefaMenuName = objvViewInfoENS.DefaMenuName, //缺省菜单名
DetailTabId = objvViewInfoENS.DetailTabId, //明细表ID
FileName = objvViewInfoENS.FileName, //文件名
FilePath = objvViewInfoENS.FilePath, //文件路径
MainTabId = objvViewInfoENS.MainTabId, //主表ID
ViewCnName = objvViewInfoENS.ViewCnName, //视图中文名
ViewGroupId = objvViewInfoENS.ViewGroupId, //界面组ID
ViewGroupName = objvViewInfoENS.ViewGroupName, //界面组名称
InSqlDsTypeId = objvViewInfoENS.InSqlDsTypeId, //输入数据源类型
OutSqlDsTypeId = objvViewInfoENS.OutSqlDsTypeId, //输出数据源类型
GeneCodeDate = objvViewInfoENS.GeneCodeDate, //生成代码日期
TaskId = objvViewInfoENS.TaskId, //任务Id
KeyId4Test = objvViewInfoENS.KeyId4Test, //测试关键字Id
ViewMasterId = objvViewInfoENS.ViewMasterId, //界面母版Id
ViewMasterName = objvViewInfoENS.ViewMasterName, //界面母版名
UpdDate = objvViewInfoENS.UpdDate, //修改日期
UpdUserId = objvViewInfoENS.UpdUserId, //修改用户Id
Memo = objvViewInfoENS.Memo, //说明
MainTabName = objvViewInfoENS.MainTabName, //主表
DetailTabName = objvViewInfoENS.DetailTabName, //详细表
MainTabKeyFld = objvViewInfoENS.MainTabKeyFld, //主表关键字
RegionNum = objvViewInfoENS.RegionNum, //区域数
DetailTabKeyFld = objvViewInfoENS.DetailTabKeyFld, //详细表关键字
};
 return objvViewInfoENT;
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
public static void CheckProperty4Condition(this clsvViewInfoEN objvViewInfoEN)
{
 clsvViewInfoBL.vViewInfoDA.CheckProperty4Condition(objvViewInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vViewInfo
{
public virtual bool UpdRelaTabDate(string strViewId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v界面(vViewInfo)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvViewInfoBL
{
public static RelatedActions_vViewInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvViewInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvViewInfoDA vViewInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvViewInfoDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvViewInfoBL()
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
if (string.IsNullOrEmpty(clsvViewInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewInfoEN._ConnectString);
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
public static DataTable GetDataTable_vViewInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewInfoDA.GetDataTable_vViewInfo(strWhereCond);
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
objDT = vViewInfoDA.GetDataTable(strWhereCond);
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
objDT = vViewInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vViewInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vViewInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vViewInfoDA.GetDataTable_Top(objTopPara);
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
objDT = vViewInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vViewInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vViewInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvViewInfoEN> GetObjLstByViewIdLst(List<string> arrViewIdLst)
{
List<clsvViewInfoEN> arrObjLst = new List<clsvViewInfoEN>(); 
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
	clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN();
try
{
objvViewInfoEN.ViewId = objRow[convViewInfo.ViewId].ToString().Trim(); //界面Id
objvViewInfoEN.TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfoEN.TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfoEN.DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfoEN.DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfoEN.ViewName = objRow[convViewInfo.ViewName].ToString().Trim(); //界面名称
objvViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfoEN.ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewInfoEN.FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfoEN.FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfoEN.FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfoEN.DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(); //数据库名
objvViewInfoEN.KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfoEN.KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objvViewInfoEN.UserId = objRow[convViewInfo.UserId].ToString().Trim(); //用户Id
objvViewInfoEN.PrjId = objRow[convViewInfo.PrjId].ToString().Trim(); //工程Id
objvViewInfoEN.PrjName = objRow[convViewInfo.PrjName].ToString().Trim(); //工程名称
objvViewInfoEN.ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(); //界面功能
objvViewInfoEN.ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(); //界面说明
objvViewInfoEN.DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfoEN.DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfoEN.FileName = objRow[convViewInfo.FileName].ToString().Trim(); //文件名
objvViewInfoEN.FilePath = objRow[convViewInfo.FilePath].ToString().Trim(); //文件路径
objvViewInfoEN.MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(); //主表ID
objvViewInfoEN.ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfoEN.ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfoEN.ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfoEN.InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfoEN.OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfoEN.GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfoEN.TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(); //任务Id
objvViewInfoEN.KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewInfoEN.ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewInfoEN.ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名
objvViewInfoEN.UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(); //修改日期
objvViewInfoEN.UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvViewInfoEN.Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(); //说明
objvViewInfoEN.MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(); //主表
objvViewInfoEN.DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(); //详细表
objvViewInfoEN.MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfoEN.RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo.RegionNum].ToString().Trim()); //区域数
objvViewInfoEN.DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvViewInfoEN> GetObjLstByViewIdLstCache(List<string> arrViewIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvViewInfoEN._CurrTabName, strPrjId);
List<clsvViewInfoEN> arrvViewInfoObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewInfoEN> arrvViewInfoObjLst_Sel =
arrvViewInfoObjLstCache
.Where(x => arrViewIdLst.Contains(x.ViewId));
return arrvViewInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewInfoEN> GetObjLst(string strWhereCond)
{
List<clsvViewInfoEN> arrObjLst = new List<clsvViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN();
try
{
objvViewInfoEN.ViewId = objRow[convViewInfo.ViewId].ToString().Trim(); //界面Id
objvViewInfoEN.TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfoEN.TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfoEN.DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfoEN.DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfoEN.ViewName = objRow[convViewInfo.ViewName].ToString().Trim(); //界面名称
objvViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfoEN.ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewInfoEN.FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfoEN.FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfoEN.FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfoEN.DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(); //数据库名
objvViewInfoEN.KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfoEN.KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objvViewInfoEN.UserId = objRow[convViewInfo.UserId].ToString().Trim(); //用户Id
objvViewInfoEN.PrjId = objRow[convViewInfo.PrjId].ToString().Trim(); //工程Id
objvViewInfoEN.PrjName = objRow[convViewInfo.PrjName].ToString().Trim(); //工程名称
objvViewInfoEN.ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(); //界面功能
objvViewInfoEN.ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(); //界面说明
objvViewInfoEN.DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfoEN.DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfoEN.FileName = objRow[convViewInfo.FileName].ToString().Trim(); //文件名
objvViewInfoEN.FilePath = objRow[convViewInfo.FilePath].ToString().Trim(); //文件路径
objvViewInfoEN.MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(); //主表ID
objvViewInfoEN.ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfoEN.ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfoEN.ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfoEN.InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfoEN.OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfoEN.GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfoEN.TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(); //任务Id
objvViewInfoEN.KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewInfoEN.ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewInfoEN.ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名
objvViewInfoEN.UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(); //修改日期
objvViewInfoEN.UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvViewInfoEN.Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(); //说明
objvViewInfoEN.MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(); //主表
objvViewInfoEN.DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(); //详细表
objvViewInfoEN.MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfoEN.RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo.RegionNum].ToString().Trim()); //区域数
objvViewInfoEN.DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfoEN);
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
public static List<clsvViewInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewInfoEN> arrObjLst = new List<clsvViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN();
try
{
objvViewInfoEN.ViewId = objRow[convViewInfo.ViewId].ToString().Trim(); //界面Id
objvViewInfoEN.TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfoEN.TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfoEN.DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfoEN.DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfoEN.ViewName = objRow[convViewInfo.ViewName].ToString().Trim(); //界面名称
objvViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfoEN.ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewInfoEN.FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfoEN.FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfoEN.FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfoEN.DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(); //数据库名
objvViewInfoEN.KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfoEN.KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objvViewInfoEN.UserId = objRow[convViewInfo.UserId].ToString().Trim(); //用户Id
objvViewInfoEN.PrjId = objRow[convViewInfo.PrjId].ToString().Trim(); //工程Id
objvViewInfoEN.PrjName = objRow[convViewInfo.PrjName].ToString().Trim(); //工程名称
objvViewInfoEN.ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(); //界面功能
objvViewInfoEN.ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(); //界面说明
objvViewInfoEN.DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfoEN.DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfoEN.FileName = objRow[convViewInfo.FileName].ToString().Trim(); //文件名
objvViewInfoEN.FilePath = objRow[convViewInfo.FilePath].ToString().Trim(); //文件路径
objvViewInfoEN.MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(); //主表ID
objvViewInfoEN.ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfoEN.ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfoEN.ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfoEN.InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfoEN.OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfoEN.GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfoEN.TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(); //任务Id
objvViewInfoEN.KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewInfoEN.ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewInfoEN.ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名
objvViewInfoEN.UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(); //修改日期
objvViewInfoEN.UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvViewInfoEN.Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(); //说明
objvViewInfoEN.MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(); //主表
objvViewInfoEN.DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(); //详细表
objvViewInfoEN.MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfoEN.RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo.RegionNum].ToString().Trim()); //区域数
objvViewInfoEN.DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvViewInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvViewInfoEN> GetSubObjLstCache(clsvViewInfoEN objvViewInfoCond)
{
 string strPrjId = objvViewInfoCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvViewInfoBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvViewInfoEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewInfo._AttributeName)
{
if (objvViewInfoCond.IsUpdated(strFldName) == false) continue;
if (objvViewInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewInfoCond[strFldName].ToString());
}
else
{
if (objvViewInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewInfoCond[strFldName]));
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
public static List<clsvViewInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvViewInfoEN> arrObjLst = new List<clsvViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN();
try
{
objvViewInfoEN.ViewId = objRow[convViewInfo.ViewId].ToString().Trim(); //界面Id
objvViewInfoEN.TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfoEN.TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfoEN.DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfoEN.DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfoEN.ViewName = objRow[convViewInfo.ViewName].ToString().Trim(); //界面名称
objvViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfoEN.ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewInfoEN.FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfoEN.FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfoEN.FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfoEN.DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(); //数据库名
objvViewInfoEN.KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfoEN.KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objvViewInfoEN.UserId = objRow[convViewInfo.UserId].ToString().Trim(); //用户Id
objvViewInfoEN.PrjId = objRow[convViewInfo.PrjId].ToString().Trim(); //工程Id
objvViewInfoEN.PrjName = objRow[convViewInfo.PrjName].ToString().Trim(); //工程名称
objvViewInfoEN.ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(); //界面功能
objvViewInfoEN.ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(); //界面说明
objvViewInfoEN.DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfoEN.DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfoEN.FileName = objRow[convViewInfo.FileName].ToString().Trim(); //文件名
objvViewInfoEN.FilePath = objRow[convViewInfo.FilePath].ToString().Trim(); //文件路径
objvViewInfoEN.MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(); //主表ID
objvViewInfoEN.ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfoEN.ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfoEN.ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfoEN.InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfoEN.OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfoEN.GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfoEN.TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(); //任务Id
objvViewInfoEN.KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewInfoEN.ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewInfoEN.ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名
objvViewInfoEN.UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(); //修改日期
objvViewInfoEN.UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvViewInfoEN.Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(); //说明
objvViewInfoEN.MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(); //主表
objvViewInfoEN.DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(); //详细表
objvViewInfoEN.MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfoEN.RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo.RegionNum].ToString().Trim()); //区域数
objvViewInfoEN.DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfoEN);
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
public static List<clsvViewInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvViewInfoEN> arrObjLst = new List<clsvViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN();
try
{
objvViewInfoEN.ViewId = objRow[convViewInfo.ViewId].ToString().Trim(); //界面Id
objvViewInfoEN.TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfoEN.TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfoEN.DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfoEN.DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfoEN.ViewName = objRow[convViewInfo.ViewName].ToString().Trim(); //界面名称
objvViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfoEN.ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewInfoEN.FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfoEN.FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfoEN.FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfoEN.DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(); //数据库名
objvViewInfoEN.KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfoEN.KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objvViewInfoEN.UserId = objRow[convViewInfo.UserId].ToString().Trim(); //用户Id
objvViewInfoEN.PrjId = objRow[convViewInfo.PrjId].ToString().Trim(); //工程Id
objvViewInfoEN.PrjName = objRow[convViewInfo.PrjName].ToString().Trim(); //工程名称
objvViewInfoEN.ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(); //界面功能
objvViewInfoEN.ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(); //界面说明
objvViewInfoEN.DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfoEN.DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfoEN.FileName = objRow[convViewInfo.FileName].ToString().Trim(); //文件名
objvViewInfoEN.FilePath = objRow[convViewInfo.FilePath].ToString().Trim(); //文件路径
objvViewInfoEN.MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(); //主表ID
objvViewInfoEN.ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfoEN.ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfoEN.ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfoEN.InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfoEN.OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfoEN.GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfoEN.TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(); //任务Id
objvViewInfoEN.KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewInfoEN.ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewInfoEN.ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名
objvViewInfoEN.UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(); //修改日期
objvViewInfoEN.UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvViewInfoEN.Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(); //说明
objvViewInfoEN.MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(); //主表
objvViewInfoEN.DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(); //详细表
objvViewInfoEN.MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfoEN.RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo.RegionNum].ToString().Trim()); //区域数
objvViewInfoEN.DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfoEN);
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
List<clsvViewInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvViewInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvViewInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvViewInfoEN> arrObjLst = new List<clsvViewInfoEN>(); 
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
	clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN();
try
{
objvViewInfoEN.ViewId = objRow[convViewInfo.ViewId].ToString().Trim(); //界面Id
objvViewInfoEN.TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfoEN.TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfoEN.DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfoEN.DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfoEN.ViewName = objRow[convViewInfo.ViewName].ToString().Trim(); //界面名称
objvViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfoEN.ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewInfoEN.FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfoEN.FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfoEN.FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfoEN.DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(); //数据库名
objvViewInfoEN.KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfoEN.KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objvViewInfoEN.UserId = objRow[convViewInfo.UserId].ToString().Trim(); //用户Id
objvViewInfoEN.PrjId = objRow[convViewInfo.PrjId].ToString().Trim(); //工程Id
objvViewInfoEN.PrjName = objRow[convViewInfo.PrjName].ToString().Trim(); //工程名称
objvViewInfoEN.ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(); //界面功能
objvViewInfoEN.ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(); //界面说明
objvViewInfoEN.DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfoEN.DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfoEN.FileName = objRow[convViewInfo.FileName].ToString().Trim(); //文件名
objvViewInfoEN.FilePath = objRow[convViewInfo.FilePath].ToString().Trim(); //文件路径
objvViewInfoEN.MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(); //主表ID
objvViewInfoEN.ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfoEN.ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfoEN.ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfoEN.InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfoEN.OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfoEN.GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfoEN.TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(); //任务Id
objvViewInfoEN.KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewInfoEN.ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewInfoEN.ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名
objvViewInfoEN.UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(); //修改日期
objvViewInfoEN.UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvViewInfoEN.Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(); //说明
objvViewInfoEN.MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(); //主表
objvViewInfoEN.DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(); //详细表
objvViewInfoEN.MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfoEN.RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo.RegionNum].ToString().Trim()); //区域数
objvViewInfoEN.DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfoEN);
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
public static List<clsvViewInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvViewInfoEN> arrObjLst = new List<clsvViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN();
try
{
objvViewInfoEN.ViewId = objRow[convViewInfo.ViewId].ToString().Trim(); //界面Id
objvViewInfoEN.TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfoEN.TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfoEN.DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfoEN.DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfoEN.ViewName = objRow[convViewInfo.ViewName].ToString().Trim(); //界面名称
objvViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfoEN.ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewInfoEN.FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfoEN.FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfoEN.FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfoEN.DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(); //数据库名
objvViewInfoEN.KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfoEN.KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objvViewInfoEN.UserId = objRow[convViewInfo.UserId].ToString().Trim(); //用户Id
objvViewInfoEN.PrjId = objRow[convViewInfo.PrjId].ToString().Trim(); //工程Id
objvViewInfoEN.PrjName = objRow[convViewInfo.PrjName].ToString().Trim(); //工程名称
objvViewInfoEN.ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(); //界面功能
objvViewInfoEN.ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(); //界面说明
objvViewInfoEN.DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfoEN.DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfoEN.FileName = objRow[convViewInfo.FileName].ToString().Trim(); //文件名
objvViewInfoEN.FilePath = objRow[convViewInfo.FilePath].ToString().Trim(); //文件路径
objvViewInfoEN.MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(); //主表ID
objvViewInfoEN.ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfoEN.ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfoEN.ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfoEN.InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfoEN.OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfoEN.GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfoEN.TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(); //任务Id
objvViewInfoEN.KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewInfoEN.ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewInfoEN.ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名
objvViewInfoEN.UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(); //修改日期
objvViewInfoEN.UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvViewInfoEN.Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(); //说明
objvViewInfoEN.MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(); //主表
objvViewInfoEN.DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(); //详细表
objvViewInfoEN.MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfoEN.RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo.RegionNum].ToString().Trim()); //区域数
objvViewInfoEN.DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvViewInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvViewInfoEN> arrObjLst = new List<clsvViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN();
try
{
objvViewInfoEN.ViewId = objRow[convViewInfo.ViewId].ToString().Trim(); //界面Id
objvViewInfoEN.TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfoEN.TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfoEN.DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfoEN.DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfoEN.ViewName = objRow[convViewInfo.ViewName].ToString().Trim(); //界面名称
objvViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfoEN.ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewInfoEN.FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfoEN.FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfoEN.FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfoEN.DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(); //数据库名
objvViewInfoEN.KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfoEN.KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objvViewInfoEN.UserId = objRow[convViewInfo.UserId].ToString().Trim(); //用户Id
objvViewInfoEN.PrjId = objRow[convViewInfo.PrjId].ToString().Trim(); //工程Id
objvViewInfoEN.PrjName = objRow[convViewInfo.PrjName].ToString().Trim(); //工程名称
objvViewInfoEN.ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(); //界面功能
objvViewInfoEN.ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(); //界面说明
objvViewInfoEN.DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfoEN.DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfoEN.FileName = objRow[convViewInfo.FileName].ToString().Trim(); //文件名
objvViewInfoEN.FilePath = objRow[convViewInfo.FilePath].ToString().Trim(); //文件路径
objvViewInfoEN.MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(); //主表ID
objvViewInfoEN.ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfoEN.ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfoEN.ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfoEN.InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfoEN.OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfoEN.GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfoEN.TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(); //任务Id
objvViewInfoEN.KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewInfoEN.ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewInfoEN.ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名
objvViewInfoEN.UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(); //修改日期
objvViewInfoEN.UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvViewInfoEN.Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(); //说明
objvViewInfoEN.MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(); //主表
objvViewInfoEN.DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(); //详细表
objvViewInfoEN.MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfoEN.RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo.RegionNum].ToString().Trim()); //区域数
objvViewInfoEN.DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfoEN);
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
public static List<clsvViewInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvViewInfoEN> arrObjLst = new List<clsvViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN();
try
{
objvViewInfoEN.ViewId = objRow[convViewInfo.ViewId].ToString().Trim(); //界面Id
objvViewInfoEN.TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfoEN.TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfoEN.DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfoEN.DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfoEN.ViewName = objRow[convViewInfo.ViewName].ToString().Trim(); //界面名称
objvViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfoEN.ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewInfoEN.FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfoEN.FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfoEN.FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfoEN.DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(); //数据库名
objvViewInfoEN.KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfoEN.KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objvViewInfoEN.UserId = objRow[convViewInfo.UserId].ToString().Trim(); //用户Id
objvViewInfoEN.PrjId = objRow[convViewInfo.PrjId].ToString().Trim(); //工程Id
objvViewInfoEN.PrjName = objRow[convViewInfo.PrjName].ToString().Trim(); //工程名称
objvViewInfoEN.ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(); //界面功能
objvViewInfoEN.ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(); //界面说明
objvViewInfoEN.DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfoEN.DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfoEN.FileName = objRow[convViewInfo.FileName].ToString().Trim(); //文件名
objvViewInfoEN.FilePath = objRow[convViewInfo.FilePath].ToString().Trim(); //文件路径
objvViewInfoEN.MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(); //主表ID
objvViewInfoEN.ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfoEN.ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfoEN.ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfoEN.InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfoEN.OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfoEN.GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfoEN.TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(); //任务Id
objvViewInfoEN.KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewInfoEN.ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewInfoEN.ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名
objvViewInfoEN.UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(); //修改日期
objvViewInfoEN.UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvViewInfoEN.Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(); //说明
objvViewInfoEN.MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(); //主表
objvViewInfoEN.DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(); //详细表
objvViewInfoEN.MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfoEN.RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo.RegionNum].ToString().Trim()); //区域数
objvViewInfoEN.DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvViewInfoEN> arrObjLst = new List<clsvViewInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN();
try
{
objvViewInfoEN.ViewId = objRow[convViewInfo.ViewId].ToString().Trim(); //界面Id
objvViewInfoEN.TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfoEN.TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfoEN.DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfoEN.DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfoEN.ViewName = objRow[convViewInfo.ViewName].ToString().Trim(); //界面名称
objvViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfoEN.ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewInfoEN.FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfoEN.FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfoEN.FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfoEN.DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(); //数据库名
objvViewInfoEN.KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfoEN.KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objvViewInfoEN.UserId = objRow[convViewInfo.UserId].ToString().Trim(); //用户Id
objvViewInfoEN.PrjId = objRow[convViewInfo.PrjId].ToString().Trim(); //工程Id
objvViewInfoEN.PrjName = objRow[convViewInfo.PrjName].ToString().Trim(); //工程名称
objvViewInfoEN.ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(); //界面功能
objvViewInfoEN.ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(); //界面说明
objvViewInfoEN.DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfoEN.DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfoEN.FileName = objRow[convViewInfo.FileName].ToString().Trim(); //文件名
objvViewInfoEN.FilePath = objRow[convViewInfo.FilePath].ToString().Trim(); //文件路径
objvViewInfoEN.MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(); //主表ID
objvViewInfoEN.ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfoEN.ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfoEN.ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfoEN.InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfoEN.OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfoEN.GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfoEN.TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(); //任务Id
objvViewInfoEN.KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewInfoEN.ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewInfoEN.ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名
objvViewInfoEN.UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(); //修改日期
objvViewInfoEN.UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvViewInfoEN.Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(); //说明
objvViewInfoEN.MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(); //主表
objvViewInfoEN.DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(); //详细表
objvViewInfoEN.MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfoEN.RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo.RegionNum].ToString().Trim()); //区域数
objvViewInfoEN.DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvViewInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvViewInfo(ref clsvViewInfoEN objvViewInfoEN)
{
bool bolResult = vViewInfoDA.GetvViewInfo(ref objvViewInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewInfoEN GetObjByViewId(string strViewId)
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
clsvViewInfoEN objvViewInfoEN = vViewInfoDA.GetObjByViewId(strViewId);
return objvViewInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvViewInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvViewInfoEN objvViewInfoEN = vViewInfoDA.GetFirstObj(strWhereCond);
 return objvViewInfoEN;
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
public static clsvViewInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvViewInfoEN objvViewInfoEN = vViewInfoDA.GetObjByDataRow(objRow);
 return objvViewInfoEN;
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
public static clsvViewInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvViewInfoEN objvViewInfoEN = vViewInfoDA.GetObjByDataRow(objRow);
 return objvViewInfoEN;
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
 /// <param name = "lstvViewInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewInfoEN GetObjByViewIdFromList(string strViewId, List<clsvViewInfoEN> lstvViewInfoObjLst)
{
foreach (clsvViewInfoEN objvViewInfoEN in lstvViewInfoObjLst)
{
if (objvViewInfoEN.ViewId == strViewId)
{
return objvViewInfoEN;
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
 strViewId = new clsvViewInfoDA().GetFirstID(strWhereCond);
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
 arrList = vViewInfoDA.GetID(strWhereCond);
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
bool bolIsExist = vViewInfoDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vViewInfoDA.IsExist(strViewId);
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
 bolIsExist = clsvViewInfoDA.IsExistTable();
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
 bolIsExist = vViewInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objvViewInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsvViewInfoEN objvViewInfoEN)
{
try
{
objvViewInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvViewInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convViewInfo.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.ViewId = objvViewInfoEN.ViewId; //界面Id
}
if (arrFldSet.Contains(convViewInfo.TitleStyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.TitleStyleId = objvViewInfoEN.TitleStyleId == "[null]" ? null :  objvViewInfoEN.TitleStyleId; //标题类型Id
}
if (arrFldSet.Contains(convViewInfo.TitleStyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.TitleStyleName = objvViewInfoEN.TitleStyleName; //标题类型名
}
if (arrFldSet.Contains(convViewInfo.DgStyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.DgStyleId = objvViewInfoEN.DgStyleId == "[null]" ? null :  objvViewInfoEN.DgStyleId; //DG模式ID
}
if (arrFldSet.Contains(convViewInfo.DgStyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.DgStyleName = objvViewInfoEN.DgStyleName; //DG模式名
}
if (arrFldSet.Contains(convViewInfo.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.ViewName = objvViewInfoEN.ViewName; //界面名称
}
if (arrFldSet.Contains(convViewInfo.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.ApplicationTypeId = objvViewInfoEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convViewInfo.ApplicationTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.ApplicationTypeSimName = objvViewInfoEN.ApplicationTypeSimName == "[null]" ? null :  objvViewInfoEN.ApplicationTypeSimName; //应用程序类型简称
}
if (arrFldSet.Contains(convViewInfo.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.FuncModuleAgcId = objvViewInfoEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convViewInfo.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.FuncModuleName = objvViewInfoEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convViewInfo.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.FuncModuleEnName = objvViewInfoEN.FuncModuleEnName == "[null]" ? null :  objvViewInfoEN.FuncModuleEnName; //功能模块英文名称
}
if (arrFldSet.Contains(convViewInfo.DataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.DataBaseName = objvViewInfoEN.DataBaseName == "[null]" ? null :  objvViewInfoEN.DataBaseName; //数据库名
}
if (arrFldSet.Contains(convViewInfo.KeyForMainTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.KeyForMainTab = objvViewInfoEN.KeyForMainTab == "[null]" ? null :  objvViewInfoEN.KeyForMainTab; //主表关键字
}
if (arrFldSet.Contains(convViewInfo.KeyForDetailTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.KeyForDetailTab = objvViewInfoEN.KeyForDetailTab == "[null]" ? null :  objvViewInfoEN.KeyForDetailTab; //明细表关键字
}
if (arrFldSet.Contains(convViewInfo.IsNeedSort, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.IsNeedSort = objvViewInfoEN.IsNeedSort; //是否需要排序
}
if (arrFldSet.Contains(convViewInfo.IsNeedTransCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.IsNeedTransCode = objvViewInfoEN.IsNeedTransCode; //是否需要转换代码
}
if (arrFldSet.Contains(convViewInfo.IsNeedSetExportFld, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.IsNeedSetExportFld = objvViewInfoEN.IsNeedSetExportFld; //是否需要设置导出字段
}
if (arrFldSet.Contains(convViewInfo.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.UserId = objvViewInfoEN.UserId; //用户Id
}
if (arrFldSet.Contains(convViewInfo.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.PrjId = objvViewInfoEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convViewInfo.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.PrjName = objvViewInfoEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convViewInfo.ViewFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.ViewFunction = objvViewInfoEN.ViewFunction == "[null]" ? null :  objvViewInfoEN.ViewFunction; //界面功能
}
if (arrFldSet.Contains(convViewInfo.ViewDetail, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.ViewDetail = objvViewInfoEN.ViewDetail == "[null]" ? null :  objvViewInfoEN.ViewDetail; //界面说明
}
if (arrFldSet.Contains(convViewInfo.DefaMenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.DefaMenuName = objvViewInfoEN.DefaMenuName; //缺省菜单名
}
if (arrFldSet.Contains(convViewInfo.DetailTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.DetailTabId = objvViewInfoEN.DetailTabId == "[null]" ? null :  objvViewInfoEN.DetailTabId; //明细表ID
}
if (arrFldSet.Contains(convViewInfo.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.FileName = objvViewInfoEN.FileName; //文件名
}
if (arrFldSet.Contains(convViewInfo.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.FilePath = objvViewInfoEN.FilePath; //文件路径
}
if (arrFldSet.Contains(convViewInfo.MainTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.MainTabId = objvViewInfoEN.MainTabId == "[null]" ? null :  objvViewInfoEN.MainTabId; //主表ID
}
if (arrFldSet.Contains(convViewInfo.ViewCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.ViewCnName = objvViewInfoEN.ViewCnName == "[null]" ? null :  objvViewInfoEN.ViewCnName; //视图中文名
}
if (arrFldSet.Contains(convViewInfo.ViewGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.ViewGroupId = objvViewInfoEN.ViewGroupId; //界面组ID
}
if (arrFldSet.Contains(convViewInfo.ViewGroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.ViewGroupName = objvViewInfoEN.ViewGroupName; //界面组名称
}
if (arrFldSet.Contains(convViewInfo.InSqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.InSqlDsTypeId = objvViewInfoEN.InSqlDsTypeId == "[null]" ? null :  objvViewInfoEN.InSqlDsTypeId; //输入数据源类型
}
if (arrFldSet.Contains(convViewInfo.OutSqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.OutSqlDsTypeId = objvViewInfoEN.OutSqlDsTypeId == "[null]" ? null :  objvViewInfoEN.OutSqlDsTypeId; //输出数据源类型
}
if (arrFldSet.Contains(convViewInfo.GeneCodeDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.GeneCodeDate = objvViewInfoEN.GeneCodeDate == "[null]" ? null :  objvViewInfoEN.GeneCodeDate; //生成代码日期
}
if (arrFldSet.Contains(convViewInfo.TaskId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.TaskId = objvViewInfoEN.TaskId == "[null]" ? null :  objvViewInfoEN.TaskId; //任务Id
}
if (arrFldSet.Contains(convViewInfo.KeyId4Test, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.KeyId4Test = objvViewInfoEN.KeyId4Test == "[null]" ? null :  objvViewInfoEN.KeyId4Test; //测试关键字Id
}
if (arrFldSet.Contains(convViewInfo.ViewMasterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.ViewMasterId = objvViewInfoEN.ViewMasterId == "[null]" ? null :  objvViewInfoEN.ViewMasterId; //界面母版Id
}
if (arrFldSet.Contains(convViewInfo.ViewMasterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.ViewMasterName = objvViewInfoEN.ViewMasterName == "[null]" ? null :  objvViewInfoEN.ViewMasterName; //界面母版名
}
if (arrFldSet.Contains(convViewInfo.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.UpdDate = objvViewInfoEN.UpdDate == "[null]" ? null :  objvViewInfoEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convViewInfo.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.UpdUserId = objvViewInfoEN.UpdUserId == "[null]" ? null :  objvViewInfoEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convViewInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.Memo = objvViewInfoEN.Memo == "[null]" ? null :  objvViewInfoEN.Memo; //说明
}
if (arrFldSet.Contains(convViewInfo.MainTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.MainTabName = objvViewInfoEN.MainTabName == "[null]" ? null :  objvViewInfoEN.MainTabName; //主表
}
if (arrFldSet.Contains(convViewInfo.DetailTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.DetailTabName = objvViewInfoEN.DetailTabName == "[null]" ? null :  objvViewInfoEN.DetailTabName; //详细表
}
if (arrFldSet.Contains(convViewInfo.MainTabKeyFld, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.MainTabKeyFld = objvViewInfoEN.MainTabKeyFld == "[null]" ? null :  objvViewInfoEN.MainTabKeyFld; //主表关键字
}
if (arrFldSet.Contains(convViewInfo.RegionNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.RegionNum = objvViewInfoEN.RegionNum; //区域数
}
if (arrFldSet.Contains(convViewInfo.DetailTabKeyFld, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewInfoEN.DetailTabKeyFld = objvViewInfoEN.DetailTabKeyFld == "[null]" ? null :  objvViewInfoEN.DetailTabKeyFld; //详细表关键字
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
 /// <param name = "objvViewInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsvViewInfoEN objvViewInfoEN)
{
try
{
if (objvViewInfoEN.TitleStyleId == "[null]") objvViewInfoEN.TitleStyleId = null; //标题类型Id
if (objvViewInfoEN.DgStyleId == "[null]") objvViewInfoEN.DgStyleId = null; //DG模式ID
if (objvViewInfoEN.ApplicationTypeSimName == "[null]") objvViewInfoEN.ApplicationTypeSimName = null; //应用程序类型简称
if (objvViewInfoEN.FuncModuleEnName == "[null]") objvViewInfoEN.FuncModuleEnName = null; //功能模块英文名称
if (objvViewInfoEN.DataBaseName == "[null]") objvViewInfoEN.DataBaseName = null; //数据库名
if (objvViewInfoEN.KeyForMainTab == "[null]") objvViewInfoEN.KeyForMainTab = null; //主表关键字
if (objvViewInfoEN.KeyForDetailTab == "[null]") objvViewInfoEN.KeyForDetailTab = null; //明细表关键字
if (objvViewInfoEN.ViewFunction == "[null]") objvViewInfoEN.ViewFunction = null; //界面功能
if (objvViewInfoEN.ViewDetail == "[null]") objvViewInfoEN.ViewDetail = null; //界面说明
if (objvViewInfoEN.DetailTabId == "[null]") objvViewInfoEN.DetailTabId = null; //明细表ID
if (objvViewInfoEN.MainTabId == "[null]") objvViewInfoEN.MainTabId = null; //主表ID
if (objvViewInfoEN.ViewCnName == "[null]") objvViewInfoEN.ViewCnName = null; //视图中文名
if (objvViewInfoEN.InSqlDsTypeId == "[null]") objvViewInfoEN.InSqlDsTypeId = null; //输入数据源类型
if (objvViewInfoEN.OutSqlDsTypeId == "[null]") objvViewInfoEN.OutSqlDsTypeId = null; //输出数据源类型
if (objvViewInfoEN.GeneCodeDate == "[null]") objvViewInfoEN.GeneCodeDate = null; //生成代码日期
if (objvViewInfoEN.TaskId == "[null]") objvViewInfoEN.TaskId = null; //任务Id
if (objvViewInfoEN.KeyId4Test == "[null]") objvViewInfoEN.KeyId4Test = null; //测试关键字Id
if (objvViewInfoEN.ViewMasterId == "[null]") objvViewInfoEN.ViewMasterId = null; //界面母版Id
if (objvViewInfoEN.ViewMasterName == "[null]") objvViewInfoEN.ViewMasterName = null; //界面母版名
if (objvViewInfoEN.UpdDate == "[null]") objvViewInfoEN.UpdDate = null; //修改日期
if (objvViewInfoEN.UpdUserId == "[null]") objvViewInfoEN.UpdUserId = null; //修改用户Id
if (objvViewInfoEN.Memo == "[null]") objvViewInfoEN.Memo = null; //说明
if (objvViewInfoEN.MainTabName == "[null]") objvViewInfoEN.MainTabName = null; //主表
if (objvViewInfoEN.DetailTabName == "[null]") objvViewInfoEN.DetailTabName = null; //详细表
if (objvViewInfoEN.MainTabKeyFld == "[null]") objvViewInfoEN.MainTabKeyFld = null; //主表关键字
if (objvViewInfoEN.DetailTabKeyFld == "[null]") objvViewInfoEN.DetailTabKeyFld = null; //详细表关键字
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
public static void CheckProperty4Condition(clsvViewInfoEN objvViewInfoEN)
{
 vViewInfoDA.CheckProperty4Condition(objvViewInfoEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_ApplicationTypeId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convViewInfo.ApplicationTypeId); 
List<clsvViewInfoEN> arrObjLst = clsvViewInfoBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_ApplicationTypeId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v界面]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convViewInfo.ApplicationTypeId); 
IEnumerable<clsvViewInfoEN> arrObjLst = clsvViewInfoBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = convViewInfo.ApplicationTypeId;
objDDL.DataTextField = convViewInfo.ApplicationTypeSimName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v界面]...","0");
List<clsvViewInfoEN> arrvViewInfoObjLst = GetAllvViewInfoObjLstCache(strPrjId); 
objDDL.DataValueField = convViewInfo.ViewId;
objDDL.DataTextField = convViewInfo.ViewName;
objDDL.DataSource = arrvViewInfoObjLst;
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
//string strWhereCond = string.Format("1 = 1 order by ViewId");
//if (arrvViewInfoObjLstCache == null)
//{
//arrvViewInfoObjLstCache = vViewInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strViewId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewInfoEN GetObjByViewIdCache(string strViewId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvViewInfoEN._CurrTabName, strPrjId);
List<clsvViewInfoEN> arrvViewInfoObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewInfoEN> arrvViewInfoObjLst_Sel =
arrvViewInfoObjLstCache
.Where(x=> x.ViewId == strViewId 
);
if (arrvViewInfoObjLst_Sel.Count() == 0)
{
   clsvViewInfoEN obj = clsvViewInfoBL.GetObjByViewId(strViewId);
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
return arrvViewInfoObjLst_Sel.First();
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
clsvViewInfoEN objvViewInfo = GetObjByViewIdCache(strViewId, strPrjId);
if (objvViewInfo == null) return "";
return objvViewInfo.ViewName;
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
clsvViewInfoEN objvViewInfo = GetObjByViewIdCache(strViewId, strPrjId);
if (objvViewInfo == null) return "";
return objvViewInfo.ViewName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewInfoEN> GetAllvViewInfoObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvViewInfoEN> arrvViewInfoObjLstCache = GetObjLstCache(strPrjId); 
return arrvViewInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewInfoEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvViewInfoEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvViewInfoEN> arrvViewInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvViewInfoObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvViewInfoEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvViewInfoEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvViewInfoEN._RefreshTimeLst.Count == 0) return "";
return clsvViewInfoEN._RefreshTimeLst[clsvViewInfoEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convViewInfo.ViewId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convViewInfo._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convViewInfo._AttributeName));
throw new Exception(strMsg);
}
var objvViewInfo = clsvViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
if (objvViewInfo == null) return "";
return objvViewInfo[strOutFldName].ToString();
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
int intRecCount = clsvViewInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsvViewInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvViewInfoDA.GetRecCount();
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
int intRecCount = clsvViewInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvViewInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvViewInfoEN objvViewInfoCond)
{
 string strPrjId = objvViewInfoCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvViewInfoBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvViewInfoEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewInfo._AttributeName)
{
if (objvViewInfoCond.IsUpdated(strFldName) == false) continue;
if (objvViewInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewInfoCond[strFldName].ToString());
}
else
{
if (objvViewInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewInfoCond[strFldName]));
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
 List<string> arrList = clsvViewInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vViewInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vViewInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}