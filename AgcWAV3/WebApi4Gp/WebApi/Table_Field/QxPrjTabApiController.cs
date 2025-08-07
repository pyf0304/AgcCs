
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:QxPrjTabApiController
 表名:QxPrjTab(00140096)
 * 版本:2023.05.10.1(服务器:WIN-SRV103-116)
 日期:2023/05/10 23:35:47
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:WebApi后台(变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:字段、表维护(Table_Field)
 框架-层名:WA_服务层(CS)(WA_Srv)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Text; 
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using com.taishsoft.json;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using com.taishsoft.common;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; using Comm.WebApi;

namespace GeneralPlatform.WebApi
{
 /// <summary>
 /// QxPrjTabController 的摘要说明
 /// (AutoGCLib.WA_Srv4CSharp:GeneCode)
 /// </summary>
[ApiController]
[Route("[controller]")]
[ApiExplorerSettings(IgnoreApi = true)]
public class QxPrjTabApiController : ControllerBase
{ 

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// 调用方法: GET /api/QxPrjTabApi/GetObjByTabId?TabId=value
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
[HttpGet("GetObjByTabId")]
public ActionResult GetObjByTabId(string strTabId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strTabId"] = strTabId,
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strTabId) == true)
 {
string strMsg = string.Format("根据关键字获取对象时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
clsQxPrjTabEN objQxPrjTabEN = clsQxPrjTabBL.GetObjByTabId(strTabId);
return Ok(new { errorId = 0, errorMsg = "", returnObj = objQxPrjTabEN });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// 调用方法: GET /api/QxPrjTabApi/GetObjByKey_Cache?TabId=value
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjByKeyId_Cache)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
[HttpGet("GetObjByTabId_Cache")]
public ActionResult GetObjByTabIdCache(string strTabId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strTabId"] = strTabId,
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strTabId) == true)
 {
string strMsg = string.Format("根据关键字获取对象时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
clsQxPrjTabEN objQxPrjTabEN = clsQxPrjTabBL.GetObjByTabIdCache(strTabId);
return Ok(new { errorId = 0, errorMsg = "", returnObj = objQxPrjTabEN });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 根据条件获取对象列表
 /// 调用方法: GET /api/QxPrjTabApi/GetObjLst?strWhereCond=v1&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[HttpGet("GetObjLst")]
public ActionResult GetObjLst(string strWhereCond)
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("根据条件获取对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
List<clsQxPrjTabEN> arrQxPrjTabObjLst = clsQxPrjTabBL.GetObjLst(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxPrjTabObjLst });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 根据条件获取对象列表
 /// 调用方法: GET /api/QxPrjTabApi/GetObjLst_Cache?
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst_Cache)
 /// </summary>
 /// <returns>返回对象列表</returns>
[HttpGet("GetObjLst_Cache")]
public ActionResult GetObjLstCache()
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
List<clsQxPrjTabEN> arrQxPrjTabObjLst = clsQxPrjTabBL.GetObjLstCache();
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxPrjTabObjLst });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// 调用方法: GET /api/QxPrjTabApi/GetSubObjLst_Cache?objTabName_Cond=v1&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetSubObjLst_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
 [HttpPost("GetSubObjLst_Cache")]
 public ActionResult GetSubObjLstCache([FromBody]clsQxPrjTabEN objQxPrjTab_Cond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strQxPrjTabJSONObj = clsJSON.GetJsonFromObj(objQxPrjTab_Cond);
dictParam.Add("strQxPrjTabJSONObj", strQxPrjTabJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 IEnumerable<clsQxPrjTabEN> arrQxPrjTabObjLst;
 try
 {
if (objQxPrjTab_Cond.sfFldComparisonOp == null)
{
objQxPrjTab_Cond.dicFldComparisonOp = null;
}
else
{
objQxPrjTab_Cond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxPrjTab_Cond.sfFldComparisonOp);
}
clsQxPrjTabBL.SetUpdFlag(objQxPrjTab_Cond);
 arrQxPrjTabObjLst = clsQxPrjTabBL.GetSubObjLstCache(objQxPrjTab_Cond);
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxPrjTabObjLst });
 }

 /// <summary>
 /// 根据关键字列表获取相关对象列表
 /// 调用方法: POST /api/QxPrjTabapi/GetObjLstByTabIdLst
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
[HttpPost("GetObjLstByTabIdLst")]
public ActionResult GetObjLstByTabIdLst([FromBody]string[] arrTabId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrTabId);
dictParam.Add("arrTabId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (arrTabId.Length == 0)
{
string strMsg = string.Format("根据关键字列表串获取对象列表时，给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstTabId = new(arrTabId);
 try
 {
List<clsQxPrjTabEN> arrQxPrjTabObjLst = clsQxPrjTabBL.GetObjLstByTabIdLst(lstTabId);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxPrjTabObjLst });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表
 /// 调用方法: POST /api/QxPrjTabapi/GetObjLstByTabIdLst
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
[HttpPost("GetObjLstByTabIdLst_Cache")]
public ActionResult GetObjLstByTabIdLstCache([FromBody]string[] arrTabId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrTabId);
dictParam.Add("arrTabId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (arrTabId.Length == 0)
{
string strMsg = string.Format("根据关键字列表串获取对象列表时，给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstTabId = new(arrTabId);
 try
 {
IEnumerable<clsQxPrjTabEN> arrQxPrjTabObjLst = clsQxPrjTabBL.GetObjLstByTabIdLstCache(lstTabId);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxPrjTabObjLst });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// 调用方法: GET /api/QxPrjTabApi/GetTopObjLst?intTopSize=v1&strOrderBy=v2&strWhereCond=v3&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
[HttpPost("GetTopObjLst")]
public ActionResult GetTopObjLst([FromBody]stuTopPara objTopPara)
{
objTopPara.whereCond = objTopPara.whereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(objTopPara.whereCond) == true)
 {
string strMsg = string.Format("根据条件获取顶部对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 if (objTopPara.topSize <= 0)
 {
string strMsg = string.Format("根据条件获取顶部对象列表，顶部记录数:[{0}]不能小于等于0!({1})", objTopPara.topSize, clsStackTrace.GetCurrClassFunction());
clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
 }
 try
 {
List<clsQxPrjTabEN> arrQxPrjTabObjLst = clsQxPrjTabBL.GetTopObjLst(objTopPara);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxPrjTabObjLst });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// 调用方法: GET /api/QxPrjTabApi/GetFirstID?strWhereCond=v1&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[HttpGet("GetFirstID")]
public ActionResult GetFirstID(string strWhereCond) 
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("根据条件获取第一条记录的关键字值时，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 string strTabId;
 try
 {
 strTabId = clsQxPrjTabBL.GetFirstID_S(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnStr = strTabId });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// 调用方法: GET /api/QxPrjTabApi/GetFirstObj?strWhereCond=v1&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
[HttpGet("GetFirstObj")]
public ActionResult GetFirstObj(string strWhereCond) 
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("根据条件获取第一条对象时，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
 clsQxPrjTabEN objQxPrjTabEN = clsQxPrjTabBL.GetFirstObj_S(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnObj = objQxPrjTabEN });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// 调用方法: GET /api/QxPrjTabApi/GetObjLstByPager?intPageIndex=v1&intPageSize=v2&strOrderBy=v3&strWhereCond=v4&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
 [HttpPost("GetObjLstByPager")]
 public ActionResult GetObjLstByPager([FromBody]stuPagerPara objPagerPara)
 {
objPagerPara.whereCond = objPagerPara.whereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(objPagerPara.whereCond) == true)
 {
string strMsg = string.Format("根据条件分页获取JSON对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 if (objPagerPara.pageSize <=0)
 {
string strMsg = string.Format("根据条件分页获取JSON对象列表，每页记录数:[{0}]不能小于等于0!({1})", objPagerPara.pageSize, clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 if (objPagerPara.pageIndex <=0)
 {
string strMsg = string.Format("根据条件分页获取JSON对象列表，页序号:[{0}]不能小于等于0!({1})", objPagerPara.pageIndex, clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 List<clsQxPrjTabEN> arrQxPrjTabObjLst;
 try
 {
 arrQxPrjTabObjLst = clsQxPrjTabBL.GetObjLstByPager(objPagerPara);
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxPrjTabObjLst });
 }

 /// <summary>
 /// 功能:获取某一条件的记录数
 /// 调用方法: GET /api/QxPrjTabApi/GetRecCountByCond?strWhereCond=v1&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>某一条件的记录数</returns>
[HttpGet("GetRecCountByCond")]
public ActionResult GetRecCountByCond(string strWhereCond)
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("获取某一条件的记录数，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intCount = clsQxPrjTabBL.GetRecCountByCond(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// 调用方法: GET /api/QxPrjTabApi/GetFldValue?strWhereCond=v1&strFldName=v2&strTabName=v3&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
[HttpGet("GetFldValue")]
public ActionResult GetFldValue(string strFldName, string strWhereCond)
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("获取某一条件的字段值，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
List<string> arrList = clsQxPrjTabBL.GetFldValue(strFldName, strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", arrList) });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// 调用方法: GET /api/QxPrjTabApi/funSetFldValue?strCondition=v1&strFldName=v2&strTabName=v3&varValue=v4&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
[HttpGet("SetFldValue")]
public ActionResult SetFldValue(string strFldName, string strValue, string strWhereCond)
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("获取某一条件的字段值，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
 try
 {
int intRecCount = clsQxPrjTabBL.SetFldValue(clsQxPrjTabEN._CurrTabName, strFldName, strValue, strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecCount });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// 调用方法: GET /api/QxPrjTabApi/IsExistRecord?strWhereCond=v1&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>包含结果的Jobject, 如果存在就返回TRUE,否则返回FALSE</returns>
[HttpGet("IsExistRecord")]
public ActionResult IsExistRecord(string strWhereCond)
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("判断是否存在某一条件的记录，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
bool bolIsExist = clsQxPrjTabBL.IsExistRecord(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnBool = bolIsExist });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// 调用方法: GET /api/QxPrjTabApi/IsExist?TabId=value
 /// (AutoGCLib.WA_Srv4CSharp:Gen_IsExist)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[HttpGet("IsExist")]
public ActionResult IsExist(string strTabId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strTabId"] = strTabId
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strTabId) == true)
 {
string strMsg = string.Format("判断表中是否存在给定关键字的记录时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
bool bolIsExist = clsQxPrjTabBL.IsExist(strTabId);
return Ok(new { errorId = 0, errorMsg = "", returnBool = bolIsExist });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// 调用方法: GET /api/QxPrjTabApi/GetMaxStrIdByPrefix?strPrefix=v1&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[HttpGet("GetMaxStrIdByPrefix")]
public ActionResult GetMaxStrIdByPrefix(string strPrefix)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
dictParam.Add("strPrefix", strPrefix);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
string strMaxstrTabId = clsQxPrjTabBL.GetMaxStrIdByPrefix_S(strPrefix);
return Ok(new { errorId = 0, errorMsg = "", returnStr =  strMaxstrTabId });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 通过JSON对象来添加记录对象
 /// 调用方法: POST /api/QxPrjTabApi/AddNewRecord
 /// 在Body区传输objQxPrjTabEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
 /// </summary>
 /// <param name = "objQxPrjTabEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("AddNewRecord")]
public ActionResult AddNewRecord([FromBody]clsQxPrjTabEN objQxPrjTabEN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strQxPrjTabJSONObj = clsJSON.GetJsonFromObj(objQxPrjTabEN);
dictParam.Add("strQxPrjTabJSONObj", strQxPrjTabJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 if (clsQxPrjTabBL.IsExist(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!({1})", objQxPrjTabEN.TabId, clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
clsQxPrjTabEN objQxPrjTab_Cond = new();
string strCondition = objQxPrjTab_Cond
.SetTabName(objQxPrjTabEN.TabName, "=")
.SetQxPrjId(objQxPrjTabEN.QxPrjId, "=")
.GetCombineCondition();
bool bolIsExist = clsQxPrjTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
string strMsg = string.Format("满足条件:{0}的记录表中已经存在，违反了唯一性.(from {1})", strCondition,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
    clsQxPrjTabBL.AccessFldValueNull(objQxPrjTabEN);
bool bolResult = objQxPrjTabEN.AddNewRecord();
return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 通过JSON对象来添加记录对象
 /// 调用方法: POST /api/QxPrjTabApi/AddNewRecordWithMaxId
 /// 在Body区传输objQxPrjTabEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objQxPrjTabEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("AddNewRecordWithMaxId")]
public ActionResult AddNewRecordWithMaxId([FromBody]clsQxPrjTabEN objQxPrjTabEN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strQxPrjTabJSONObj = clsJSON.GetJsonFromObj(objQxPrjTabEN);
dictParam.Add("strQxPrjTabJSONObj", strQxPrjTabJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
    clsQxPrjTabBL.AccessFldValueNull(objQxPrjTabEN);
string strTabId = objQxPrjTabEN.AddNewRecordWithMaxId();
return Ok(new { errorId = 0, errorMsg = "", returnStr =  strTabId });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// 调用方法: POST /api/QxPrjTabApi/AddNewRecordWithReturnKey
 /// 在Body区传输objQxPrjTabEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
[HttpPost("AddNewRecordWithReturnKey")]
public ActionResult AddNewRecordWithReturnKey(clsQxPrjTabEN objQxPrjTabEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WebApi.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
dictParam.Add("objQxPrjTabEN", JsonConvert.SerializeObject(objQxPrjTabEN));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
    clsQxPrjTabBL.AccessFldValueNull(objQxPrjTabEN);
string strKey = clsQxPrjTabBL.AddNewRecordBySql2WithReturnKey(objQxPrjTabEN);
return Ok(new { errorId = 0, errorMsg = "", returnStr =  strKey });
}
catch (Exception objException)
{
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
}

 /// <summary>
 /// 通过JSON对象来修改记录对象
 /// 调用方法: Post /api/QxPrjTabApi/UpdateRecord
 /// 在Body区传输objQxPrjTabEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateRecord)
 /// </summary>
 /// <param name = "strQxPrjTabJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[HttpPost("UpdateRecord")]
public ActionResult UpdateRecord([FromBody]clsQxPrjTabEN objQxPrjTabEN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strQxPrjTabJSONObj = clsJSON.GetJsonFromObj(objQxPrjTabEN);
dictParam.Add("strQxPrjTabJSONObj", strQxPrjTabJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("修改记录时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
    clsQxPrjTabBL.SetUpdFlag(objQxPrjTabEN);
    clsQxPrjTabBL.AccessFldValueNull(objQxPrjTabEN);
bool bolResult = objQxPrjTabEN.Update();
return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 根据条件来修改记录对象
 /// 调用方法: Post /api/QxPrjTabApi/UpdateWithCondition
 /// 在Body区传输objQxPrjTabEN的JSON对象和strWhereCond条件串
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateWithCondition)
 /// </summary>
 /// <param name = "strQxPrjTabJSONObj">JSON对象字符串</param>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>是否成功</returns>
[HttpPost("UpdateWithCondition")]
public ActionResult UpdateWithCondition(clsQxPrjTabEN objQxPrjTabEN, string strWhereCond)
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WebApi.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 }
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("根据条件修改记录时，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
try
{
    clsQxPrjTabBL.AccessFldValueNull(objQxPrjTabEN);
bool bolResult = objQxPrjTabEN.UpdateWithCondition(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
}
catch (Exception objException)
{
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// 调用方法: DELETE /api/QxPrjTabApi/DelRecord/Id
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecord)
 /// </summary>
 /// <param name = "Id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
[HttpDelete("DelRecord")]
public ActionResult DelRecord(string Id)
{
string strTabId = Id;
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["Id"] = strTabId
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strTabId) == true)
 {
string strMsg = string.Format("删除关键字所指定的记录，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intRecNum = clsQxPrjTabBL.DelRecord(strTabId);
return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// 调用方法: POST /api/QxPrjTabApi/DelQxPrjTabs
 /// 在Body区传输arrTabId(关键字值列表)的JSON串
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecord)
 /// </summary>
 /// <param name = "arrTabId">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
[HttpPost("DelQxPrjTabs")]
public ActionResult DelQxPrjTabs([FromBody]string[] arrTabId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrTabId);
dictParam.Add("arrTabId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
int intRecNum = clsQxPrjTabBL.DelQxPrjTabs(arrLst);
return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录, 通过JSON串
 /// 调用方法: POST /api/QxPrjTabApi/DelRecords
 /// 在Body区传输strKeyIdLst字符串列表的JSON串
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecords)
 /// </summary>
 /// <param name = "strKeyIdLst">给定的关键字值列表的JSON串</param>
 /// <returns>返回删除的记录数</returns>
[HttpPost("DelRecords")]
public ActionResult DelRecords([FromBody]string[] strKeyIdLst)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrKey = new(strKeyIdLst);
dictParam.Add("strKeyIdLst", clsArray.GetSqlInStrByArray(arrKey,true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
  if (strKeyIdLst.Length == 0)
 {
string strMsg = string.Format("根据关键字列表串删除记录时，给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intRecNum = clsQxPrjTabBL.DelQxPrjTabs(arrKey);
return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// 调用方法: POST /api/QxPrjTabApi/DelQxPrjTabsByCond
 /// 在Body区传输{"strWhereCond":"1=1"}
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[HttpGet("DelQxPrjTabsByCond")]
public ActionResult DelQxPrjTabsByCond(string strWhereCond)
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("删除满足条件的多条记录，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intRecNum = clsQxPrjTabBL.DelQxPrjTabsByCond(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}
}
}