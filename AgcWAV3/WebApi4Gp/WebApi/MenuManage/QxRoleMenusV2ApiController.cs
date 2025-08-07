
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:QxRoleMenusV2ApiController
 表名:QxRoleMenusV2(00140114)
 * 版本:2023.05.10.1(服务器:WIN-SRV103-116)
 日期:2023/05/15 23:45:56
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:109.244.40.104,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:菜单管理(MenuManage)
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
 /// QxRoleMenusV2Controller 的摘要说明
 /// (AutoGCLib.WA_Srv4CSharp:GeneCode)
 /// </summary>
[ApiController]
[Route("[controller]")]
[ApiExplorerSettings(IgnoreApi = true)]
public class QxRoleMenusV2ApiController : ControllerBase
{ 

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// 调用方法: GET /api/QxRoleMenusV2Api/GetObjByRId?RId=value
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "intRId">表关键字</param>
 /// <param name = "intMeId">表关键字</param>
 /// <returns>表对象</returns>
[HttpGet("GetObjByKeyLst")]
public ActionResult GetObjByKeyLst(int intRId,int intMeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["intRId"] = intRId.ToString(),
["intMeId"] = intMeId.ToString(),
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (intRId <= 0)
 if (intMeId <= 0)
 {
string strMsg = string.Format("根据关键字获取对象时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
clsQxRoleMenusV2EN objQxRoleMenusV2EN = clsQxRoleMenusV2BL.GetObjByKeyLst(intRId,intMeId);
return Ok(new { errorId = 0, errorMsg = "", returnObj = objQxRoleMenusV2EN });
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
 /// 调用方法: GET /api/QxRoleMenusV2Api/GetObjByKey_Cache?RId=value
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjByKeyId_Cache)
 /// </summary>
 /// <param name = "intRId">表关键字</param>
 /// <param name = "intMeId">表关键字</param>
 /// <param name = "strQxPrjId">缓存的分类字段</param>
 /// <returns>表对象</returns>
[HttpGet("GetObjByKeyLst_Cache")]
public ActionResult GetObjByKeyLstCache(int intRId,int intMeId, string strQxPrjId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["intRId"] = intRId.ToString(),
["intMeId"] = intMeId.ToString(),
["strQxPrjId"] = strQxPrjId,
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (intRId <= 0)
 if (intMeId <= 0)
 {
string strMsg = string.Format("根据关键字获取对象时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
clsQxRoleMenusV2EN objQxRoleMenusV2EN = clsQxRoleMenusV2BL.GetObjByKeyLstCache(intRId,intMeId, strQxPrjId);
return Ok(new { errorId = 0, errorMsg = "", returnObj = objQxRoleMenusV2EN });
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
 /// 调用方法: GET /api/QxRoleMenusV2Api/GetObjLst?strWhereCond=v1&
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
List<clsQxRoleMenusV2EN> arrQxRoleMenusV2ObjLst = clsQxRoleMenusV2BL.GetObjLst(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxRoleMenusV2ObjLst });
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
 /// 调用方法: GET /api/QxRoleMenusV2Api/GetObjLst_Cache?
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst_Cache)
 /// </summary>
 /// <returns>返回对象列表</returns>
[HttpGet("GetObjLst_Cache")]
public ActionResult GetObjLstCache(string strQxPrjId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
List<clsQxRoleMenusV2EN> arrQxRoleMenusV2ObjLst = clsQxRoleMenusV2BL.GetObjLstCache(strQxPrjId);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxRoleMenusV2ObjLst });
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
 /// 调用方法: GET /api/QxRoleMenusV2Api/GetSubObjLst_Cache?objTabName_Cond=v1&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetSubObjLst_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
 [HttpPost("GetSubObjLst_Cache")]
 public ActionResult GetSubObjLstCache([FromBody]clsQxRoleMenusV2EN objQxRoleMenusV2_Cond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strQxRoleMenusV2JSONObj = clsJSON.GetJsonFromObj(objQxRoleMenusV2_Cond);
dictParam.Add("strQxRoleMenusV2JSONObj", strQxRoleMenusV2JSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 IEnumerable<clsQxRoleMenusV2EN> arrQxRoleMenusV2ObjLst;
 try
 {
if (objQxRoleMenusV2_Cond.sfFldComparisonOp == null)
{
objQxRoleMenusV2_Cond.dicFldComparisonOp = null;
}
else
{
objQxRoleMenusV2_Cond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxRoleMenusV2_Cond.sfFldComparisonOp);
}
clsQxRoleMenusV2BL.SetUpdFlag(objQxRoleMenusV2_Cond);
 arrQxRoleMenusV2ObjLst = clsQxRoleMenusV2BL.GetSubObjLstCache(objQxRoleMenusV2_Cond);
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxRoleMenusV2ObjLst });
 }

 /// <summary>
 /// 根据关键字列表获取相关对象列表
 /// 调用方法: POST /api/QxRoleMenusV2api/GetObjLstByRIdLst
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "arrKeyLst">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
[HttpPost("GetObjLstByKeyLsts_Cache")]
public ActionResult GetObjLstByKeyLstsCache([FromBody]string[] arrKeyLst, string QxPrjId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrKeyLst);
dictParam.Add("arrRId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (arrKeyLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表串获取对象列表时，给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
 try
 {
List<string> lstKeyLst = new(arrKeyLst);
IEnumerable<clsQxRoleMenusV2EN> arrQxRoleMenusV2ObjLst = clsQxRoleMenusV2BL.GetObjLstByKeyLstsCache(lstKeyLst, QxPrjId);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxRoleMenusV2ObjLst });
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
 /// 调用方法: GET /api/QxRoleMenusV2Api/GetTopObjLst?intTopSize=v1&strOrderBy=v2&strWhereCond=v3&
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
List<clsQxRoleMenusV2EN> arrQxRoleMenusV2ObjLst = clsQxRoleMenusV2BL.GetTopObjLst(objTopPara);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxRoleMenusV2ObjLst });
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
 /// 调用方法: GET /api/QxRoleMenusV2Api/GetFirstID?strWhereCond=v1&
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
 int intRId;
 try
 {
 intRId = clsQxRoleMenusV2BL.GetFirstID_S(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnStr = intRId });
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
 /// 调用方法: GET /api/QxRoleMenusV2Api/GetFirstObj?strWhereCond=v1&
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
 clsQxRoleMenusV2EN objQxRoleMenusV2EN = clsQxRoleMenusV2BL.GetFirstObj_S(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnObj = objQxRoleMenusV2EN });
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
 /// 调用方法: GET /api/QxRoleMenusV2Api/GetObjLstByPager?intPageIndex=v1&intPageSize=v2&strOrderBy=v3&strWhereCond=v4&
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
 List<clsQxRoleMenusV2EN> arrQxRoleMenusV2ObjLst;
 try
 {
 arrQxRoleMenusV2ObjLst = clsQxRoleMenusV2BL.GetObjLstByPager(objPagerPara);
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxRoleMenusV2ObjLst });
 }

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// 调用方法: GET /api/QxRoleMenusV2Api/GetObjLstByPager_Cache?intPageIndex=v1&intPageSize=v2&strOrderBy=v3&strWhereCond=v4&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
 [HttpPost("GetObjLstByPager_Cache")]
 public ActionResult GetObjLstByPagerCache([FromBody]stuPagerPara objPagerPara)
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
 IEnumerable<clsQxRoleMenusV2EN> arrQxRoleMenusV2ObjLst;
 try
 {
 arrQxRoleMenusV2ObjLst = clsQxRoleMenusV2BL.GetObjLstByPagerCache(objPagerPara);
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxRoleMenusV2ObjLst });
 }

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// 调用方法: GET /api/QxRoleMenusV2Api/GetObjLstByRange?strOrderBy=v1&intMaxNum=v2&intMinNum=v3&strWhereCond=v4&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
 [HttpPost("GetObjLstByRange")]
 public ActionResult GetObjLstByRange([FromBody]stuRangePara objRangePara)
 {
objRangePara.whereCond = objRangePara.whereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = objRangePara.GetDictParam();
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(objRangePara.whereCond) == true)
 {
string strMsg = string.Format("根据条件获取范围内的对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 if (objRangePara.minNum <0)
 {
string strMsg = string.Format("根据条件分页获取JSON对象列表，最小记录号:[{0}]不能小于0!({1})", objRangePara.minNum, clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 if (objRangePara.maxNum <0)
 {
string strMsg = string.Format("根据条件分页获取JSON对象列表，最大记录号:[{0}]不能小于0!({1})", objRangePara.maxNum, clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 if (objRangePara.maxNum <= objRangePara.minNum)
 {
string strMsg = string.Format("根据条件分页获取JSON对象列表，最大记录号:[{0}]不能小于等于最小记录号:[{1}]!({2})", objRangePara.maxNum, objRangePara.minNum, clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 List<clsQxRoleMenusV2EN> arrQxRoleMenusV2ObjLst;
 try
 {
 arrQxRoleMenusV2ObjLst = clsQxRoleMenusV2BL.GetObjLstByRange(objRangePara);
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxRoleMenusV2ObjLst });
 }

 /// <summary>
 /// 功能:获取某一条件的记录数
 /// 调用方法: GET /api/QxRoleMenusV2Api/GetRecCountByCond?strWhereCond=v1&
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
int intCount = clsQxRoleMenusV2BL.GetRecCountByCond(strWhereCond);
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
 /// 调用方法: GET /api/QxRoleMenusV2Api/GetFldValue?strWhereCond=v1&strFldName=v2&strTabName=v3&
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
List<string> arrList = clsQxRoleMenusV2BL.GetFldValue(strFldName, strWhereCond);
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
 /// 调用方法: GET /api/QxRoleMenusV2Api/funSetFldValue?strCondition=v1&strFldName=v2&strTabName=v3&varValue=v4&
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
int intRecCount = clsQxRoleMenusV2BL.SetFldValue(clsQxRoleMenusV2EN._CurrTabName, strFldName, strValue, strWhereCond);
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
 /// 调用方法: GET /api/QxRoleMenusV2Api/IsExistRecord?strWhereCond=v1&
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
bool bolIsExist = clsQxRoleMenusV2BL.IsExistRecord(strWhereCond);
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
 /// 调用方法: GET /api/QxRoleMenusV2Api/IsExist?RId=value
 /// (AutoGCLib.WA_Srv4CSharp:Gen_IsExist)
 /// </summary>
 /// <param name = "intRId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[HttpGet("IsExist")]
public ActionResult IsExist(int intRId,int intMeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["intRId"] = intRId.ToString()
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (intRId <= 0)
 {
string strMsg = string.Format("判断表中是否存在给定关键字的记录时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
bool bolIsExist = clsQxRoleMenusV2BL.IsExist(intRId,intMeId);
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
 /// 调用方法: POST /api/QxRoleMenusV2Api/AddNewRecord
 /// 在Body区传输objQxRoleMenusV2EN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
 /// </summary>
 /// <param name = "objQxRoleMenusV2EN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("AddNewRecord")]
public ActionResult AddNewRecord([FromBody]clsQxRoleMenusV2EN objQxRoleMenusV2EN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strQxRoleMenusV2JSONObj = clsJSON.GetJsonFromObj(objQxRoleMenusV2EN);
dictParam.Add("strQxRoleMenusV2JSONObj", strQxRoleMenusV2JSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (objQxRoleMenusV2EN.RId == 0)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 if (clsQxRoleMenusV2BL.IsExist(objQxRoleMenusV2EN.RId,objQxRoleMenusV2EN.MeId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!({1})", objQxRoleMenusV2EN.RId, clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
    clsQxRoleMenusV2BL.AccessFldValueNull(objQxRoleMenusV2EN);
bool bolResult = objQxRoleMenusV2EN.AddNewRecord();
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
 /// 调用方法: POST /api/QxRoleMenusV2Api/AddNewRecordWithReturnKey
 /// 在Body区传输objQxRoleMenusV2EN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objQxRoleMenusV2EN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
[HttpPost("AddNewRecordWithReturnKey")]
public ActionResult AddNewRecordWithReturnKey(clsQxRoleMenusV2EN objQxRoleMenusV2EN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WebApi.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
dictParam.Add("objQxRoleMenusV2EN", JsonConvert.SerializeObject(objQxRoleMenusV2EN));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
    clsQxRoleMenusV2BL.AccessFldValueNull(objQxRoleMenusV2EN);
string strKey = clsQxRoleMenusV2BL.AddNewRecordBySql2WithReturnKey(objQxRoleMenusV2EN);
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
 /// 调用方法: Post /api/QxRoleMenusV2Api/UpdateRecord
 /// 在Body区传输objQxRoleMenusV2EN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateRecord)
 /// </summary>
 /// <param name = "strQxRoleMenusV2JSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[HttpPost("UpdateRecord")]
public ActionResult UpdateRecord([FromBody]clsQxRoleMenusV2EN objQxRoleMenusV2EN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strQxRoleMenusV2JSONObj = clsJSON.GetJsonFromObj(objQxRoleMenusV2EN);
dictParam.Add("strQxRoleMenusV2JSONObj", strQxRoleMenusV2JSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (objQxRoleMenusV2EN.RId <= 0)
 {
string strMsg = string.Format("修改记录时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
    clsQxRoleMenusV2BL.SetUpdFlag(objQxRoleMenusV2EN);
    clsQxRoleMenusV2BL.AccessFldValueNull(objQxRoleMenusV2EN);
bool bolResult = objQxRoleMenusV2EN.Update();
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
 /// 调用方法: Post /api/QxRoleMenusV2Api/UpdateWithCondition
 /// 在Body区传输objQxRoleMenusV2EN的JSON对象和strWhereCond条件串
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateWithCondition)
 /// </summary>
 /// <param name = "strQxRoleMenusV2JSONObj">JSON对象字符串</param>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>是否成功</returns>
[HttpPost("UpdateWithCondition")]
public ActionResult UpdateWithCondition(clsQxRoleMenusV2EN objQxRoleMenusV2EN, string strWhereCond)
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
    clsQxRoleMenusV2BL.AccessFldValueNull(objQxRoleMenusV2EN);
bool bolResult = objQxRoleMenusV2EN.UpdateWithCondition(strWhereCond);
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
 /// 调用方法: DELETE /api/QxRoleMenusV2Api/DelRecord/Id
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecord)
 /// </summary>
 /// <param name = "intRId">给定的关键字值</param>
 /// <param name = "intMeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
[HttpGet("DelRecKeyLst")]
public ActionResult DelRecKeyLst(int intRId,int intMeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["RId"] = intRId.ToString(),
["MeId"] = intMeId.ToString(),
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (intRId <= 0)
 {
string strMsg = string.Format("删除关键字所指定的记录，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 if (intMeId <= 0)
 {
string strMsg = string.Format("删除关键字所指定的记录，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intRecNum = clsQxRoleMenusV2BL.DelRecord(intRId,intMeId);
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
 /// 调用方法: POST /api/QxRoleMenusV2Api/DelRecords
 /// 在Body区传输strKeyIdLst字符串列表的JSON串
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecords)
 /// </summary>
 /// <param name = "arrKeyLsts">给定的关键字值列表的JSON串</param>
 /// <returns>返回删除的记录数</returns>
[HttpPost("DelRecKeyLsts")]
public ActionResult DelRecKeyLsts([FromBody]string[] arrKeyLsts)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrKey = new(arrKeyLsts);
dictParam.Add("arrKeyLsts", clsArray.GetSqlInStrByArray(arrKey,true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
  if (arrKeyLsts.Length == 0)
 {
string strMsg = string.Format("根据关键字列表串删除记录时，给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intRecNum = clsQxRoleMenusV2BL.DelRecKeyLsts(arrKey);
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
 /// 调用方法: POST /api/QxRoleMenusV2Api/DelQxRoleMenusV2sByCond
 /// 在Body区传输{"strWhereCond":"1=1"}
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[HttpGet("DelQxRoleMenusV2sByCond")]
public ActionResult DelQxRoleMenusV2sByCond(string strWhereCond)
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
int intRecNum = clsQxRoleMenusV2BL.DelQxRoleMenusV2sByCond(strWhereCond);
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