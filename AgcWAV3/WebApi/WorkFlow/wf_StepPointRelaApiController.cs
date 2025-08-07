
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:wf_StepPointRelaApiController
 表名:wf_StepPointRela(00050486)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/23 10:16:41
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
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
 /// wf_StepPointRelaController 的摘要说明
 /// (AutoGCLib.WA_Srv4CSharp:GeneCode)
 /// </summary>
[ApiController]
[Route("[controller]")]
[ApiExplorerSettings(IgnoreApi = true)]
public class  wf_StepPointRelaApiController : ControllerBase
{ 

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// 调用方法: GET /api/wf_StepPointRelaApi/GetObjByWorkFlowStepPointRelaId?WorkFlowStepPointRelaId=value
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngWorkFlowStepPointRelaId">表关键字</param>
 /// <returns>表对象</returns>
[HttpGet("GetObjByWorkFlowStepPointRelaId")]
public ActionResult GetObjByWorkFlowStepPointRelaId(long lngWorkFlowStepPointRelaId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["lngWorkFlowStepPointRelaId"] = lngWorkFlowStepPointRelaId.ToString(),
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (lngWorkFlowStepPointRelaId <= 0)
 {
string strMsg = string.Format("根据关键字获取对象时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
clswf_StepPointRelaEN objwf_StepPointRelaEN = clswf_StepPointRelaBL.GetObjByWorkFlowStepPointRelaId(lngWorkFlowStepPointRelaId);
return Ok(new { errorId = 0, errorMsg = "", returnObj = objwf_StepPointRelaEN });
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
 /// 调用方法: GET /api/wf_StepPointRelaApi/GetObjLst?strWhereCond=v1&
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
List<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLst = clswf_StepPointRelaBL.GetObjLst(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrwf_StepPointRelaObjLst });
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
 /// 调用方法: GET /api/wf_StepPointRelaApi/GetObjLst_Cache?
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstCache)
 /// </summary>
 /// <returns>返回对象列表</returns>
[HttpGet("GetObjLstCache")]
public ActionResult GetObjLstCache()
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
List<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLst = clswf_StepPointRelaBL.GetObjLstCache();
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrwf_StepPointRelaObjLst });
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
 /// 调用方法: POST /api/wf_StepPointRelaapi/GetObjLstByWorkFlowStepPointRelaIdLst
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrWorkFlowStepPointRelaIdLst">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
[HttpPost("GetObjLstByWorkFlowStepPointRelaIdLst")]
public ActionResult GetObjLstByWorkFlowStepPointRelaIdLst([FromBody]string[] arrWorkFlowStepPointRelaId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrWorkFlowStepPointRelaId);
dictParam.Add("arrWorkFlowStepPointRelaId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (arrWorkFlowStepPointRelaId.Length == 0)
{
string strMsg = string.Format("根据关键字列表串获取对象列表时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstWorkFlowStepPointRelaId_Str = new List<string>(arrWorkFlowStepPointRelaId);
List<long> lstWorkFlowStepPointRelaId = lstWorkFlowStepPointRelaId_Str.Select(x=>long.Parse(x)).ToList();
 try
 {
List<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLst = clswf_StepPointRelaBL.GetObjLstByWorkFlowStepPointRelaIdLst(lstWorkFlowStepPointRelaId);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrwf_StepPointRelaObjLst });
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
 /// 调用方法: POST /api/wf_StepPointRelaapi/GetObjLstByWorkFlowStepPointRelaIdLst
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrWorkFlowStepPointRelaIdLst">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
[HttpPost("GetObjLstByWorkFlowStepPointRelaIdLstCache")]
public ActionResult GetObjLstByWorkFlowStepPointRelaIdLstCache([FromBody]string[] arrWorkFlowStepPointRelaId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrWorkFlowStepPointRelaId);
dictParam.Add("arrWorkFlowStepPointRelaId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (arrWorkFlowStepPointRelaId.Length == 0)
{
string strMsg = string.Format("根据关键字列表串获取对象列表时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstWorkFlowStepPointRelaId_Str = new List<string>(arrWorkFlowStepPointRelaId);
List<long> lstWorkFlowStepPointRelaId = lstWorkFlowStepPointRelaId_Str.Select(x=>long.Parse(x)).ToList();
 try
 {
IEnumerable<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLst = clswf_StepPointRelaBL.GetObjLstByWorkFlowStepPointRelaIdLstCache(lstWorkFlowStepPointRelaId);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrwf_StepPointRelaObjLst });
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
 /// 调用方法: GET /api/wf_StepPointRelaApi/GetTopObjLst?intTopSize=v1&strOrderBy=v2&strWhereCond=v3&
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
List<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLst = clswf_StepPointRelaBL.GetTopObjLst(objTopPara);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrwf_StepPointRelaObjLst });
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
 /// 调用方法: GET /api/wf_StepPointRelaApi/GetFirstID?strWhereCond=v1&
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
 long lngWorkFlowStepPointRelaId;
 try
 {
 lngWorkFlowStepPointRelaId = clswf_StepPointRelaBL.GetFirstID_S(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnStr = lngWorkFlowStepPointRelaId });
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
 /// 调用方法: GET /api/wf_StepPointRelaApi/GetFirstObj?strWhereCond=v1&
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
 clswf_StepPointRelaEN objwf_StepPointRelaEN = clswf_StepPointRelaBL.GetFirstObj_S(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnObj = objwf_StepPointRelaEN });
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
 /// 调用方法: GET /api/wf_StepPointRelaApi/GetObjLstByPager?intPageIndex=v1&intPageSize=v2&strOrderBy=v3&strWhereCond=v4&
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
 List<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLst;
 try
 {
 arrwf_StepPointRelaObjLst = clswf_StepPointRelaBL.GetObjLstByPager(objPagerPara);
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrwf_StepPointRelaObjLst });
 }

 /// <summary>
 /// 功能:获取某一条件的记录数
 /// 调用方法: GET /api/wf_StepPointRelaApi/GetRecCountByCond?strWhereCond=v1&
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
int intCount = clswf_StepPointRelaBL.GetRecCountByCond(strWhereCond);
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
 /// 调用方法: GET /api/wf_StepPointRelaApi/GetFldValue?strWhereCond=v1&strFldName=v2&strTabName=v3&
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
List<string> arrList = clswf_StepPointRelaBL.GetFldValue(strFldName, strWhereCond);
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
 /// 调用方法: GET /api/wf_StepPointRelaApi/funSetFldValue?strCondition=v1&strFldName=v2&strTabName=v3&varValue=v4&
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
int intRecCount = clswf_StepPointRelaBL.SetFldValue(clswf_StepPointRelaEN._CurrTabName, strFldName, strValue, strWhereCond);
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
 /// 调用方法: GET /api/wf_StepPointRelaApi/IsExistRecord?strWhereCond=v1&
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
bool bolIsExist = clswf_StepPointRelaBL.IsExistRecord(strWhereCond);
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
 /// 调用方法: GET /api/wf_StepPointRelaApi/IsExist?WorkFlowStepPointRelaId=value
 /// (AutoGCLib.WA_Srv4CSharp:Gen_IsExist)
 /// </summary>
 /// <param name = "lngWorkFlowStepPointRelaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[HttpGet("IsExist")]
