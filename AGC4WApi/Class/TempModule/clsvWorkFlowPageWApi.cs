
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWorkFlowPageWApi
 表名:vWorkFlowPage(00050489)
 生成代码版本:2020.05.28.1
 生成日期:2020/05/28 17:52:36
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:临时模块
 模块英文名:TempModule
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
using AGC.Const;

namespace AGC4WApi
{
public static class clsvWorkFlowPageWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWorkFlowPageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWorkFlowPageEN SetmId(this clsvWorkFlowPageEN objvWorkFlowPageEN, long lngmId, string strComparisonOp="")
	{
objvWorkFlowPageEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWorkFlowPageEN.dicFldComparisonOp.ContainsKey(clsvWorkFlowPageEN.con_mId) == false)
{
objvWorkFlowPageEN.dicFldComparisonOp.Add(clsvWorkFlowPageEN.con_mId, strComparisonOp);
}
else
{
objvWorkFlowPageEN.dicFldComparisonOp[clsvWorkFlowPageEN.con_mId] = strComparisonOp;
}
}
return objvWorkFlowPageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWorkFlowPageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWorkFlowPageEN SetPostId(this clsvWorkFlowPageEN objvWorkFlowPageEN, string strPostId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPostId, 4, clsvWorkFlowPageEN.con_PostId);
clsCheckSql.CheckFieldForeignKey(strPostId, 4, clsvWorkFlowPageEN.con_PostId);
objvWorkFlowPageEN.PostId = strPostId; //岗位编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWorkFlowPageEN.dicFldComparisonOp.ContainsKey(clsvWorkFlowPageEN.con_PostId) == false)
{
objvWorkFlowPageEN.dicFldComparisonOp.Add(clsvWorkFlowPageEN.con_PostId, strComparisonOp);
}
else
{
objvWorkFlowPageEN.dicFldComparisonOp[clsvWorkFlowPageEN.con_PostId] = strComparisonOp;
}
}
return objvWorkFlowPageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWorkFlowPageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWorkFlowPageEN SetPostName(this clsvWorkFlowPageEN objvWorkFlowPageEN, string strPostName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPostName, clsvWorkFlowPageEN.con_PostName);
clsCheckSql.CheckFieldLen(strPostName, 50, clsvWorkFlowPageEN.con_PostName);
objvWorkFlowPageEN.PostName = strPostName; //岗位名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWorkFlowPageEN.dicFldComparisonOp.ContainsKey(clsvWorkFlowPageEN.con_PostName) == false)
{
objvWorkFlowPageEN.dicFldComparisonOp.Add(clsvWorkFlowPageEN.con_PostName, strComparisonOp);
}
else
{
objvWorkFlowPageEN.dicFldComparisonOp[clsvWorkFlowPageEN.con_PostName] = strComparisonOp;
}
}
return objvWorkFlowPageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWorkFlowPageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWorkFlowPageEN SetWorkStepPicPageName(this clsvWorkFlowPageEN objvWorkFlowPageEN, string strWorkStepPicPageName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkStepPicPageName, clsvWorkFlowPageEN.con_WorkStepPicPageName);
clsCheckSql.CheckFieldLen(strWorkStepPicPageName, 100, clsvWorkFlowPageEN.con_WorkStepPicPageName);
objvWorkFlowPageEN.WorkStepPicPageName = strWorkStepPicPageName; //图片页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWorkFlowPageEN.dicFldComparisonOp.ContainsKey(clsvWorkFlowPageEN.con_WorkStepPicPageName) == false)
{
objvWorkFlowPageEN.dicFldComparisonOp.Add(clsvWorkFlowPageEN.con_WorkStepPicPageName, strComparisonOp);
}
else
{
objvWorkFlowPageEN.dicFldComparisonOp[clsvWorkFlowPageEN.con_WorkStepPicPageName] = strComparisonOp;
}
}
return objvWorkFlowPageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWorkFlowPageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWorkFlowPageEN SetMemo(this clsvWorkFlowPageEN objvWorkFlowPageEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, clsvWorkFlowPageEN.con_Memo);
objvWorkFlowPageEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWorkFlowPageEN.dicFldComparisonOp.ContainsKey(clsvWorkFlowPageEN.con_Memo) == false)
{
objvWorkFlowPageEN.dicFldComparisonOp.Add(clsvWorkFlowPageEN.con_Memo, strComparisonOp);
}
else
{
objvWorkFlowPageEN.dicFldComparisonOp[clsvWorkFlowPageEN.con_Memo] = strComparisonOp;
}
}
return objvWorkFlowPageEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvWorkFlowPageEN objvWorkFlowPage_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvWorkFlowPage_Cond.IsUpdated(clsvWorkFlowPageEN.con_mId) == true)
{
string strComparisonOp_mId = objvWorkFlowPage_Cond.dicFldComparisonOp[clsvWorkFlowPageEN.con_mId];
strWhereCond += string.Format(" And {0} {2} {1}", clsvWorkFlowPageEN.con_mId, objvWorkFlowPage_Cond.mId, strComparisonOp_mId);
}
if (objvWorkFlowPage_Cond.IsUpdated(clsvWorkFlowPageEN.con_PostId) == true)
{
string strComparisonOp_PostId = objvWorkFlowPage_Cond.dicFldComparisonOp[clsvWorkFlowPageEN.con_PostId];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsvWorkFlowPageEN.con_PostId, objvWorkFlowPage_Cond.PostId, strComparisonOp_PostId);
}
if (objvWorkFlowPage_Cond.IsUpdated(clsvWorkFlowPageEN.con_PostName) == true)
{
string strComparisonOp_PostName = objvWorkFlowPage_Cond.dicFldComparisonOp[clsvWorkFlowPageEN.con_PostName];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsvWorkFlowPageEN.con_PostName, objvWorkFlowPage_Cond.PostName, strComparisonOp_PostName);
}
if (objvWorkFlowPage_Cond.IsUpdated(clsvWorkFlowPageEN.con_WorkStepPicPageName) == true)
{
string strComparisonOp_WorkStepPicPageName = objvWorkFlowPage_Cond.dicFldComparisonOp[clsvWorkFlowPageEN.con_WorkStepPicPageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsvWorkFlowPageEN.con_WorkStepPicPageName, objvWorkFlowPage_Cond.WorkStepPicPageName, strComparisonOp_WorkStepPicPageName);
}
if (objvWorkFlowPage_Cond.IsUpdated(clsvWorkFlowPageEN.con_Memo) == true)
{
string strComparisonOp_Memo = objvWorkFlowPage_Cond.dicFldComparisonOp[clsvWorkFlowPageEN.con_Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsvWorkFlowPageEN.con_Memo, objvWorkFlowPage_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工作流图片名称(vWorkFlowPage)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvWorkFlowPageWApi
{
private static readonly string mstrApiControllerName = "vWorkFlowPageApi";

 public clsvWorkFlowPageWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWorkFlowPageEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvWorkFlowPageEN objvWorkFlowPageEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvWorkFlowPageEN = JsonConvert.DeserializeObject<clsvWorkFlowPageEN>((string)jobjReturn["ReturnObj"]);
return objvWorkFlowPageEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static clsvWorkFlowPageEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvWorkFlowPageEN objvWorkFlowPageEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvWorkFlowPageEN = JsonConvert.DeserializeObject<clsvWorkFlowPageEN>((string)jobjReturn["ReturnObj"]);
return objvWorkFlowPageEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static clsvWorkFlowPageEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvWorkFlowPageEN objvWorkFlowPageEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvWorkFlowPageEN = JsonConvert.DeserializeObject<clsvWorkFlowPageEN>((string)jobjReturn["ReturnObj"]);
return objvWorkFlowPageEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static clsvWorkFlowPageEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvWorkFlowPageEN._CurrTabName_S);
List<clsvWorkFlowPageEN> arrvWorkFlowPageObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvWorkFlowPageEN> arrvWorkFlowPageObjLst_Sel =
from objvWorkFlowPageEN in arrvWorkFlowPageObjLst_Cache
where objvWorkFlowPageEN.mId == lngmId
select objvWorkFlowPageEN;
if (arrvWorkFlowPageObjLst_Sel.Count() == 0)
{
   clsvWorkFlowPageEN obj = clsvWorkFlowPageWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvWorkFlowPageObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWorkFlowPageEN> GetObjLst(string strWhereCond)
{
 List<clsvWorkFlowPageEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvWorkFlowPageEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsvWorkFlowPageEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvWorkFlowPageEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvWorkFlowPageEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static IEnumerable<clsvWorkFlowPageEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvWorkFlowPageEN._CurrTabName_S);
List<clsvWorkFlowPageEN> arrvWorkFlowPageObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvWorkFlowPageEN> arrvWorkFlowPageObjLst_Sel =
from objvWorkFlowPageEN in arrvWorkFlowPageObjLst_Cache
where arrMId.Contains(objvWorkFlowPageEN.mId)
select objvWorkFlowPageEN;
return arrvWorkFlowPageObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWorkFlowPageEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvWorkFlowPageEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvWorkFlowPageEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsvWorkFlowPageEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvWorkFlowPageEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvWorkFlowPageEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsvWorkFlowPageEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvWorkFlowPageEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvWorkFlowPageEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsvWorkFlowPageEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvWorkFlowPageEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvWorkFlowPageEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsvWorkFlowPageEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvWorkFlowPageEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvWorkFlowPageEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "objvWorkFlowPageENS">源对象</param>
 /// <param name = "objvWorkFlowPageENT">目标对象</param>
 public static void CopyTo(clsvWorkFlowPageEN objvWorkFlowPageENS, clsvWorkFlowPageEN objvWorkFlowPageENT)
{
try
{
objvWorkFlowPageENT.mId = objvWorkFlowPageENS.mId; //mId
objvWorkFlowPageENT.PostId = objvWorkFlowPageENS.PostId; //岗位编号
objvWorkFlowPageENT.PostName = objvWorkFlowPageENS.PostName; //岗位名称
objvWorkFlowPageENT.WorkStepPicPageName = objvWorkFlowPageENS.WorkStepPicPageName; //图片页面名称
objvWorkFlowPageENT.Memo = objvWorkFlowPageENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvWorkFlowPageEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvWorkFlowPageEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvWorkFlowPageEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvWorkFlowPageEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvWorkFlowPageEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvWorkFlowPageEN.AttributeName)
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvWorkFlowPageObjLst_Cache == null)
//{
//arrvWorkFlowPageObjLst_Cache = await clsvWorkFlowPageWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvWorkFlowPageEN._CurrTabName_S);
CacheHelper.Remove(strKey);
strMsg = string.Format("刷新缓存成功！({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3)); 
clsSysParaEN.objLog.WriteDebugLog(strMsg);
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
public static List<clsvWorkFlowPageEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvWorkFlowPageEN._CurrTabName_S);
List<clsvWorkFlowPageEN> arrvWorkFlowPageObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvWorkFlowPageObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvWorkFlowPageEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convWorkFlowPage.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convWorkFlowPage.PostId, Type.GetType("System.String"));
objDT.Columns.Add(convWorkFlowPage.PostName, Type.GetType("System.String"));
objDT.Columns.Add(convWorkFlowPage.WorkStepPicPageName, Type.GetType("System.String"));
objDT.Columns.Add(convWorkFlowPage.Memo, Type.GetType("System.String"));
foreach (clsvWorkFlowPageEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convWorkFlowPage.mId] = objInFor[convWorkFlowPage.mId];
objDR[convWorkFlowPage.PostId] = objInFor[convWorkFlowPage.PostId];
objDR[convWorkFlowPage.PostName] = objInFor[convWorkFlowPage.PostName];
objDR[convWorkFlowPage.WorkStepPicPageName] = objInFor[convWorkFlowPage.WorkStepPicPageName];
objDR[convWorkFlowPage.Memo] = objInFor[convWorkFlowPage.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}