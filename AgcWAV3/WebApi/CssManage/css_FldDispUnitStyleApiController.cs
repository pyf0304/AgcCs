
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:css_FldDispUnitStyleApiController
 表名:css_FldDispUnitStyle(00050615)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/23 10:14:29
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
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
 /// css_FldDispUnitStyleController 的摘要说明
 /// (AutoGCLib.WA_Srv4CSharp:GeneCode)
 /// </summary>
[ApiController]
[Route("[controller]")]
[ApiExplorerSettings(IgnoreApi = true)]
public class  css_FldDispUnitStyleApiController : ControllerBase
{ 

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// 调用方法: GET /api/css_FldDispUnitStyleApi/GetObjByFldDispUnitStyleId?FldDispUnitStyleId=value
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">表关键字</param>
 /// <returns>表对象</returns>
[HttpGet("GetObjByFldDispUnitStyleId")]
public ActionResult GetObjByFldDispUnitStyleId(string strFldDispUnitStyleId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strFldDispUnitStyleId"] = strFldDispUnitStyleId,
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strFldDispUnitStyleId) == true)
 {
string strMsg = string.Format("根据关键字获取对象时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = clscss_FldDispUnitStyleBL.GetObjByFldDispUnitStyleId(strFldDispUnitStyleId);
return Ok(new { errorId = 0, errorMsg = "", returnObj = objcss_FldDispUnitStyleEN });
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
 /// 调用方法: GET /api/css_FldDispUnitStyleApi/GetObjLst?strWhereCond=v1&
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
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLst = clscss_FldDispUnitStyleBL.GetObjLst(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrcss_FldDispUnitStyleObjLst });
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
 /// 调用方法: GET /api/css_FldDispUnitStyleApi/GetObjLst_Cache?
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
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLst = clscss_FldDispUnitStyleBL.GetObjLstCache();
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrcss_FldDispUnitStyleObjLst });
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
 /// 调用方法: POST /api/css_FldDispUnitStyleapi/GetObjLstByFldDispUnitStyleIdLst
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrFldDispUnitStyleIdLst">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
[HttpPost("GetObjLstByFldDispUnitStyleIdLst")]
public ActionResult GetObjLstByFldDispUnitStyleIdLst([FromBody]string[] arrFldDispUnitStyleId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrFldDispUnitStyleId);
dictParam.Add("arrFldDispUnitStyleId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (arrFldDispUnitStyleId.Length == 0)
{
string strMsg = string.Format("根据关键字列表串获取对象列表时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstFldDispUnitStyleId = new(arrFldDispUnitStyleId);
 try
 {
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLst = clscss_FldDispUnitStyleBL.GetObjLstByFldDispUnitStyleIdLst(lstFldDispUnitStyleId);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrcss_FldDispUnitStyleObjLst });
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
 /// 调用方法: POST /api/css_FldDispUnitStyleapi/GetObjLstByFldDispUnitStyleIdLst
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFldDispUnitStyleIdLst">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
[HttpPost("GetObjLstByFldDispUnitStyleIdLstCache")]
public ActionResult GetObjLstByFldDispUnitStyleIdLstCache([FromBody]string[] arrFldDispUnitStyleId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrFldDispUnitStyleId);
dictParam.Add("arrFldDispUnitStyleId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (arrFldDispUnitStyleId.Length == 0)
{
string strMsg = string.Format("根据关键字列表串获取对象列表时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstFldDispUnitStyleId = new(arrFldDispUnitStyleId);
 try
 {
IEnumerable<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLst = clscss_FldDispUnitStyleBL.GetObjLstByFldDispUnitStyleIdLstCache(lstFldDispUnitStyleId);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrcss_FldDispUnitStyleObjLst });
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
 /// 调用方法: GET /api/css_FldDispUnitStyleApi/GetTopObjLst?intTopSize=v1&strOrderBy=v2&strWhereCond=v3&
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
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLst = clscss_FldDispUnitStyleBL.GetTopObjLst(objTopPara);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrcss_FldDispUnitStyleObjLst });
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
 /// 调用方法: GET /api/css_FldDispUnitStyleApi/GetFirstID?strWhereCond=v1&
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
 string strFldDispUnitStyleId;
 try
 {
 strFldDispUnitStyleId = clscss_FldDispUnitStyleBL.GetFirstID_S(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnStr = strFldDispUnitStyleId });
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
 /// 调用方法: GET /api/css_FldDispUnitStyleApi/GetFirstObj?strWhereCond=v1&
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
 clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = clscss_FldDispUnitStyleBL.GetFirstObj_S(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnObj = objcss_FldDispUnitStyleEN });
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
 /// 调用方法: GET /api/css_FldDispUnitStyleApi/GetObjLstByPager?intPageIndex=v1&intPageSize=v2&strOrderBy=v3&strWhereCond=v4&
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
 List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLst;
 try
 {
 arrcss_FldDispUnitStyleObjLst = clscss_FldDispUnitStyleBL.GetObjLstByPager(objPagerPara);
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrcss_FldDispUnitStyleObjLst });
 }

 /// <summary>
 /// 功能:获取某一条件的记录数
 /// 调用方法: GET /api/css_FldDispUnitStyleApi/GetRecCountByCond?strWhereCond=v1&
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
int intCount = clscss_FldDispUnitStyleBL.GetRecCountByCond(strWhereCond);
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
 /// 调用方法: GET /api/css_FldDispUnitStyleApi/GetFldValue?strWhereCond=v1&strFldName=v2&strTabName=v3&
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
List<string> arrList = clscss_FldDispUnitStyleBL.GetFldValue(strFldName, strWhereCond);
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
 /// 调用方法: GET /api/css_FldDispUnitStyleApi/funSetFldValue?strCondition=v1&strFldName=v2&strTabName=v3&varValue=v4&
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
int intRecCount = clscss_FldDispUnitStyleBL.SetFldValue(clscss_FldDispUnitStyleEN._CurrTabName, strFldName, strValue, strWhereCond);
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
 /// 调用方法: GET /api/css_FldDispUnitStyleApi/IsExistRecord?strWhereCond=v1&
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
bool bolIsExist = clscss_FldDispUnitStyleBL.IsExistRecord(strWhereCond);
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
 /// 调用方法: GET /api/css_FldDispUnitStyleApi/IsExist?FldDispUnitStyleId=value
 /// (AutoGCLib.WA_Srv4CSharp:Gen_IsExist)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[HttpGet("IsExist")]
