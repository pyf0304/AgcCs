
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewMasterWApi
 表名:vViewMaster(00050558)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:08:12
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
public static class  clsvViewMasterWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewMasterId">界面母版Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewMasterEN SetViewMasterId(this clsvViewMasterEN objvViewMasterEN, string strViewMasterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewMasterId, 8, convViewMaster.ViewMasterId);
clsCheckSql.CheckFieldForeignKey(strViewMasterId, 8, convViewMaster.ViewMasterId);
objvViewMasterEN.ViewMasterId = strViewMasterId; //界面母版Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewMasterEN.dicFldComparisonOp.ContainsKey(convViewMaster.ViewMasterId) == false)
{
objvViewMasterEN.dicFldComparisonOp.Add(convViewMaster.ViewMasterId, strComparisonOp);
}
else
{
objvViewMasterEN.dicFldComparisonOp[convViewMaster.ViewMasterId] = strComparisonOp;
}
}
return objvViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewMasterName">界面母版名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewMasterEN SetViewMasterName(this clsvViewMasterEN objvViewMasterEN, string strViewMasterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewMasterName, 50, convViewMaster.ViewMasterName);
objvViewMasterEN.ViewMasterName = strViewMasterName; //界面母版名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewMasterEN.dicFldComparisonOp.ContainsKey(convViewMaster.ViewMasterName) == false)
{
objvViewMasterEN.dicFldComparisonOp.Add(convViewMaster.ViewMasterName, strComparisonOp);
}
else
{
objvViewMasterEN.dicFldComparisonOp[convViewMaster.ViewMasterName] = strComparisonOp;
}
}
return objvViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewMasterPath">界面母版路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewMasterEN SetViewMasterPath(this clsvViewMasterEN objvViewMasterEN, string strViewMasterPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewMasterPath, 100, convViewMaster.ViewMasterPath);
objvViewMasterEN.ViewMasterPath = strViewMasterPath; //界面母版路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewMasterEN.dicFldComparisonOp.ContainsKey(convViewMaster.ViewMasterPath) == false)
{
objvViewMasterEN.dicFldComparisonOp.Add(convViewMaster.ViewMasterPath, strComparisonOp);
}
else
{
objvViewMasterEN.dicFldComparisonOp[convViewMaster.ViewMasterPath] = strComparisonOp;
}
}
return objvViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewMasterEN SetApplicationTypeId(this clsvViewMasterEN objvViewMasterEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convViewMaster.ApplicationTypeId);
objvViewMasterEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewMasterEN.dicFldComparisonOp.ContainsKey(convViewMaster.ApplicationTypeId) == false)
{
objvViewMasterEN.dicFldComparisonOp.Add(convViewMaster.ApplicationTypeId, strComparisonOp);
}
else
{
objvViewMasterEN.dicFldComparisonOp[convViewMaster.ApplicationTypeId] = strComparisonOp;
}
}
return objvViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewMasterEN SetApplicationTypeName(this clsvViewMasterEN objvViewMasterEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, convViewMaster.ApplicationTypeName);
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convViewMaster.ApplicationTypeName);
objvViewMasterEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewMasterEN.dicFldComparisonOp.ContainsKey(convViewMaster.ApplicationTypeName) == false)
{
objvViewMasterEN.dicFldComparisonOp.Add(convViewMaster.ApplicationTypeName, strComparisonOp);
}
else
{
objvViewMasterEN.dicFldComparisonOp[convViewMaster.ApplicationTypeName] = strComparisonOp;
}
}
return objvViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeSimName">应用程序类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewMasterEN SetApplicationTypeSimName(this clsvViewMasterEN objvViewMasterEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convViewMaster.ApplicationTypeSimName);
objvViewMasterEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewMasterEN.dicFldComparisonOp.ContainsKey(convViewMaster.ApplicationTypeSimName) == false)
{
objvViewMasterEN.dicFldComparisonOp.Add(convViewMaster.ApplicationTypeSimName, strComparisonOp);
}
else
{
objvViewMasterEN.dicFldComparisonOp[convViewMaster.ApplicationTypeSimName] = strComparisonOp;
}
}
return objvViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewMasterEN SetPrjId(this clsvViewMasterEN objvViewMasterEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convViewMaster.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewMaster.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewMaster.PrjId);
objvViewMasterEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewMasterEN.dicFldComparisonOp.ContainsKey(convViewMaster.PrjId) == false)
{
objvViewMasterEN.dicFldComparisonOp.Add(convViewMaster.PrjId, strComparisonOp);
}
else
{
objvViewMasterEN.dicFldComparisonOp[convViewMaster.PrjId] = strComparisonOp;
}
}
return objvViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewMasterEN SetUpdDate(this clsvViewMasterEN objvViewMasterEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewMaster.UpdDate);
objvViewMasterEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewMasterEN.dicFldComparisonOp.ContainsKey(convViewMaster.UpdDate) == false)
{
objvViewMasterEN.dicFldComparisonOp.Add(convViewMaster.UpdDate, strComparisonOp);
}
else
{
objvViewMasterEN.dicFldComparisonOp[convViewMaster.UpdDate] = strComparisonOp;
}
}
return objvViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewMasterEN SetUpdUser(this clsvViewMasterEN objvViewMasterEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convViewMaster.UpdUser);
objvViewMasterEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewMasterEN.dicFldComparisonOp.ContainsKey(convViewMaster.UpdUser) == false)
{
objvViewMasterEN.dicFldComparisonOp.Add(convViewMaster.UpdUser, strComparisonOp);
}
else
{
objvViewMasterEN.dicFldComparisonOp[convViewMaster.UpdUser] = strComparisonOp;
}
}
return objvViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewMasterEN SetMemo(this clsvViewMasterEN objvViewMasterEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewMaster.Memo);
objvViewMasterEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewMasterEN.dicFldComparisonOp.ContainsKey(convViewMaster.Memo) == false)
{
objvViewMasterEN.dicFldComparisonOp.Add(convViewMaster.Memo, strComparisonOp);
}
else
{
objvViewMasterEN.dicFldComparisonOp[convViewMaster.Memo] = strComparisonOp;
}
}
return objvViewMasterEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewMasterEN objvViewMasterCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewMasterCond.IsUpdated(convViewMaster.ViewMasterId) == true)
{
string strComparisonOpViewMasterId = objvViewMasterCond.dicFldComparisonOp[convViewMaster.ViewMasterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewMaster.ViewMasterId, objvViewMasterCond.ViewMasterId, strComparisonOpViewMasterId);
}
if (objvViewMasterCond.IsUpdated(convViewMaster.ViewMasterName) == true)
{
string strComparisonOpViewMasterName = objvViewMasterCond.dicFldComparisonOp[convViewMaster.ViewMasterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewMaster.ViewMasterName, objvViewMasterCond.ViewMasterName, strComparisonOpViewMasterName);
}
if (objvViewMasterCond.IsUpdated(convViewMaster.ViewMasterPath) == true)
{
string strComparisonOpViewMasterPath = objvViewMasterCond.dicFldComparisonOp[convViewMaster.ViewMasterPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewMaster.ViewMasterPath, objvViewMasterCond.ViewMasterPath, strComparisonOpViewMasterPath);
}
if (objvViewMasterCond.IsUpdated(convViewMaster.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvViewMasterCond.dicFldComparisonOp[convViewMaster.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewMaster.ApplicationTypeId, objvViewMasterCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvViewMasterCond.IsUpdated(convViewMaster.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvViewMasterCond.dicFldComparisonOp[convViewMaster.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewMaster.ApplicationTypeName, objvViewMasterCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvViewMasterCond.IsUpdated(convViewMaster.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objvViewMasterCond.dicFldComparisonOp[convViewMaster.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewMaster.ApplicationTypeSimName, objvViewMasterCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objvViewMasterCond.IsUpdated(convViewMaster.PrjId) == true)
{
string strComparisonOpPrjId = objvViewMasterCond.dicFldComparisonOp[convViewMaster.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewMaster.PrjId, objvViewMasterCond.PrjId, strComparisonOpPrjId);
}
if (objvViewMasterCond.IsUpdated(convViewMaster.UpdDate) == true)
{
string strComparisonOpUpdDate = objvViewMasterCond.dicFldComparisonOp[convViewMaster.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewMaster.UpdDate, objvViewMasterCond.UpdDate, strComparisonOpUpdDate);
}
if (objvViewMasterCond.IsUpdated(convViewMaster.UpdUser) == true)
{
string strComparisonOpUpdUser = objvViewMasterCond.dicFldComparisonOp[convViewMaster.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewMaster.UpdUser, objvViewMasterCond.UpdUser, strComparisonOpUpdUser);
}
if (objvViewMasterCond.IsUpdated(convViewMaster.Memo) == true)
{
string strComparisonOpMemo = objvViewMasterCond.dicFldComparisonOp[convViewMaster.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewMaster.Memo, objvViewMasterCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vViewMaster(vViewMaster)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvViewMasterWApi
{
private static readonly string mstrApiControllerName = "vViewMasterApi";

 public clsvViewMasterWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewMasterId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewMasterEN GetObjByViewMasterId(string strViewMasterId)
{
if (strViewMasterId == "") return null;
string strAction = "GetObjByViewMasterId";
clsvViewMasterEN objvViewMasterEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewMasterId"] = strViewMasterId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvViewMasterEN = JsonConvert.DeserializeObject<clsvViewMasterEN>(strJson);
return objvViewMasterEN;
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
public static clsvViewMasterEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvViewMasterEN objvViewMasterEN;
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
objvViewMasterEN = JsonConvert.DeserializeObject<clsvViewMasterEN>(strJson);
return objvViewMasterEN;
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
 /// <param name = "strViewMasterId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewMasterEN GetObjByViewMasterIdCache(string strViewMasterId,string strPrjId)
{
if (string.IsNullOrEmpty(strViewMasterId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvViewMasterEN._CurrTabName, strPrjId);
List<clsvViewMasterEN> arrvViewMasterObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewMasterEN> arrvViewMasterObjLst_Sel =
from objvViewMasterEN in arrvViewMasterObjLstCache
where objvViewMasterEN.ViewMasterId == strViewMasterId 
select objvViewMasterEN;
if (arrvViewMasterObjLst_Sel.Count() == 0)
{
   clsvViewMasterEN obj = clsvViewMasterWApi.GetObjByViewMasterId(strViewMasterId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvViewMasterObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewMasterEN> GetObjLst(string strWhereCond)
{
 List<clsvViewMasterEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewMasterEN>>(strJson);
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
 /// <param name = "arrViewMasterId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewMasterEN> GetObjLstByViewMasterIdLst(List<string> arrViewMasterId)
{
 List<clsvViewMasterEN> arrObjLst; 
string strAction = "GetObjLstByViewMasterIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewMasterId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewMasterEN>>(strJson);
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
 /// <param name = "arrViewMasterId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvViewMasterEN> GetObjLstByViewMasterIdLstCache(List<string> arrViewMasterId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvViewMasterEN._CurrTabName, strPrjId);
List<clsvViewMasterEN> arrvViewMasterObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewMasterEN> arrvViewMasterObjLst_Sel =
from objvViewMasterEN in arrvViewMasterObjLstCache
where arrViewMasterId.Contains(objvViewMasterEN.ViewMasterId)
select objvViewMasterEN;
return arrvViewMasterObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewMasterEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvViewMasterEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewMasterEN>>(strJson);
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
public static List<clsvViewMasterEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvViewMasterEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewMasterEN>>(strJson);
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
public static List<clsvViewMasterEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvViewMasterEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewMasterEN>>(strJson);
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
public static List<clsvViewMasterEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvViewMasterEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewMasterEN>>(strJson);
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
public static bool IsExist(string strViewMasterId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewMasterId"] = strViewMasterId
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
 /// <param name = "objvViewMasterENS">源对象</param>
 /// <param name = "objvViewMasterENT">目标对象</param>
 public static void CopyTo(clsvViewMasterEN objvViewMasterENS, clsvViewMasterEN objvViewMasterENT)
{
try
{
objvViewMasterENT.ViewMasterId = objvViewMasterENS.ViewMasterId; //界面母版Id
objvViewMasterENT.ViewMasterName = objvViewMasterENS.ViewMasterName; //界面母版名
objvViewMasterENT.ViewMasterPath = objvViewMasterENS.ViewMasterPath; //界面母版路径
objvViewMasterENT.ApplicationTypeId = objvViewMasterENS.ApplicationTypeId; //应用程序类型ID
objvViewMasterENT.ApplicationTypeName = objvViewMasterENS.ApplicationTypeName; //应用程序类型名称
objvViewMasterENT.ApplicationTypeSimName = objvViewMasterENS.ApplicationTypeSimName; //应用程序类型简称
objvViewMasterENT.PrjId = objvViewMasterENS.PrjId; //工程Id
objvViewMasterENT.UpdDate = objvViewMasterENS.UpdDate; //修改日期
objvViewMasterENT.UpdUser = objvViewMasterENS.UpdUser; //修改者
objvViewMasterENT.Memo = objvViewMasterENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvViewMasterEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvViewMasterEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvViewMasterEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvViewMasterEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvViewMasterEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvViewMasterEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvViewMasterWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvViewMasterWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvViewMasterEN._CurrTabName, strPrjId);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewMasterEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvViewMasterWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvViewMasterWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvViewMasterEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvViewMasterEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convViewMaster.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvViewMasterEN._CurrTabName, strPrjId);
List<clsvViewMasterEN> arrvViewMasterObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvViewMasterObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewMasterEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvViewMasterEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvViewMasterWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvViewMasterWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvViewMasterEN._CurrTabName, strPrjId);
List<clsvViewMasterEN> arrvViewMasterObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvViewMasterObjLstCache = CacheHelper.Get<List<clsvViewMasterEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvViewMasterObjLstCache = CacheHelper.Get<List<clsvViewMasterEN>>(strKey);
}
return arrvViewMasterObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvViewMasterEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convViewMaster.ViewMasterId, Type.GetType("System.String"));
objDT.Columns.Add(convViewMaster.ViewMasterName, Type.GetType("System.String"));
objDT.Columns.Add(convViewMaster.ViewMasterPath, Type.GetType("System.String"));
objDT.Columns.Add(convViewMaster.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewMaster.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewMaster.ApplicationTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convViewMaster.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convViewMaster.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convViewMaster.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convViewMaster.Memo, Type.GetType("System.String"));
foreach (clsvViewMasterEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convViewMaster.ViewMasterId] = objInFor[convViewMaster.ViewMasterId];
objDR[convViewMaster.ViewMasterName] = objInFor[convViewMaster.ViewMasterName];
objDR[convViewMaster.ViewMasterPath] = objInFor[convViewMaster.ViewMasterPath];
objDR[convViewMaster.ApplicationTypeId] = objInFor[convViewMaster.ApplicationTypeId];
objDR[convViewMaster.ApplicationTypeName] = objInFor[convViewMaster.ApplicationTypeName];
objDR[convViewMaster.ApplicationTypeSimName] = objInFor[convViewMaster.ApplicationTypeSimName];
objDR[convViewMaster.PrjId] = objInFor[convViewMaster.PrjId];
objDR[convViewMaster.UpdDate] = objInFor[convViewMaster.UpdDate];
objDR[convViewMaster.UpdUser] = objInFor[convViewMaster.UpdUser];
objDR[convViewMaster.Memo] = objInFor[convViewMaster.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}