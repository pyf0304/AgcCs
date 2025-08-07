
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvLog4GeneViewCodeWApi
 表名:vLog4GeneViewCode(00050281)
 生成代码版本:2021.07.30.2
 生成日期:2021/07/30 16:30:10
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理
 模块英文名:LogManage
 框架-层名:WA_访问层(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
public static class clsvLog4GeneViewCodeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetUserId(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convLog4GeneViewCode.UserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetUserName(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convLog4GeneViewCode.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convLog4GeneViewCode.UserName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetViewId(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewId, 8, convLog4GeneViewCode.ViewId);
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convLog4GeneViewCode.ViewId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetViewName(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, convLog4GeneViewCode.ViewName);
clsCheckSql.CheckFieldLen(strViewName, 100, convLog4GeneViewCode.ViewName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetViewCnName(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strViewCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewCnName, 100, convLog4GeneViewCode.ViewCnName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetPrjId(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convLog4GeneViewCode.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convLog4GeneViewCode.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convLog4GeneViewCode.PrjId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetPrjName(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convLog4GeneViewCode.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convLog4GeneViewCode.PrjName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetFuncModuleAgcId(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convLog4GeneViewCode.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convLog4GeneViewCode.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convLog4GeneViewCode.FuncModuleAgcId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetFuncModuleName(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convLog4GeneViewCode.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convLog4GeneViewCode.FuncModuleName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetGeneCodeDate(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strGeneCodeDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convLog4GeneViewCode.GeneCodeDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetVersionGeneCode(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strVersionGeneCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionGeneCode, convLog4GeneViewCode.VersionGeneCode);
clsCheckSql.CheckFieldLen(strVersionGeneCode, 30, convLog4GeneViewCode.VersionGeneCode);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneViewCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneViewCodeEN SetMemo(this clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convLog4GeneViewCode.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvLog4GeneViewCodeEN objvLog4GeneViewCode_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvLog4GeneViewCode_Cond.IsUpdated(convLog4GeneViewCode.mId) == true)
{
string strComparisonOp_mId = objvLog4GeneViewCode_Cond.dicFldComparisonOp[convLog4GeneViewCode.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convLog4GeneViewCode.mId, objvLog4GeneViewCode_Cond.mId, strComparisonOp_mId);
}
if (objvLog4GeneViewCode_Cond.IsUpdated(convLog4GeneViewCode.UserId) == true)
{
string strComparisonOp_UserId = objvLog4GeneViewCode_Cond.dicFldComparisonOp[convLog4GeneViewCode.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.UserId, objvLog4GeneViewCode_Cond.UserId, strComparisonOp_UserId);
}
if (objvLog4GeneViewCode_Cond.IsUpdated(convLog4GeneViewCode.UserName) == true)
{
string strComparisonOp_UserName = objvLog4GeneViewCode_Cond.dicFldComparisonOp[convLog4GeneViewCode.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.UserName, objvLog4GeneViewCode_Cond.UserName, strComparisonOp_UserName);
}
if (objvLog4GeneViewCode_Cond.IsUpdated(convLog4GeneViewCode.ViewId) == true)
{
string strComparisonOp_ViewId = objvLog4GeneViewCode_Cond.dicFldComparisonOp[convLog4GeneViewCode.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.ViewId, objvLog4GeneViewCode_Cond.ViewId, strComparisonOp_ViewId);
}
if (objvLog4GeneViewCode_Cond.IsUpdated(convLog4GeneViewCode.ViewName) == true)
{
string strComparisonOp_ViewName = objvLog4GeneViewCode_Cond.dicFldComparisonOp[convLog4GeneViewCode.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.ViewName, objvLog4GeneViewCode_Cond.ViewName, strComparisonOp_ViewName);
}
if (objvLog4GeneViewCode_Cond.IsUpdated(convLog4GeneViewCode.ViewCnName) == true)
{
string strComparisonOp_ViewCnName = objvLog4GeneViewCode_Cond.dicFldComparisonOp[convLog4GeneViewCode.ViewCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.ViewCnName, objvLog4GeneViewCode_Cond.ViewCnName, strComparisonOp_ViewCnName);
}
if (objvLog4GeneViewCode_Cond.IsUpdated(convLog4GeneViewCode.PrjId) == true)
{
string strComparisonOp_PrjId = objvLog4GeneViewCode_Cond.dicFldComparisonOp[convLog4GeneViewCode.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.PrjId, objvLog4GeneViewCode_Cond.PrjId, strComparisonOp_PrjId);
}
if (objvLog4GeneViewCode_Cond.IsUpdated(convLog4GeneViewCode.PrjName) == true)
{
string strComparisonOp_PrjName = objvLog4GeneViewCode_Cond.dicFldComparisonOp[convLog4GeneViewCode.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.PrjName, objvLog4GeneViewCode_Cond.PrjName, strComparisonOp_PrjName);
}
if (objvLog4GeneViewCode_Cond.IsUpdated(convLog4GeneViewCode.FuncModuleAgcId) == true)
{
string strComparisonOp_FuncModuleAgcId = objvLog4GeneViewCode_Cond.dicFldComparisonOp[convLog4GeneViewCode.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.FuncModuleAgcId, objvLog4GeneViewCode_Cond.FuncModuleAgcId, strComparisonOp_FuncModuleAgcId);
}
if (objvLog4GeneViewCode_Cond.IsUpdated(convLog4GeneViewCode.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvLog4GeneViewCode_Cond.dicFldComparisonOp[convLog4GeneViewCode.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.FuncModuleName, objvLog4GeneViewCode_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvLog4GeneViewCode_Cond.IsUpdated(convLog4GeneViewCode.GeneCodeDate) == true)
{
string strComparisonOp_GeneCodeDate = objvLog4GeneViewCode_Cond.dicFldComparisonOp[convLog4GeneViewCode.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.GeneCodeDate, objvLog4GeneViewCode_Cond.GeneCodeDate, strComparisonOp_GeneCodeDate);
}
if (objvLog4GeneViewCode_Cond.IsUpdated(convLog4GeneViewCode.VersionGeneCode) == true)
{
string strComparisonOp_VersionGeneCode = objvLog4GeneViewCode_Cond.dicFldComparisonOp[convLog4GeneViewCode.VersionGeneCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.VersionGeneCode, objvLog4GeneViewCode_Cond.VersionGeneCode, strComparisonOp_VersionGeneCode);
}
if (objvLog4GeneViewCode_Cond.IsUpdated(convLog4GeneViewCode.Memo) == true)
{
string strComparisonOp_Memo = objvLog4GeneViewCode_Cond.dicFldComparisonOp[convLog4GeneViewCode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneViewCode.Memo, objvLog4GeneViewCode_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v生成界面代码日志(vLog4GeneViewCode)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvLog4GeneViewCodeWApi
{
private static readonly string mstrApiControllerName = "vLog4GeneViewCodeApi";

 public clsvLog4GeneViewCodeWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvLog4GeneViewCodeEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvLog4GeneViewCodeEN = JsonConvert.DeserializeObject<clsvLog4GeneViewCodeEN>((string)jobjReturn["returnObj"]);
return objvLog4GeneViewCodeEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvLog4GeneViewCodeEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvLog4GeneViewCodeEN = JsonConvert.DeserializeObject<clsvLog4GeneViewCodeEN>((string)jobjReturn["returnObj"]);
return objvLog4GeneViewCodeEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn["returnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static clsvLog4GeneViewCodeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvLog4GeneViewCodeEN objvLog4GeneViewCodeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvLog4GeneViewCodeEN = JsonConvert.DeserializeObject<clsvLog4GeneViewCodeEN>((string)jobjReturn["returnObj"]);
return objvLog4GeneViewCodeEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvLog4GeneViewCodeEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvLog4GeneViewCodeEN._CurrTabName);
List<clsvLog4GeneViewCodeEN> arrvLog4GeneViewCodeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvLog4GeneViewCodeEN> arrvLog4GeneViewCodeObjLst_Sel =
from objvLog4GeneViewCodeEN in arrvLog4GeneViewCodeObjLst_Cache
where objvLog4GeneViewCodeEN.mId == lngmId
select objvLog4GeneViewCodeEN;
if (arrvLog4GeneViewCodeObjLst_Sel.Count() == 0)
{
   clsvLog4GeneViewCodeEN obj = clsvLog4GeneViewCodeWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvLog4GeneViewCodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GeneViewCodeEN> GetObjLst(string strWhereCond)
{
 List<clsvLog4GeneViewCodeEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GeneViewCodeEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GeneViewCodeEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvLog4GeneViewCodeEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GeneViewCodeEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvLog4GeneViewCodeEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvLog4GeneViewCodeEN._CurrTabName);
List<clsvLog4GeneViewCodeEN> arrvLog4GeneViewCodeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvLog4GeneViewCodeEN> arrvLog4GeneViewCodeObjLst_Sel =
from objvLog4GeneViewCodeEN in arrvLog4GeneViewCodeObjLst_Cache
where arrMId.Contains(objvLog4GeneViewCodeEN.mId)
select objvLog4GeneViewCodeEN;
return arrvLog4GeneViewCodeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GeneViewCodeEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvLog4GeneViewCodeEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GeneViewCodeEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GeneViewCodeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvLog4GeneViewCodeEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GeneViewCodeEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsvLog4GeneViewCodeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvLog4GeneViewCodeEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GeneViewCodeEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsvLog4GeneViewCodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvLog4GeneViewCodeEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GeneViewCodeEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvLog4GeneViewCodeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvLog4GeneViewCodeEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GeneViewCodeEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static DataTable ToDataTable(List<clsvLog4GeneViewCodeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvLog4GeneViewCodeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvLog4GeneViewCodeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvLog4GeneViewCodeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvLog4GeneViewCodeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvLog4GeneViewCodeEN.AttributeName)
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
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsUsersWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsLog4GeneViewCodeWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsLog4GeneViewCodeWApi没有刷新缓存机制(clsLog4GeneViewCodeWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsProjectsWApi没有刷新缓存机制(clsProjectsWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewInfoWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsViewInfoWApi没有刷新缓存机制(clsViewInfoWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsPrjTabWApi没有刷新缓存机制(clsPrjTabWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModule_AgcWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsFuncModule_AgcWApi没有刷新缓存机制(clsFuncModule_AgcWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTabWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsFieldTabWApi没有刷新缓存机制(clsFieldTabWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewTypeCodeTabWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsViewTypeCodeTabWApi没有刷新缓存机制(clsViewTypeCodeTabWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsApplicationTypeWApi没有刷新缓存机制(clsApplicationTypeWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewGroupWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsViewGroupWApi没有刷新缓存机制(clsViewGroupWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsCMProjectWApi没有刷新缓存机制(clsCMProjectWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewMasterWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsViewMasterWApi没有刷新缓存机制(clsViewMasterWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTitleStyleWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsTitleStyleWApi没有刷新缓存机制(clsTitleStyleWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataGridStyleWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsDataGridStyleWApi没有刷新缓存机制(clsDataGridStyleWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewStyleWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsViewStyleWApi没有刷新缓存机制(clsViewStyleWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvLog4GeneViewCodeObjLst_Cache == null)
//{
//arrvLog4GeneViewCodeObjLst_Cache = await clsvLog4GeneViewCodeWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
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

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvLog4GeneViewCodeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvLog4GeneViewCodeEN._CurrTabName);
List<clsvLog4GeneViewCodeEN> arrvLog4GeneViewCodeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvLog4GeneViewCodeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvLog4GeneViewCodeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convLog4GeneViewCode.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convLog4GeneViewCode.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneViewCode.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneViewCode.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneViewCode.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneViewCode.ViewCnName, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneViewCode.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneViewCode.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneViewCode.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneViewCode.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneViewCode.GeneCodeDate, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneViewCode.VersionGeneCode, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneViewCode.Memo, Type.GetType("System.String"));
foreach (clsvLog4GeneViewCodeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convLog4GeneViewCode.mId] = objInFor[convLog4GeneViewCode.mId];
objDR[convLog4GeneViewCode.UserId] = objInFor[convLog4GeneViewCode.UserId];
objDR[convLog4GeneViewCode.UserName] = objInFor[convLog4GeneViewCode.UserName];
objDR[convLog4GeneViewCode.ViewId] = objInFor[convLog4GeneViewCode.ViewId];
objDR[convLog4GeneViewCode.ViewName] = objInFor[convLog4GeneViewCode.ViewName];
objDR[convLog4GeneViewCode.ViewCnName] = objInFor[convLog4GeneViewCode.ViewCnName];
objDR[convLog4GeneViewCode.PrjId] = objInFor[convLog4GeneViewCode.PrjId];
objDR[convLog4GeneViewCode.PrjName] = objInFor[convLog4GeneViewCode.PrjName];
objDR[convLog4GeneViewCode.FuncModuleAgcId] = objInFor[convLog4GeneViewCode.FuncModuleAgcId];
objDR[convLog4GeneViewCode.FuncModuleName] = objInFor[convLog4GeneViewCode.FuncModuleName];
objDR[convLog4GeneViewCode.GeneCodeDate] = objInFor[convLog4GeneViewCode.GeneCodeDate];
objDR[convLog4GeneViewCode.VersionGeneCode] = objInFor[convLog4GeneViewCode.VersionGeneCode];
objDR[convLog4GeneViewCode.Memo] = objInFor[convLog4GeneViewCode.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}