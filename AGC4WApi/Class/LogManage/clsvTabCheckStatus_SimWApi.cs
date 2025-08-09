
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabCheckStatus_SimWApi
 表名:vTabCheckStatus_Sim(00050599)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:55
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
public static class  clsvTabCheckStatus_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckStatus_SimEN SetmId(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN, long lngmId, string strComparisonOp="")
	{
objvTabCheckStatus_SimEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckStatus_SimEN.dicFldComparisonOp.ContainsKey(convTabCheckStatus_Sim.mId) == false)
{
objvTabCheckStatus_SimEN.dicFldComparisonOp.Add(convTabCheckStatus_Sim.mId, strComparisonOp);
}
else
{
objvTabCheckStatus_SimEN.dicFldComparisonOp[convTabCheckStatus_Sim.mId] = strComparisonOp;
}
}
return objvTabCheckStatus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckStatus_SimEN SetPrjId(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convTabCheckStatus_Sim.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convTabCheckStatus_Sim.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTabCheckStatus_Sim.PrjId);
objvTabCheckStatus_SimEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckStatus_SimEN.dicFldComparisonOp.ContainsKey(convTabCheckStatus_Sim.PrjId) == false)
{
objvTabCheckStatus_SimEN.dicFldComparisonOp.Add(convTabCheckStatus_Sim.PrjId, strComparisonOp);
}
else
{
objvTabCheckStatus_SimEN.dicFldComparisonOp[convTabCheckStatus_Sim.PrjId] = strComparisonOp;
}
}
return objvTabCheckStatus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckStatus_SimEN SetTabId(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convTabCheckStatus_Sim.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convTabCheckStatus_Sim.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convTabCheckStatus_Sim.TabId);
objvTabCheckStatus_SimEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckStatus_SimEN.dicFldComparisonOp.ContainsKey(convTabCheckStatus_Sim.TabId) == false)
{
objvTabCheckStatus_SimEN.dicFldComparisonOp.Add(convTabCheckStatus_Sim.TabId, strComparisonOp);
}
else
{
objvTabCheckStatus_SimEN.dicFldComparisonOp[convTabCheckStatus_Sim.TabId] = strComparisonOp;
}
}
return objvTabCheckStatus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intErrorLevelId">错误等级Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckStatus_SimEN SetErrorLevelId(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN, int intErrorLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intErrorLevelId, convTabCheckStatus_Sim.ErrorLevelId);
objvTabCheckStatus_SimEN.ErrorLevelId = intErrorLevelId; //错误等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckStatus_SimEN.dicFldComparisonOp.ContainsKey(convTabCheckStatus_Sim.ErrorLevelId) == false)
{
objvTabCheckStatus_SimEN.dicFldComparisonOp.Add(convTabCheckStatus_Sim.ErrorLevelId, strComparisonOp);
}
else
{
objvTabCheckStatus_SimEN.dicFldComparisonOp[convTabCheckStatus_Sim.ErrorLevelId] = strComparisonOp;
}
}
return objvTabCheckStatus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrorMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckStatus_SimEN SetErrorMsg(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN, string strErrorMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrorMsg, 5000, convTabCheckStatus_Sim.ErrorMsg);
objvTabCheckStatus_SimEN.ErrorMsg = strErrorMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckStatus_SimEN.dicFldComparisonOp.ContainsKey(convTabCheckStatus_Sim.ErrorMsg) == false)
{
objvTabCheckStatus_SimEN.dicFldComparisonOp.Add(convTabCheckStatus_Sim.ErrorMsg, strComparisonOp);
}
else
{
objvTabCheckStatus_SimEN.dicFldComparisonOp[convTabCheckStatus_Sim.ErrorMsg] = strComparisonOp;
}
}
return objvTabCheckStatus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseId">项目数据库Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckStatus_SimEN SetPrjDataBaseId(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, convTabCheckStatus_Sim.PrjDataBaseId);
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, convTabCheckStatus_Sim.PrjDataBaseId);
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, convTabCheckStatus_Sim.PrjDataBaseId);
objvTabCheckStatus_SimEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckStatus_SimEN.dicFldComparisonOp.ContainsKey(convTabCheckStatus_Sim.PrjDataBaseId) == false)
{
objvTabCheckStatus_SimEN.dicFldComparisonOp.Add(convTabCheckStatus_Sim.PrjDataBaseId, strComparisonOp);
}
else
{
objvTabCheckStatus_SimEN.dicFldComparisonOp[convTabCheckStatus_Sim.PrjDataBaseId] = strComparisonOp;
}
}
return objvTabCheckStatus_SimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTabCheckStatus_SimCond.IsUpdated(convTabCheckStatus_Sim.mId) == true)
{
string strComparisonOpmId = objvTabCheckStatus_SimCond.dicFldComparisonOp[convTabCheckStatus_Sim.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convTabCheckStatus_Sim.mId, objvTabCheckStatus_SimCond.mId, strComparisonOpmId);
}
if (objvTabCheckStatus_SimCond.IsUpdated(convTabCheckStatus_Sim.PrjId) == true)
{
string strComparisonOpPrjId = objvTabCheckStatus_SimCond.dicFldComparisonOp[convTabCheckStatus_Sim.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckStatus_Sim.PrjId, objvTabCheckStatus_SimCond.PrjId, strComparisonOpPrjId);
}
if (objvTabCheckStatus_SimCond.IsUpdated(convTabCheckStatus_Sim.TabId) == true)
{
string strComparisonOpTabId = objvTabCheckStatus_SimCond.dicFldComparisonOp[convTabCheckStatus_Sim.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckStatus_Sim.TabId, objvTabCheckStatus_SimCond.TabId, strComparisonOpTabId);
}
if (objvTabCheckStatus_SimCond.IsUpdated(convTabCheckStatus_Sim.ErrorLevelId) == true)
{
string strComparisonOpErrorLevelId = objvTabCheckStatus_SimCond.dicFldComparisonOp[convTabCheckStatus_Sim.ErrorLevelId];
strWhereCond += string.Format(" And {0} {2} {1}", convTabCheckStatus_Sim.ErrorLevelId, objvTabCheckStatus_SimCond.ErrorLevelId, strComparisonOpErrorLevelId);
}
if (objvTabCheckStatus_SimCond.IsUpdated(convTabCheckStatus_Sim.ErrorMsg) == true)
{
string strComparisonOpErrorMsg = objvTabCheckStatus_SimCond.dicFldComparisonOp[convTabCheckStatus_Sim.ErrorMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckStatus_Sim.ErrorMsg, objvTabCheckStatus_SimCond.ErrorMsg, strComparisonOpErrorMsg);
}
if (objvTabCheckStatus_SimCond.IsUpdated(convTabCheckStatus_Sim.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objvTabCheckStatus_SimCond.dicFldComparisonOp[convTabCheckStatus_Sim.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckStatus_Sim.PrjDataBaseId, objvTabCheckStatus_SimCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v表检查状态_Sim(vTabCheckStatus_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTabCheckStatus_SimWApi
{
private static readonly string mstrApiControllerName = "vTabCheckStatus_SimApi";

 public clsvTabCheckStatus_SimWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabCheckStatus_SimEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN;
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
objvTabCheckStatus_SimEN = JsonConvert.DeserializeObject<clsvTabCheckStatus_SimEN>(strJson);
return objvTabCheckStatus_SimEN;
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
public static clsvTabCheckStatus_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN;
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
objvTabCheckStatus_SimEN = JsonConvert.DeserializeObject<clsvTabCheckStatus_SimEN>(strJson);
return objvTabCheckStatus_SimEN;
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
public static clsvTabCheckStatus_SimEN GetObjBymIdCache(long lngmId,string strPrjId,string strPrjDataBaseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvTabCheckStatus_SimEN._CurrTabName, strPrjId);
List<clsvTabCheckStatus_SimEN> arrvTabCheckStatus_SimObjLstCache = GetObjLstCache(strPrjId,strPrjDataBaseId);
IEnumerable <clsvTabCheckStatus_SimEN> arrvTabCheckStatus_SimObjLst_Sel =
from objvTabCheckStatus_SimEN in arrvTabCheckStatus_SimObjLstCache
where objvTabCheckStatus_SimEN.mId == lngmId 
select objvTabCheckStatus_SimEN;
if (arrvTabCheckStatus_SimObjLst_Sel.Count() == 0)
{
   clsvTabCheckStatus_SimEN obj = clsvTabCheckStatus_SimWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTabCheckStatus_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvTabCheckStatus_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabCheckStatus_SimEN>>(strJson);
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
public static List<clsvTabCheckStatus_SimEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvTabCheckStatus_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabCheckStatus_SimEN>>(strJson);
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
public static IEnumerable<clsvTabCheckStatus_SimEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId,string strPrjDataBaseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvTabCheckStatus_SimEN._CurrTabName, strPrjId);
List<clsvTabCheckStatus_SimEN> arrvTabCheckStatus_SimObjLstCache = GetObjLstCache(strPrjId,strPrjDataBaseId);
IEnumerable <clsvTabCheckStatus_SimEN> arrvTabCheckStatus_SimObjLst_Sel =
from objvTabCheckStatus_SimEN in arrvTabCheckStatus_SimObjLstCache
where arrMId.Contains(objvTabCheckStatus_SimEN.mId)
select objvTabCheckStatus_SimEN;
return arrvTabCheckStatus_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTabCheckStatus_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabCheckStatus_SimEN>>(strJson);
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
public static List<clsvTabCheckStatus_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTabCheckStatus_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabCheckStatus_SimEN>>(strJson);
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
public static List<clsvTabCheckStatus_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTabCheckStatus_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabCheckStatus_SimEN>>(strJson);
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
public static List<clsvTabCheckStatus_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvTabCheckStatus_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabCheckStatus_SimEN>>(strJson);
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
 /// <param name = "objvTabCheckStatus_SimENS">源对象</param>
 /// <param name = "objvTabCheckStatus_SimENT">目标对象</param>
 public static void CopyTo(clsvTabCheckStatus_SimEN objvTabCheckStatus_SimENS, clsvTabCheckStatus_SimEN objvTabCheckStatus_SimENT)
{
try
{
objvTabCheckStatus_SimENT.mId = objvTabCheckStatus_SimENS.mId; //mId
objvTabCheckStatus_SimENT.PrjId = objvTabCheckStatus_SimENS.PrjId; //工程Id
objvTabCheckStatus_SimENT.TabId = objvTabCheckStatus_SimENS.TabId; //表ID
objvTabCheckStatus_SimENT.ErrorLevelId = objvTabCheckStatus_SimENS.ErrorLevelId; //错误等级Id
objvTabCheckStatus_SimENT.ErrorMsg = objvTabCheckStatus_SimENS.ErrorMsg; //错误信息
objvTabCheckStatus_SimENT.PrjDataBaseId = objvTabCheckStatus_SimENS.PrjDataBaseId; //项目数据库Id
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
public static DataTable ToDataTable(List<clsvTabCheckStatus_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTabCheckStatus_SimEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTabCheckStatus_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTabCheckStatus_SimEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTabCheckStatus_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTabCheckStatus_SimEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId,string strPrjDataBaseId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvTabCheckStatus_SimWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvTabCheckStatus_SimWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}

if (string.IsNullOrEmpty(strPrjDataBaseId) == true)
{
  var strMsg = string.Format("参数:[strPrjDataBaseId]不能为空！(In clsvTabCheckStatus_SimWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjDataBaseId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjDataBaseId]的长度:[{0}]不正确！(clsvTabCheckStatus_SimWApi.ReFreshThisCache)", strPrjDataBaseId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvTabCheckStatus_SimEN._CurrTabName, strPrjId);
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
public static List<clsvTabCheckStatus_SimEN> GetObjLstCache(string strPrjId,string strPrjDataBaseId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvTabCheckStatus_SimWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvTabCheckStatus_SimWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}

if (string.IsNullOrEmpty(strPrjDataBaseId) == true)
{
  var strMsg = string.Format("参数:[strPrjDataBaseId]不能为空！(In clsvTabCheckStatus_SimWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjDataBaseId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjDataBaseId]的长度:[{0}]不正确！(clsvTabCheckStatus_SimWApi.GetObjLstCache)", strPrjDataBaseId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvTabCheckStatus_SimEN._WhereFormat) == false)
{
strWhereCond = string.Format(clsvTabCheckStatus_SimEN._WhereFormat, strPrjId, strPrjDataBaseId);
}
else
{
strWhereCond = string.Format("PrjId='{0}' and PrjDataBaseId='{1}'", strPrjId, strPrjDataBaseId);
}
var strKey = string.Format("{0}_{1}_{2}", clsvTabCheckStatus_SimEN._CurrTabName, strPrjId, strPrjDataBaseId);
List<clsvTabCheckStatus_SimEN> arrvTabCheckStatus_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvTabCheckStatus_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetObjLstCacheFromObjLst(string strPrjId,string strPrjDataBaseId,List<clsvTabCheckStatus_SimEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvTabCheckStatus_SimWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvTabCheckStatus_SimWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}

if (string.IsNullOrEmpty(strPrjDataBaseId) == true)
{
  var strMsg = string.Format("参数:[strPrjDataBaseId]不能为空！(In clsvTabCheckStatus_SimWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjDataBaseId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjDataBaseId]的长度:[{0}]不正确！(clsvTabCheckStatus_SimWApi.GetObjLstCacheFromObjLst)", strPrjDataBaseId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}_{2}", clsvTabCheckStatus_SimEN._CurrTabName, strPrjId, strPrjDataBaseId);
List<clsvTabCheckStatus_SimEN> arrvTabCheckStatus_SimObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvTabCheckStatus_SimObjLstCache = CacheHelper.Get<List<clsvTabCheckStatus_SimEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvTabCheckStatus_SimObjLstCache = CacheHelper.Get<List<clsvTabCheckStatus_SimEN>>(strKey);
}
return arrvTabCheckStatus_SimObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTabCheckStatus_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTabCheckStatus_Sim.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convTabCheckStatus_Sim.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckStatus_Sim.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckStatus_Sim.ErrorLevelId, Type.GetType("System.Int32"));
objDT.Columns.Add(convTabCheckStatus_Sim.ErrorMsg, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckStatus_Sim.PrjDataBaseId, Type.GetType("System.String"));
foreach (clsvTabCheckStatus_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTabCheckStatus_Sim.mId] = objInFor[convTabCheckStatus_Sim.mId];
objDR[convTabCheckStatus_Sim.PrjId] = objInFor[convTabCheckStatus_Sim.PrjId];
objDR[convTabCheckStatus_Sim.TabId] = objInFor[convTabCheckStatus_Sim.TabId];
objDR[convTabCheckStatus_Sim.ErrorLevelId] = objInFor[convTabCheckStatus_Sim.ErrorLevelId];
objDR[convTabCheckStatus_Sim.ErrorMsg] = objInFor[convTabCheckStatus_Sim.ErrorMsg];
objDR[convTabCheckStatus_Sim.PrjDataBaseId] = objInFor[convTabCheckStatus_Sim.PrjDataBaseId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}