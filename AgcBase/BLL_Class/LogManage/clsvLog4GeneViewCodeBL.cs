
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvLog4GeneViewCodeBL
 表名:vLog4GeneViewCode(00050281)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:00
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
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
public static class clsvLog4GeneViewCodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvLog4GeneViewCodeEN GetObj(this K_mId_vLog4GeneViewCode myKey)
{
clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = clsvLog4GeneViewCodeBL.vLog4GeneViewCodeDA.GetObjBymId(myKey.Value);
return objvLog4GeneViewCodeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetmId(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, long lngmId, string strComparisonOp="")
	{
objvLog4GeneViewCodeEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneViewCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneViewCode.mId) == false)
{
objvLog4GeneViewCodeEN.dicFldComparisonOp.Add(convLog4GeneViewCode.mId, strComparisonOp);
}
else
{
objvLog4GeneViewCodeEN.dicFldComparisonOp[convLog4GeneViewCode.mId] = strComparisonOp;
}
}
return objvLog4GeneViewCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetUserId(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convLog4GeneViewCode.UserId);
}
objvLog4GeneViewCodeEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneViewCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneViewCode.UserId) == false)
{
objvLog4GeneViewCodeEN.dicFldComparisonOp.Add(convLog4GeneViewCode.UserId, strComparisonOp);
}
else
{
objvLog4GeneViewCodeEN.dicFldComparisonOp[convLog4GeneViewCode.UserId] = strComparisonOp;
}
}
return objvLog4GeneViewCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetUserName(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convLog4GeneViewCode.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convLog4GeneViewCode.UserName);
}
objvLog4GeneViewCodeEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneViewCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneViewCode.UserName) == false)
{
objvLog4GeneViewCodeEN.dicFldComparisonOp.Add(convLog4GeneViewCode.UserName, strComparisonOp);
}
else
{
objvLog4GeneViewCodeEN.dicFldComparisonOp[convLog4GeneViewCode.UserName] = strComparisonOp;
}
}
return objvLog4GeneViewCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetViewId(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, convLog4GeneViewCode.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convLog4GeneViewCode.ViewId);
}
objvLog4GeneViewCodeEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneViewCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneViewCode.ViewId) == false)
{
objvLog4GeneViewCodeEN.dicFldComparisonOp.Add(convLog4GeneViewCode.ViewId, strComparisonOp);
}
else
{
objvLog4GeneViewCodeEN.dicFldComparisonOp[convLog4GeneViewCode.ViewId] = strComparisonOp;
}
}
return objvLog4GeneViewCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetViewName(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, convLog4GeneViewCode.ViewName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, convLog4GeneViewCode.ViewName);
}
objvLog4GeneViewCodeEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneViewCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneViewCode.ViewName) == false)
{
objvLog4GeneViewCodeEN.dicFldComparisonOp.Add(convLog4GeneViewCode.ViewName, strComparisonOp);
}
else
{
objvLog4GeneViewCodeEN.dicFldComparisonOp[convLog4GeneViewCode.ViewName] = strComparisonOp;
}
}
return objvLog4GeneViewCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetViewCnName(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strViewCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewCnName, 100, convLog4GeneViewCode.ViewCnName);
}
objvLog4GeneViewCodeEN.ViewCnName = strViewCnName; //视图中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneViewCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneViewCode.ViewCnName) == false)
{
objvLog4GeneViewCodeEN.dicFldComparisonOp.Add(convLog4GeneViewCode.ViewCnName, strComparisonOp);
}
else
{
objvLog4GeneViewCodeEN.dicFldComparisonOp[convLog4GeneViewCode.ViewCnName] = strComparisonOp;
}
}
return objvLog4GeneViewCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetPrjId(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convLog4GeneViewCode.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convLog4GeneViewCode.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convLog4GeneViewCode.PrjId);
}
objvLog4GeneViewCodeEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneViewCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneViewCode.PrjId) == false)
{
objvLog4GeneViewCodeEN.dicFldComparisonOp.Add(convLog4GeneViewCode.PrjId, strComparisonOp);
}
else
{
objvLog4GeneViewCodeEN.dicFldComparisonOp[convLog4GeneViewCode.PrjId] = strComparisonOp;
}
}
return objvLog4GeneViewCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetPrjName(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convLog4GeneViewCode.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convLog4GeneViewCode.PrjName);
}
objvLog4GeneViewCodeEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneViewCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneViewCode.PrjName) == false)
{
objvLog4GeneViewCodeEN.dicFldComparisonOp.Add(convLog4GeneViewCode.PrjName, strComparisonOp);
}
else
{
objvLog4GeneViewCodeEN.dicFldComparisonOp[convLog4GeneViewCode.PrjName] = strComparisonOp;
}
}
return objvLog4GeneViewCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetFuncModuleAgcId(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convLog4GeneViewCode.FuncModuleAgcId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convLog4GeneViewCode.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convLog4GeneViewCode.FuncModuleAgcId);
}
objvLog4GeneViewCodeEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneViewCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneViewCode.FuncModuleAgcId) == false)
{
objvLog4GeneViewCodeEN.dicFldComparisonOp.Add(convLog4GeneViewCode.FuncModuleAgcId, strComparisonOp);
}
else
{
objvLog4GeneViewCodeEN.dicFldComparisonOp[convLog4GeneViewCode.FuncModuleAgcId] = strComparisonOp;
}
}
return objvLog4GeneViewCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetFuncModuleName(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convLog4GeneViewCode.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convLog4GeneViewCode.FuncModuleName);
}
objvLog4GeneViewCodeEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneViewCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneViewCode.FuncModuleName) == false)
{
objvLog4GeneViewCodeEN.dicFldComparisonOp.Add(convLog4GeneViewCode.FuncModuleName, strComparisonOp);
}
else
{
objvLog4GeneViewCodeEN.dicFldComparisonOp[convLog4GeneViewCode.FuncModuleName] = strComparisonOp;
}
}
return objvLog4GeneViewCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetGeneCodeDate(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strGeneCodeDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convLog4GeneViewCode.GeneCodeDate);
}
objvLog4GeneViewCodeEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneViewCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneViewCode.GeneCodeDate) == false)
{
objvLog4GeneViewCodeEN.dicFldComparisonOp.Add(convLog4GeneViewCode.GeneCodeDate, strComparisonOp);
}
else
{
objvLog4GeneViewCodeEN.dicFldComparisonOp[convLog4GeneViewCode.GeneCodeDate] = strComparisonOp;
}
}
return objvLog4GeneViewCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetVersionGeneCode(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strVersionGeneCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionGeneCode, convLog4GeneViewCode.VersionGeneCode);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionGeneCode, 30, convLog4GeneViewCode.VersionGeneCode);
}
objvLog4GeneViewCodeEN.VersionGeneCode = strVersionGeneCode; //生成代码版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneViewCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneViewCode.VersionGeneCode) == false)
{
objvLog4GeneViewCodeEN.dicFldComparisonOp.Add(convLog4GeneViewCode.VersionGeneCode, strComparisonOp);
}
else
{
objvLog4GeneViewCodeEN.dicFldComparisonOp[convLog4GeneViewCode.VersionGeneCode] = strComparisonOp;
}
}
return objvLog4GeneViewCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetMemo(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convLog4GeneViewCode.Memo);
}
objvLog4GeneViewCodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneViewCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneViewCode.Memo) == false)
{
objvLog4GeneViewCodeEN.dicFldComparisonOp.Add(convLog4GeneViewCode.Memo, strComparisonOp);
}
else
{
objvLog4GeneViewCodeEN.dicFldComparisonOp[convLog4GeneViewCode.Memo] = strComparisonOp;
}
}
return objvLog4GeneViewCodeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeENS">源对象</param>
 /// <param name = "objvLog4GeneViewCodeENT">目标对象</param>
 public static void CopyTo(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeENS, clsvLog4GeneViewCodeEN objvLog4GeneViewCodeENT)
{
try
{
objvLog4GeneViewCodeENT.mId = objvLog4GeneViewCodeENS.mId; //mId
objvLog4GeneViewCodeENT.UserId = objvLog4GeneViewCodeENS.UserId; //用户Id
objvLog4GeneViewCodeENT.UserName = objvLog4GeneViewCodeENS.UserName; //用户名
objvLog4GeneViewCodeENT.ViewId = objvLog4GeneViewCodeENS.ViewId; //界面Id
objvLog4GeneViewCodeENT.ViewName = objvLog4GeneViewCodeENS.ViewName; //界面名称
objvLog4GeneViewCodeENT.ViewCnName = objvLog4GeneViewCodeENS.ViewCnName; //视图中文名
objvLog4GeneViewCodeENT.PrjId = objvLog4GeneViewCodeENS.PrjId; //工程ID
objvLog4GeneViewCodeENT.PrjName = objvLog4GeneViewCodeENS.PrjName; //工程名称
objvLog4GeneViewCodeENT.FuncModuleAgcId = objvLog4GeneViewCodeENS.FuncModuleAgcId; //功能模块Id
objvLog4GeneViewCodeENT.FuncModuleName = objvLog4GeneViewCodeENS.FuncModuleName; //功能模块名称
objvLog4GeneViewCodeENT.GeneCodeDate = objvLog4GeneViewCodeENS.GeneCodeDate; //生成代码日期
objvLog4GeneViewCodeENT.VersionGeneCode = objvLog4GeneViewCodeENS.VersionGeneCode; //生成代码版本
objvLog4GeneViewCodeENT.Memo = objvLog4GeneViewCodeENS.Memo; //说明
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
 /// <param name = "objvLog4GeneViewCodeENS">源对象</param>
 /// <returns>目标对象=>clsvLog4GeneViewCodeEN:objvLog4GeneViewCodeENT</returns>
 public static clsvLog4GeneViewCodeEN CopyTo(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeENS)
{
try
{
 clsvLog4GeneViewCodeEN objvLog4GeneViewCodeENT = new clsvLog4GeneViewCodeEN()
{
mId = objvLog4GeneViewCodeENS.mId, //mId
UserId = objvLog4GeneViewCodeENS.UserId, //用户Id
UserName = objvLog4GeneViewCodeENS.UserName, //用户名
ViewId = objvLog4GeneViewCodeENS.ViewId, //界面Id
ViewName = objvLog4GeneViewCodeENS.ViewName, //界面名称
ViewCnName = objvLog4GeneViewCodeENS.ViewCnName, //视图中文名
PrjId = objvLog4GeneViewCodeENS.PrjId, //工程ID
PrjName = objvLog4GeneViewCodeENS.PrjName, //工程名称
FuncModuleAgcId = objvLog4GeneViewCodeENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvLog4GeneViewCodeENS.FuncModuleName, //功能模块名称
GeneCodeDate = objvLog4GeneViewCodeENS.GeneCodeDate, //生成代码日期
VersionGeneCode = objvLog4GeneViewCodeENS.VersionGeneCode, //生成代码版本
Memo = objvLog4GeneViewCodeENS.Memo, //说明
};
 return objvLog4GeneViewCodeENT;
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
public static void CheckProperty4Condition(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN)
{
 clsvLog4GeneViewCodeBL.vLog4GeneViewCodeDA.CheckProperty4Condition(objvLog4GeneViewCodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvLog4GeneViewCodeCond.IsUpdated(convLog4GeneViewCode.mId) == true)
{
string strComparisonOpmId = objvLog4GeneViewCodeCond.dicFldComparisonOp[convLog4GeneViewCode.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convLog4GeneViewCode.mId, objvLog4GeneViewCodeCond.mId, strComparisonOpmId);
}
if (objvLog4GeneViewCodeCond.IsUpdated(convLog4GeneViewCode.UserId) == true)
{
string strComparisonOpUserId = objvLog4GeneViewCodeCond.dicFldComparisonOp[convLog4GeneViewCode.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.UserId, objvLog4GeneViewCodeCond.UserId, strComparisonOpUserId);
}
if (objvLog4GeneViewCodeCond.IsUpdated(convLog4GeneViewCode.UserName) == true)
{
string strComparisonOpUserName = objvLog4GeneViewCodeCond.dicFldComparisonOp[convLog4GeneViewCode.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.UserName, objvLog4GeneViewCodeCond.UserName, strComparisonOpUserName);
}
if (objvLog4GeneViewCodeCond.IsUpdated(convLog4GeneViewCode.ViewId) == true)
{
string strComparisonOpViewId = objvLog4GeneViewCodeCond.dicFldComparisonOp[convLog4GeneViewCode.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.ViewId, objvLog4GeneViewCodeCond.ViewId, strComparisonOpViewId);
}
if (objvLog4GeneViewCodeCond.IsUpdated(convLog4GeneViewCode.ViewName) == true)
{
string strComparisonOpViewName = objvLog4GeneViewCodeCond.dicFldComparisonOp[convLog4GeneViewCode.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.ViewName, objvLog4GeneViewCodeCond.ViewName, strComparisonOpViewName);
}
if (objvLog4GeneViewCodeCond.IsUpdated(convLog4GeneViewCode.ViewCnName) == true)
{
string strComparisonOpViewCnName = objvLog4GeneViewCodeCond.dicFldComparisonOp[convLog4GeneViewCode.ViewCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.ViewCnName, objvLog4GeneViewCodeCond.ViewCnName, strComparisonOpViewCnName);
}
if (objvLog4GeneViewCodeCond.IsUpdated(convLog4GeneViewCode.PrjId) == true)
{
string strComparisonOpPrjId = objvLog4GeneViewCodeCond.dicFldComparisonOp[convLog4GeneViewCode.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.PrjId, objvLog4GeneViewCodeCond.PrjId, strComparisonOpPrjId);
}
if (objvLog4GeneViewCodeCond.IsUpdated(convLog4GeneViewCode.PrjName) == true)
{
string strComparisonOpPrjName = objvLog4GeneViewCodeCond.dicFldComparisonOp[convLog4GeneViewCode.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.PrjName, objvLog4GeneViewCodeCond.PrjName, strComparisonOpPrjName);
}
if (objvLog4GeneViewCodeCond.IsUpdated(convLog4GeneViewCode.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvLog4GeneViewCodeCond.dicFldComparisonOp[convLog4GeneViewCode.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.FuncModuleAgcId, objvLog4GeneViewCodeCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvLog4GeneViewCodeCond.IsUpdated(convLog4GeneViewCode.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvLog4GeneViewCodeCond.dicFldComparisonOp[convLog4GeneViewCode.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.FuncModuleName, objvLog4GeneViewCodeCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvLog4GeneViewCodeCond.IsUpdated(convLog4GeneViewCode.GeneCodeDate) == true)
{
string strComparisonOpGeneCodeDate = objvLog4GeneViewCodeCond.dicFldComparisonOp[convLog4GeneViewCode.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.GeneCodeDate, objvLog4GeneViewCodeCond.GeneCodeDate, strComparisonOpGeneCodeDate);
}
if (objvLog4GeneViewCodeCond.IsUpdated(convLog4GeneViewCode.VersionGeneCode) == true)
{
string strComparisonOpVersionGeneCode = objvLog4GeneViewCodeCond.dicFldComparisonOp[convLog4GeneViewCode.VersionGeneCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.VersionGeneCode, objvLog4GeneViewCodeCond.VersionGeneCode, strComparisonOpVersionGeneCode);
}
if (objvLog4GeneViewCodeCond.IsUpdated(convLog4GeneViewCode.Memo) == true)
{
string strComparisonOpMemo = objvLog4GeneViewCodeCond.dicFldComparisonOp[convLog4GeneViewCode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.Memo, objvLog4GeneViewCodeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vLog4GeneViewCode
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v生成界面代码日志(vLog4GeneViewCode)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvLog4GeneViewCodeBL
{
public static RelatedActions_vLog4GeneViewCode relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vLog4GeneViewCodeListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vLog4GeneViewCodeList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvLog4GeneViewCodeEN> arrvLog4GeneViewCodeObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvLog4GeneViewCodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvLog4GeneViewCodeDA vLog4GeneViewCodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvLog4GeneViewCodeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvLog4GeneViewCodeBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsvLog4GeneViewCodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvLog4GeneViewCodeEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = vLog4GeneViewCodeDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = vLog4GeneViewCodeDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = vLog4GeneViewCodeDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vLog4GeneViewCode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vLog4GeneViewCodeDA.GetDataTable_vLog4GeneViewCode(strWhereCond);
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
objDT = vLog4GeneViewCodeDA.GetDataTable(strWhereCond);
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
objDT = vLog4GeneViewCodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vLog4GeneViewCodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vLog4GeneViewCodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vLog4GeneViewCodeDA.GetDataTable_Top(objTopPara);
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
objDT = vLog4GeneViewCodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vLog4GeneViewCodeDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = vLog4GeneViewCodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vLog4GeneViewCodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vLog4GeneViewCodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vLog4GeneViewCodeDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vLog4GeneViewCodeDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vLog4GeneViewCodeDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
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
public static List<clsvLog4GeneViewCodeEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvLog4GeneViewCodeEN> arrObjLst = new List<clsvLog4GeneViewCodeEN>(); 
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
	clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = new clsvLog4GeneViewCodeEN();
try
{
objvLog4GeneViewCodeEN.mId = Int32.Parse(objRow[convLog4GeneViewCode.mId].ToString().Trim()); //mId
objvLog4GeneViewCodeEN.UserId = objRow[convLog4GeneViewCode.UserId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objvLog4GeneViewCodeEN.UserName = objRow[convLog4GeneViewCode.UserName].ToString().Trim(); //用户名
objvLog4GeneViewCodeEN.ViewId = objRow[convLog4GeneViewCode.ViewId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objvLog4GeneViewCodeEN.ViewName = objRow[convLog4GeneViewCode.ViewName].ToString().Trim(); //界面名称
objvLog4GeneViewCodeEN.ViewCnName = objRow[convLog4GeneViewCode.ViewCnName] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewCnName].ToString().Trim(); //视图中文名
objvLog4GeneViewCodeEN.PrjId = objRow[convLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objvLog4GeneViewCodeEN.PrjName = objRow[convLog4GeneViewCode.PrjName].ToString().Trim(); //工程名称
objvLog4GeneViewCodeEN.FuncModuleAgcId = objRow[convLog4GeneViewCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GeneViewCodeEN.FuncModuleName = objRow[convLog4GeneViewCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GeneViewCodeEN.GeneCodeDate = objRow[convLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GeneViewCodeEN.VersionGeneCode = objRow[convLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GeneViewCodeEN.Memo = objRow[convLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[convLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GeneViewCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GeneViewCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvLog4GeneViewCodeEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvLog4GeneViewCodeEN._CurrTabName);
List<clsvLog4GeneViewCodeEN> arrvLog4GeneViewCodeObjLstCache = GetObjLstCache();
IEnumerable <clsvLog4GeneViewCodeEN> arrvLog4GeneViewCodeObjLst_Sel =
arrvLog4GeneViewCodeObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvLog4GeneViewCodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GeneViewCodeEN> GetObjLst(string strWhereCond)
{
List<clsvLog4GeneViewCodeEN> arrObjLst = new List<clsvLog4GeneViewCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = new clsvLog4GeneViewCodeEN();
try
{
objvLog4GeneViewCodeEN.mId = Int32.Parse(objRow[convLog4GeneViewCode.mId].ToString().Trim()); //mId
objvLog4GeneViewCodeEN.UserId = objRow[convLog4GeneViewCode.UserId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objvLog4GeneViewCodeEN.UserName = objRow[convLog4GeneViewCode.UserName].ToString().Trim(); //用户名
objvLog4GeneViewCodeEN.ViewId = objRow[convLog4GeneViewCode.ViewId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objvLog4GeneViewCodeEN.ViewName = objRow[convLog4GeneViewCode.ViewName].ToString().Trim(); //界面名称
objvLog4GeneViewCodeEN.ViewCnName = objRow[convLog4GeneViewCode.ViewCnName] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewCnName].ToString().Trim(); //视图中文名
objvLog4GeneViewCodeEN.PrjId = objRow[convLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objvLog4GeneViewCodeEN.PrjName = objRow[convLog4GeneViewCode.PrjName].ToString().Trim(); //工程名称
objvLog4GeneViewCodeEN.FuncModuleAgcId = objRow[convLog4GeneViewCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GeneViewCodeEN.FuncModuleName = objRow[convLog4GeneViewCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GeneViewCodeEN.GeneCodeDate = objRow[convLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GeneViewCodeEN.VersionGeneCode = objRow[convLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GeneViewCodeEN.Memo = objRow[convLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[convLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GeneViewCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GeneViewCodeEN);
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
public static List<clsvLog4GeneViewCodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvLog4GeneViewCodeEN> arrObjLst = new List<clsvLog4GeneViewCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = new clsvLog4GeneViewCodeEN();
try
{
objvLog4GeneViewCodeEN.mId = Int32.Parse(objRow[convLog4GeneViewCode.mId].ToString().Trim()); //mId
objvLog4GeneViewCodeEN.UserId = objRow[convLog4GeneViewCode.UserId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objvLog4GeneViewCodeEN.UserName = objRow[convLog4GeneViewCode.UserName].ToString().Trim(); //用户名
objvLog4GeneViewCodeEN.ViewId = objRow[convLog4GeneViewCode.ViewId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objvLog4GeneViewCodeEN.ViewName = objRow[convLog4GeneViewCode.ViewName].ToString().Trim(); //界面名称
objvLog4GeneViewCodeEN.ViewCnName = objRow[convLog4GeneViewCode.ViewCnName] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewCnName].ToString().Trim(); //视图中文名
objvLog4GeneViewCodeEN.PrjId = objRow[convLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objvLog4GeneViewCodeEN.PrjName = objRow[convLog4GeneViewCode.PrjName].ToString().Trim(); //工程名称
objvLog4GeneViewCodeEN.FuncModuleAgcId = objRow[convLog4GeneViewCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GeneViewCodeEN.FuncModuleName = objRow[convLog4GeneViewCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GeneViewCodeEN.GeneCodeDate = objRow[convLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GeneViewCodeEN.VersionGeneCode = objRow[convLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GeneViewCodeEN.Memo = objRow[convLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[convLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GeneViewCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GeneViewCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvLog4GeneViewCodeEN> GetSubObjLstCache(clsvLog4GeneViewCodeEN objvLog4GeneViewCodeCond)
{
List<clsvLog4GeneViewCodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvLog4GeneViewCodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convLog4GeneViewCode.AttributeName)
{
if (objvLog4GeneViewCodeCond.IsUpdated(strFldName) == false) continue;
if (objvLog4GeneViewCodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4GeneViewCodeCond[strFldName].ToString());
}
else
{
if (objvLog4GeneViewCodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvLog4GeneViewCodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4GeneViewCodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvLog4GeneViewCodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvLog4GeneViewCodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvLog4GeneViewCodeCond[strFldName]));
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
public static List<clsvLog4GeneViewCodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvLog4GeneViewCodeEN> arrObjLst = new List<clsvLog4GeneViewCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = new clsvLog4GeneViewCodeEN();
try
{
objvLog4GeneViewCodeEN.mId = Int32.Parse(objRow[convLog4GeneViewCode.mId].ToString().Trim()); //mId
objvLog4GeneViewCodeEN.UserId = objRow[convLog4GeneViewCode.UserId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objvLog4GeneViewCodeEN.UserName = objRow[convLog4GeneViewCode.UserName].ToString().Trim(); //用户名
objvLog4GeneViewCodeEN.ViewId = objRow[convLog4GeneViewCode.ViewId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objvLog4GeneViewCodeEN.ViewName = objRow[convLog4GeneViewCode.ViewName].ToString().Trim(); //界面名称
objvLog4GeneViewCodeEN.ViewCnName = objRow[convLog4GeneViewCode.ViewCnName] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewCnName].ToString().Trim(); //视图中文名
objvLog4GeneViewCodeEN.PrjId = objRow[convLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objvLog4GeneViewCodeEN.PrjName = objRow[convLog4GeneViewCode.PrjName].ToString().Trim(); //工程名称
objvLog4GeneViewCodeEN.FuncModuleAgcId = objRow[convLog4GeneViewCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GeneViewCodeEN.FuncModuleName = objRow[convLog4GeneViewCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GeneViewCodeEN.GeneCodeDate = objRow[convLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GeneViewCodeEN.VersionGeneCode = objRow[convLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GeneViewCodeEN.Memo = objRow[convLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[convLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GeneViewCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GeneViewCodeEN);
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
public static List<clsvLog4GeneViewCodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvLog4GeneViewCodeEN> arrObjLst = new List<clsvLog4GeneViewCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = new clsvLog4GeneViewCodeEN();
try
{
objvLog4GeneViewCodeEN.mId = Int32.Parse(objRow[convLog4GeneViewCode.mId].ToString().Trim()); //mId
objvLog4GeneViewCodeEN.UserId = objRow[convLog4GeneViewCode.UserId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objvLog4GeneViewCodeEN.UserName = objRow[convLog4GeneViewCode.UserName].ToString().Trim(); //用户名
objvLog4GeneViewCodeEN.ViewId = objRow[convLog4GeneViewCode.ViewId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objvLog4GeneViewCodeEN.ViewName = objRow[convLog4GeneViewCode.ViewName].ToString().Trim(); //界面名称
objvLog4GeneViewCodeEN.ViewCnName = objRow[convLog4GeneViewCode.ViewCnName] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewCnName].ToString().Trim(); //视图中文名
objvLog4GeneViewCodeEN.PrjId = objRow[convLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objvLog4GeneViewCodeEN.PrjName = objRow[convLog4GeneViewCode.PrjName].ToString().Trim(); //工程名称
objvLog4GeneViewCodeEN.FuncModuleAgcId = objRow[convLog4GeneViewCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GeneViewCodeEN.FuncModuleName = objRow[convLog4GeneViewCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GeneViewCodeEN.GeneCodeDate = objRow[convLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GeneViewCodeEN.VersionGeneCode = objRow[convLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GeneViewCodeEN.Memo = objRow[convLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[convLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GeneViewCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GeneViewCodeEN);
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
List<clsvLog4GeneViewCodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvLog4GeneViewCodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GeneViewCodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvLog4GeneViewCodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvLog4GeneViewCodeEN> arrObjLst = new List<clsvLog4GeneViewCodeEN>(); 
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
	clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = new clsvLog4GeneViewCodeEN();
try
{
objvLog4GeneViewCodeEN.mId = Int32.Parse(objRow[convLog4GeneViewCode.mId].ToString().Trim()); //mId
objvLog4GeneViewCodeEN.UserId = objRow[convLog4GeneViewCode.UserId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objvLog4GeneViewCodeEN.UserName = objRow[convLog4GeneViewCode.UserName].ToString().Trim(); //用户名
objvLog4GeneViewCodeEN.ViewId = objRow[convLog4GeneViewCode.ViewId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objvLog4GeneViewCodeEN.ViewName = objRow[convLog4GeneViewCode.ViewName].ToString().Trim(); //界面名称
objvLog4GeneViewCodeEN.ViewCnName = objRow[convLog4GeneViewCode.ViewCnName] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewCnName].ToString().Trim(); //视图中文名
objvLog4GeneViewCodeEN.PrjId = objRow[convLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objvLog4GeneViewCodeEN.PrjName = objRow[convLog4GeneViewCode.PrjName].ToString().Trim(); //工程名称
objvLog4GeneViewCodeEN.FuncModuleAgcId = objRow[convLog4GeneViewCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GeneViewCodeEN.FuncModuleName = objRow[convLog4GeneViewCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GeneViewCodeEN.GeneCodeDate = objRow[convLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GeneViewCodeEN.VersionGeneCode = objRow[convLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GeneViewCodeEN.Memo = objRow[convLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[convLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GeneViewCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GeneViewCodeEN);
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
public static List<clsvLog4GeneViewCodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvLog4GeneViewCodeEN> arrObjLst = new List<clsvLog4GeneViewCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = new clsvLog4GeneViewCodeEN();
try
{
objvLog4GeneViewCodeEN.mId = Int32.Parse(objRow[convLog4GeneViewCode.mId].ToString().Trim()); //mId
objvLog4GeneViewCodeEN.UserId = objRow[convLog4GeneViewCode.UserId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objvLog4GeneViewCodeEN.UserName = objRow[convLog4GeneViewCode.UserName].ToString().Trim(); //用户名
objvLog4GeneViewCodeEN.ViewId = objRow[convLog4GeneViewCode.ViewId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objvLog4GeneViewCodeEN.ViewName = objRow[convLog4GeneViewCode.ViewName].ToString().Trim(); //界面名称
objvLog4GeneViewCodeEN.ViewCnName = objRow[convLog4GeneViewCode.ViewCnName] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewCnName].ToString().Trim(); //视图中文名
objvLog4GeneViewCodeEN.PrjId = objRow[convLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objvLog4GeneViewCodeEN.PrjName = objRow[convLog4GeneViewCode.PrjName].ToString().Trim(); //工程名称
objvLog4GeneViewCodeEN.FuncModuleAgcId = objRow[convLog4GeneViewCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GeneViewCodeEN.FuncModuleName = objRow[convLog4GeneViewCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GeneViewCodeEN.GeneCodeDate = objRow[convLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GeneViewCodeEN.VersionGeneCode = objRow[convLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GeneViewCodeEN.Memo = objRow[convLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[convLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GeneViewCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GeneViewCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvLog4GeneViewCodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvLog4GeneViewCodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvLog4GeneViewCodeEN> arrObjLst = new List<clsvLog4GeneViewCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = new clsvLog4GeneViewCodeEN();
try
{
objvLog4GeneViewCodeEN.mId = Int32.Parse(objRow[convLog4GeneViewCode.mId].ToString().Trim()); //mId
objvLog4GeneViewCodeEN.UserId = objRow[convLog4GeneViewCode.UserId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objvLog4GeneViewCodeEN.UserName = objRow[convLog4GeneViewCode.UserName].ToString().Trim(); //用户名
objvLog4GeneViewCodeEN.ViewId = objRow[convLog4GeneViewCode.ViewId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objvLog4GeneViewCodeEN.ViewName = objRow[convLog4GeneViewCode.ViewName].ToString().Trim(); //界面名称
objvLog4GeneViewCodeEN.ViewCnName = objRow[convLog4GeneViewCode.ViewCnName] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewCnName].ToString().Trim(); //视图中文名
objvLog4GeneViewCodeEN.PrjId = objRow[convLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objvLog4GeneViewCodeEN.PrjName = objRow[convLog4GeneViewCode.PrjName].ToString().Trim(); //工程名称
objvLog4GeneViewCodeEN.FuncModuleAgcId = objRow[convLog4GeneViewCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GeneViewCodeEN.FuncModuleName = objRow[convLog4GeneViewCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GeneViewCodeEN.GeneCodeDate = objRow[convLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GeneViewCodeEN.VersionGeneCode = objRow[convLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GeneViewCodeEN.Memo = objRow[convLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[convLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GeneViewCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GeneViewCodeEN);
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
public static List<clsvLog4GeneViewCodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvLog4GeneViewCodeEN> arrObjLst = new List<clsvLog4GeneViewCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = new clsvLog4GeneViewCodeEN();
try
{
objvLog4GeneViewCodeEN.mId = Int32.Parse(objRow[convLog4GeneViewCode.mId].ToString().Trim()); //mId
objvLog4GeneViewCodeEN.UserId = objRow[convLog4GeneViewCode.UserId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objvLog4GeneViewCodeEN.UserName = objRow[convLog4GeneViewCode.UserName].ToString().Trim(); //用户名
objvLog4GeneViewCodeEN.ViewId = objRow[convLog4GeneViewCode.ViewId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objvLog4GeneViewCodeEN.ViewName = objRow[convLog4GeneViewCode.ViewName].ToString().Trim(); //界面名称
objvLog4GeneViewCodeEN.ViewCnName = objRow[convLog4GeneViewCode.ViewCnName] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewCnName].ToString().Trim(); //视图中文名
objvLog4GeneViewCodeEN.PrjId = objRow[convLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objvLog4GeneViewCodeEN.PrjName = objRow[convLog4GeneViewCode.PrjName].ToString().Trim(); //工程名称
objvLog4GeneViewCodeEN.FuncModuleAgcId = objRow[convLog4GeneViewCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GeneViewCodeEN.FuncModuleName = objRow[convLog4GeneViewCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GeneViewCodeEN.GeneCodeDate = objRow[convLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GeneViewCodeEN.VersionGeneCode = objRow[convLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GeneViewCodeEN.Memo = objRow[convLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[convLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GeneViewCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GeneViewCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsvLog4GeneViewCodeEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvLog4GeneViewCodeEN objvLog4GeneViewCodeCond, string strOrderBy)
{
List<clsvLog4GeneViewCodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvLog4GeneViewCodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convLog4GeneViewCode.AttributeName)
{
if (objvLog4GeneViewCodeCond.IsUpdated(strFldName) == false) continue;
if (objvLog4GeneViewCodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4GeneViewCodeCond[strFldName].ToString());
}
else
{
if (objvLog4GeneViewCodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvLog4GeneViewCodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4GeneViewCodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvLog4GeneViewCodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvLog4GeneViewCodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvLog4GeneViewCodeCond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLstSel = arrObjLstSel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLstSel = arrObjLstSel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLstSel = arrObjLstSel.Skip(intSkip).Take(intPageSize);
return arrObjLstSel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsvLog4GeneViewCodeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvLog4GeneViewCodeEN objvLog4GeneViewCodeCond = JsonConvert.DeserializeObject<clsvLog4GeneViewCodeEN>(objPagerPara.whereCond);
if (objvLog4GeneViewCodeCond.sfFldComparisonOp == null)
{
objvLog4GeneViewCodeCond.dicFldComparisonOp = null;
}
else
{
objvLog4GeneViewCodeCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvLog4GeneViewCodeCond.sfFldComparisonOp);
}
clsvLog4GeneViewCodeBL.SetUpdFlag(objvLog4GeneViewCodeCond);
 try
{
CheckProperty4Condition(objvLog4GeneViewCodeCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvLog4GeneViewCodeBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvLog4GeneViewCodeCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GeneViewCodeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GeneViewCodeEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvLog4GeneViewCodeEN> arrObjLst = new List<clsvLog4GeneViewCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = new clsvLog4GeneViewCodeEN();
try
{
objvLog4GeneViewCodeEN.mId = Int32.Parse(objRow[convLog4GeneViewCode.mId].ToString().Trim()); //mId
objvLog4GeneViewCodeEN.UserId = objRow[convLog4GeneViewCode.UserId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objvLog4GeneViewCodeEN.UserName = objRow[convLog4GeneViewCode.UserName].ToString().Trim(); //用户名
objvLog4GeneViewCodeEN.ViewId = objRow[convLog4GeneViewCode.ViewId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objvLog4GeneViewCodeEN.ViewName = objRow[convLog4GeneViewCode.ViewName].ToString().Trim(); //界面名称
objvLog4GeneViewCodeEN.ViewCnName = objRow[convLog4GeneViewCode.ViewCnName] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewCnName].ToString().Trim(); //视图中文名
objvLog4GeneViewCodeEN.PrjId = objRow[convLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objvLog4GeneViewCodeEN.PrjName = objRow[convLog4GeneViewCode.PrjName].ToString().Trim(); //工程名称
objvLog4GeneViewCodeEN.FuncModuleAgcId = objRow[convLog4GeneViewCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GeneViewCodeEN.FuncModuleName = objRow[convLog4GeneViewCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GeneViewCodeEN.GeneCodeDate = objRow[convLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GeneViewCodeEN.VersionGeneCode = objRow[convLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GeneViewCodeEN.Memo = objRow[convLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[convLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GeneViewCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GeneViewCodeEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GeneViewCodeEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvLog4GeneViewCodeEN> arrObjLst = new List<clsvLog4GeneViewCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = new clsvLog4GeneViewCodeEN();
try
{
objvLog4GeneViewCodeEN.mId = Int32.Parse(objRow[convLog4GeneViewCode.mId].ToString().Trim()); //mId
objvLog4GeneViewCodeEN.UserId = objRow[convLog4GeneViewCode.UserId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objvLog4GeneViewCodeEN.UserName = objRow[convLog4GeneViewCode.UserName].ToString().Trim(); //用户名
objvLog4GeneViewCodeEN.ViewId = objRow[convLog4GeneViewCode.ViewId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objvLog4GeneViewCodeEN.ViewName = objRow[convLog4GeneViewCode.ViewName].ToString().Trim(); //界面名称
objvLog4GeneViewCodeEN.ViewCnName = objRow[convLog4GeneViewCode.ViewCnName] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewCnName].ToString().Trim(); //视图中文名
objvLog4GeneViewCodeEN.PrjId = objRow[convLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objvLog4GeneViewCodeEN.PrjName = objRow[convLog4GeneViewCode.PrjName].ToString().Trim(); //工程名称
objvLog4GeneViewCodeEN.FuncModuleAgcId = objRow[convLog4GeneViewCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GeneViewCodeEN.FuncModuleName = objRow[convLog4GeneViewCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GeneViewCodeEN.GeneCodeDate = objRow[convLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GeneViewCodeEN.VersionGeneCode = objRow[convLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GeneViewCodeEN.Memo = objRow[convLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[convLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GeneViewCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GeneViewCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GeneViewCodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvLog4GeneViewCodeEN> arrObjLst = new List<clsvLog4GeneViewCodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = new clsvLog4GeneViewCodeEN();
try
{
objvLog4GeneViewCodeEN.mId = Int32.Parse(objRow[convLog4GeneViewCode.mId].ToString().Trim()); //mId
objvLog4GeneViewCodeEN.UserId = objRow[convLog4GeneViewCode.UserId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objvLog4GeneViewCodeEN.UserName = objRow[convLog4GeneViewCode.UserName].ToString().Trim(); //用户名
objvLog4GeneViewCodeEN.ViewId = objRow[convLog4GeneViewCode.ViewId] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objvLog4GeneViewCodeEN.ViewName = objRow[convLog4GeneViewCode.ViewName].ToString().Trim(); //界面名称
objvLog4GeneViewCodeEN.ViewCnName = objRow[convLog4GeneViewCode.ViewCnName] == DBNull.Value ? null : objRow[convLog4GeneViewCode.ViewCnName].ToString().Trim(); //视图中文名
objvLog4GeneViewCodeEN.PrjId = objRow[convLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objvLog4GeneViewCodeEN.PrjName = objRow[convLog4GeneViewCode.PrjName].ToString().Trim(); //工程名称
objvLog4GeneViewCodeEN.FuncModuleAgcId = objRow[convLog4GeneViewCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GeneViewCodeEN.FuncModuleName = objRow[convLog4GeneViewCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GeneViewCodeEN.GeneCodeDate = objRow[convLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GeneViewCodeEN.VersionGeneCode = objRow[convLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GeneViewCodeEN.Memo = objRow[convLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[convLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4GeneViewCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4GeneViewCodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvLog4GeneViewCode(ref clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN)
{
bool bolResult = vLog4GeneViewCodeDA.GetvLog4GeneViewCode(ref objvLog4GeneViewCodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvLog4GeneViewCodeEN GetObjBymId(long lngmId)
{
clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = vLog4GeneViewCodeDA.GetObjBymId(lngmId);
return objvLog4GeneViewCodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvLog4GeneViewCodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = vLog4GeneViewCodeDA.GetFirstObj(strWhereCond);
 return objvLog4GeneViewCodeEN;
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
public static clsvLog4GeneViewCodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = vLog4GeneViewCodeDA.GetObjByDataRow(objRow);
 return objvLog4GeneViewCodeEN;
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
public static clsvLog4GeneViewCodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = vLog4GeneViewCodeDA.GetObjByDataRow(objRow);
 return objvLog4GeneViewCodeEN;
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
 /// <param name = "lstvLog4GeneViewCodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvLog4GeneViewCodeEN GetObjBymIdFromList(long lngmId, List<clsvLog4GeneViewCodeEN> lstvLog4GeneViewCodeObjLst)
{
foreach (clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN in lstvLog4GeneViewCodeObjLst)
{
if (objvLog4GeneViewCodeEN.mId == lngmId)
{
return objvLog4GeneViewCodeEN;
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
 lngmId = new clsvLog4GeneViewCodeDA().GetFirstID(strWhereCond);
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
 arrList = vLog4GeneViewCodeDA.GetID(strWhereCond);
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
bool bolIsExist = vLog4GeneViewCodeDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vLog4GeneViewCodeDA.IsExist(lngmId);
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
 bolIsExist = clsvLog4GeneViewCodeDA.IsExistTable();
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
 bolIsExist = vLog4GeneViewCodeDA.IsExistTable(strTabName);
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
 /// <param name = "objvLog4GeneViewCodeENS">源对象</param>
 /// <param name = "objvLog4GeneViewCodeENT">目标对象</param>
 public static void CopyTo(clsvLog4GeneViewCodeEN objvLog4GeneViewCodeENS, clsvLog4GeneViewCodeEN objvLog4GeneViewCodeENT)
{
try
{
objvLog4GeneViewCodeENT.mId = objvLog4GeneViewCodeENS.mId; //mId
objvLog4GeneViewCodeENT.UserId = objvLog4GeneViewCodeENS.UserId; //用户Id
objvLog4GeneViewCodeENT.UserName = objvLog4GeneViewCodeENS.UserName; //用户名
objvLog4GeneViewCodeENT.ViewId = objvLog4GeneViewCodeENS.ViewId; //界面Id
objvLog4GeneViewCodeENT.ViewName = objvLog4GeneViewCodeENS.ViewName; //界面名称
objvLog4GeneViewCodeENT.ViewCnName = objvLog4GeneViewCodeENS.ViewCnName; //视图中文名
objvLog4GeneViewCodeENT.PrjId = objvLog4GeneViewCodeENS.PrjId; //工程ID
objvLog4GeneViewCodeENT.PrjName = objvLog4GeneViewCodeENS.PrjName; //工程名称
objvLog4GeneViewCodeENT.FuncModuleAgcId = objvLog4GeneViewCodeENS.FuncModuleAgcId; //功能模块Id
objvLog4GeneViewCodeENT.FuncModuleName = objvLog4GeneViewCodeENS.FuncModuleName; //功能模块名称
objvLog4GeneViewCodeENT.GeneCodeDate = objvLog4GeneViewCodeENS.GeneCodeDate; //生成代码日期
objvLog4GeneViewCodeENT.VersionGeneCode = objvLog4GeneViewCodeENS.VersionGeneCode; //生成代码版本
objvLog4GeneViewCodeENT.Memo = objvLog4GeneViewCodeENS.Memo; //说明
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
 /// <param name = "objvLog4GeneViewCodeEN">源简化对象</param>
 public static void SetUpdFlag(clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN)
{
try
{
objvLog4GeneViewCodeEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvLog4GeneViewCodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convLog4GeneViewCode.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GeneViewCodeEN.mId = objvLog4GeneViewCodeEN.mId; //mId
}
if (arrFldSet.Contains(convLog4GeneViewCode.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GeneViewCodeEN.UserId = objvLog4GeneViewCodeEN.UserId == "[null]" ? null :  objvLog4GeneViewCodeEN.UserId; //用户Id
}
if (arrFldSet.Contains(convLog4GeneViewCode.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GeneViewCodeEN.UserName = objvLog4GeneViewCodeEN.UserName; //用户名
}
if (arrFldSet.Contains(convLog4GeneViewCode.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GeneViewCodeEN.ViewId = objvLog4GeneViewCodeEN.ViewId == "[null]" ? null :  objvLog4GeneViewCodeEN.ViewId; //界面Id
}
if (arrFldSet.Contains(convLog4GeneViewCode.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GeneViewCodeEN.ViewName = objvLog4GeneViewCodeEN.ViewName; //界面名称
}
if (arrFldSet.Contains(convLog4GeneViewCode.ViewCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GeneViewCodeEN.ViewCnName = objvLog4GeneViewCodeEN.ViewCnName == "[null]" ? null :  objvLog4GeneViewCodeEN.ViewCnName; //视图中文名
}
if (arrFldSet.Contains(convLog4GeneViewCode.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GeneViewCodeEN.PrjId = objvLog4GeneViewCodeEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convLog4GeneViewCode.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GeneViewCodeEN.PrjName = objvLog4GeneViewCodeEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convLog4GeneViewCode.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GeneViewCodeEN.FuncModuleAgcId = objvLog4GeneViewCodeEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convLog4GeneViewCode.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GeneViewCodeEN.FuncModuleName = objvLog4GeneViewCodeEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convLog4GeneViewCode.GeneCodeDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GeneViewCodeEN.GeneCodeDate = objvLog4GeneViewCodeEN.GeneCodeDate == "[null]" ? null :  objvLog4GeneViewCodeEN.GeneCodeDate; //生成代码日期
}
if (arrFldSet.Contains(convLog4GeneViewCode.VersionGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GeneViewCodeEN.VersionGeneCode = objvLog4GeneViewCodeEN.VersionGeneCode; //生成代码版本
}
if (arrFldSet.Contains(convLog4GeneViewCode.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4GeneViewCodeEN.Memo = objvLog4GeneViewCodeEN.Memo == "[null]" ? null :  objvLog4GeneViewCodeEN.Memo; //说明
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN)
{
try
{
if (objvLog4GeneViewCodeEN.UserId == "[null]") objvLog4GeneViewCodeEN.UserId = null; //用户Id
if (objvLog4GeneViewCodeEN.ViewId == "[null]") objvLog4GeneViewCodeEN.ViewId = null; //界面Id
if (objvLog4GeneViewCodeEN.ViewCnName == "[null]") objvLog4GeneViewCodeEN.ViewCnName = null; //视图中文名
if (objvLog4GeneViewCodeEN.GeneCodeDate == "[null]") objvLog4GeneViewCodeEN.GeneCodeDate = null; //生成代码日期
if (objvLog4GeneViewCodeEN.Memo == "[null]") objvLog4GeneViewCodeEN.Memo = null; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckProperty4Condition(clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN)
{
 vLog4GeneViewCodeDA.CheckProperty4Condition(objvLog4GeneViewCodeEN);
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
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsLog4GeneViewCodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsLog4GeneViewCodeBL没有刷新缓存机制(clsLog4GeneViewCodeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewInfoBL没有刷新缓存机制(clsViewInfoBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewTypeCodeTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewTypeCodeTabBL没有刷新缓存机制(clsViewTypeCodeTabBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewGroupBL没有刷新缓存机制(clsViewGroupBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectBL没有刷新缓存机制(clsCMProjectBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewMasterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewMasterBL没有刷新缓存机制(clsViewMasterBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTitleStyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTitleStyleBL没有刷新缓存机制(clsTitleStyleBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataGridStyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataGridStyleBL没有刷新缓存机制(clsDataGridStyleBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewStyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewStyleBL没有刷新缓存机制(clsViewStyleBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvLog4GeneViewCodeObjLstCache == null)
//{
//arrvLog4GeneViewCodeObjLstCache = vLog4GeneViewCodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvLog4GeneViewCodeEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvLog4GeneViewCodeEN._CurrTabName);
List<clsvLog4GeneViewCodeEN> arrvLog4GeneViewCodeObjLstCache = GetObjLstCache();
IEnumerable <clsvLog4GeneViewCodeEN> arrvLog4GeneViewCodeObjLst_Sel =
arrvLog4GeneViewCodeObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvLog4GeneViewCodeObjLst_Sel.Count() == 0)
{
   clsvLog4GeneViewCodeEN obj = clsvLog4GeneViewCodeBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvLog4GeneViewCodeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvLog4GeneViewCodeEN> GetAllvLog4GeneViewCodeObjLstCache()
{
//获取缓存中的对象列表
List<clsvLog4GeneViewCodeEN> arrvLog4GeneViewCodeObjLstCache = GetObjLstCache(); 
return arrvLog4GeneViewCodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvLog4GeneViewCodeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvLog4GeneViewCodeEN._CurrTabName);
List<clsvLog4GeneViewCodeEN> arrvLog4GeneViewCodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvLog4GeneViewCodeObjLstCache;
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
string strKey = string.Format("{0}", clsvLog4GeneViewCodeEN._CurrTabName);
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
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvLog4GeneViewCodeObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvLog4GeneViewCodeEN> lstvLog4GeneViewCodeObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvLog4GeneViewCodeObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstvLog4GeneViewCodeObjLst">[clsvLog4GeneViewCodeEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvLog4GeneViewCodeEN> lstvLog4GeneViewCodeObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvLog4GeneViewCodeBL.listXmlNode);
writer.WriteStartElement(clsvLog4GeneViewCodeBL.itemsXmlNode);
foreach (clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN in lstvLog4GeneViewCodeObjLst)
{
clsvLog4GeneViewCodeBL.SerializeXML(writer, objvLog4GeneViewCodeEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objvLog4GeneViewCodeEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN)
{
writer.WriteStartElement(clsvLog4GeneViewCodeBL.itemXmlNode);
 
writer.WriteElementString(convLog4GeneViewCode.mId, objvLog4GeneViewCodeEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvLog4GeneViewCodeEN.UserId != null)
{
writer.WriteElementString(convLog4GeneViewCode.UserId, objvLog4GeneViewCodeEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4GeneViewCodeEN.UserName != null)
{
writer.WriteElementString(convLog4GeneViewCode.UserName, objvLog4GeneViewCodeEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4GeneViewCodeEN.ViewId != null)
{
writer.WriteElementString(convLog4GeneViewCode.ViewId, objvLog4GeneViewCodeEN.ViewId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4GeneViewCodeEN.ViewName != null)
{
writer.WriteElementString(convLog4GeneViewCode.ViewName, objvLog4GeneViewCodeEN.ViewName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4GeneViewCodeEN.ViewCnName != null)
{
writer.WriteElementString(convLog4GeneViewCode.ViewCnName, objvLog4GeneViewCodeEN.ViewCnName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4GeneViewCodeEN.PrjId != null)
{
writer.WriteElementString(convLog4GeneViewCode.PrjId, objvLog4GeneViewCodeEN.PrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4GeneViewCodeEN.PrjName != null)
{
writer.WriteElementString(convLog4GeneViewCode.PrjName, objvLog4GeneViewCodeEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4GeneViewCodeEN.FuncModuleAgcId != null)
{
writer.WriteElementString(convLog4GeneViewCode.FuncModuleAgcId, objvLog4GeneViewCodeEN.FuncModuleAgcId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4GeneViewCodeEN.FuncModuleName != null)
{
writer.WriteElementString(convLog4GeneViewCode.FuncModuleName, objvLog4GeneViewCodeEN.FuncModuleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4GeneViewCodeEN.GeneCodeDate != null)
{
writer.WriteElementString(convLog4GeneViewCode.GeneCodeDate, objvLog4GeneViewCodeEN.GeneCodeDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4GeneViewCodeEN.VersionGeneCode != null)
{
writer.WriteElementString(convLog4GeneViewCode.VersionGeneCode, objvLog4GeneViewCodeEN.VersionGeneCode.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4GeneViewCodeEN.Memo != null)
{
writer.WriteElementString(convLog4GeneViewCode.Memo, objvLog4GeneViewCodeEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsvLog4GeneViewCodeEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = new clsvLog4GeneViewCodeEN();
reader.Read();
while (!(reader.Name == clsvLog4GeneViewCodeBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convLog4GeneViewCode.mId))
{
objvLog4GeneViewCodeEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convLog4GeneViewCode.UserId))
{
objvLog4GeneViewCodeEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4GeneViewCode.UserName))
{
objvLog4GeneViewCodeEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4GeneViewCode.ViewId))
{
objvLog4GeneViewCodeEN.ViewId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4GeneViewCode.ViewName))
{
objvLog4GeneViewCodeEN.ViewName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4GeneViewCode.ViewCnName))
{
objvLog4GeneViewCodeEN.ViewCnName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4GeneViewCode.PrjId))
{
objvLog4GeneViewCodeEN.PrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4GeneViewCode.PrjName))
{
objvLog4GeneViewCodeEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4GeneViewCode.FuncModuleAgcId))
{
objvLog4GeneViewCodeEN.FuncModuleAgcId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4GeneViewCode.FuncModuleName))
{
objvLog4GeneViewCodeEN.FuncModuleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4GeneViewCode.GeneCodeDate))
{
objvLog4GeneViewCodeEN.GeneCodeDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4GeneViewCode.VersionGeneCode))
{
objvLog4GeneViewCodeEN.VersionGeneCode = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4GeneViewCode.Memo))
{
objvLog4GeneViewCodeEN.Memo = reader.ReadElementContentAsString();
}
}
return objvLog4GeneViewCodeEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvLog4GeneViewCodeObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvLog4GeneViewCodeEN GetObjFromXmlStr(string strvLog4GeneViewCodeObjXmlStr)
{
clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = new clsvLog4GeneViewCodeEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvLog4GeneViewCodeObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvLog4GeneViewCodeBL.itemXmlNode))
{
objvLog4GeneViewCodeEN = GetObjFromXml(reader);
return objvLog4GeneViewCodeEN;
}
}
return objvLog4GeneViewCodeEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvLog4GeneViewCodeEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convLog4GeneViewCode.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convLog4GeneViewCode.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convLog4GeneViewCode.AttributeName));
throw new Exception(strMsg);
}
var objvLog4GeneViewCode = clsvLog4GeneViewCodeBL.GetObjBymIdCache(lngmId);
if (objvLog4GeneViewCode == null) return "";
return objvLog4GeneViewCode[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvLog4GeneViewCodeEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvLog4GeneViewCodeEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstvLog4GeneViewCodeObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvLog4GeneViewCodeEN> lstvLog4GeneViewCodeObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvLog4GeneViewCodeObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN in lstvLog4GeneViewCodeObjLst)
{
string strJSON_One = SerializeObjToJSON(objvLog4GeneViewCodeEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


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
int intRecCount = clsvLog4GeneViewCodeDA.GetRecCount(strTabName);
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
int intRecCount = clsvLog4GeneViewCodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvLog4GeneViewCodeDA.GetRecCount();
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
int intRecCount = clsvLog4GeneViewCodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvLog4GeneViewCodeEN objvLog4GeneViewCodeCond)
{
List<clsvLog4GeneViewCodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvLog4GeneViewCodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convLog4GeneViewCode.AttributeName)
{
if (objvLog4GeneViewCodeCond.IsUpdated(strFldName) == false) continue;
if (objvLog4GeneViewCodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4GeneViewCodeCond[strFldName].ToString());
}
else
{
if (objvLog4GeneViewCodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvLog4GeneViewCodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4GeneViewCodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvLog4GeneViewCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvLog4GeneViewCodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvLog4GeneViewCodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvLog4GeneViewCodeCond[strFldName]));
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
 List<string> arrList = clsvLog4GeneViewCodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vLog4GeneViewCodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vLog4GeneViewCodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}