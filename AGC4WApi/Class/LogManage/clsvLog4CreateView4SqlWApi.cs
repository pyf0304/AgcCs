
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvLog4CreateView4SqlWApi
 表名:vLog4CreateView4Sql(00050295)
 生成代码版本:2021.07.30.2
 生成日期:2021/07/30 16:30:05
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
public static class clsvLog4CreateView4SqlWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetmId(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, long lngmId, string strComparisonOp="")
	{
objvLog4CreateView4SqlEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.mId) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.mId, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.mId] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetSqlViewId(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strSqlViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewId, convLog4CreateView4Sql.SqlViewId);
clsCheckSql.CheckFieldLen(strSqlViewId, 8, convLog4CreateView4Sql.SqlViewId);
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, convLog4CreateView4Sql.SqlViewId);
objvLog4CreateView4SqlEN.SqlViewId = strSqlViewId; //Sql视图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.SqlViewId) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.SqlViewId, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.SqlViewId] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetPrjDataBaseId(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, convLog4CreateView4Sql.PrjDataBaseId);
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, convLog4CreateView4Sql.PrjDataBaseId);
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, convLog4CreateView4Sql.PrjDataBaseId);
objvLog4CreateView4SqlEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.PrjDataBaseId) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.PrjDataBaseId, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.PrjDataBaseId] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetPrjDataBaseName(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strPrjDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, convLog4CreateView4Sql.PrjDataBaseName);
objvLog4CreateView4SqlEN.PrjDataBaseName = strPrjDataBaseName; //项目数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.PrjDataBaseName) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.PrjDataBaseName, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.PrjDataBaseName] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetCreateViewDate(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strCreateViewDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateViewDate, 14, convLog4CreateView4Sql.CreateViewDate);
objvLog4CreateView4SqlEN.CreateViewDate = strCreateViewDate; //建立视图日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.CreateViewDate) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.CreateViewDate, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.CreateViewDate] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetPrjId(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convLog4CreateView4Sql.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convLog4CreateView4Sql.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convLog4CreateView4Sql.PrjId);
objvLog4CreateView4SqlEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.PrjId) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.PrjId, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.PrjId] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetPrjName(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convLog4CreateView4Sql.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convLog4CreateView4Sql.PrjName);
objvLog4CreateView4SqlEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.PrjName) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.PrjName, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.PrjName] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetUserId(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convLog4CreateView4Sql.UserId);
objvLog4CreateView4SqlEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.UserId) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.UserId, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.UserId] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetMemo(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convLog4CreateView4Sql.Memo);
objvLog4CreateView4SqlEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.Memo) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.Memo, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.Memo] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvLog4CreateView4SqlEN objvLog4CreateView4Sql_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvLog4CreateView4Sql_Cond.IsUpdated(convLog4CreateView4Sql.mId) == true)
{
string strComparisonOp_mId = objvLog4CreateView4Sql_Cond.dicFldComparisonOp[convLog4CreateView4Sql.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convLog4CreateView4Sql.mId, objvLog4CreateView4Sql_Cond.mId, strComparisonOp_mId);
}
if (objvLog4CreateView4Sql_Cond.IsUpdated(convLog4CreateView4Sql.SqlViewId) == true)
{
string strComparisonOp_SqlViewId = objvLog4CreateView4Sql_Cond.dicFldComparisonOp[convLog4CreateView4Sql.SqlViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.SqlViewId, objvLog4CreateView4Sql_Cond.SqlViewId, strComparisonOp_SqlViewId);
}
if (objvLog4CreateView4Sql_Cond.IsUpdated(convLog4CreateView4Sql.PrjDataBaseId) == true)
{
string strComparisonOp_PrjDataBaseId = objvLog4CreateView4Sql_Cond.dicFldComparisonOp[convLog4CreateView4Sql.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.PrjDataBaseId, objvLog4CreateView4Sql_Cond.PrjDataBaseId, strComparisonOp_PrjDataBaseId);
}
if (objvLog4CreateView4Sql_Cond.IsUpdated(convLog4CreateView4Sql.PrjDataBaseName) == true)
{
string strComparisonOp_PrjDataBaseName = objvLog4CreateView4Sql_Cond.dicFldComparisonOp[convLog4CreateView4Sql.PrjDataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.PrjDataBaseName, objvLog4CreateView4Sql_Cond.PrjDataBaseName, strComparisonOp_PrjDataBaseName);
}
if (objvLog4CreateView4Sql_Cond.IsUpdated(convLog4CreateView4Sql.CreateViewDate) == true)
{
string strComparisonOp_CreateViewDate = objvLog4CreateView4Sql_Cond.dicFldComparisonOp[convLog4CreateView4Sql.CreateViewDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.CreateViewDate, objvLog4CreateView4Sql_Cond.CreateViewDate, strComparisonOp_CreateViewDate);
}
if (objvLog4CreateView4Sql_Cond.IsUpdated(convLog4CreateView4Sql.PrjId) == true)
{
string strComparisonOp_PrjId = objvLog4CreateView4Sql_Cond.dicFldComparisonOp[convLog4CreateView4Sql.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.PrjId, objvLog4CreateView4Sql_Cond.PrjId, strComparisonOp_PrjId);
}
if (objvLog4CreateView4Sql_Cond.IsUpdated(convLog4CreateView4Sql.PrjName) == true)
{
string strComparisonOp_PrjName = objvLog4CreateView4Sql_Cond.dicFldComparisonOp[convLog4CreateView4Sql.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.PrjName, objvLog4CreateView4Sql_Cond.PrjName, strComparisonOp_PrjName);
}
if (objvLog4CreateView4Sql_Cond.IsUpdated(convLog4CreateView4Sql.UserId) == true)
{
string strComparisonOp_UserId = objvLog4CreateView4Sql_Cond.dicFldComparisonOp[convLog4CreateView4Sql.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.UserId, objvLog4CreateView4Sql_Cond.UserId, strComparisonOp_UserId);
}
if (objvLog4CreateView4Sql_Cond.IsUpdated(convLog4CreateView4Sql.Memo) == true)
{
string strComparisonOp_Memo = objvLog4CreateView4Sql_Cond.dicFldComparisonOp[convLog4CreateView4Sql.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.Memo, objvLog4CreateView4Sql_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v建立视图日志(vLog4CreateView4Sql)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvLog4CreateView4SqlWApi
{
private static readonly string mstrApiControllerName = "vLog4CreateView4SqlApi";

 public clsvLog4CreateView4SqlWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvLog4CreateView4SqlEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = null;
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
objvLog4CreateView4SqlEN = JsonConvert.DeserializeObject<clsvLog4CreateView4SqlEN>((string)jobjReturn["returnObj"]);
return objvLog4CreateView4SqlEN;
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
public static clsvLog4CreateView4SqlEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = null;
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
objvLog4CreateView4SqlEN = JsonConvert.DeserializeObject<clsvLog4CreateView4SqlEN>((string)jobjReturn["returnObj"]);
return objvLog4CreateView4SqlEN;
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
public static clsvLog4CreateView4SqlEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = null;
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
objvLog4CreateView4SqlEN = JsonConvert.DeserializeObject<clsvLog4CreateView4SqlEN>((string)jobjReturn["returnObj"]);
return objvLog4CreateView4SqlEN;
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
public static clsvLog4CreateView4SqlEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvLog4CreateView4SqlEN._CurrTabName);
List<clsvLog4CreateView4SqlEN> arrvLog4CreateView4SqlObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvLog4CreateView4SqlEN> arrvLog4CreateView4SqlObjLst_Sel =
from objvLog4CreateView4SqlEN in arrvLog4CreateView4SqlObjLst_Cache
where objvLog4CreateView4SqlEN.mId == lngmId
select objvLog4CreateView4SqlEN;
if (arrvLog4CreateView4SqlObjLst_Sel.Count() == 0)
{
   clsvLog4CreateView4SqlEN obj = clsvLog4CreateView4SqlWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvLog4CreateView4SqlObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4CreateView4SqlEN> GetObjLst(string strWhereCond)
{
 List<clsvLog4CreateView4SqlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4CreateView4SqlEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsvLog4CreateView4SqlEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvLog4CreateView4SqlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4CreateView4SqlEN>>((string)jobjReturn["returnObjLst"]);
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
public static IEnumerable<clsvLog4CreateView4SqlEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvLog4CreateView4SqlEN._CurrTabName);
List<clsvLog4CreateView4SqlEN> arrvLog4CreateView4SqlObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvLog4CreateView4SqlEN> arrvLog4CreateView4SqlObjLst_Sel =
from objvLog4CreateView4SqlEN in arrvLog4CreateView4SqlObjLst_Cache
where arrMId.Contains(objvLog4CreateView4SqlEN.mId)
select objvLog4CreateView4SqlEN;
return arrvLog4CreateView4SqlObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4CreateView4SqlEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvLog4CreateView4SqlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4CreateView4SqlEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsvLog4CreateView4SqlEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvLog4CreateView4SqlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4CreateView4SqlEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsvLog4CreateView4SqlEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvLog4CreateView4SqlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4CreateView4SqlEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsvLog4CreateView4SqlEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvLog4CreateView4SqlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4CreateView4SqlEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsvLog4CreateView4SqlEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvLog4CreateView4SqlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4CreateView4SqlEN>>((string)jobjReturn["returnObjLst"]);
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
 /// <param name = "objvLog4CreateView4SqlENS">源对象</param>
 /// <param name = "objvLog4CreateView4SqlENT">目标对象</param>
 public static void CopyTo(clsvLog4CreateView4SqlEN objvLog4CreateView4SqlENS, clsvLog4CreateView4SqlEN objvLog4CreateView4SqlENT)
{
try
{
objvLog4CreateView4SqlENT.mId = objvLog4CreateView4SqlENS.mId; //mId
objvLog4CreateView4SqlENT.SqlViewId = objvLog4CreateView4SqlENS.SqlViewId; //Sql视图Id
objvLog4CreateView4SqlENT.PrjDataBaseId = objvLog4CreateView4SqlENS.PrjDataBaseId; //项目数据库Id
objvLog4CreateView4SqlENT.PrjDataBaseName = objvLog4CreateView4SqlENS.PrjDataBaseName; //项目数据库名
objvLog4CreateView4SqlENT.CreateViewDate = objvLog4CreateView4SqlENS.CreateViewDate; //建立视图日期
objvLog4CreateView4SqlENT.PrjId = objvLog4CreateView4SqlENS.PrjId; //工程ID
objvLog4CreateView4SqlENT.PrjName = objvLog4CreateView4SqlENS.PrjName; //工程名称
objvLog4CreateView4SqlENT.UserId = objvLog4CreateView4SqlENS.UserId; //用户Id
objvLog4CreateView4SqlENT.Memo = objvLog4CreateView4SqlENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvLog4CreateView4SqlEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvLog4CreateView4SqlEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvLog4CreateView4SqlEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvLog4CreateView4SqlEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvLog4CreateView4SqlEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvLog4CreateView4SqlEN.AttributeName)
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
if (clsProjectsWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsProjectsWApi没有刷新缓存机制(clsProjectsWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjDataBaseWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsPrjDataBaseWApi没有刷新缓存机制(clsPrjDataBaseWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsLog4CreateView4SqlWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsLog4CreateView4SqlWApi没有刷新缓存机制(clsLog4CreateView4SqlWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvLog4CreateView4SqlObjLst_Cache == null)
//{
//arrvLog4CreateView4SqlObjLst_Cache = await clsvLog4CreateView4SqlWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvLog4CreateView4SqlEN._CurrTabName);
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
public static List<clsvLog4CreateView4SqlEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvLog4CreateView4SqlEN._CurrTabName);
List<clsvLog4CreateView4SqlEN> arrvLog4CreateView4SqlObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvLog4CreateView4SqlObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvLog4CreateView4SqlEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convLog4CreateView4Sql.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convLog4CreateView4Sql.SqlViewId, Type.GetType("System.String"));
objDT.Columns.Add(convLog4CreateView4Sql.PrjDataBaseId, Type.GetType("System.String"));
objDT.Columns.Add(convLog4CreateView4Sql.PrjDataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convLog4CreateView4Sql.CreateViewDate, Type.GetType("System.String"));
objDT.Columns.Add(convLog4CreateView4Sql.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convLog4CreateView4Sql.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convLog4CreateView4Sql.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convLog4CreateView4Sql.Memo, Type.GetType("System.String"));
foreach (clsvLog4CreateView4SqlEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convLog4CreateView4Sql.mId] = objInFor[convLog4CreateView4Sql.mId];
objDR[convLog4CreateView4Sql.SqlViewId] = objInFor[convLog4CreateView4Sql.SqlViewId];
objDR[convLog4CreateView4Sql.PrjDataBaseId] = objInFor[convLog4CreateView4Sql.PrjDataBaseId];
objDR[convLog4CreateView4Sql.PrjDataBaseName] = objInFor[convLog4CreateView4Sql.PrjDataBaseName];
objDR[convLog4CreateView4Sql.CreateViewDate] = objInFor[convLog4CreateView4Sql.CreateViewDate];
objDR[convLog4CreateView4Sql.PrjId] = objInFor[convLog4CreateView4Sql.PrjId];
objDR[convLog4CreateView4Sql.PrjName] = objInFor[convLog4CreateView4Sql.PrjName];
objDR[convLog4CreateView4Sql.UserId] = objInFor[convLog4CreateView4Sql.UserId];
objDR[convLog4CreateView4Sql.Memo] = objInFor[convLog4CreateView4Sql.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}