public ActionResult IsExist(string strFldDispUnitStyleId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strFldDispUnitStyleId"] = strFldDispUnitStyleId
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strFldDispUnitStyleId) == true)
 {
string strMsg = string.Format("判断表中是否存在给定关键字的记录时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
bool bolIsExist = clscss_FldDispUnitStyleBL.IsExist(strFldDispUnitStyleId);
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
 /// 调用方法: GET /api/css_FldDispUnitStyleApi/GetMaxStrId?
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[HttpGet("GetMaxStrId")]
public ActionResult GetMaxStrId()
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
string strMaxstrFldDispUnitStyleId = clscss_FldDispUnitStyleBL.GetMaxStrId_S();
return Ok(new { errorId = 0, errorMsg = "", returnStr =  strMaxstrFldDispUnitStyleId });
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
 /// 调用方法: POST /api/css_FldDispUnitStyleApi/AddNewRecord
 /// 在Body区传输objcss_FldDispUnitStyleEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("AddNewRecord")]
public ActionResult AddNewRecord([FromBody]clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strcss_FldDispUnitStyleJSONObj = clsJSON.GetJsonFromObj(objcss_FldDispUnitStyleEN);
dictParam.Add("strcss_FldDispUnitStyleJSONObj", strcss_FldDispUnitStyleJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleCond = new();
string strCondition = objcss_FldDispUnitStyleCond
.SetFldDispUnitStyleName(objcss_FldDispUnitStyleEN.FldDispUnitStyleName, "=")
.SetCtlTypeId(objcss_FldDispUnitStyleEN.CtlTypeId, "=")
.GetCombineCondition();
bool bolIsExist = clscss_FldDispUnitStyleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
string strMsg = string.Format("满足条件:{0}的记录表中已经存在,违反了唯一性.(from {1})", strCondition,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
 if (string.IsNullOrEmpty(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true || clscss_FldDispUnitStyleBL.IsExist(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true)
 {
     objcss_FldDispUnitStyleEN.FldDispUnitStyleId = clscss_FldDispUnitStyleBL.GetMaxStrId_S();
 }
    clscss_FldDispUnitStyleBL.AccessFldValueNull(objcss_FldDispUnitStyleEN);
bool bolResult = objcss_FldDispUnitStyleEN.AddNewRecord();
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
 /// 调用方法: POST /api/css_FldDispUnitStyleApi/AddNewRecordWithMaxId
 /// 在Body区传输objcss_FldDispUnitStyleEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("AddNewRecordWithMaxId")]
public ActionResult AddNewRecordWithMaxId([FromBody]clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strcss_FldDispUnitStyleJSONObj = clsJSON.GetJsonFromObj(objcss_FldDispUnitStyleEN);
dictParam.Add("strcss_FldDispUnitStyleJSONObj", strcss_FldDispUnitStyleJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
    clscss_FldDispUnitStyleBL.AccessFldValueNull(objcss_FldDispUnitStyleEN);
string strFldDispUnitStyleId = objcss_FldDispUnitStyleEN.AddNewRecordWithMaxId();
return Ok(new { errorId = 0, errorMsg = "", returnStr =  strFldDispUnitStyleId });
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
 /// 调用方法: POST /api/css_FldDispUnitStyleApi/AddNewRecordWithReturnKey
 /// 在Body区传输objcss_FldDispUnitStyleEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
[HttpPost("AddNewRecordWithReturnKey")]
public ActionResult AddNewRecordWithReturnKey(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WebApi.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空,请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
dictParam.Add("objcss_FldDispUnitStyleEN", JsonConvert.SerializeObject(objcss_FldDispUnitStyleEN));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
    clscss_FldDispUnitStyleBL.AccessFldValueNull(objcss_FldDispUnitStyleEN);
string strKey = clscss_FldDispUnitStyleBL.AddNewRecordBySql2WithReturnKey(objcss_FldDispUnitStyleEN);
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
 /// 调用方法: Post /api/css_FldDispUnitStyleApi/UpdateRecord
 /// 在Body区传输objcss_FldDispUnitStyleEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateRecord)
 /// </summary>
 /// <param name = "strcss_FldDispUnitStyleJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[HttpPost("UpdateRecord")]
public ActionResult UpdateRecord([FromBody]clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strcss_FldDispUnitStyleJSONObj = clsJSON.GetJsonFromObj(objcss_FldDispUnitStyleEN);
dictParam.Add("strcss_FldDispUnitStyleJSONObj", strcss_FldDispUnitStyleJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true)
 {
string strMsg = string.Format("修改记录时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
    clscss_FldDispUnitStyleBL.SetUpdFlag(objcss_FldDispUnitStyleEN);
    clscss_FldDispUnitStyleBL.AccessFldValueNull(objcss_FldDispUnitStyleEN);
bool bolResult = objcss_FldDispUnitStyleEN.Update();
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
 /// 调用方法: POST /api/css_FldDispUnitStyleApi/GoTop
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GoTop)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("GoTop")]
public ActionResult GoTop([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrFldDispUnitStyleId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表置顶时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstFldDispUnitStyleId = new(objOrderByData.KeyIdLst);
try
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strCtlTypeId = "";
if (jobjOrderByData.ContainsKey("ctlTypeId"))
{
strCtlTypeId = jobjOrderByData["ctlTypeId"].ToString();
}
else if (jobjOrderByData.ContainsKey("ctltypeid"))
{
strCtlTypeId = jobjOrderByData["ctltypeid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[ctlTypeId]的数据,请检查!", "ctlTypeId|ctltypeid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
bool bolResult = clscss_FldDispUnitStyleBL.GoTop(lstFldDispUnitStyleId, strCtlTypeId);
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
 /// 调用方法: POST /api/css_FldDispUnitStyleApi/UpMove
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpMove)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("UpMove")]
public ActionResult UpMove([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrFldDispUnitStyleId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表上移时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstFldDispUnitStyleId = new(objOrderByData.KeyIdLst);
try
{
foreach(var x in lstFldDispUnitStyleId)
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strCtlTypeId = "";
if (jobjOrderByData.ContainsKey("ctlTypeId"))
{
strCtlTypeId = jobjOrderByData["ctlTypeId"].ToString();
}
else if (jobjOrderByData.ContainsKey("ctltypeid"))
{
strCtlTypeId = jobjOrderByData["ctltypeid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[ctlTypeId]的数据,请检查!", "ctlTypeId|ctltypeid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
clscss_FldDispUnitStyleBL.AdjustOrderNum("UP", x, strCtlTypeId);
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
 /// 调用方法: POST /api/css_FldDispUnitStyleApi/DownMove
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DownMove)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("DownMove")]
public ActionResult DownMove([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrFldDispUnitStyleId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表下移时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstFldDispUnitStyleId = new(objOrderByData.KeyIdLst);
lstFldDispUnitStyleId.Reverse();
try
{
foreach(var x in lstFldDispUnitStyleId)
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strCtlTypeId = "";
if (jobjOrderByData.ContainsKey("ctlTypeId"))
{
strCtlTypeId = jobjOrderByData["ctlTypeId"].ToString();
}
else if (jobjOrderByData.ContainsKey("ctltypeid"))
{
strCtlTypeId = jobjOrderByData["ctltypeid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[ctlTypeId]的数据,请检查!", "ctlTypeId|ctltypeid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
clscss_FldDispUnitStyleBL.AdjustOrderNum("DOWN", x, strCtlTypeId);
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
 /// 调用方法: POST /api/css_FldDispUnitStyleApi/GoBottom
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GoBottom)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("GoBottom")]
public ActionResult GoBottom([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrFldDispUnitStyleId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表置底时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstFldDispUnitStyleId = new(objOrderByData.KeyIdLst);
try
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strCtlTypeId = "";
if (jobjOrderByData.ContainsKey("ctlTypeId"))
{
strCtlTypeId = jobjOrderByData["ctlTypeId"].ToString();
}
else if (jobjOrderByData.ContainsKey("ctltypeid"))
{
strCtlTypeId = jobjOrderByData["ctltypeid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[ctlTypeId]的数据,请检查!", "ctlTypeId|ctltypeid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
bool bolResult = clscss_FldDispUnitStyleBL.GoBottom(lstFldDispUnitStyleId, strCtlTypeId);
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
 /// 调用方法: POST /api/css_FldDispUnitStyleApi/ReOrder
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_ReOrder)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">对象</param>
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

string strCtlTypeId = "";
if (jobjOrderByData.ContainsKey("ctlTypeId"))
{
strCtlTypeId = jobjOrderByData["ctlTypeId"].ToString();
}
else if (jobjOrderByData.ContainsKey("ctltypeid"))
{
strCtlTypeId = jobjOrderByData["ctltypeid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[ctlTypeId]的数据,请检查!", "ctlTypeId|ctltypeid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
bool bolResult = clscss_FldDispUnitStyleBL.ReOrder(strCtlTypeId);
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
 /// 调用方法: Post /api/css_FldDispUnitStyleApi/UpdateWithCondition
 /// 在Body区传输objcss_FldDispUnitStyleEN的JSON对象和strWhereCond条件串
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateWithCondition)
 /// </summary>
 /// <param name = "strcss_FldDispUnitStyleJSONObj">JSON对象字符串</param>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>是否成功</returns>
[HttpPost("UpdateWithCondition")]
public ActionResult UpdateWithCondition(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strWhereCond)
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
    clscss_FldDispUnitStyleBL.AccessFldValueNull(objcss_FldDispUnitStyleEN);
bool bolResult = objcss_FldDispUnitStyleEN.UpdateWithCondition(strWhereCond);
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
 /// 调用方法: DELETE /api/css_FldDispUnitStyleApi/DelRecord/Id
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecord)
 /// </summary>
 /// <param name = "Id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
[HttpDelete("DelRecord")]
public ActionResult DelRecord(string Id)
{
string strFldDispUnitStyleId = Id;
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["Id"] = strFldDispUnitStyleId
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strFldDispUnitStyleId) == true)
 {
string strMsg = string.Format("删除关键字所指定的记录,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intRecNum = clscss_FldDispUnitStyleBL.DelRecord(strFldDispUnitStyleId);
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
 /// 调用方法: POST /api/css_FldDispUnitStyleApi/Delcss_FldDispUnitStyles
 /// 在Body区传输arrFldDispUnitStyleId(关键字值列表)的JSON串
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecord)
 /// </summary>
 /// <param name = "arrFldDispUnitStyleId">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
[HttpPost("Delcss_FldDispUnitStyles")]
public ActionResult Delcss_FldDispUnitStyles([FromBody]string[] arrFldDispUnitStyleId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrFldDispUnitStyleId);
dictParam.Add("arrFldDispUnitStyleId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
int intRecNum = clscss_FldDispUnitStyleBL.Delcss_FldDispUnitStyles(arrLst);
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
 /// 调用方法: POST /api/css_FldDispUnitStyleApi/DelRecords
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
int intRecNum = clscss_FldDispUnitStyleBL.Delcss_FldDispUnitStyles(arrKey);
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
 /// 调用方法: POST /api/css_FldDispUnitStyleApi/Delcss_FldDispUnitStylesByCond
 /// 在Body区传输{"strWhereCond":"1=1"}
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[HttpGet("Delcss_FldDispUnitStylesByCond")]
public ActionResult Delcss_FldDispUnitStylesByCond(string strWhereCond)
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
int intRecNum = clscss_FldDispUnitStyleBL.Delcss_FldDispUnitStylesByCond(strWhereCond);
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
 /// 根据标志删除关键字列表
 /// 调用方法: POST /api/css_FldDispUnitStyleapi/DelRecordBySign
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecordBySign)
 /// </summary>
 /// <param name = "arrFldDispUnitStyleIdLst">所给的关键字列表</param>
 /// <returns>删除的记录数</returns>
[HttpPost("DelRecordBySign")]
public ActionResult DelRecordBySign([FromBody]string[] arrFldDispUnitStyleId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrFldDispUnitStyleId);
dictParam.Add("arrFldDispUnitStyleId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (arrFldDispUnitStyleId.Length == 0)
{
string strMsg = string.Format("根据标志删除记录时,给定的关键字值列表不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstFldDispUnitStyleId = new(arrFldDispUnitStyleId);
 try
 {
int intRecNum = clscss_FldDispUnitStyleBL.DelRecordBySign(lstFldDispUnitStyleId);
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
 /// 根据标志恢复删除的记录列表
 /// 调用方法: POST /api/css_FldDispUnitStyleapi/UnDelRecordBySign
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UnDelRecordBySign)
 /// </summary>
 /// <param name = "arrFldDispUnitStyleIdLst">所给的关键字列表</param>
 /// <returns>恢复删除的记录数</returns>
[HttpPost("UnDelRecordBySign")]
public ActionResult UnDelRecordBySign([FromBody]string[] arrFldDispUnitStyleId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrFldDispUnitStyleId);
dictParam.Add("arrFldDispUnitStyleId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (arrFldDispUnitStyleId.Length == 0)
{
string strMsg = string.Format("根据标志恢复删除记录时,给定的关键字值列表不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstFldDispUnitStyleId = new(arrFldDispUnitStyleId);
 try
 {
int intRecNum = clscss_FldDispUnitStyleBL.UnDelRecordBySign(lstFldDispUnitStyleId);
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