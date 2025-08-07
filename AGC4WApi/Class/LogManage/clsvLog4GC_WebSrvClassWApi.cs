
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvLog4GC_WebSrvClassWApi
 表名:vLog4GC_WebSrvClass(00050371)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/23 23:09:24
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
 框架-层名:WA_访问层(CS)(WA_Access)
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
public static class  clsvLog4GC_WebSrvClassWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetmId(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, long lngmId, string strComparisonOp="")
	{
objvLog4GC_WebSrvClassEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.mId) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.mId, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.mId] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetUserId(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convLog4GC_WebSrvClass.UserId);
objvLog4GC_WebSrvClassEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.UserId) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.UserId, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.UserId] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetUserName(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convLog4GC_WebSrvClass.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convLog4GC_WebSrvClass.UserName);
objvLog4GC_WebSrvClassEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.UserName) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.UserName, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.UserName] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvClassId">类Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetWebSrvClassId(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strWebSrvClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvClassId, convLog4GC_WebSrvClass.WebSrvClassId);
clsCheckSql.CheckFieldLen(strWebSrvClassId, 8, convLog4GC_WebSrvClass.WebSrvClassId);
clsCheckSql.CheckFieldForeignKey(strWebSrvClassId, 8, convLog4GC_WebSrvClass.WebSrvClassId);
objvLog4GC_WebSrvClassEN.WebSrvClassId = strWebSrvClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.WebSrvClassId) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.WebSrvClassId, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.WebSrvClassId] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strClassName">类名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetClassName(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strClassName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassName, convLog4GC_WebSrvClass.ClsName);
clsCheckSql.CheckFieldLen(strClassName, 100, convLog4GC_WebSrvClass.ClsName);
objvLog4GC_WebSrvClassEN.ClsName = strClassName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.ClsName) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.ClsName, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.ClsName] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strNameSpace">域名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetNameSpace(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strNameSpace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNameSpace, 50, convLog4GC_WebSrvClass.NameSpace);
objvLog4GC_WebSrvClassEN.NameSpace = strNameSpace; //域名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.NameSpace) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.NameSpace, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.NameSpace] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvUrl">WebSrv地址</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetWebSrvUrl(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strWebSrvUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvUrl, convLog4GC_WebSrvClass.WebSrvUrl);
clsCheckSql.CheckFieldLen(strWebSrvUrl, 300, convLog4GC_WebSrvClass.WebSrvUrl);
objvLog4GC_WebSrvClassEN.WebSrvUrl = strWebSrvUrl; //WebSrv地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.WebSrvUrl) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.WebSrvUrl, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.WebSrvUrl] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageName">页面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetPageName(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strPageName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageName, 100, convLog4GC_WebSrvClass.PageName);
objvLog4GC_WebSrvClassEN.PageName = strPageName; //页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.PageName) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.PageName, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.PageName] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetFuncModuleAgcId(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convLog4GC_WebSrvClass.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convLog4GC_WebSrvClass.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convLog4GC_WebSrvClass.FuncModuleAgcId);
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.FuncModuleAgcId) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.FuncModuleAgcId, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.FuncModuleAgcId] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetFuncModuleName(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convLog4GC_WebSrvClass.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convLog4GC_WebSrvClass.FuncModuleName);
objvLog4GC_WebSrvClassEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.FuncModuleName) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.FuncModuleName, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.FuncModuleName] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedGene">是否需要生成</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetIsNeedGene(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, bool bolIsNeedGene, string strComparisonOp="")
	{
objvLog4GC_WebSrvClassEN.IsNeedGene = bolIsNeedGene; //是否需要生成
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.IsNeedGene) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.IsNeedGene, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.IsNeedGene] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetPrjId(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convLog4GC_WebSrvClass.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convLog4GC_WebSrvClass.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convLog4GC_WebSrvClass.PrjId);
objvLog4GC_WebSrvClassEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.PrjId) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.PrjId, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.PrjId] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetPrjName(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convLog4GC_WebSrvClass.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convLog4GC_WebSrvClass.PrjName);
objvLog4GC_WebSrvClassEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.PrjName) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.PrjName, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.PrjName] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "intFuncNum">函数个数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetFuncNum(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, int intFuncNum, string strComparisonOp="")
	{
objvLog4GC_WebSrvClassEN.FuncNum = intFuncNum; //函数个数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.FuncNum) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.FuncNum, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.FuncNum] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strGeneCodeDate">生成代码日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetGeneCodeDate(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strGeneCodeDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convLog4GC_WebSrvClass.GeneCodeDate);
objvLog4GC_WebSrvClassEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.GeneCodeDate) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.GeneCodeDate, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.GeneCodeDate] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strVersionGeneCode">生成代码版本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetVersionGeneCode(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strVersionGeneCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionGeneCode, convLog4GC_WebSrvClass.VersionGeneCode);
clsCheckSql.CheckFieldLen(strVersionGeneCode, 30, convLog4GC_WebSrvClass.VersionGeneCode);
objvLog4GC_WebSrvClassEN.VersionGeneCode = strVersionGeneCode; //生成代码版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.VersionGeneCode) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.VersionGeneCode, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.VersionGeneCode] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetMemo(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convLog4GC_WebSrvClass.Memo);
objvLog4GC_WebSrvClassEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(convLog4GC_WebSrvClass.Memo) == false)
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(convLog4GC_WebSrvClass.Memo, strComparisonOp);
}
else
{
objvLog4GC_WebSrvClassEN.dicFldComparisonOp[convLog4GC_WebSrvClass.Memo] = strComparisonOp;
}
}
return objvLog4GC_WebSrvClassEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.mId) == true)
{
string strComparisonOpmId = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convLog4GC_WebSrvClass.mId, objvLog4GC_WebSrvClassCond.mId, strComparisonOpmId);
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.UserId) == true)
{
string strComparisonOpUserId = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GC_WebSrvClass.UserId, objvLog4GC_WebSrvClassCond.UserId, strComparisonOpUserId);
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.UserName) == true)
{
string strComparisonOpUserName = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GC_WebSrvClass.UserName, objvLog4GC_WebSrvClassCond.UserName, strComparisonOpUserName);
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.WebSrvClassId) == true)
{
string strComparisonOpWebSrvClassId = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.WebSrvClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GC_WebSrvClass.WebSrvClassId, objvLog4GC_WebSrvClassCond.WebSrvClassId, strComparisonOpWebSrvClassId);
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.ClsName) == true)
{
string strComparisonOpClassName = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GC_WebSrvClass.ClsName, objvLog4GC_WebSrvClassCond.ClsName, strComparisonOpClassName);
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.NameSpace) == true)
{
string strComparisonOpNameSpace = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.NameSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GC_WebSrvClass.NameSpace, objvLog4GC_WebSrvClassCond.NameSpace, strComparisonOpNameSpace);
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.WebSrvUrl) == true)
{
string strComparisonOpWebSrvUrl = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.WebSrvUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GC_WebSrvClass.WebSrvUrl, objvLog4GC_WebSrvClassCond.WebSrvUrl, strComparisonOpWebSrvUrl);
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.PageName) == true)
{
string strComparisonOpPageName = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.PageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GC_WebSrvClass.PageName, objvLog4GC_WebSrvClassCond.PageName, strComparisonOpPageName);
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GC_WebSrvClass.FuncModuleAgcId, objvLog4GC_WebSrvClassCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GC_WebSrvClass.FuncModuleName, objvLog4GC_WebSrvClassCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.IsNeedGene) == true)
{
if (objvLog4GC_WebSrvClassCond.IsNeedGene == true)
{
strWhereCond += string.Format(" And {0} = '1'", convLog4GC_WebSrvClass.IsNeedGene);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convLog4GC_WebSrvClass.IsNeedGene);
}
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.PrjId) == true)
{
string strComparisonOpPrjId = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GC_WebSrvClass.PrjId, objvLog4GC_WebSrvClassCond.PrjId, strComparisonOpPrjId);
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.PrjName) == true)
{
string strComparisonOpPrjName = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GC_WebSrvClass.PrjName, objvLog4GC_WebSrvClassCond.PrjName, strComparisonOpPrjName);
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.FuncNum) == true)
{
string strComparisonOpFuncNum = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.FuncNum];
strWhereCond += string.Format(" And {0} {2} {1}", convLog4GC_WebSrvClass.FuncNum, objvLog4GC_WebSrvClassCond.FuncNum, strComparisonOpFuncNum);
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.GeneCodeDate) == true)
{
string strComparisonOpGeneCodeDate = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GC_WebSrvClass.GeneCodeDate, objvLog4GC_WebSrvClassCond.GeneCodeDate, strComparisonOpGeneCodeDate);
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.VersionGeneCode) == true)
{
string strComparisonOpVersionGeneCode = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.VersionGeneCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GC_WebSrvClass.VersionGeneCode, objvLog4GC_WebSrvClassCond.VersionGeneCode, strComparisonOpVersionGeneCode);
}
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.Memo) == true)
{
string strComparisonOpMemo = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GC_WebSrvClass.Memo, objvLog4GC_WebSrvClassCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v生成WebSrvClass代码日志(vLog4GC_WebSrvClass)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvLog4GC_WebSrvClassWApi
{
private static readonly string mstrApiControllerName = "vLog4GC_WebSrvClassApi";

 public clsvLog4GC_WebSrvClassWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvLog4GC_WebSrvClassEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN;
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
objvLog4GC_WebSrvClassEN = JsonConvert.DeserializeObject<clsvLog4GC_WebSrvClassEN>(strJson);
return objvLog4GC_WebSrvClassEN;
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
public static clsvLog4GC_WebSrvClassEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN;
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
objvLog4GC_WebSrvClassEN = JsonConvert.DeserializeObject<clsvLog4GC_WebSrvClassEN>(strJson);
return objvLog4GC_WebSrvClassEN;
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
public static List<clsvLog4GC_WebSrvClassEN> GetObjLst(string strWhereCond)
{
 List<clsvLog4GC_WebSrvClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GC_WebSrvClassEN>>(strJson);
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
public static List<clsvLog4GC_WebSrvClassEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvLog4GC_WebSrvClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GC_WebSrvClassEN>>(strJson);
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
public static List<clsvLog4GC_WebSrvClassEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvLog4GC_WebSrvClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GC_WebSrvClassEN>>(strJson);
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
public static List<clsvLog4GC_WebSrvClassEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvLog4GC_WebSrvClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GC_WebSrvClassEN>>(strJson);
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
public static List<clsvLog4GC_WebSrvClassEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvLog4GC_WebSrvClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GC_WebSrvClassEN>>(strJson);
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
public static List<clsvLog4GC_WebSrvClassEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvLog4GC_WebSrvClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GC_WebSrvClassEN>>(strJson);
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
 /// <param name = "objvLog4GC_WebSrvClassENS">源对象</param>
 /// <param name = "objvLog4GC_WebSrvClassENT">目标对象</param>
 public static void CopyTo(clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassENS, clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassENT)
{
try
{
objvLog4GC_WebSrvClassENT.mId = objvLog4GC_WebSrvClassENS.mId; //mId
objvLog4GC_WebSrvClassENT.UserId = objvLog4GC_WebSrvClassENS.UserId; //用户Id
objvLog4GC_WebSrvClassENT.UserName = objvLog4GC_WebSrvClassENS.UserName; //用户名
objvLog4GC_WebSrvClassENT.WebSrvClassId = objvLog4GC_WebSrvClassENS.WebSrvClassId; //类Id
objvLog4GC_WebSrvClassENT.ClsName = objvLog4GC_WebSrvClassENS.ClsName; //类名
objvLog4GC_WebSrvClassENT.NameSpace = objvLog4GC_WebSrvClassENS.NameSpace; //域名
objvLog4GC_WebSrvClassENT.WebSrvUrl = objvLog4GC_WebSrvClassENS.WebSrvUrl; //WebSrv地址
objvLog4GC_WebSrvClassENT.PageName = objvLog4GC_WebSrvClassENS.PageName; //页面名称
objvLog4GC_WebSrvClassENT.FuncModuleAgcId = objvLog4GC_WebSrvClassENS.FuncModuleAgcId; //功能模块Id
objvLog4GC_WebSrvClassENT.FuncModuleName = objvLog4GC_WebSrvClassENS.FuncModuleName; //功能模块名称
objvLog4GC_WebSrvClassENT.IsNeedGene = objvLog4GC_WebSrvClassENS.IsNeedGene; //是否需要生成
objvLog4GC_WebSrvClassENT.PrjId = objvLog4GC_WebSrvClassENS.PrjId; //工程ID
objvLog4GC_WebSrvClassENT.PrjName = objvLog4GC_WebSrvClassENS.PrjName; //工程名称
objvLog4GC_WebSrvClassENT.FuncNum = objvLog4GC_WebSrvClassENS.FuncNum; //函数个数
objvLog4GC_WebSrvClassENT.GeneCodeDate = objvLog4GC_WebSrvClassENS.GeneCodeDate; //生成代码日期
objvLog4GC_WebSrvClassENT.VersionGeneCode = objvLog4GC_WebSrvClassENS.VersionGeneCode; //生成代码版本
objvLog4GC_WebSrvClassENT.Memo = objvLog4GC_WebSrvClassENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvLog4GC_WebSrvClassEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvLog4GC_WebSrvClassEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvLog4GC_WebSrvClassEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvLog4GC_WebSrvClassEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvLog4GC_WebSrvClassEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvLog4GC_WebSrvClassEN.AttributeName)
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
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvLog4GC_WebSrvClassEN._CurrTabName);
CacheHelper.Remove(strKey);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvLog4GC_WebSrvClassEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convLog4GC_WebSrvClass.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convLog4GC_WebSrvClass.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GC_WebSrvClass.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GC_WebSrvClass.WebSrvClassId, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GC_WebSrvClass.ClsName, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GC_WebSrvClass.NameSpace, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GC_WebSrvClass.WebSrvUrl, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GC_WebSrvClass.PageName, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GC_WebSrvClass.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GC_WebSrvClass.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GC_WebSrvClass.IsNeedGene, Type.GetType("System.Boolean"));
objDT.Columns.Add(convLog4GC_WebSrvClass.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GC_WebSrvClass.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GC_WebSrvClass.FuncNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convLog4GC_WebSrvClass.GeneCodeDate, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GC_WebSrvClass.VersionGeneCode, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GC_WebSrvClass.Memo, Type.GetType("System.String"));
foreach (clsvLog4GC_WebSrvClassEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convLog4GC_WebSrvClass.mId] = objInFor[convLog4GC_WebSrvClass.mId];
objDR[convLog4GC_WebSrvClass.UserId] = objInFor[convLog4GC_WebSrvClass.UserId];
objDR[convLog4GC_WebSrvClass.UserName] = objInFor[convLog4GC_WebSrvClass.UserName];
objDR[convLog4GC_WebSrvClass.WebSrvClassId] = objInFor[convLog4GC_WebSrvClass.WebSrvClassId];
objDR[convLog4GC_WebSrvClass.ClsName] = objInFor[convLog4GC_WebSrvClass.ClsName];
objDR[convLog4GC_WebSrvClass.NameSpace] = objInFor[convLog4GC_WebSrvClass.NameSpace];
objDR[convLog4GC_WebSrvClass.WebSrvUrl] = objInFor[convLog4GC_WebSrvClass.WebSrvUrl];
objDR[convLog4GC_WebSrvClass.PageName] = objInFor[convLog4GC_WebSrvClass.PageName];
objDR[convLog4GC_WebSrvClass.FuncModuleAgcId] = objInFor[convLog4GC_WebSrvClass.FuncModuleAgcId];
objDR[convLog4GC_WebSrvClass.FuncModuleName] = objInFor[convLog4GC_WebSrvClass.FuncModuleName];
objDR[convLog4GC_WebSrvClass.IsNeedGene] = objInFor[convLog4GC_WebSrvClass.IsNeedGene];
objDR[convLog4GC_WebSrvClass.PrjId] = objInFor[convLog4GC_WebSrvClass.PrjId];
objDR[convLog4GC_WebSrvClass.PrjName] = objInFor[convLog4GC_WebSrvClass.PrjName];
objDR[convLog4GC_WebSrvClass.FuncNum] = objInFor[convLog4GC_WebSrvClass.FuncNum];
objDR[convLog4GC_WebSrvClass.GeneCodeDate] = objInFor[convLog4GC_WebSrvClass.GeneCodeDate];
objDR[convLog4GC_WebSrvClass.VersionGeneCode] = objInFor[convLog4GC_WebSrvClass.VersionGeneCode];
objDR[convLog4GC_WebSrvClass.Memo] = objInFor[convLog4GC_WebSrvClass.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}