public ActionResult IsExist(long lngWorkFlowStepPointRelaId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["lngWorkFlowStepPointRelaId"] = lngWorkFlowStepPointRelaId.ToString()
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (lngWorkFlowStepPointRelaId <= 0)
 {
string strMsg = string.Format("判断表中是否存在给定关键字的记录时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
bool bolIsExist = clswf_StepPointRelaBL.IsExist(lngWorkFlowStepPointRelaId);
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
 /// 调用方法: POST /api/wf_StepPointRelaApi/AddNewRecord
 /// 在Body区传输objwf_StepPointRelaEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("AddNewRecord")]
public ActionResult AddNewRecord([FromBody]clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strwf_StepPointRelaJSONObj = clsJSON.GetJsonFromObj(objwf_StepPointRelaEN);
dictParam.Add("strwf_StepPointRelaJSONObj", strwf_StepPointRelaJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
clswf_StepPointRelaEN objwf_StepPointRelaCond = new();
string strCondition = objwf_StepPointRelaCond
.SetWorkFlowId(objwf_StepPointRelaEN.WorkFlowId, "=")
.SetPointId(objwf_StepPointRelaEN.PointId, "=")
.GetCombineCondition();
bool bolIsExist = clswf_StepPointRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
string strMsg = string.Format("满足条件:{0}的记录表中已经存在,违反了唯一性.(from {1})", strCondition,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
    clswf_StepPointRelaBL.AccessFldValueNull(objwf_StepPointRelaEN);
bool bolResult = objwf_StepPointRelaEN.AddNewRecord();
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
 /// 调用方法: POST /api/wf_StepPointRelaApi/AddNewRecordWithReturnKey
 /// 在Body区传输objwf_StepPointRelaEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
[HttpPost("AddNewRecordWithReturnKey")]
public ActionResult AddNewRecordWithReturnKey(clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WebApi.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空,请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
dictParam.Add("objwf_StepPointRelaEN", JsonConvert.SerializeObject(objwf_StepPointRelaEN));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
    clswf_StepPointRelaBL.AccessFldValueNull(objwf_StepPointRelaEN);
string strKey = clswf_StepPointRelaBL.AddNewRecordBySql2WithReturnKey(objwf_StepPointRelaEN);
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
 /// 调用方法: Post /api/wf_StepPointRelaApi/UpdateRecord
 /// 在Body区传输objwf_StepPointRelaEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateRecord)
 /// </summary>
 /// <param name = "strwf_StepPointRelaJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[HttpPost("UpdateRecord")]
public ActionResult UpdateRecord([FromBody]clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strwf_StepPointRelaJSONObj = clsJSON.GetJsonFromObj(objwf_StepPointRelaEN);
dictParam.Add("strwf_StepPointRelaJSONObj", strwf_StepPointRelaJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (objwf_StepPointRelaEN.WorkFlowStepPointRelaId <= 0)
 {
string strMsg = string.Format("修改记录时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
    clswf_StepPointRelaBL.SetUpdFlag(objwf_StepPointRelaEN);
    clswf_StepPointRelaBL.AccessFldValueNull(objwf_StepPointRelaEN);
bool bolResult = objwf_StepPointRelaEN.Update();
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
 /// 调用方法: POST /api/wf_StepPointRelaApi/GoTop
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GoTop)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("GoTop")]
public ActionResult GoTop([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrWorkFlowStepPointRelaId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表置顶时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstWorkFlowStepPointRelaId_T = new(objOrderByData.KeyIdLst);
List<long> lstWorkFlowStepPointRelaId = lstWorkFlowStepPointRelaId_T.Select(x=>long.Parse(x)).ToList();
try
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strWorkFlowId = "";
if (jobjOrderByData.ContainsKey("workFlowId"))
{
strWorkFlowId = jobjOrderByData["workFlowId"].ToString();
}
else if (jobjOrderByData.ContainsKey("workflowid"))
{
strWorkFlowId = jobjOrderByData["workflowid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[workFlowId]的数据,请检查!", "workFlowId|workflowid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
bool bolResult = clswf_StepPointRelaBL.GoTop(lstWorkFlowStepPointRelaId, strWorkFlowId);
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
 /// 调用方法: POST /api/wf_StepPointRelaApi/UpMove
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpMove)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("UpMove")]
public ActionResult UpMove([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrWorkFlowStepPointRelaId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表上移时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstWorkFlowStepPointRelaId_T = new(objOrderByData.KeyIdLst);
List<long> lstWorkFlowStepPointRelaId = lstWorkFlowStepPointRelaId_T.Select(x=>long.Parse(x)).ToList();
try
{
foreach(var x in lstWorkFlowStepPointRelaId)
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strWorkFlowId = "";
if (jobjOrderByData.ContainsKey("workFlowId"))
{
strWorkFlowId = jobjOrderByData["workFlowId"].ToString();
}
else if (jobjOrderByData.ContainsKey("workflowid"))
{
strWorkFlowId = jobjOrderByData["workflowid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[workFlowId]的数据,请检查!", "workFlowId|workflowid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
clswf_StepPointRelaBL.AdjustOrderNum("UP", x, strWorkFlowId);
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
 /// 调用方法: POST /api/wf_StepPointRelaApi/DownMove
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DownMove)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("DownMove")]
public ActionResult DownMove([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrWorkFlowStepPointRelaId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表下移时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstWorkFlowStepPointRelaId_T = new(objOrderByData.KeyIdLst);
List<long> lstWorkFlowStepPointRelaId = lstWorkFlowStepPointRelaId_T.Select(x=>long.Parse(x)).ToList();
lstWorkFlowStepPointRelaId.Reverse();
try
{
foreach(var x in lstWorkFlowStepPointRelaId)
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strWorkFlowId = "";
if (jobjOrderByData.ContainsKey("workFlowId"))
{
strWorkFlowId = jobjOrderByData["workFlowId"].ToString();
}
else if (jobjOrderByData.ContainsKey("workflowid"))
{
strWorkFlowId = jobjOrderByData["workflowid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[workFlowId]的数据,请检查!", "workFlowId|workflowid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
clswf_StepPointRelaBL.AdjustOrderNum("DOWN", x, strWorkFlowId);
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
 /// 调用方法: POST /api/wf_StepPointRelaApi/GoBottom
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GoBottom)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("GoBottom")]
public ActionResult GoBottom([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrWorkFlowStepPointRelaId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表置底时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstWorkFlowStepPointRelaId_T = new(objOrderByData.KeyIdLst);
List<long> lstWorkFlowStepPointRelaId = lstWorkFlowStepPointRelaId_T.Select(x=>long.Parse(x)).ToList();
try
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strWorkFlowId = "";
if (jobjOrderByData.ContainsKey("workFlowId"))
{
strWorkFlowId = jobjOrderByData["workFlowId"].ToString();
}
else if (jobjOrderByData.ContainsKey("workflowid"))
{
strWorkFlowId = jobjOrderByData["workflowid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[workFlowId]的数据,请检查!", "workFlowId|workflowid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
bool bolResult = clswf_StepPointRelaBL.GoBottom(lstWorkFlowStepPointRelaId, strWorkFlowId);
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
 /// 调用方法: POST /api/wf_StepPointRelaApi/ReOrder
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_ReOrder)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">对象</param>
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

string strWorkFlowId = "";
if (jobjOrderByData.ContainsKey("workFlowId"))
{
strWorkFlowId = jobjOrderByData["workFlowId"].ToString();
}
else if (jobjOrderByData.ContainsKey("workflowid"))
{
strWorkFlowId = jobjOrderByData["workflowid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[workFlowId]的数据,请检查!", "workFlowId|workflowid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
bool bolResult = clswf_StepPointRelaBL.ReOrder(strWorkFlowId);
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
 /// 调用方法: Post /api/wf_StepPointRelaApi/UpdateWithCondition
 /// 在Body区传输objwf_StepPointRelaEN的JSON对象和strWhereCond条件串
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateWithCondition)
 /// </summary>
 /// <param name = "strwf_StepPointRelaJSONObj">JSON对象字符串</param>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>是否成功</returns>
[HttpPost("UpdateWithCondition")]
public ActionResult UpdateWithCondition(clswf_StepPointRelaEN objwf_StepPointRelaEN, string strWhereCond)
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
    clswf_StepPointRelaBL.AccessFldValueNull(objwf_StepPointRelaEN);
bool bolResult = objwf_StepPointRelaEN.UpdateWithCondition(strWhereCond);
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
 /// 调用方法: DELETE /api/wf_StepPointRelaApi/DelRecord/Id
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecord)
 /// </summary>
 /// <param name = "Id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
[HttpDelete("DelRecord")]
public ActionResult DelRecord(long Id)
{
long lngWorkFlowStepPointRelaId = Id;
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["Id"] = lngWorkFlowStepPointRelaId.ToString()
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (lngWorkFlowStepPointRelaId <= 0)
 {
string strMsg = string.Format("删除关键字所指定的记录,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intRecNum = clswf_StepPointRelaBL.DelRecord(lngWorkFlowStepPointRelaId);
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
 /// 调用方法: POST /api/wf_StepPointRelaApi/Delwf_StepPointRelas
 /// 在Body区传输arrWorkFlowStepPointRelaId(关键字值列表)的JSON串
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecord)
 /// </summary>
 /// <param name = "arrWorkFlowStepPointRelaId">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
[HttpPost("Delwf_StepPointRelas")]
public ActionResult Delwf_StepPointRelas([FromBody]string[] arrWorkFlowStepPointRelaId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrWorkFlowStepPointRelaId);
dictParam.Add("arrWorkFlowStepPointRelaId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
int intRecNum = clswf_StepPointRelaBL.Delwf_StepPointRelas(arrLst);
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
 /// 调用方法: POST /api/wf_StepPointRelaApi/DelRecords
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
int intRecNum = clswf_StepPointRelaBL.Delwf_StepPointRelas(arrKey);
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
 /// 调用方法: POST /api/wf_StepPointRelaApi/Delwf_StepPointRelasByCond
 /// 在Body区传输{"strWhereCond":"1=1"}
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[HttpGet("Delwf_StepPointRelasByCond")]
public ActionResult Delwf_StepPointRelasByCond(string strWhereCond)
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
int intRecNum = clswf_StepPointRelaBL.Delwf_StepPointRelasByCond(strWhereCond);
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