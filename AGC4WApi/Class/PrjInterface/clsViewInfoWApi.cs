
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewInfoWApi
 表名:ViewInfo(00050006)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:29
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsViewInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewId">界面Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetViewId(this clsViewInfoEN objViewInfoEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewId, 8, conViewInfo.ViewId);
clsCheckSql.CheckFieldForeignKey(strViewId, 8, conViewInfo.ViewId);
objViewInfoEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ViewId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ViewId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ViewId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewName">界面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetViewName(this clsViewInfoEN objViewInfoEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, conViewInfo.ViewName);
clsCheckSql.CheckFieldLen(strViewName, 100, conViewInfo.ViewName);
objViewInfoEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ViewName) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ViewName, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ViewName] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetApplicationTypeId(this clsViewInfoEN objViewInfoEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conViewInfo.ApplicationTypeId);
objViewInfoEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ApplicationTypeId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ApplicationTypeId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ApplicationTypeId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetFuncModuleAgcId(this clsViewInfoEN objViewInfoEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conViewInfo.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conViewInfo.FuncModuleAgcId);
objViewInfoEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.FuncModuleAgcId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.FuncModuleAgcId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.FuncModuleAgcId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseName">数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetDataBaseName(this clsViewInfoEN objViewInfoEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, conViewInfo.DataBaseName);
objViewInfoEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.DataBaseName) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.DataBaseName, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.DataBaseName] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyForMainTab">主表关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetKeyForMainTab(this clsViewInfoEN objViewInfoEN, string strKeyForMainTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyForMainTab, 50, conViewInfo.KeyForMainTab);
objViewInfoEN.KeyForMainTab = strKeyForMainTab; //主表关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.KeyForMainTab) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.KeyForMainTab, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.KeyForMainTab] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyForDetailTab">明细表关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetKeyForDetailTab(this clsViewInfoEN objViewInfoEN, string strKeyForDetailTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyForDetailTab, 50, conViewInfo.KeyForDetailTab);
objViewInfoEN.KeyForDetailTab = strKeyForDetailTab; //明细表关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.KeyForDetailTab) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.KeyForDetailTab, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.KeyForDetailTab] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedSort">是否需要排序</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetIsNeedSort(this clsViewInfoEN objViewInfoEN, bool bolIsNeedSort, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedSort, conViewInfo.IsNeedSort);
objViewInfoEN.IsNeedSort = bolIsNeedSort; //是否需要排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.IsNeedSort) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.IsNeedSort, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.IsNeedSort] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedTransCode">是否需要转换代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetIsNeedTransCode(this clsViewInfoEN objViewInfoEN, bool bolIsNeedTransCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedTransCode, conViewInfo.IsNeedTransCode);
objViewInfoEN.IsNeedTransCode = bolIsNeedTransCode; //是否需要转换代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.IsNeedTransCode) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.IsNeedTransCode, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.IsNeedTransCode] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedSetExportFld">是否需要设置导出字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetIsNeedSetExportFld(this clsViewInfoEN objViewInfoEN, bool bolIsNeedSetExportFld, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedSetExportFld, conViewInfo.IsNeedSetExportFld);
objViewInfoEN.IsNeedSetExportFld = bolIsNeedSetExportFld; //是否需要设置导出字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.IsNeedSetExportFld) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.IsNeedSetExportFld, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.IsNeedSetExportFld] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetUserId(this clsViewInfoEN objViewInfoEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conViewInfo.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, conViewInfo.UserId);
objViewInfoEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.UserId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.UserId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.UserId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetPrjId(this clsViewInfoEN objViewInfoEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewInfo.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewInfo.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewInfo.PrjId);
objViewInfoEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.PrjId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.PrjId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.PrjId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewFunction">界面功能</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetViewFunction(this clsViewInfoEN objViewInfoEN, string strViewFunction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewFunction, 100, conViewInfo.ViewFunction);
objViewInfoEN.ViewFunction = strViewFunction; //界面功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ViewFunction) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ViewFunction, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ViewFunction] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewDetail">界面说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetViewDetail(this clsViewInfoEN objViewInfoEN, string strViewDetail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewDetail, 1000, conViewInfo.ViewDetail);
objViewInfoEN.ViewDetail = strViewDetail; //界面说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ViewDetail) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ViewDetail, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ViewDetail] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaMenuName">缺省菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetDefaMenuName(this clsViewInfoEN objViewInfoEN, string strDefaMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaMenuName, conViewInfo.DefaMenuName);
clsCheckSql.CheckFieldLen(strDefaMenuName, 100, conViewInfo.DefaMenuName);
objViewInfoEN.DefaMenuName = strDefaMenuName; //缺省菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.DefaMenuName) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.DefaMenuName, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.DefaMenuName] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDetailTabId">明细表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetDetailTabId(this clsViewInfoEN objViewInfoEN, string strDetailTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDetailTabId, 8, conViewInfo.DetailTabId);
objViewInfoEN.DetailTabId = strDetailTabId; //明细表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.DetailTabId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.DetailTabId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.DetailTabId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetFileName(this clsViewInfoEN objViewInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, conViewInfo.FileName);
clsCheckSql.CheckFieldLen(strFileName, 150, conViewInfo.FileName);
objViewInfoEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.FileName) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.FileName, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.FileName] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilePath">文件路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetFilePath(this clsViewInfoEN objViewInfoEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, conViewInfo.FilePath);
clsCheckSql.CheckFieldLen(strFilePath, 500, conViewInfo.FilePath);
objViewInfoEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.FilePath) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.FilePath, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.FilePath] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strMainTabId">主表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetMainTabId(this clsViewInfoEN objViewInfoEN, string strMainTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMainTabId, 8, conViewInfo.MainTabId);
objViewInfoEN.MainTabId = strMainTabId; //主表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.MainTabId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.MainTabId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.MainTabId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewCnName">视图中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetViewCnName(this clsViewInfoEN objViewInfoEN, string strViewCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewCnName, conViewInfo.ViewCnName);
clsCheckSql.CheckFieldLen(strViewCnName, 100, conViewInfo.ViewCnName);
objViewInfoEN.ViewCnName = strViewCnName; //视图中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ViewCnName) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ViewCnName, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ViewCnName] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewGroupId">界面组ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetViewGroupId(this clsViewInfoEN objViewInfoEN, string strViewGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewGroupId, 8, conViewInfo.ViewGroupId);
clsCheckSql.CheckFieldForeignKey(strViewGroupId, 8, conViewInfo.ViewGroupId);
objViewInfoEN.ViewGroupId = strViewGroupId; //界面组ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ViewGroupId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ViewGroupId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ViewGroupId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strInRelaTabId">输入数据源表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetInRelaTabId(this clsViewInfoEN objViewInfoEN, string strInRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInRelaTabId, 8, conViewInfo.InRelaTabId);
clsCheckSql.CheckFieldForeignKey(strInRelaTabId, 8, conViewInfo.InRelaTabId);
objViewInfoEN.InRelaTabId = strInRelaTabId; //输入数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.InRelaTabId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.InRelaTabId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.InRelaTabId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strInSqlDsTypeId">输入数据源类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetInSqlDsTypeId(this clsViewInfoEN objViewInfoEN, string strInSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInSqlDsTypeId, 2, conViewInfo.InSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strInSqlDsTypeId, 2, conViewInfo.InSqlDsTypeId);
objViewInfoEN.InSqlDsTypeId = strInSqlDsTypeId; //输入数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.InSqlDsTypeId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.InSqlDsTypeId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.InSqlDsTypeId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutRelaTabId">输出数据源表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetOutRelaTabId(this clsViewInfoEN objViewInfoEN, string strOutRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutRelaTabId, 8, conViewInfo.OutRelaTabId);
clsCheckSql.CheckFieldForeignKey(strOutRelaTabId, 8, conViewInfo.OutRelaTabId);
objViewInfoEN.OutRelaTabId = strOutRelaTabId; //输出数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.OutRelaTabId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.OutRelaTabId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.OutRelaTabId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutSqlDsTypeId">输出数据源类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetOutSqlDsTypeId(this clsViewInfoEN objViewInfoEN, string strOutSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutSqlDsTypeId, 2, conViewInfo.OutSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strOutSqlDsTypeId, 2, conViewInfo.OutSqlDsTypeId);
objViewInfoEN.OutSqlDsTypeId = strOutSqlDsTypeId; //输出数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.OutSqlDsTypeId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.OutSqlDsTypeId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.OutSqlDsTypeId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDetailTabType">DetailTabType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetDetailTabType(this clsViewInfoEN objViewInfoEN, string strDetailTabType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDetailTabType, 10, conViewInfo.DetailTabType);
objViewInfoEN.DetailTabType = strDetailTabType; //DetailTabType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.DetailTabType) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.DetailTabType, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.DetailTabType] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDetailViewId">DetailViewId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetDetailViewId(this clsViewInfoEN objViewInfoEN, string strDetailViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDetailViewId, 8, conViewInfo.DetailViewId);
objViewInfoEN.DetailViewId = strDetailViewId; //DetailViewId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.DetailViewId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.DetailViewId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.DetailViewId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strMainTabType">MainTabType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetMainTabType(this clsViewInfoEN objViewInfoEN, string strMainTabType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMainTabType, 10, conViewInfo.MainTabType);
objViewInfoEN.MainTabType = strMainTabType; //MainTabType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.MainTabType) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.MainTabType, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.MainTabType] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strMainViewId">MainViewId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetMainViewId(this clsViewInfoEN objViewInfoEN, string strMainViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMainViewId, 8, conViewInfo.MainViewId);
objViewInfoEN.MainViewId = strMainViewId; //MainViewId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.MainViewId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.MainViewId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.MainViewId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strGeneCodeDate">生成代码日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetGeneCodeDate(this clsViewInfoEN objViewInfoEN, string strGeneCodeDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, conViewInfo.GeneCodeDate);
objViewInfoEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.GeneCodeDate) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.GeneCodeDate, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.GeneCodeDate] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strTaskId">任务Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetTaskId(this clsViewInfoEN objViewInfoEN, string strTaskId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTaskId, 16, conViewInfo.TaskId);
clsCheckSql.CheckFieldForeignKey(strTaskId, 16, conViewInfo.TaskId);
objViewInfoEN.TaskId = strTaskId; //任务Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.TaskId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.TaskId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.TaskId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyId4Test">测试关键字Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetKeyId4Test(this clsViewInfoEN objViewInfoEN, string strKeyId4Test, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyId4Test, 50, conViewInfo.KeyId4Test);
objViewInfoEN.KeyId4Test = strKeyId4Test; //测试关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.KeyId4Test) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.KeyId4Test, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.KeyId4Test] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewMasterId">界面母版Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetViewMasterId(this clsViewInfoEN objViewInfoEN, string strViewMasterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewMasterId, 8, conViewInfo.ViewMasterId);
clsCheckSql.CheckFieldForeignKey(strViewMasterId, 8, conViewInfo.ViewMasterId);
objViewInfoEN.ViewMasterId = strViewMasterId; //界面母版Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ViewMasterId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ViewMasterId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ViewMasterId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsShare">是否共享</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetIsShare(this clsViewInfoEN objViewInfoEN, bool bolIsShare, string strComparisonOp="")
	{
objViewInfoEN.IsShare = bolIsShare; //是否共享
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.IsShare) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.IsShare, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.IsShare] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetErrMsg(this clsViewInfoEN objViewInfoEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conViewInfo.ErrMsg);
objViewInfoEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ErrMsg) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ErrMsg, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ErrMsg] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetUpdDate(this clsViewInfoEN objViewInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewInfo.UpdDate);
objViewInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.UpdDate) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.UpdDate, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.UpdDate] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetUpdUserId(this clsViewInfoEN objViewInfoEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conViewInfo.UpdUserId);
objViewInfoEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.UpdUserId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.UpdUserId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.UpdUserId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetMemo(this clsViewInfoEN objViewInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewInfo.Memo);
objViewInfoEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.Memo) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.Memo, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.Memo] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "intRegionNum">区域数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetRegionNum(this clsViewInfoEN objViewInfoEN, int intRegionNum, string strComparisonOp="")
	{
objViewInfoEN.RegionNum = intRegionNum; //区域数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.RegionNum) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.RegionNum, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.RegionNum] = strComparisonOp;
}
}
return objViewInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewInfoEN objViewInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewInfoCond.IsUpdated(conViewInfo.ViewId) == true)
{
string strComparisonOpViewId = objViewInfoCond.dicFldComparisonOp[conViewInfo.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ViewId, objViewInfoCond.ViewId, strComparisonOpViewId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.ViewName) == true)
{
string strComparisonOpViewName = objViewInfoCond.dicFldComparisonOp[conViewInfo.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ViewName, objViewInfoCond.ViewName, strComparisonOpViewName);
}
if (objViewInfoCond.IsUpdated(conViewInfo.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objViewInfoCond.dicFldComparisonOp[conViewInfo.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewInfo.ApplicationTypeId, objViewInfoCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objViewInfoCond.dicFldComparisonOp[conViewInfo.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.FuncModuleAgcId, objViewInfoCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objViewInfoCond.dicFldComparisonOp[conViewInfo.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.DataBaseName, objViewInfoCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objViewInfoCond.IsUpdated(conViewInfo.KeyForMainTab) == true)
{
string strComparisonOpKeyForMainTab = objViewInfoCond.dicFldComparisonOp[conViewInfo.KeyForMainTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.KeyForMainTab, objViewInfoCond.KeyForMainTab, strComparisonOpKeyForMainTab);
}
if (objViewInfoCond.IsUpdated(conViewInfo.KeyForDetailTab) == true)
{
string strComparisonOpKeyForDetailTab = objViewInfoCond.dicFldComparisonOp[conViewInfo.KeyForDetailTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.KeyForDetailTab, objViewInfoCond.KeyForDetailTab, strComparisonOpKeyForDetailTab);
}
if (objViewInfoCond.IsUpdated(conViewInfo.IsNeedSort) == true)
{
if (objViewInfoCond.IsNeedSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewInfo.IsNeedSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewInfo.IsNeedSort);
}
}
if (objViewInfoCond.IsUpdated(conViewInfo.IsNeedTransCode) == true)
{
if (objViewInfoCond.IsNeedTransCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewInfo.IsNeedTransCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewInfo.IsNeedTransCode);
}
}
if (objViewInfoCond.IsUpdated(conViewInfo.IsNeedSetExportFld) == true)
{
if (objViewInfoCond.IsNeedSetExportFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewInfo.IsNeedSetExportFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewInfo.IsNeedSetExportFld);
}
}
if (objViewInfoCond.IsUpdated(conViewInfo.UserId) == true)
{
string strComparisonOpUserId = objViewInfoCond.dicFldComparisonOp[conViewInfo.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.UserId, objViewInfoCond.UserId, strComparisonOpUserId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.PrjId) == true)
{
string strComparisonOpPrjId = objViewInfoCond.dicFldComparisonOp[conViewInfo.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.PrjId, objViewInfoCond.PrjId, strComparisonOpPrjId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.ViewFunction) == true)
{
string strComparisonOpViewFunction = objViewInfoCond.dicFldComparisonOp[conViewInfo.ViewFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ViewFunction, objViewInfoCond.ViewFunction, strComparisonOpViewFunction);
}
if (objViewInfoCond.IsUpdated(conViewInfo.ViewDetail) == true)
{
string strComparisonOpViewDetail = objViewInfoCond.dicFldComparisonOp[conViewInfo.ViewDetail];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ViewDetail, objViewInfoCond.ViewDetail, strComparisonOpViewDetail);
}
if (objViewInfoCond.IsUpdated(conViewInfo.DefaMenuName) == true)
{
string strComparisonOpDefaMenuName = objViewInfoCond.dicFldComparisonOp[conViewInfo.DefaMenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.DefaMenuName, objViewInfoCond.DefaMenuName, strComparisonOpDefaMenuName);
}
if (objViewInfoCond.IsUpdated(conViewInfo.DetailTabId) == true)
{
string strComparisonOpDetailTabId = objViewInfoCond.dicFldComparisonOp[conViewInfo.DetailTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.DetailTabId, objViewInfoCond.DetailTabId, strComparisonOpDetailTabId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.FileName) == true)
{
string strComparisonOpFileName = objViewInfoCond.dicFldComparisonOp[conViewInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.FileName, objViewInfoCond.FileName, strComparisonOpFileName);
}
if (objViewInfoCond.IsUpdated(conViewInfo.FilePath) == true)
{
string strComparisonOpFilePath = objViewInfoCond.dicFldComparisonOp[conViewInfo.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.FilePath, objViewInfoCond.FilePath, strComparisonOpFilePath);
}
if (objViewInfoCond.IsUpdated(conViewInfo.MainTabId) == true)
{
string strComparisonOpMainTabId = objViewInfoCond.dicFldComparisonOp[conViewInfo.MainTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.MainTabId, objViewInfoCond.MainTabId, strComparisonOpMainTabId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.ViewCnName) == true)
{
string strComparisonOpViewCnName = objViewInfoCond.dicFldComparisonOp[conViewInfo.ViewCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ViewCnName, objViewInfoCond.ViewCnName, strComparisonOpViewCnName);
}
if (objViewInfoCond.IsUpdated(conViewInfo.ViewGroupId) == true)
{
string strComparisonOpViewGroupId = objViewInfoCond.dicFldComparisonOp[conViewInfo.ViewGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ViewGroupId, objViewInfoCond.ViewGroupId, strComparisonOpViewGroupId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.InRelaTabId) == true)
{
string strComparisonOpInRelaTabId = objViewInfoCond.dicFldComparisonOp[conViewInfo.InRelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.InRelaTabId, objViewInfoCond.InRelaTabId, strComparisonOpInRelaTabId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.InSqlDsTypeId) == true)
{
string strComparisonOpInSqlDsTypeId = objViewInfoCond.dicFldComparisonOp[conViewInfo.InSqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.InSqlDsTypeId, objViewInfoCond.InSqlDsTypeId, strComparisonOpInSqlDsTypeId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.OutRelaTabId) == true)
{
string strComparisonOpOutRelaTabId = objViewInfoCond.dicFldComparisonOp[conViewInfo.OutRelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.OutRelaTabId, objViewInfoCond.OutRelaTabId, strComparisonOpOutRelaTabId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.OutSqlDsTypeId) == true)
{
string strComparisonOpOutSqlDsTypeId = objViewInfoCond.dicFldComparisonOp[conViewInfo.OutSqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.OutSqlDsTypeId, objViewInfoCond.OutSqlDsTypeId, strComparisonOpOutSqlDsTypeId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.DetailTabType) == true)
{
string strComparisonOpDetailTabType = objViewInfoCond.dicFldComparisonOp[conViewInfo.DetailTabType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.DetailTabType, objViewInfoCond.DetailTabType, strComparisonOpDetailTabType);
}
if (objViewInfoCond.IsUpdated(conViewInfo.DetailViewId) == true)
{
string strComparisonOpDetailViewId = objViewInfoCond.dicFldComparisonOp[conViewInfo.DetailViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.DetailViewId, objViewInfoCond.DetailViewId, strComparisonOpDetailViewId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.MainTabType) == true)
{
string strComparisonOpMainTabType = objViewInfoCond.dicFldComparisonOp[conViewInfo.MainTabType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.MainTabType, objViewInfoCond.MainTabType, strComparisonOpMainTabType);
}
if (objViewInfoCond.IsUpdated(conViewInfo.MainViewId) == true)
{
string strComparisonOpMainViewId = objViewInfoCond.dicFldComparisonOp[conViewInfo.MainViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.MainViewId, objViewInfoCond.MainViewId, strComparisonOpMainViewId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.GeneCodeDate) == true)
{
string strComparisonOpGeneCodeDate = objViewInfoCond.dicFldComparisonOp[conViewInfo.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.GeneCodeDate, objViewInfoCond.GeneCodeDate, strComparisonOpGeneCodeDate);
}
if (objViewInfoCond.IsUpdated(conViewInfo.TaskId) == true)
{
string strComparisonOpTaskId = objViewInfoCond.dicFldComparisonOp[conViewInfo.TaskId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.TaskId, objViewInfoCond.TaskId, strComparisonOpTaskId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.KeyId4Test) == true)
{
string strComparisonOpKeyId4Test = objViewInfoCond.dicFldComparisonOp[conViewInfo.KeyId4Test];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.KeyId4Test, objViewInfoCond.KeyId4Test, strComparisonOpKeyId4Test);
}
if (objViewInfoCond.IsUpdated(conViewInfo.ViewMasterId) == true)
{
string strComparisonOpViewMasterId = objViewInfoCond.dicFldComparisonOp[conViewInfo.ViewMasterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ViewMasterId, objViewInfoCond.ViewMasterId, strComparisonOpViewMasterId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.IsShare) == true)
{
if (objViewInfoCond.IsShare == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewInfo.IsShare);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewInfo.IsShare);
}
}
if (objViewInfoCond.IsUpdated(conViewInfo.ErrMsg) == true)
{
string strComparisonOpErrMsg = objViewInfoCond.dicFldComparisonOp[conViewInfo.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ErrMsg, objViewInfoCond.ErrMsg, strComparisonOpErrMsg);
}
if (objViewInfoCond.IsUpdated(conViewInfo.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewInfoCond.dicFldComparisonOp[conViewInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.UpdDate, objViewInfoCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewInfoCond.IsUpdated(conViewInfo.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objViewInfoCond.dicFldComparisonOp[conViewInfo.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.UpdUserId, objViewInfoCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.Memo) == true)
{
string strComparisonOpMemo = objViewInfoCond.dicFldComparisonOp[conViewInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.Memo, objViewInfoCond.Memo, strComparisonOpMemo);
}
if (objViewInfoCond.IsUpdated(conViewInfo.RegionNum) == true)
{
string strComparisonOpRegionNum = objViewInfoCond.dicFldComparisonOp[conViewInfo.RegionNum];
strWhereCond += string.Format(" And {0} {2} {1}", conViewInfo.RegionNum, objViewInfoCond.RegionNum, strComparisonOpRegionNum);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewInfoEN objViewInfoEN)
{
 if (string.IsNullOrEmpty(objViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objViewInfoEN.sfUpdFldSetStr = objViewInfoEN.getsfUpdFldSetStr();
clsViewInfoWApi.CheckPropertyNew(objViewInfoEN); 
bool bolResult = clsViewInfoWApi.UpdateRecord(objViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoWApi.ReFreshCache(objViewInfoEN.PrjId);
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
 /// 获取唯一性条件串--ViewInfo(界面), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_ViewName_ApplicationTypeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsViewInfoEN objViewInfoEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewInfoEN == null) return "";
if (objViewInfoEN.ViewId == null || objViewInfoEN.ViewId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewInfoEN.PrjId);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objViewInfoEN.ViewName);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewInfoEN.ApplicationTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewId !=  '{0}'", objViewInfoEN.ViewId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewInfoEN.PrjId);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objViewInfoEN.ViewName);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewInfoEN.ApplicationTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewInfoEN objViewInfoEN)
{
 if (string.IsNullOrEmpty(objViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewInfoWApi.IsExist(objViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewInfoEN.ViewId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsViewInfoWApi.CheckPropertyNew(objViewInfoEN); 
bool bolResult = clsViewInfoWApi.AddNewRecord(objViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoWApi.ReFreshCache(objViewInfoEN.PrjId);
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsViewInfoEN objViewInfoEN)
{
try
{
clsViewInfoWApi.CheckPropertyNew(objViewInfoEN); 
string strViewId = clsViewInfoWApi.AddNewRecordWithMaxId(objViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoWApi.ReFreshCache(objViewInfoEN.PrjId);
return strViewId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objViewInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewInfoEN objViewInfoEN, string strWhereCond)
{
try
{
clsViewInfoWApi.CheckPropertyNew(objViewInfoEN); 
bool bolResult = clsViewInfoWApi.UpdateWithCondition(objViewInfoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoWApi.ReFreshCache(objViewInfoEN.PrjId);
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
 /// 界面(ViewInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsViewInfoWApi
{
private static readonly string mstrApiControllerName = "ViewInfoApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsViewInfoWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面]...","0");
List<clsViewInfoEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", conViewInfo.ViewId); 
List<clsViewInfoEN> arrObjLst = clsViewInfoWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsViewInfoEN objViewInfoEN = new clsViewInfoEN()
{
ViewId = "0",
ViewName = "选[界面]..."
};
arrObjLstSel.Insert(0, objViewInfoEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conViewInfo.ViewId;
objComboBox.DisplayMember = conViewInfo.ViewName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsViewInfoEN objViewInfoEN)
{
if (!Object.Equals(null, objViewInfoEN.ViewId) && GetStrLen(objViewInfoEN.ViewId) > 8)
{
 throw new Exception("字段[界面Id]的长度不能超过8!");
}
if (!Object.Equals(null, objViewInfoEN.ViewName) && GetStrLen(objViewInfoEN.ViewName) > 100)
{
 throw new Exception("字段[界面名称]的长度不能超过100!");
}
if (!Object.Equals(null, objViewInfoEN.FuncModuleAgcId) && GetStrLen(objViewInfoEN.FuncModuleAgcId) > 8)
{
 throw new Exception("字段[功能模块Id]的长度不能超过8!");
}
if (!Object.Equals(null, objViewInfoEN.DataBaseName) && GetStrLen(objViewInfoEN.DataBaseName) > 50)
{
 throw new Exception("字段[数据库名]的长度不能超过50!");
}
if (!Object.Equals(null, objViewInfoEN.KeyForMainTab) && GetStrLen(objViewInfoEN.KeyForMainTab) > 50)
{
 throw new Exception("字段[主表关键字]的长度不能超过50!");
}
if (!Object.Equals(null, objViewInfoEN.KeyForDetailTab) && GetStrLen(objViewInfoEN.KeyForDetailTab) > 50)
{
 throw new Exception("字段[明细表关键字]的长度不能超过50!");
}
if (!Object.Equals(null, objViewInfoEN.UserId) && GetStrLen(objViewInfoEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objViewInfoEN.PrjId) && GetStrLen(objViewInfoEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objViewInfoEN.ViewFunction) && GetStrLen(objViewInfoEN.ViewFunction) > 100)
{
 throw new Exception("字段[界面功能]的长度不能超过100!");
}
if (!Object.Equals(null, objViewInfoEN.ViewDetail) && GetStrLen(objViewInfoEN.ViewDetail) > 1000)
{
 throw new Exception("字段[界面说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objViewInfoEN.DefaMenuName) && GetStrLen(objViewInfoEN.DefaMenuName) > 100)
{
 throw new Exception("字段[缺省菜单名]的长度不能超过100!");
}
if (!Object.Equals(null, objViewInfoEN.DetailTabId) && GetStrLen(objViewInfoEN.DetailTabId) > 8)
{
 throw new Exception("字段[明细表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objViewInfoEN.FileName) && GetStrLen(objViewInfoEN.FileName) > 150)
{
 throw new Exception("字段[文件名]的长度不能超过150!");
}
if (!Object.Equals(null, objViewInfoEN.FilePath) && GetStrLen(objViewInfoEN.FilePath) > 500)
{
 throw new Exception("字段[文件路径]的长度不能超过500!");
}
if (!Object.Equals(null, objViewInfoEN.MainTabId) && GetStrLen(objViewInfoEN.MainTabId) > 8)
{
 throw new Exception("字段[主表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objViewInfoEN.ViewCnName) && GetStrLen(objViewInfoEN.ViewCnName) > 100)
{
 throw new Exception("字段[视图中文名]的长度不能超过100!");
}
if (!Object.Equals(null, objViewInfoEN.ViewGroupId) && GetStrLen(objViewInfoEN.ViewGroupId) > 8)
{
 throw new Exception("字段[界面组ID]的长度不能超过8!");
}
if (!Object.Equals(null, objViewInfoEN.InRelaTabId) && GetStrLen(objViewInfoEN.InRelaTabId) > 8)
{
 throw new Exception("字段[输入数据源表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objViewInfoEN.InSqlDsTypeId) && GetStrLen(objViewInfoEN.InSqlDsTypeId) > 2)
{
 throw new Exception("字段[输入数据源类型]的长度不能超过2!");
}
if (!Object.Equals(null, objViewInfoEN.OutRelaTabId) && GetStrLen(objViewInfoEN.OutRelaTabId) > 8)
{
 throw new Exception("字段[输出数据源表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objViewInfoEN.OutSqlDsTypeId) && GetStrLen(objViewInfoEN.OutSqlDsTypeId) > 2)
{
 throw new Exception("字段[输出数据源类型]的长度不能超过2!");
}
if (!Object.Equals(null, objViewInfoEN.DetailTabType) && GetStrLen(objViewInfoEN.DetailTabType) > 10)
{
 throw new Exception("字段[DetailTabType]的长度不能超过10!");
}
if (!Object.Equals(null, objViewInfoEN.DetailViewId) && GetStrLen(objViewInfoEN.DetailViewId) > 8)
{
 throw new Exception("字段[DetailViewId]的长度不能超过8!");
}
if (!Object.Equals(null, objViewInfoEN.MainTabType) && GetStrLen(objViewInfoEN.MainTabType) > 10)
{
 throw new Exception("字段[MainTabType]的长度不能超过10!");
}
if (!Object.Equals(null, objViewInfoEN.MainViewId) && GetStrLen(objViewInfoEN.MainViewId) > 8)
{
 throw new Exception("字段[MainViewId]的长度不能超过8!");
}
if (!Object.Equals(null, objViewInfoEN.GeneCodeDate) && GetStrLen(objViewInfoEN.GeneCodeDate) > 20)
{
 throw new Exception("字段[生成代码日期]的长度不能超过20!");
}
if (!Object.Equals(null, objViewInfoEN.TaskId) && GetStrLen(objViewInfoEN.TaskId) > 16)
{
 throw new Exception("字段[任务Id]的长度不能超过16!");
}
if (!Object.Equals(null, objViewInfoEN.KeyId4Test) && GetStrLen(objViewInfoEN.KeyId4Test) > 50)
{
 throw new Exception("字段[测试关键字Id]的长度不能超过50!");
}
if (!Object.Equals(null, objViewInfoEN.ViewMasterId) && GetStrLen(objViewInfoEN.ViewMasterId) > 8)
{
 throw new Exception("字段[界面母版Id]的长度不能超过8!");
}
if (!Object.Equals(null, objViewInfoEN.ErrMsg) && GetStrLen(objViewInfoEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objViewInfoEN.UpdDate) && GetStrLen(objViewInfoEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objViewInfoEN.UpdUserId) && GetStrLen(objViewInfoEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objViewInfoEN.Memo) && GetStrLen(objViewInfoEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objViewInfoEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewInfoEN GetObjByViewId(string strViewId)
{
if (strViewId == "") return null;
string strAction = "GetObjByViewId";
clsViewInfoEN objViewInfoEN;
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
objViewInfoEN = JsonConvert.DeserializeObject<clsViewInfoEN>(strJson);
return objViewInfoEN;
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
public static clsViewInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsViewInfoEN objViewInfoEN;
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
objViewInfoEN = JsonConvert.DeserializeObject<clsViewInfoEN>(strJson);
return objViewInfoEN;
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
public static clsViewInfoEN GetObjByViewIdCache(string strViewId,string strPrjId)
{
if (string.IsNullOrEmpty(strViewId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsViewInfoEN._CurrTabName, strPrjId);
List<clsViewInfoEN> arrViewInfoObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewInfoEN> arrViewInfoObjLst_Sel =
from objViewInfoEN in arrViewInfoObjLstCache
where objViewInfoEN.ViewId == strViewId 
select objViewInfoEN;
if (arrViewInfoObjLst_Sel.Count() == 0)
{
   clsViewInfoEN obj = clsViewInfoWApi.GetObjByViewId(strViewId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrViewInfoObjLst_Sel.First();
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
List<clsViewInfoEN> arrViewInfoObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewInfoEN> arrViewInfoObjLst_Sel1 =
from objViewInfoEN in arrViewInfoObjLstCache
where objViewInfoEN.ViewId == strViewId 
select objViewInfoEN;
List <clsViewInfoEN> arrViewInfoObjLst_Sel = new List<clsViewInfoEN>();
foreach (clsViewInfoEN obj in arrViewInfoObjLst_Sel1)
{
arrViewInfoObjLst_Sel.Add(obj);
}
if (arrViewInfoObjLst_Sel.Count > 0)
{
return arrViewInfoObjLst_Sel[0].ViewName;
}
string strErrMsgForGetObjById = string.Format("在ViewInfo对象缓存列表中,找不到记录[ViewId = {0}](函数:{1})", strViewId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsViewInfoBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
List<clsViewInfoEN> arrViewInfoObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewInfoEN> arrViewInfoObjLst_Sel1 =
from objViewInfoEN in arrViewInfoObjLstCache
where objViewInfoEN.ViewId == strViewId 
select objViewInfoEN;
List <clsViewInfoEN> arrViewInfoObjLst_Sel = new List<clsViewInfoEN>();
foreach (clsViewInfoEN obj in arrViewInfoObjLst_Sel1)
{
arrViewInfoObjLst_Sel.Add(obj);
}
if (arrViewInfoObjLst_Sel.Count > 0)
{
return arrViewInfoObjLst_Sel[0].ViewName;
}
string strErrMsgForGetObjById = string.Format("在ViewInfo对象缓存列表中,找不到记录的相关名称[ViewId = {0}](函数:{1})", strViewId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsViewInfoBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewInfoEN> GetObjLst(string strWhereCond)
{
 List<clsViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewInfoEN>>(strJson);
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
public static List<clsViewInfoEN> GetObjLstByViewIdLst(List<string> arrViewId)
{
 List<clsViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewInfoEN>>(strJson);
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
public static IEnumerable<clsViewInfoEN> GetObjLstByViewIdLstCache(List<string> arrViewId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsViewInfoEN._CurrTabName, strPrjId);
List<clsViewInfoEN> arrViewInfoObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewInfoEN> arrViewInfoObjLst_Sel =
from objViewInfoEN in arrViewInfoObjLstCache
where arrViewId.Contains(objViewInfoEN.ViewId)
select objViewInfoEN;
return arrViewInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewInfoEN>>(strJson);
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
public static List<clsViewInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewInfoEN>>(strJson);
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
public static List<clsViewInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewInfoEN>>(strJson);
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
public static List<clsViewInfoEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewInfoEN>>(strJson);
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
public static int DelRecord(string strViewId)
{
string strAction = "DelRecord";
try
{
 clsViewInfoEN objViewInfoEN = clsViewInfoWApi.GetObjByViewId(strViewId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strViewId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsViewInfoWApi.ReFreshCache(objViewInfoEN.PrjId);
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
public static int DelViewInfos(List<string> arrViewId)
{
string strAction = "DelViewInfos";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsViewInfoEN objViewInfoEN = clsViewInfoWApi.GetObjByViewId(arrViewId[0]);
clsViewInfoWApi.ReFreshCache(objViewInfoEN.PrjId);
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
public static int DelViewInfosByCond(string strWhereCond)
{
string strAction = "DelViewInfosByCond";
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
public static bool AddNewRecord(clsViewInfoEN objViewInfoEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewInfoEN>(objViewInfoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoWApi.ReFreshCache(objViewInfoEN.PrjId);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsViewInfoEN objViewInfoEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewInfoEN>(objViewInfoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoWApi.ReFreshCache(objViewInfoEN.PrjId);
var strViewId = (string)jobjReturn0["returnStr"];
return strViewId;
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
public static bool UpdateRecord(clsViewInfoEN objViewInfoEN)
{
if (string.IsNullOrEmpty(objViewInfoEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewInfoEN.ViewId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewInfoEN>(objViewInfoEN);
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
 /// <param name = "objViewInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsViewInfoEN objViewInfoEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objViewInfoEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewInfoEN.ViewId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewInfoEN.ViewId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewInfoEN>(objViewInfoEN);
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objViewInfoENS">源对象</param>
 /// <param name = "objViewInfoENT">目标对象</param>
 public static void CopyTo(clsViewInfoEN objViewInfoENS, clsViewInfoEN objViewInfoENT)
{
try
{
objViewInfoENT.ViewId = objViewInfoENS.ViewId; //界面Id
objViewInfoENT.ViewName = objViewInfoENS.ViewName; //界面名称
objViewInfoENT.ApplicationTypeId = objViewInfoENS.ApplicationTypeId; //应用程序类型ID
objViewInfoENT.FuncModuleAgcId = objViewInfoENS.FuncModuleAgcId; //功能模块Id
objViewInfoENT.DataBaseName = objViewInfoENS.DataBaseName; //数据库名
objViewInfoENT.KeyForMainTab = objViewInfoENS.KeyForMainTab; //主表关键字
objViewInfoENT.KeyForDetailTab = objViewInfoENS.KeyForDetailTab; //明细表关键字
objViewInfoENT.IsNeedSort = objViewInfoENS.IsNeedSort; //是否需要排序
objViewInfoENT.IsNeedTransCode = objViewInfoENS.IsNeedTransCode; //是否需要转换代码
objViewInfoENT.IsNeedSetExportFld = objViewInfoENS.IsNeedSetExportFld; //是否需要设置导出字段
objViewInfoENT.UserId = objViewInfoENS.UserId; //用户Id
objViewInfoENT.PrjId = objViewInfoENS.PrjId; //工程Id
objViewInfoENT.ViewFunction = objViewInfoENS.ViewFunction; //界面功能
objViewInfoENT.ViewDetail = objViewInfoENS.ViewDetail; //界面说明
objViewInfoENT.DefaMenuName = objViewInfoENS.DefaMenuName; //缺省菜单名
objViewInfoENT.DetailTabId = objViewInfoENS.DetailTabId; //明细表ID
objViewInfoENT.FileName = objViewInfoENS.FileName; //文件名
objViewInfoENT.FilePath = objViewInfoENS.FilePath; //文件路径
objViewInfoENT.MainTabId = objViewInfoENS.MainTabId; //主表ID
objViewInfoENT.ViewCnName = objViewInfoENS.ViewCnName; //视图中文名
objViewInfoENT.ViewGroupId = objViewInfoENS.ViewGroupId; //界面组ID
objViewInfoENT.InRelaTabId = objViewInfoENS.InRelaTabId; //输入数据源表ID
objViewInfoENT.InSqlDsTypeId = objViewInfoENS.InSqlDsTypeId; //输入数据源类型
objViewInfoENT.OutRelaTabId = objViewInfoENS.OutRelaTabId; //输出数据源表ID
objViewInfoENT.OutSqlDsTypeId = objViewInfoENS.OutSqlDsTypeId; //输出数据源类型
objViewInfoENT.DetailTabType = objViewInfoENS.DetailTabType; //DetailTabType
objViewInfoENT.DetailViewId = objViewInfoENS.DetailViewId; //DetailViewId
objViewInfoENT.MainTabType = objViewInfoENS.MainTabType; //MainTabType
objViewInfoENT.MainViewId = objViewInfoENS.MainViewId; //MainViewId
objViewInfoENT.GeneCodeDate = objViewInfoENS.GeneCodeDate; //生成代码日期
objViewInfoENT.TaskId = objViewInfoENS.TaskId; //任务Id
objViewInfoENT.KeyId4Test = objViewInfoENS.KeyId4Test; //测试关键字Id
objViewInfoENT.ViewMasterId = objViewInfoENS.ViewMasterId; //界面母版Id
objViewInfoENT.IsShare = objViewInfoENS.IsShare; //是否共享
objViewInfoENT.ErrMsg = objViewInfoENS.ErrMsg; //错误信息
objViewInfoENT.UpdDate = objViewInfoENS.UpdDate; //修改日期
objViewInfoENT.UpdUserId = objViewInfoENS.UpdUserId; //修改用户Id
objViewInfoENT.Memo = objViewInfoENS.Memo; //说明
objViewInfoENT.RegionNum = objViewInfoENS.RegionNum; //区域数
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
public static DataTable ToDataTable(List<clsViewInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsViewInfoEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsViewInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsViewInfoEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsViewInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsViewInfoEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewInfoWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewInfoWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsViewInfoEN._CurrTabName, strPrjId);
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
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsViewInfoWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewInfoEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewInfoWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewInfoEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewInfoWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewInfoWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsViewInfoEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsViewInfoEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conViewInfo.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsViewInfoEN._CurrTabName, strPrjId);
List<clsViewInfoEN> arrViewInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrViewInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewInfoEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsViewInfoEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewInfoWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewInfoWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsViewInfoEN._CurrTabName, strPrjId);
List<clsViewInfoEN> arrViewInfoObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrViewInfoObjLstCache = CacheHelper.Get<List<clsViewInfoEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrViewInfoObjLstCache = CacheHelper.Get<List<clsViewInfoEN>>(strKey);
}
return arrViewInfoObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsViewInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conViewInfo.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewInfo.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.DataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.KeyForMainTab, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.KeyForDetailTab, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.IsNeedSort, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewInfo.IsNeedTransCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewInfo.IsNeedSetExportFld, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewInfo.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.ViewFunction, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.ViewDetail, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.DefaMenuName, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.DetailTabId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.MainTabId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.ViewCnName, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.ViewGroupId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.InRelaTabId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.InSqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.OutRelaTabId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.OutSqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.DetailTabType, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.DetailViewId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.MainTabType, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.MainViewId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.GeneCodeDate, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.TaskId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.KeyId4Test, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.ViewMasterId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.IsShare, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewInfo.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conViewInfo.RegionNum, Type.GetType("System.Int32"));
foreach (clsViewInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conViewInfo.ViewId] = objInFor[conViewInfo.ViewId];
objDR[conViewInfo.ViewName] = objInFor[conViewInfo.ViewName];
objDR[conViewInfo.ApplicationTypeId] = objInFor[conViewInfo.ApplicationTypeId];
objDR[conViewInfo.FuncModuleAgcId] = objInFor[conViewInfo.FuncModuleAgcId];
objDR[conViewInfo.DataBaseName] = objInFor[conViewInfo.DataBaseName];
objDR[conViewInfo.KeyForMainTab] = objInFor[conViewInfo.KeyForMainTab];
objDR[conViewInfo.KeyForDetailTab] = objInFor[conViewInfo.KeyForDetailTab];
objDR[conViewInfo.IsNeedSort] = objInFor[conViewInfo.IsNeedSort];
objDR[conViewInfo.IsNeedTransCode] = objInFor[conViewInfo.IsNeedTransCode];
objDR[conViewInfo.IsNeedSetExportFld] = objInFor[conViewInfo.IsNeedSetExportFld];
objDR[conViewInfo.UserId] = objInFor[conViewInfo.UserId];
objDR[conViewInfo.PrjId] = objInFor[conViewInfo.PrjId];
objDR[conViewInfo.ViewFunction] = objInFor[conViewInfo.ViewFunction];
objDR[conViewInfo.ViewDetail] = objInFor[conViewInfo.ViewDetail];
objDR[conViewInfo.DefaMenuName] = objInFor[conViewInfo.DefaMenuName];
objDR[conViewInfo.DetailTabId] = objInFor[conViewInfo.DetailTabId];
objDR[conViewInfo.FileName] = objInFor[conViewInfo.FileName];
objDR[conViewInfo.FilePath] = objInFor[conViewInfo.FilePath];
objDR[conViewInfo.MainTabId] = objInFor[conViewInfo.MainTabId];
objDR[conViewInfo.ViewCnName] = objInFor[conViewInfo.ViewCnName];
objDR[conViewInfo.ViewGroupId] = objInFor[conViewInfo.ViewGroupId];
objDR[conViewInfo.InRelaTabId] = objInFor[conViewInfo.InRelaTabId];
objDR[conViewInfo.InSqlDsTypeId] = objInFor[conViewInfo.InSqlDsTypeId];
objDR[conViewInfo.OutRelaTabId] = objInFor[conViewInfo.OutRelaTabId];
objDR[conViewInfo.OutSqlDsTypeId] = objInFor[conViewInfo.OutSqlDsTypeId];
objDR[conViewInfo.DetailTabType] = objInFor[conViewInfo.DetailTabType];
objDR[conViewInfo.DetailViewId] = objInFor[conViewInfo.DetailViewId];
objDR[conViewInfo.MainTabType] = objInFor[conViewInfo.MainTabType];
objDR[conViewInfo.MainViewId] = objInFor[conViewInfo.MainViewId];
objDR[conViewInfo.GeneCodeDate] = objInFor[conViewInfo.GeneCodeDate];
objDR[conViewInfo.TaskId] = objInFor[conViewInfo.TaskId];
objDR[conViewInfo.KeyId4Test] = objInFor[conViewInfo.KeyId4Test];
objDR[conViewInfo.ViewMasterId] = objInFor[conViewInfo.ViewMasterId];
objDR[conViewInfo.IsShare] = objInFor[conViewInfo.IsShare];
objDR[conViewInfo.ErrMsg] = objInFor[conViewInfo.ErrMsg];
objDR[conViewInfo.UpdDate] = objInFor[conViewInfo.UpdDate];
objDR[conViewInfo.UpdUserId] = objInFor[conViewInfo.UpdUserId];
objDR[conViewInfo.Memo] = objInFor[conViewInfo.Memo];
objDR[conViewInfo.RegionNum] = objInFor[conViewInfo.RegionNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 界面(ViewInfo)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ViewInfo : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
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
clsViewInfoWApi.ReFreshThisCache(strPrjId);
}
}

}