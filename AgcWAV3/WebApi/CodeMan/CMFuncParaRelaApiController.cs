
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:CMFuncParaRelaApiController
 表名:CMFuncParaRela(00050504)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/23 10:14:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
using AGC.Entity;
using AGC.BusinessLogic;
using com.taishsoft.common;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; using Comm.WebApi;

namespace AGC.WebApi
{
 /// <summary>
 /// CMFuncParaRelaController 的摘要说明
 /// (AutoGCLib.WA_Srv4CSharp:GeneCode)
 /// </summary>
[ApiController]
[Route("[controller]")]
[ApiExplorerSettings(IgnoreApi = true)]
public class  CMFuncParaRelaApiController : ControllerBase
{ 

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// 调用方法: GET /api/CMFuncParaRelaApi/GetObjBymId?mId=value
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
[HttpGet("GetObjBymId")]
public ActionResult GetObjBymId(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["lngmId"] = lngmId.ToString(),
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (lngmId <= 0)
 {
string strMsg = string.Format("根据关键字获取对象时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
clsCMFuncParaRelaEN objCMFuncParaRelaEN = clsCMFuncParaRelaBL.GetObjBymId(lngmId);
return Ok(new { errorId = 0, errorMsg = "", returnObj = objCMFuncParaRelaEN });
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
 /// 调用方法: GET /api/CMFuncParaRelaApi/GetObjLst?strWhereCond=v1&
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
string strMsg = string.Format("根据条件获取对象列表,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
List<clsCMFuncParaRelaEN> arrCMFuncParaRelaObjLst = clsCMFuncParaRelaBL.GetObjLst(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrCMFuncParaRelaObjLst });
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
 /// 调用方法: GET /api/CMFuncParaRelaApi/GetObjLst_Cache?
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstCache)
 /// </summary>
 /// <returns>返回对象列表</returns>
[HttpGet("GetObjLstCache")]
public ActionResult GetObjLstCache(string strPrjId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
List<clsCMFuncParaRelaEN> arrCMFuncParaRelaObjLst = clsCMFuncParaRelaBL.GetObjLstCache(strPrjId);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrCMFuncParaRelaObjLst });
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
 /// 调用方法: POST /api/CMFuncParaRelaapi/GetObjLstByMIdLst
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
[HttpPost("GetObjLstByMIdLst")]
public ActionResult GetObjLstByMIdLst([FromBody]string[] arrMId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrMId);
dictParam.Add("arrmId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (arrMId.Length == 0)
{
string strMsg = string.Format("根据关键字列表串获取对象列表时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstMId_Str = new List<string>(arrMId);
List<long> lstMId = lstMId_Str.Select(x=>long.Parse(x)).ToList();
 try
 {
List<clsCMFuncParaRelaEN> arrCMFuncParaRelaObjLst = clsCMFuncParaRelaBL.GetObjLstByMIdLst(lstMId);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrCMFuncParaRelaObjLst });
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
 /// 调用方法: POST /api/CMFuncParaRelaapi/GetObjLstByMIdLst
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
[HttpPost("GetObjLstByMIdLstCache")]
public ActionResult GetObjLstByMIdLstCache([FromBody]string[] arrMId, string PrjId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrMId);
dictParam.Add("arrmId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (arrMId.Length == 0)
{
string strMsg = string.Format("根据关键字列表串获取对象列表时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstMId_Str = new List<string>(arrMId);
List<long> lstMId = lstMId_Str.Select(x=>long.Parse(x)).ToList();
 try
 {
IEnumerable<clsCMFuncParaRelaEN> arrCMFuncParaRelaObjLst = clsCMFuncParaRelaBL.GetObjLstByMIdLstCache(lstMId, PrjId);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrCMFuncParaRelaObjLst });
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
 /// 调用方法: GET /api/CMFuncParaRelaApi/GetTopObjLst?intTopSize=v1&strOrderBy=v2&strWhereCond=v3&
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
string strMsg = string.Format("根据条件获取顶部对象列表,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 if (objTopPara.topSize <= 0)
 {
string strMsg = string.Format("根据条件获取顶部对象列表,顶部记录数:[{0}]不能小于等于0!({1})", objTopPara.topSize, clsStackTrace.GetCurrClassFunction());
clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
 }
 try
 {
List<clsCMFuncParaRelaEN> arrCMFuncParaRelaObjLst = clsCMFuncParaRelaBL.GetTopObjLst(objTopPara);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrCMFuncParaRelaObjLst });
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
 /// 调用方法: GET /api/CMFuncParaRelaApi/GetFirstID?strWhereCond=v1&
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
string strMsg = string.Format("根据条件获取第一条记录的关键字值时,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 long lngmId;
 try
 {
 lngmId = clsCMFuncParaRelaBL.GetFirstID_S(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnStr = lngmId });
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
 /// 调用方法: GET /api/CMFuncParaRelaApi/GetFirstObj?strWhereCond=v1&
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
string strMsg = string.Format("根据条件获取第一条对象时,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
 clsCMFuncParaRelaEN objCMFuncParaRelaEN = clsCMFuncParaRelaBL.GetFirstObj_S(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnObj = objCMFuncParaRelaEN });
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
 /// 调用方法: GET /api/CMFuncParaRelaApi/GetObjLstByPager?intPageIndex=v1&intPageSize=v2&strOrderBy=v3&strWhereCond=v4&
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
string strMsg = string.Format("根据条件分页获取JSON对象列表,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 if (objPagerPara.pageSize <=0)
 {
string strMsg = string.Format("根据条件分页获取JSON对象列表,每页记录数:[{0}]不能小于等于0!({1})", objPagerPara.pageSize, clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 if (objPagerPara.pageIndex <=0)
 {
string strMsg = string.Format("根据条件分页获取JSON对象列表,页序号:[{0}]不能小于等于0!({1})", objPagerPara.pageIndex, clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 List<clsCMFuncParaRelaEN> arrCMFuncParaRelaObjLst;
 try
 {
 arrCMFuncParaRelaObjLst = clsCMFuncParaRelaBL.GetObjLstByPager(objPagerPara);
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrCMFuncParaRelaObjLst });
 }

 /// <summary>
 /// 功能:获取某一条件的记录数
 /// 调用方法: GET /api/CMFuncParaRelaApi/GetRecCountByCond?strWhereCond=v1&
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
string strMsg = string.Format("获取某一条件的记录数,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intCount = clsCMFuncParaRelaBL.GetRecCountByCond(strWhereCond);
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
 /// 调用方法: GET /api/CMFuncParaRelaApi/GetFldValue?strWhereCond=v1&strFldName=v2&strTabName=v3&
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
string strMsg = string.Format("获取某一条件的字段值,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
List<string> arrList = clsCMFuncParaRelaBL.GetFldValue(strFldName, strWhereCond);
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
 /// 调用方法: GET /api/CMFuncParaRelaApi/funSetFldValue?strCondition=v1&strFldName=v2&strTabName=v3&varValue=v4&
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
string strMsg = string.Format("获取某一条件的字段值,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
 try
 {
int intRecCount = clsCMFuncParaRelaBL.SetFldValue(clsCMFuncParaRelaEN._CurrTabName, strFldName, strValue, strWhereCond);
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
 /// 调用方法: GET /api/CMFuncParaRelaApi/IsExistRecord?strWhereCond=v1&
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
string strMsg = string.Format("判断是否存在某一条件的记录,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
bool bolIsExist = clsCMFuncParaRelaBL.IsExistRecord(strWhereCond);
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
 /// 调用方法: GET /api/CMFuncParaRelaApi/IsExist?mId=value
 /// (AutoGCLib.WA_Srv4CSharp:Gen_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[HttpGet("IsExist")]
public ActionResult IsExist(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["lngmId"] = lngmId.ToString()
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (lngmId <= 0)
 {
string strMsg = string.Format("判断表中是否存在给定关键字的记录时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
bool bolIsExist = clsCMFuncParaRelaBL.IsExist(lngmId);
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
 /// 通过JSON对象来添加记录对象
 /// 调用方法: POST /api/CMFuncParaRelaApi/AddNewRecord
 /// 在Body区传输objCMFuncParaRelaEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
 /// </summary>
 /// <param name = "objCMFuncParaRelaEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("AddNewRecord")]
public ActionResult AddNewRecord([FromBody]clsCMFuncParaRelaEN objCMFuncParaRelaEN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strCMFuncParaRelaJSONObj = clsJSON.GetJsonFromObj(objCMFuncParaRelaEN);
dictParam.Add("strCMFuncParaRelaJSONObj", strCMFuncParaRelaJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
clsCMFuncParaRelaEN objCMFuncParaRelaCond = new();
string strCondition = objCMFuncParaRelaCond
.SetCmFuncParaId(objCMFuncParaRelaEN.CmFuncParaId, "=")
.SetCmFunctionId(objCMFuncParaRelaEN.CmFunctionId, "=")
.GetCombineCondition();
bool bolIsExist = clsCMFuncParaRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
string strMsg = string.Format("满足条件:{0}的记录表中已经存在,违反了唯一性.(from {1})", strCondition,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
    clsCMFuncParaRelaBL.AccessFldValueNull(objCMFuncParaRelaEN);
bool bolResult = objCMFuncParaRelaEN.AddNewRecord();
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// 调用方法: POST /api/CMFuncParaRelaApi/AddNewRecordWithReturnKey
 /// 在Body区传输objCMFuncParaRelaEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objCMFuncParaRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
[HttpPost("AddNewRecordWithReturnKey")]
public ActionResult AddNewRecordWithReturnKey(clsCMFuncParaRelaEN objCMFuncParaRelaEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WebApi.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空,请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
dictParam.Add("objCMFuncParaRelaEN", JsonConvert.SerializeObject(objCMFuncParaRelaEN));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
    clsCMFuncParaRelaBL.AccessFldValueNull(objCMFuncParaRelaEN);
string strKey = clsCMFuncParaRelaBL.AddNewRecordBySql2WithReturnKey(objCMFuncParaRelaEN);
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
 /// 调用方法: Post /api/CMFuncParaRelaApi/UpdateRecord
 /// 在Body区传输objCMFuncParaRelaEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateRecord)
 /// </summary>
 /// <param name = "strCMFuncParaRelaJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[HttpPost("UpdateRecord")]
public ActionResult UpdateRecord([FromBody]clsCMFuncParaRelaEN objCMFuncParaRelaEN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strCMFuncParaRelaJSONObj = clsJSON.GetJsonFromObj(objCMFuncParaRelaEN);
dictParam.Add("strCMFuncParaRelaJSONObj", strCMFuncParaRelaJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (objCMFuncParaRelaEN.mId <= 0)
 {
string strMsg = string.Format("修改记录时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
    clsCMFuncParaRelaBL.SetUpdFlag(objCMFuncParaRelaEN);
    clsCMFuncParaRelaBL.AccessFldValueNull(objCMFuncParaRelaEN);
bool bolResult = objCMFuncParaRelaEN.Update();
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
 /// 把所给的关键字列表相关的记录移顶
 /// 调用方法: POST /api/CMFuncParaRelaApi/GoTop
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GoTop)
 /// </summary>
 /// <param name = "objCMFuncParaRelaEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("GoTop")]
public ActionResult GoTop([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrmId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表置顶时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstmId_T = new(objOrderByData.KeyIdLst);
List<long> lstmId = lstmId_T.Select(x=>long.Parse(x)).ToList();
try
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strCmFunctionId = "";
if (jobjOrderByData.ContainsKey("cmFunctionId"))
{
strCmFunctionId = jobjOrderByData["cmFunctionId"].ToString();
}
else if (jobjOrderByData.ContainsKey("cmfunctionid"))
{
strCmFunctionId = jobjOrderByData["cmfunctionid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[cmFunctionId]的数据,请检查!", "cmFunctionId|cmfunctionid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
bool bolResult = clsCMFuncParaRelaBL.GoTop(lstmId, strCmFunctionId);
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
 /// 把所给的关键字列表相关的记录上移
 /// 调用方法: POST /api/CMFuncParaRelaApi/UpMove
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpMove)
 /// </summary>
 /// <param name = "objCMFuncParaRelaEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("UpMove")]
public ActionResult UpMove([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrmId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表上移时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstmId_T = new(objOrderByData.KeyIdLst);
List<long> lstmId = lstmId_T.Select(x=>long.Parse(x)).ToList();
try
{
foreach(var x in lstmId)
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strCmFunctionId = "";
if (jobjOrderByData.ContainsKey("cmFunctionId"))
{
strCmFunctionId = jobjOrderByData["cmFunctionId"].ToString();
}
else if (jobjOrderByData.ContainsKey("cmfunctionid"))
{
strCmFunctionId = jobjOrderByData["cmfunctionid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[cmFunctionId]的数据,请检查!", "cmFunctionId|cmfunctionid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
clsCMFuncParaRelaBL.AdjustOrderNum("UP", x, strCmFunctionId);
}
return Ok(new { errorId = 0, errorMsg = "", returnBool = true });
}
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 把所给的关键字列表相关的记录下移
 /// 调用方法: POST /api/CMFuncParaRelaApi/DownMove
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DownMove)
 /// </summary>
 /// <param name = "objCMFuncParaRelaEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("DownMove")]
public ActionResult DownMove([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrmId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表下移时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstmId_T = new(objOrderByData.KeyIdLst);
List<long> lstmId = lstmId_T.Select(x=>long.Parse(x)).ToList();
lstmId.Reverse();
try
{
foreach(var x in lstmId)
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strCmFunctionId = "";
if (jobjOrderByData.ContainsKey("cmFunctionId"))
{
strCmFunctionId = jobjOrderByData["cmFunctionId"].ToString();
}
else if (jobjOrderByData.ContainsKey("cmfunctionid"))
{
strCmFunctionId = jobjOrderByData["cmfunctionid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[cmFunctionId]的数据,请检查!", "cmFunctionId|cmfunctionid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
clsCMFuncParaRelaBL.AdjustOrderNum("DOWN", x, strCmFunctionId);
}
return Ok(new { errorId = 0, errorMsg = "", returnBool = true });
}
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 把所给的关键字列表相关的记录移底
 /// 调用方法: POST /api/CMFuncParaRelaApi/GoBottom
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GoBottom)
 /// </summary>
 /// <param name = "objCMFuncParaRelaEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("GoBottom")]
public ActionResult GoBottom([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrmId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表置底时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstmId_T = new(objOrderByData.KeyIdLst);
List<long> lstmId = lstmId_T.Select(x=>long.Parse(x)).ToList();
try
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strCmFunctionId = "";
if (jobjOrderByData.ContainsKey("cmFunctionId"))
{
strCmFunctionId = jobjOrderByData["cmFunctionId"].ToString();
}
else if (jobjOrderByData.ContainsKey("cmfunctionid"))
{
strCmFunctionId = jobjOrderByData["cmfunctionid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[cmFunctionId]的数据,请检查!", "cmFunctionId|cmfunctionid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
bool bolResult = clsCMFuncParaRelaBL.GoBottom(lstmId, strCmFunctionId);
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
 /// 把所给的关键字列表相关的记录移底
 /// 调用方法: POST /api/CMFuncParaRelaApi/ReOrder
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_ReOrder)
 /// </summary>
 /// <param name = "objCMFuncParaRelaEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("ReOrder")]
public ActionResult ReOrder([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
try
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strCmFunctionId = "";
if (jobjOrderByData.ContainsKey("cmFunctionId"))
{
strCmFunctionId = jobjOrderByData["cmFunctionId"].ToString();
}
else if (jobjOrderByData.ContainsKey("cmfunctionid"))
{
strCmFunctionId = jobjOrderByData["cmfunctionid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[cmFunctionId]的数据,请检查!", "cmFunctionId|cmfunctionid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
bool bolResult = clsCMFuncParaRelaBL.ReOrder(strCmFunctionId);
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
 /// 调用方法: Post /api/CMFuncParaRelaApi/UpdateWithCondition
 /// 在Body区传输objCMFuncParaRelaEN的JSON对象和strWhereCond条件串
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateWithCondition)
 /// </summary>
 /// <param name = "strCMFuncParaRelaJSONObj">JSON对象字符串</param>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>是否成功</returns>
[HttpPost("UpdateWithCondition")]
public ActionResult UpdateWithCondition(clsCMFuncParaRelaEN objCMFuncParaRelaEN, string strWhereCond)
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WebApi.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空,请检查!");
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
string strMsg = string.Format("根据条件修改记录时,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
try
{
    clsCMFuncParaRelaBL.AccessFldValueNull(objCMFuncParaRelaEN);
bool bolResult = objCMFuncParaRelaEN.UpdateWithCondition(strWhereCond);
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
 /// 调用方法: DELETE /api/CMFuncParaRelaApi/DelRecord/Id
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecord)
 /// </summary>
 /// <param name = "Id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
[HttpDelete("DelRecord")]
public ActionResult DelRecord(long Id)
{
long lngmId = Id;
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["Id"] = lngmId.ToString()
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (lngmId <= 0)
 {
string strMsg = string.Format("删除关键字所指定的记录,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intRecNum = clsCMFuncParaRelaBL.DelRecord(lngmId);
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
 /// 调用方法: POST /api/CMFuncParaRelaApi/DelCMFuncParaRelas
 /// 在Body区传输arrmId(关键字值列表)的JSON串
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecord)
 /// </summary>
 /// <param name = "arrmId">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
[HttpPost("DelCMFuncParaRelas")]
public ActionResult DelCMFuncParaRelas([FromBody]string[] arrmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrmId);
dictParam.Add("arrmId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
int intRecNum = clsCMFuncParaRelaBL.DelCMFuncParaRelas(arrLst);
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
 /// 调用方法: POST /api/CMFuncParaRelaApi/DelRecords
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
string strMsg = string.Format("根据关键字列表串删除记录时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intRecNum = clsCMFuncParaRelaBL.DelCMFuncParaRelas(arrKey);
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
 /// 调用方法: POST /api/CMFuncParaRelaApi/DelCMFuncParaRelasByCond
 /// 在Body区传输{"strWhereCond":"1=1"}
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[HttpGet("DelCMFuncParaRelasByCond")]
public ActionResult DelCMFuncParaRelasByCond(string strWhereCond)
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
string strMsg = string.Format("删除满足条件的多条记录,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intRecNum = clsCMFuncParaRelaBL.DelCMFuncParaRelasByCond(strWhereCond);
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