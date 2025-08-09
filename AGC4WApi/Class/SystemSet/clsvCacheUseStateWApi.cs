
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCacheUseStateWApi
 表名:vCacheUseState(00050567)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:09
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsvCacheUseStateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetmId(this clsvCacheUseStateEN objvCacheUseStateEN, long lngmId, string strComparisonOp="")
	{
objvCacheUseStateEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.mId) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.mId, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.mId] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetUserId(this clsvCacheUseStateEN objvCacheUseStateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convCacheUseState.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convCacheUseState.UserId);
objvCacheUseStateEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.UserId) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.UserId, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.UserId] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheModeId">缓存方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetCacheModeId(this clsvCacheUseStateEN objvCacheUseStateEN, string strCacheModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheModeId, 2, convCacheUseState.CacheModeId);
clsCheckSql.CheckFieldForeignKey(strCacheModeId, 2, convCacheUseState.CacheModeId);
objvCacheUseStateEN.CacheModeId = strCacheModeId; //缓存方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.CacheModeId) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.CacheModeId, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.CacheModeId] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheModeName">缓存方式名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetCacheModeName(this clsvCacheUseStateEN objvCacheUseStateEN, string strCacheModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheModeName, 50, convCacheUseState.CacheModeName);
objvCacheUseStateEN.CacheModeName = strCacheModeName; //缓存方式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.CacheModeName) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.CacheModeName, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.CacheModeName] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheModeENName">缓存方式英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetCacheModeENName(this clsvCacheUseStateEN objvCacheUseStateEN, string strCacheModeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheModeENName, 50, convCacheUseState.CacheModeENName);
objvCacheUseStateEN.CacheModeENName = strCacheModeENName; //缓存方式英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.CacheModeENName) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.CacheModeENName, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.CacheModeENName] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheKey">缓存关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetCacheKey(this clsvCacheUseStateEN objvCacheUseStateEN, string strCacheKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheKey, 50, convCacheUseState.CacheKey);
objvCacheUseStateEN.CacheKey = strCacheKey; //缓存关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.CacheKey) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.CacheKey, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.CacheKey] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "intCacheSize">缓存大小</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetCacheSize(this clsvCacheUseStateEN objvCacheUseStateEN, int intCacheSize, string strComparisonOp="")
	{
objvCacheUseStateEN.CacheSize = intCacheSize; //缓存大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.CacheSize) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.CacheSize, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.CacheSize] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseDate">使用日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetUseDate(this clsvCacheUseStateEN objvCacheUseStateEN, string strUseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUseDate, 20, convCacheUseState.UseDate);
objvCacheUseStateEN.UseDate = strUseDate; //使用日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.UseDate) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.UseDate, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.UseDate] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetMemo(this clsvCacheUseStateEN objvCacheUseStateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCacheUseState.Memo);
objvCacheUseStateEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.Memo) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.Memo, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.Memo] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCacheUseStateEN objvCacheUseStateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.mId) == true)
{
string strComparisonOpmId = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCacheUseState.mId, objvCacheUseStateCond.mId, strComparisonOpmId);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.UserId) == true)
{
string strComparisonOpUserId = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.UserId, objvCacheUseStateCond.UserId, strComparisonOpUserId);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.CacheModeId) == true)
{
string strComparisonOpCacheModeId = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.CacheModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.CacheModeId, objvCacheUseStateCond.CacheModeId, strComparisonOpCacheModeId);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.CacheModeName) == true)
{
string strComparisonOpCacheModeName = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.CacheModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.CacheModeName, objvCacheUseStateCond.CacheModeName, strComparisonOpCacheModeName);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.CacheModeENName) == true)
{
string strComparisonOpCacheModeENName = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.CacheModeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.CacheModeENName, objvCacheUseStateCond.CacheModeENName, strComparisonOpCacheModeENName);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.CacheKey) == true)
{
string strComparisonOpCacheKey = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.CacheKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.CacheKey, objvCacheUseStateCond.CacheKey, strComparisonOpCacheKey);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.CacheSize) == true)
{
string strComparisonOpCacheSize = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.CacheSize];
strWhereCond += string.Format(" And {0} {2} {1}", convCacheUseState.CacheSize, objvCacheUseStateCond.CacheSize, strComparisonOpCacheSize);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.UseDate) == true)
{
string strComparisonOpUseDate = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.UseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.UseDate, objvCacheUseStateCond.UseDate, strComparisonOpUseDate);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.Memo) == true)
{
string strComparisonOpMemo = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.Memo, objvCacheUseStateCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCacheUseState(vCacheUseState)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCacheUseStateWApi
{
private static readonly string mstrApiControllerName = "vCacheUseStateApi";

 public clsvCacheUseStateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCacheUseStateEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvCacheUseStateEN objvCacheUseStateEN;
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
objvCacheUseStateEN = JsonConvert.DeserializeObject<clsvCacheUseStateEN>(strJson);
return objvCacheUseStateEN;
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
public static clsvCacheUseStateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCacheUseStateEN objvCacheUseStateEN;
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
objvCacheUseStateEN = JsonConvert.DeserializeObject<clsvCacheUseStateEN>(strJson);
return objvCacheUseStateEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCacheUseStateEN GetObjBymIdCache(long lngmId,string strUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, strUserId);
List<clsvCacheUseStateEN> arrvCacheUseStateObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsvCacheUseStateEN> arrvCacheUseStateObjLst_Sel =
from objvCacheUseStateEN in arrvCacheUseStateObjLstCache
where objvCacheUseStateEN.mId == lngmId 
select objvCacheUseStateEN;
if (arrvCacheUseStateObjLst_Sel.Count() == 0)
{
   clsvCacheUseStateEN obj = clsvCacheUseStateWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCacheUseStateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCacheUseStateEN> GetObjLst(string strWhereCond)
{
 List<clsvCacheUseStateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCacheUseStateEN>>(strJson);
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
public static List<clsvCacheUseStateEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvCacheUseStateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCacheUseStateEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvCacheUseStateEN> GetObjLstByMIdLstCache(List<long> arrMId, string strUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, strUserId);
List<clsvCacheUseStateEN> arrvCacheUseStateObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsvCacheUseStateEN> arrvCacheUseStateObjLst_Sel =
from objvCacheUseStateEN in arrvCacheUseStateObjLstCache
where arrMId.Contains(objvCacheUseStateEN.mId)
select objvCacheUseStateEN;
return arrvCacheUseStateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCacheUseStateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCacheUseStateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCacheUseStateEN>>(strJson);
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
public static List<clsvCacheUseStateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCacheUseStateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCacheUseStateEN>>(strJson);
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
public static List<clsvCacheUseStateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCacheUseStateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCacheUseStateEN>>(strJson);
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
public static List<clsvCacheUseStateEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCacheUseStateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCacheUseStateEN>>(strJson);
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
 /// <param name = "objvCacheUseStateENS">源对象</param>
 /// <param name = "objvCacheUseStateENT">目标对象</param>
 public static void CopyTo(clsvCacheUseStateEN objvCacheUseStateENS, clsvCacheUseStateEN objvCacheUseStateENT)
{
try
{
objvCacheUseStateENT.mId = objvCacheUseStateENS.mId; //mId
objvCacheUseStateENT.UserId = objvCacheUseStateENS.UserId; //用户Id
objvCacheUseStateENT.CacheModeId = objvCacheUseStateENS.CacheModeId; //缓存方式Id
objvCacheUseStateENT.CacheModeName = objvCacheUseStateENS.CacheModeName; //缓存方式名
objvCacheUseStateENT.CacheModeENName = objvCacheUseStateENS.CacheModeENName; //缓存方式英文名
objvCacheUseStateENT.CacheKey = objvCacheUseStateENS.CacheKey; //缓存关键字
objvCacheUseStateENT.CacheSize = objvCacheUseStateENS.CacheSize; //缓存大小
objvCacheUseStateENT.UseDate = objvCacheUseStateENS.UseDate; //使用日期
objvCacheUseStateENT.Memo = objvCacheUseStateENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvCacheUseStateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCacheUseStateEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCacheUseStateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCacheUseStateEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCacheUseStateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCacheUseStateEN._AttributeName)
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
public static void ReFreshThisCache(string strUserId)
{


if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空！(In clsvCacheUseStateWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, strUserId);
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
public static List<clsvCacheUseStateEN> GetObjLstCache(string strUserId)
{


if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空！(In clsvCacheUseStateWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvCacheUseStateEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvCacheUseStateEN._WhereFormat, strUserId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convCacheUseState.UserId, strUserId);
}
var strKey = string.Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, strUserId);
List<clsvCacheUseStateEN> arrvCacheUseStateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvCacheUseStateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCacheUseStateEN> GetObjLstCacheFromObjLst(string strUserId,List<clsvCacheUseStateEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空！(In clsvCacheUseStateWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, strUserId);
List<clsvCacheUseStateEN> arrvCacheUseStateObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvCacheUseStateObjLstCache = CacheHelper.Get<List<clsvCacheUseStateEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.UserId == strUserId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvCacheUseStateObjLstCache = CacheHelper.Get<List<clsvCacheUseStateEN>>(strKey);
}
return arrvCacheUseStateObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCacheUseStateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCacheUseState.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCacheUseState.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convCacheUseState.CacheModeId, Type.GetType("System.String"));
objDT.Columns.Add(convCacheUseState.CacheModeName, Type.GetType("System.String"));
objDT.Columns.Add(convCacheUseState.CacheModeENName, Type.GetType("System.String"));
objDT.Columns.Add(convCacheUseState.CacheKey, Type.GetType("System.String"));
objDT.Columns.Add(convCacheUseState.CacheSize, Type.GetType("System.Int32"));
objDT.Columns.Add(convCacheUseState.UseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCacheUseState.Memo, Type.GetType("System.String"));
foreach (clsvCacheUseStateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCacheUseState.mId] = objInFor[convCacheUseState.mId];
objDR[convCacheUseState.UserId] = objInFor[convCacheUseState.UserId];
objDR[convCacheUseState.CacheModeId] = objInFor[convCacheUseState.CacheModeId];
objDR[convCacheUseState.CacheModeName] = objInFor[convCacheUseState.CacheModeName];
objDR[convCacheUseState.CacheModeENName] = objInFor[convCacheUseState.CacheModeENName];
objDR[convCacheUseState.CacheKey] = objInFor[convCacheUseState.CacheKey];
objDR[convCacheUseState.CacheSize] = objInFor[convCacheUseState.CacheSize];
objDR[convCacheUseState.UseDate] = objInFor[convCacheUseState.UseDate];
objDR[convCacheUseState.Memo] = objInFor[convCacheUseState.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}