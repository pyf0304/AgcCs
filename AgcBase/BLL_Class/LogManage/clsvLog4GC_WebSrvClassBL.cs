
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvLog4GC_WebSrvClassBL
 表名:vLog4GC_WebSrvClass(00050371)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 16:17:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class  clsvLog4GC_WebSrvClassBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvLog4GC_WebSrvClassEN GetObj(this K_mId_vLog4GC_WebSrvClass myKey)
{
clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = clsvLog4GC_WebSrvClassBL.vLog4GC_WebSrvClassDA.GetObjBymId(myKey.Value);
return objvLog4GC_WebSrvClassEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetUserId(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convLog4GC_WebSrvClass.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetUserName(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convLog4GC_WebSrvClass.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convLog4GC_WebSrvClass.UserName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetWebSrvClassId(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strWebSrvClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvClassId, convLog4GC_WebSrvClass.WebSrvClassId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvClassId, 8, convLog4GC_WebSrvClass.WebSrvClassId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWebSrvClassId, 8, convLog4GC_WebSrvClass.WebSrvClassId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetNameSpace(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strNameSpace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNameSpace, 50, convLog4GC_WebSrvClass.NameSpace);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetWebSrvUrl(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strWebSrvUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvUrl, convLog4GC_WebSrvClass.WebSrvUrl);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvUrl, 300, convLog4GC_WebSrvClass.WebSrvUrl);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetPageName(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strPageName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageName, 100, convLog4GC_WebSrvClass.PageName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetFuncModuleAgcId(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convLog4GC_WebSrvClass.FuncModuleAgcId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convLog4GC_WebSrvClass.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convLog4GC_WebSrvClass.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetFuncModuleName(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convLog4GC_WebSrvClass.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convLog4GC_WebSrvClass.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetPrjId(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convLog4GC_WebSrvClass.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convLog4GC_WebSrvClass.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convLog4GC_WebSrvClass.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetPrjName(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convLog4GC_WebSrvClass.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convLog4GC_WebSrvClass.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetFuncNum(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, int? intFuncNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetGeneCodeDate(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strGeneCodeDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convLog4GC_WebSrvClass.GeneCodeDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetVersionGeneCode(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strVersionGeneCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionGeneCode, convLog4GC_WebSrvClass.VersionGeneCode);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionGeneCode, 30, convLog4GC_WebSrvClass.VersionGeneCode);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvLog4GC_WebSrvClassEN SetMemo(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convLog4GC_WebSrvClass.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassENS">源对象</param>
 /// <param name = "objvLog4GC_WebSrvClassENT">目标对象</param>
 public static void CopyTo(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassENS, clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassENT)
{
try
{
objvLog4GC_WebSrvClassENT.mId = objvLog4GC_WebSrvClassENS.mId; //mId
objvLog4GC_WebSrvClassENT.UserId = objvLog4GC_WebSrvClassENS.UserId; //用户Id
objvLog4GC_WebSrvClassENT.UserName = objvLog4GC_WebSrvClassENS.UserName; //用户名
objvLog4GC_WebSrvClassENT.WebSrvClassId = objvLog4GC_WebSrvClassENS.WebSrvClassId; //类Id
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
objvLog4GC_WebSrvClassENT.ClsName = objvLog4GC_WebSrvClassENS.ClsName; //类名
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
 /// <param name = "objvLog4GC_WebSrvClassENS">源对象</param>
 /// <returns>目标对象=>clsvLog4GC_WebSrvClassEN:objvLog4GC_WebSrvClassENT</returns>
 public static clsvLog4GC_WebSrvClassEN CopyTo(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassENS)
{
try
{
 clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassENT = new clsvLog4GC_WebSrvClassEN()
{
mId = objvLog4GC_WebSrvClassENS.mId, //mId
UserId = objvLog4GC_WebSrvClassENS.UserId, //用户Id
UserName = objvLog4GC_WebSrvClassENS.UserName, //用户名
WebSrvClassId = objvLog4GC_WebSrvClassENS.WebSrvClassId, //类Id
NameSpace = objvLog4GC_WebSrvClassENS.NameSpace, //域名
WebSrvUrl = objvLog4GC_WebSrvClassENS.WebSrvUrl, //WebSrv地址
PageName = objvLog4GC_WebSrvClassENS.PageName, //页面名称
FuncModuleAgcId = objvLog4GC_WebSrvClassENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvLog4GC_WebSrvClassENS.FuncModuleName, //功能模块名称
IsNeedGene = objvLog4GC_WebSrvClassENS.IsNeedGene, //是否需要生成
PrjId = objvLog4GC_WebSrvClassENS.PrjId, //工程ID
PrjName = objvLog4GC_WebSrvClassENS.PrjName, //工程名称
FuncNum = objvLog4GC_WebSrvClassENS.FuncNum, //函数个数
GeneCodeDate = objvLog4GC_WebSrvClassENS.GeneCodeDate, //生成代码日期
VersionGeneCode = objvLog4GC_WebSrvClassENS.VersionGeneCode, //生成代码版本
Memo = objvLog4GC_WebSrvClassENS.Memo, //说明
ClsName = objvLog4GC_WebSrvClassENS.ClsName, //类名
};
 return objvLog4GC_WebSrvClassENT;
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
public static void CheckProperty4Condition(this clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN)
{
 clsvLog4GC_WebSrvClassBL.vLog4GC_WebSrvClassDA.CheckProperty4Condition(objvLog4GC_WebSrvClassEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
if (objvLog4GC_WebSrvClassCond.IsUpdated(convLog4GC_WebSrvClass.ClsName) == true)
{
string strComparisonOpClsName = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[convLog4GC_WebSrvClass.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GC_WebSrvClass.ClsName, objvLog4GC_WebSrvClassCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vLog4GC_WebSrvClass
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v生成WebSrvClass代码日志(vLog4GC_WebSrvClass)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvLog4GC_WebSrvClassBL
{
public static RelatedActions_vLog4GC_WebSrvClass relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvLog4GC_WebSrvClassDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvLog4GC_WebSrvClassDA vLog4GC_WebSrvClassDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvLog4GC_WebSrvClassDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvLog4GC_WebSrvClassBL()
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
if (string.IsNullOrEmpty(clsvLog4GC_WebSrvClassEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvLog4GC_WebSrvClassEN._ConnectString);
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
public static DataTable GetDataTable_vLog4GC_WebSrvClass(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vLog4GC_WebSrvClassDA.GetDataTable_vLog4GC_WebSrvClass(strWhereCond);
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
objDT = vLog4GC_WebSrvClassDA.GetDataTable(strWhereCond);
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
objDT = vLog4GC_WebSrvClassDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vLog4GC_WebSrvClassDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vLog4GC_WebSrvClassDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vLog4GC_WebSrvClassDA.GetDataTable_Top(objTopPara);
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
objDT = vLog4GC_WebSrvClassDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vLog4GC_WebSrvClassDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vLog4GC_WebSrvClassDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvLog4GC_WebSrvClassEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvLog4GC_WebSrvClassEN> arrObjLst = new List<clsvLog4GC_WebSrvClassEN>(); 
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
	clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN();
try
{
objvLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objvLog4GC_WebSrvClassEN.UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objvLog4GC_WebSrvClassEN.UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名
objvLog4GC_WebSrvClassEN.WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvLog4GC_WebSrvClassEN.NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名
objvLog4GC_WebSrvClassEN.WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvLog4GC_WebSrvClassEN.PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GC_WebSrvClassEN.FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GC_WebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvLog4GC_WebSrvClassEN.PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID
objvLog4GC_WebSrvClassEN.PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称
objvLog4GC_WebSrvClassEN.FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvLog4GC_WebSrvClassEN.GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GC_WebSrvClassEN.VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GC_WebSrvClassEN.Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
objvLog4GC_WebSrvClassEN.ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GC_WebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvLog4GC_WebSrvClassEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvLog4GC_WebSrvClassEN._CurrTabName);
List<clsvLog4GC_WebSrvClassEN> arrvLog4GC_WebSrvClassObjLstCache = GetObjLstCache();
IEnumerable <clsvLog4GC_WebSrvClassEN> arrvLog4GC_WebSrvClassObjLst_Sel =
arrvLog4GC_WebSrvClassObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvLog4GC_WebSrvClassObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GC_WebSrvClassEN> GetObjLst(string strWhereCond)
{
List<clsvLog4GC_WebSrvClassEN> arrObjLst = new List<clsvLog4GC_WebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN();
try
{
objvLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objvLog4GC_WebSrvClassEN.UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objvLog4GC_WebSrvClassEN.UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名
objvLog4GC_WebSrvClassEN.WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvLog4GC_WebSrvClassEN.NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名
objvLog4GC_WebSrvClassEN.WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvLog4GC_WebSrvClassEN.PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GC_WebSrvClassEN.FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GC_WebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvLog4GC_WebSrvClassEN.PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID
objvLog4GC_WebSrvClassEN.PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称
objvLog4GC_WebSrvClassEN.FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvLog4GC_WebSrvClassEN.GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GC_WebSrvClassEN.VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GC_WebSrvClassEN.Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
objvLog4GC_WebSrvClassEN.ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GC_WebSrvClassEN);
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
public static List<clsvLog4GC_WebSrvClassEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvLog4GC_WebSrvClassEN> arrObjLst = new List<clsvLog4GC_WebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN();
try
{
objvLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objvLog4GC_WebSrvClassEN.UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objvLog4GC_WebSrvClassEN.UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名
objvLog4GC_WebSrvClassEN.WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvLog4GC_WebSrvClassEN.NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名
objvLog4GC_WebSrvClassEN.WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvLog4GC_WebSrvClassEN.PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GC_WebSrvClassEN.FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GC_WebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvLog4GC_WebSrvClassEN.PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID
objvLog4GC_WebSrvClassEN.PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称
objvLog4GC_WebSrvClassEN.FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvLog4GC_WebSrvClassEN.GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GC_WebSrvClassEN.VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GC_WebSrvClassEN.Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
objvLog4GC_WebSrvClassEN.ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GC_WebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvLog4GC_WebSrvClassEN> GetSubObjLstCache(clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassCond)
{
List<clsvLog4GC_WebSrvClassEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvLog4GC_WebSrvClassEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convLog4GC_WebSrvClass.AttributeName)
{
if (objvLog4GC_WebSrvClassCond.IsUpdated(strFldName) == false) continue;
if (objvLog4GC_WebSrvClassCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4GC_WebSrvClassCond[strFldName].ToString());
}
else
{
if (objvLog4GC_WebSrvClassCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4GC_WebSrvClassCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvLog4GC_WebSrvClassCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvLog4GC_WebSrvClassCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvLog4GC_WebSrvClassCond[strFldName]));
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
public static List<clsvLog4GC_WebSrvClassEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvLog4GC_WebSrvClassEN> arrObjLst = new List<clsvLog4GC_WebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN();
try
{
objvLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objvLog4GC_WebSrvClassEN.UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objvLog4GC_WebSrvClassEN.UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名
objvLog4GC_WebSrvClassEN.WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvLog4GC_WebSrvClassEN.NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名
objvLog4GC_WebSrvClassEN.WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvLog4GC_WebSrvClassEN.PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GC_WebSrvClassEN.FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GC_WebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvLog4GC_WebSrvClassEN.PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID
objvLog4GC_WebSrvClassEN.PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称
objvLog4GC_WebSrvClassEN.FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvLog4GC_WebSrvClassEN.GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GC_WebSrvClassEN.VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GC_WebSrvClassEN.Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
objvLog4GC_WebSrvClassEN.ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GC_WebSrvClassEN);
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
public static List<clsvLog4GC_WebSrvClassEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvLog4GC_WebSrvClassEN> arrObjLst = new List<clsvLog4GC_WebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN();
try
{
objvLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objvLog4GC_WebSrvClassEN.UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objvLog4GC_WebSrvClassEN.UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名
objvLog4GC_WebSrvClassEN.WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvLog4GC_WebSrvClassEN.NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名
objvLog4GC_WebSrvClassEN.WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvLog4GC_WebSrvClassEN.PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GC_WebSrvClassEN.FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GC_WebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvLog4GC_WebSrvClassEN.PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID
objvLog4GC_WebSrvClassEN.PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称
objvLog4GC_WebSrvClassEN.FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvLog4GC_WebSrvClassEN.GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GC_WebSrvClassEN.VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GC_WebSrvClassEN.Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
objvLog4GC_WebSrvClassEN.ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GC_WebSrvClassEN);
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
List<clsvLog4GC_WebSrvClassEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvLog4GC_WebSrvClassEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GC_WebSrvClassEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvLog4GC_WebSrvClassEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvLog4GC_WebSrvClassEN> arrObjLst = new List<clsvLog4GC_WebSrvClassEN>(); 
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
	clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN();
try
{
objvLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objvLog4GC_WebSrvClassEN.UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objvLog4GC_WebSrvClassEN.UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名
objvLog4GC_WebSrvClassEN.WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvLog4GC_WebSrvClassEN.NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名
objvLog4GC_WebSrvClassEN.WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvLog4GC_WebSrvClassEN.PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GC_WebSrvClassEN.FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GC_WebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvLog4GC_WebSrvClassEN.PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID
objvLog4GC_WebSrvClassEN.PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称
objvLog4GC_WebSrvClassEN.FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvLog4GC_WebSrvClassEN.GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GC_WebSrvClassEN.VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GC_WebSrvClassEN.Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
objvLog4GC_WebSrvClassEN.ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GC_WebSrvClassEN);
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
public static List<clsvLog4GC_WebSrvClassEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvLog4GC_WebSrvClassEN> arrObjLst = new List<clsvLog4GC_WebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN();
try
{
objvLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objvLog4GC_WebSrvClassEN.UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objvLog4GC_WebSrvClassEN.UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名
objvLog4GC_WebSrvClassEN.WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvLog4GC_WebSrvClassEN.NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名
objvLog4GC_WebSrvClassEN.WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvLog4GC_WebSrvClassEN.PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GC_WebSrvClassEN.FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GC_WebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvLog4GC_WebSrvClassEN.PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID
objvLog4GC_WebSrvClassEN.PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称
objvLog4GC_WebSrvClassEN.FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvLog4GC_WebSrvClassEN.GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GC_WebSrvClassEN.VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GC_WebSrvClassEN.Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
objvLog4GC_WebSrvClassEN.ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GC_WebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvLog4GC_WebSrvClassEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvLog4GC_WebSrvClassEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvLog4GC_WebSrvClassEN> arrObjLst = new List<clsvLog4GC_WebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN();
try
{
objvLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objvLog4GC_WebSrvClassEN.UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objvLog4GC_WebSrvClassEN.UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名
objvLog4GC_WebSrvClassEN.WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvLog4GC_WebSrvClassEN.NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名
objvLog4GC_WebSrvClassEN.WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvLog4GC_WebSrvClassEN.PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GC_WebSrvClassEN.FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GC_WebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvLog4GC_WebSrvClassEN.PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID
objvLog4GC_WebSrvClassEN.PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称
objvLog4GC_WebSrvClassEN.FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvLog4GC_WebSrvClassEN.GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GC_WebSrvClassEN.VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GC_WebSrvClassEN.Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
objvLog4GC_WebSrvClassEN.ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GC_WebSrvClassEN);
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
public static List<clsvLog4GC_WebSrvClassEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvLog4GC_WebSrvClassEN> arrObjLst = new List<clsvLog4GC_WebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN();
try
{
objvLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objvLog4GC_WebSrvClassEN.UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objvLog4GC_WebSrvClassEN.UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名
objvLog4GC_WebSrvClassEN.WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvLog4GC_WebSrvClassEN.NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名
objvLog4GC_WebSrvClassEN.WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvLog4GC_WebSrvClassEN.PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GC_WebSrvClassEN.FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GC_WebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvLog4GC_WebSrvClassEN.PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID
objvLog4GC_WebSrvClassEN.PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称
objvLog4GC_WebSrvClassEN.FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvLog4GC_WebSrvClassEN.GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GC_WebSrvClassEN.VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GC_WebSrvClassEN.Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
objvLog4GC_WebSrvClassEN.ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GC_WebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GC_WebSrvClassEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvLog4GC_WebSrvClassEN> arrObjLst = new List<clsvLog4GC_WebSrvClassEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN();
try
{
objvLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objvLog4GC_WebSrvClassEN.UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objvLog4GC_WebSrvClassEN.UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名
objvLog4GC_WebSrvClassEN.WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvLog4GC_WebSrvClassEN.NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名
objvLog4GC_WebSrvClassEN.WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvLog4GC_WebSrvClassEN.PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GC_WebSrvClassEN.FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GC_WebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvLog4GC_WebSrvClassEN.PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID
objvLog4GC_WebSrvClassEN.PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称
objvLog4GC_WebSrvClassEN.FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvLog4GC_WebSrvClassEN.GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GC_WebSrvClassEN.VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GC_WebSrvClassEN.Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
objvLog4GC_WebSrvClassEN.ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GC_WebSrvClassEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvLog4GC_WebSrvClass(ref clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN)
{
bool bolResult = vLog4GC_WebSrvClassDA.GetvLog4GC_WebSrvClass(ref objvLog4GC_WebSrvClassEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvLog4GC_WebSrvClassEN GetObjBymId(long lngmId)
{
clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = vLog4GC_WebSrvClassDA.GetObjBymId(lngmId);
return objvLog4GC_WebSrvClassEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvLog4GC_WebSrvClassEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = vLog4GC_WebSrvClassDA.GetFirstObj(strWhereCond);
 return objvLog4GC_WebSrvClassEN;
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
public static clsvLog4GC_WebSrvClassEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = vLog4GC_WebSrvClassDA.GetObjByDataRow(objRow);
 return objvLog4GC_WebSrvClassEN;
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
public static clsvLog4GC_WebSrvClassEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = vLog4GC_WebSrvClassDA.GetObjByDataRow(objRow);
 return objvLog4GC_WebSrvClassEN;
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
 /// <param name = "lstvLog4GC_WebSrvClassObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvLog4GC_WebSrvClassEN GetObjBymIdFromList(long lngmId, List<clsvLog4GC_WebSrvClassEN> lstvLog4GC_WebSrvClassObjLst)
{
foreach (clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN in lstvLog4GC_WebSrvClassObjLst)
{
if (objvLog4GC_WebSrvClassEN.mId == lngmId)
{
return objvLog4GC_WebSrvClassEN;
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
 lngmId = new clsvLog4GC_WebSrvClassDA().GetFirstID(strWhereCond);
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
 arrList = vLog4GC_WebSrvClassDA.GetID(strWhereCond);
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
bool bolIsExist = vLog4GC_WebSrvClassDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vLog4GC_WebSrvClassDA.IsExist(lngmId);
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
 bolIsExist = clsvLog4GC_WebSrvClassDA.IsExistTable();
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
 bolIsExist = vLog4GC_WebSrvClassDA.IsExistTable(strTabName);
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
objvLog4GC_WebSrvClassENT.ClsName = objvLog4GC_WebSrvClassENS.ClsName; //类名
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
 /// <param name = "objvLog4GC_WebSrvClassEN">源简化对象</param>
 public static void SetUpdFlag(clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN)
{
try
{
objvLog4GC_WebSrvClassEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvLog4GC_WebSrvClassEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convLog4GC_WebSrvClass.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.mId = objvLog4GC_WebSrvClassEN.mId; //mId
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.UserId = objvLog4GC_WebSrvClassEN.UserId == "[null]" ? null :  objvLog4GC_WebSrvClassEN.UserId; //用户Id
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.UserName = objvLog4GC_WebSrvClassEN.UserName; //用户名
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.WebSrvClassId, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.WebSrvClassId = objvLog4GC_WebSrvClassEN.WebSrvClassId; //类Id
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.NameSpace, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.NameSpace = objvLog4GC_WebSrvClassEN.NameSpace == "[null]" ? null :  objvLog4GC_WebSrvClassEN.NameSpace; //域名
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.WebSrvUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.WebSrvUrl = objvLog4GC_WebSrvClassEN.WebSrvUrl; //WebSrv地址
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.PageName, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.PageName = objvLog4GC_WebSrvClassEN.PageName == "[null]" ? null :  objvLog4GC_WebSrvClassEN.PageName; //页面名称
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objvLog4GC_WebSrvClassEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.FuncModuleName = objvLog4GC_WebSrvClassEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.IsNeedGene, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.IsNeedGene = objvLog4GC_WebSrvClassEN.IsNeedGene; //是否需要生成
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.PrjId = objvLog4GC_WebSrvClassEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.PrjName = objvLog4GC_WebSrvClassEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.FuncNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.FuncNum = objvLog4GC_WebSrvClassEN.FuncNum; //函数个数
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.GeneCodeDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.GeneCodeDate = objvLog4GC_WebSrvClassEN.GeneCodeDate == "[null]" ? null :  objvLog4GC_WebSrvClassEN.GeneCodeDate; //生成代码日期
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.VersionGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.VersionGeneCode = objvLog4GC_WebSrvClassEN.VersionGeneCode; //生成代码版本
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.Memo = objvLog4GC_WebSrvClassEN.Memo == "[null]" ? null :  objvLog4GC_WebSrvClassEN.Memo; //说明
}
if (arrFldSet.Contains(convLog4GC_WebSrvClass.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GC_WebSrvClassEN.ClsName = objvLog4GC_WebSrvClassEN.ClsName == "[null]" ? null :  objvLog4GC_WebSrvClassEN.ClsName; //类名
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
 /// <param name = "objvLog4GC_WebSrvClassEN">源简化对象</param>
 public static void AccessFldValueNull(clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN)
{
try
{
if (objvLog4GC_WebSrvClassEN.UserId == "[null]") objvLog4GC_WebSrvClassEN.UserId = null; //用户Id
if (objvLog4GC_WebSrvClassEN.NameSpace == "[null]") objvLog4GC_WebSrvClassEN.NameSpace = null; //域名
if (objvLog4GC_WebSrvClassEN.PageName == "[null]") objvLog4GC_WebSrvClassEN.PageName = null; //页面名称
if (objvLog4GC_WebSrvClassEN.GeneCodeDate == "[null]") objvLog4GC_WebSrvClassEN.GeneCodeDate = null; //生成代码日期
if (objvLog4GC_WebSrvClassEN.Memo == "[null]") objvLog4GC_WebSrvClassEN.Memo = null; //说明
if (objvLog4GC_WebSrvClassEN.ClsName == "[null]") objvLog4GC_WebSrvClassEN.ClsName = null; //类名
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
public static void CheckProperty4Condition(clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN)
{
 vLog4GC_WebSrvClassDA.CheckProperty4Condition(objvLog4GC_WebSrvClassEN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsLog4GC_WebSrvClassBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsLog4GC_WebSrvClassBL没有刷新缓存机制(clsLog4GC_WebSrvClassBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWebSrvClassBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsWebSrvClassBL没有刷新缓存机制(clsWebSrvClassBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvLog4GC_WebSrvClassObjLstCache == null)
//{
//arrvLog4GC_WebSrvClassObjLstCache = vLog4GC_WebSrvClassDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvLog4GC_WebSrvClassEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvLog4GC_WebSrvClassEN._CurrTabName);
List<clsvLog4GC_WebSrvClassEN> arrvLog4GC_WebSrvClassObjLstCache = GetObjLstCache();
IEnumerable <clsvLog4GC_WebSrvClassEN> arrvLog4GC_WebSrvClassObjLst_Sel =
arrvLog4GC_WebSrvClassObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvLog4GC_WebSrvClassObjLst_Sel.Count() == 0)
{
   clsvLog4GC_WebSrvClassEN obj = clsvLog4GC_WebSrvClassBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvLog4GC_WebSrvClassObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvLog4GC_WebSrvClassEN> GetAllvLog4GC_WebSrvClassObjLstCache()
{
//获取缓存中的对象列表
List<clsvLog4GC_WebSrvClassEN> arrvLog4GC_WebSrvClassObjLstCache = GetObjLstCache(); 
return arrvLog4GC_WebSrvClassObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvLog4GC_WebSrvClassEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvLog4GC_WebSrvClassEN._CurrTabName);
List<clsvLog4GC_WebSrvClassEN> arrvLog4GC_WebSrvClassObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvLog4GC_WebSrvClassObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-01-26
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convLog4GC_WebSrvClass.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convLog4GC_WebSrvClass.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convLog4GC_WebSrvClass.AttributeName));
throw new Exception(strMsg);
}
var objvLog4GC_WebSrvClass = clsvLog4GC_WebSrvClassBL.GetObjBymIdCache(lngmId);
if (objvLog4GC_WebSrvClass == null) return "";
return objvLog4GC_WebSrvClass[strOutFldName].ToString();
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
int intRecCount = clsvLog4GC_WebSrvClassDA.GetRecCount(strTabName);
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
int intRecCount = clsvLog4GC_WebSrvClassDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvLog4GC_WebSrvClassDA.GetRecCount();
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
int intRecCount = clsvLog4GC_WebSrvClassDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassCond)
{
List<clsvLog4GC_WebSrvClassEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvLog4GC_WebSrvClassEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convLog4GC_WebSrvClass.AttributeName)
{
if (objvLog4GC_WebSrvClassCond.IsUpdated(strFldName) == false) continue;
if (objvLog4GC_WebSrvClassCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4GC_WebSrvClassCond[strFldName].ToString());
}
else
{
if (objvLog4GC_WebSrvClassCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvLog4GC_WebSrvClassCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4GC_WebSrvClassCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvLog4GC_WebSrvClassCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvLog4GC_WebSrvClassCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvLog4GC_WebSrvClassCond[strFldName]));
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
 List<string> arrList = clsvLog4GC_WebSrvClassDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vLog4GC_WebSrvClassDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vLog4GC_WebSrvClassDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}