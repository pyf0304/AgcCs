
/*-- -- -- -- -- -- -- -- -- -- --
类名:QxRolesApiController
表名:QxRoles(00140014)
* 版本:2023.12.26.1(服务器:WIN-SRV103-116)
日期:2023/12/28 23:01:28
生成者:pyf
生成服务器IP:
工程名称:统一平台(0014)
CM工程:WebApi后台(变量首字母不限定)-WebApi函数集
相关数据库:109.244.40.104,9433GeneralPlatformTz
PrjDataBaseId:0218
模块中文名:用户管理(UserManage_GP)
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
using Newtonsoft.Json.Linq;
using Comm.WebApi;

namespace GeneralPlatform.WebApi
{
    /// <summary>
    /// QxRolesController 的摘要说明
    /// (AutoGCLib.WA_Srv4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class QxRolesApiController : ControllerBase
    {

        /// <summary>
        /// 获取当前关键字的记录对象,用对象的形式表示.
        /// 调用方法: GET /api/QxRolesApi/GetObjByRoleId?RoleId=value
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjByKeyId)
        /// </summary>
        /// <param name = "strRoleId">表关键字</param>
        /// <returns>表对象</returns>
        [HttpGet("GetObjByRoleId")]
        public ActionResult GetObjByRoleId(string strRoleId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {
                ["strRoleId"] = strRoleId,
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("根据关键字获取对象时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                clsQxRolesEN objQxRolesEN = clsQxRolesBL.GetObjByRoleId(strRoleId);
                return Ok(new { errorId = 0, errorMsg = "", returnObj = objQxRolesEN });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/QxRolesApi/GetObjLst?strWhereCond=v1&
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
                List<clsQxRolesEN> arrQxRolesObjLst = clsQxRolesBL.GetObjLst(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxRolesObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/QxRolesApi/GetObjLst_Cache?
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
                List<clsQxRolesEN> arrQxRolesObjLst = clsQxRolesBL.GetObjLstCache();
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxRolesObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据关键字列表获取相关对象列表
        /// 调用方法: POST /api/QxRolesapi/GetObjLstByRoleIdLst
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLst)
        /// </summary>
        /// <param name = "arrRoleIdLst">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        [HttpPost("GetObjLstByRoleIdLst")]
        public ActionResult GetObjLstByRoleIdLst([FromBody] string[] arrRoleId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            List<string> arrLst = new(arrRoleId);
            dictParam.Add("arrRoleId", clsArray.GetSqlInStrByArray(arrLst, true));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (arrRoleId.Length == 0)
            {
                string strMsg = string.Format("根据关键字列表串获取对象列表时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            List<string> lstRoleId = new(arrRoleId);
            try
            {
                List<clsQxRolesEN> arrQxRolesObjLst = clsQxRolesBL.GetObjLstByRoleIdLst(lstRoleId);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxRolesObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据关键字列表获取相关对象列表
        /// 调用方法: POST /api/QxRolesapi/GetObjLstByRoleIdLst
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLstCache)
        /// </summary>
        /// <param name = "arrRoleIdLst">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        [HttpPost("GetObjLstByRoleIdLstCache")]
        public ActionResult GetObjLstByRoleIdLstCache([FromBody] string[] arrRoleId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            List<string> arrLst = new(arrRoleId);
            dictParam.Add("arrRoleId", clsArray.GetSqlInStrByArray(arrLst, true));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (arrRoleId.Length == 0)
            {
                string strMsg = string.Format("根据关键字列表串获取对象列表时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            List<string> lstRoleId = new(arrRoleId);
            try
            {
                IEnumerable<clsQxRolesEN> arrQxRolesObjLst = clsQxRolesBL.GetObjLstByRoleIdLstCache(lstRoleId);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxRolesObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件获取顶部对象列表
        /// 调用方法: GET /api/QxRolesApi/GetTopObjLst?intTopSize=v1&strOrderBy=v2&strWhereCond=v3&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetTopObjLst)
        /// </summary>
        /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
        /// <returns>返回对象列表</returns>
        [HttpPost("GetTopObjLst")]
        public ActionResult GetTopObjLst([FromBody] stuTopPara objTopPara)
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
                List<clsQxRolesEN> arrQxRolesObjLst = clsQxRolesBL.GetTopObjLst(objTopPara);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxRolesObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// 调用方法: GET /api/QxRolesApi/GetFirstID?strWhereCond=v1&
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
            string strRoleId;
            try
            {
                strRoleId = clsQxRolesBL.GetFirstID_S(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = strRoleId });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的对象
        /// 调用方法: GET /api/QxRolesApi/GetFirstObj?strWhereCond=v1&
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
                clsQxRolesEN objQxRolesEN = clsQxRolesBL.GetFirstObj_S(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnObj = objQxRolesEN });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件分页获取JSON对象列表
        /// 调用方法: GET /api/QxRolesApi/GetObjLstByPager?intPageIndex=v1&intPageSize=v2&strOrderBy=v3&strWhereCond=v4&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByPager)
        /// </summary>
        /// <param name = "objPagerPara">分页获取记录的参数对象</param>
        /// <returns>返回JSON对象列表</returns>
        [HttpPost("GetObjLstByPager")]
        public ActionResult GetObjLstByPager([FromBody] stuPagerPara objPagerPara)
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
            if (objPagerPara.pageSize <= 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表,每页记录数:[{0}]不能小于等于0!({1})", objPagerPara.pageSize, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            if (objPagerPara.pageIndex <= 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表,页序号:[{0}]不能小于等于0!({1})", objPagerPara.pageIndex, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            List<clsQxRolesEN> arrQxRolesObjLst;
            try
            {
                arrQxRolesObjLst = clsQxRolesBL.GetObjLstByPager(objPagerPara);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrQxRolesObjLst });
        }

        /// <summary>
        /// 功能:获取某一条件的记录数
        /// 调用方法: GET /api/QxRolesApi/GetRecCountByCond?strWhereCond=v1&
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
                int intCount = clsQxRolesBL.GetRecCountByCond(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
        /// 调用方法: GET /api/QxRolesApi/GetFldValue?strWhereCond=v1&strFldName=v2&strTabName=v3&
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
                List<string> arrList = clsQxRolesBL.GetFldValue(strFldName, strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", arrList) });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
        /// 调用方法: GET /api/QxRolesApi/funSetFldValue?strCondition=v1&strFldName=v2&strTabName=v3&varValue=v4&
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
                int intRecCount = clsQxRolesBL.SetFldValue(clsQxRolesEN._CurrTabName, strFldName, strValue, strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecCount });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:判断是否存在某一条件的记录
        /// 调用方法: GET /api/QxRolesApi/IsExistRecord?strWhereCond=v1&
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
                bool bolIsExist = clsQxRolesBL.IsExistRecord(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolIsExist });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 判断当前表中是否存在给定关键字值的记录
        /// 调用方法: GET /api/QxRolesApi/IsExist?RoleId=value
        /// (AutoGCLib.WA_Srv4CSharp:Gen_IsExist)
        /// </summary>
        /// <param name = "strRoleId">给定的关键字值</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("IsExist")]
        public ActionResult IsExist(string strRoleId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {
                ["strRoleId"] = strRoleId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("判断表中是否存在给定关键字的记录时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                bool bolIsExist = clsQxRolesBL.IsExist(strRoleId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolIsExist });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 获取当前表关键字值的最大值,再加1,避免重复
        /// 调用方法: GET /api/QxRolesApi/GetMaxStrIdByPrefix?strPrefix=v1&
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
                string strMaxstrRoleId = clsQxRolesBL.GetMaxStrIdByPrefix_S(strPrefix);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = strMaxstrRoleId });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/QxRolesApi/AddNewRecord
        /// 在Body区传输objQxRolesEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
        /// </summary>
        /// <param name = "objQxRolesEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost("AddNewRecord")]
        public ActionResult AddNewRecord([FromBody] clsQxRolesEN objQxRolesEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            string strQxRolesJSONObj = clsJSON.GetJsonFromObj(objQxRolesEN);
            dictParam.Add("strQxRolesJSONObj", strQxRolesJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objQxRolesEN.RoleId) == true)
            {
                string strMsg = string.Format("添加记录时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            if (clsQxRolesBL.IsExist(objQxRolesEN.RoleId) == true)
            {
                string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!({1})", objQxRolesEN.RoleId, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                clsQxRolesEN objQxRolesCond = new();
                string strCondition = objQxRolesCond
                .SetRoleName(objQxRolesEN.RoleName, "=")
                .SetQxPrjId(objQxRolesEN.QxPrjId, "=")
                .GetCombineCondition();
                bool bolIsExist = clsQxRolesBL.IsExistRecord(strCondition);
                if (bolIsExist)
                {
                    string strMsg = string.Format("满足条件:{0}的记录表中已经存在,违反了唯一性.(from {1})", strCondition, clsStackTrace.GetCurrClassFunction());
                    clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                    return Ok(new { errorId = 1, errorMsg = strMsg });
                }
                clsQxRolesBL.AccessFldValueNull(objQxRolesEN);
                bool bolResult = objQxRolesEN.AddNewRecord();
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        // 表:QxRoles的主键是前缀自增,但该表中没有一个相关的前缀字段。请检查!(In AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithMaxId)

        /// <summary>
        /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
        /// 调用方法: POST /api/QxRolesApi/AddNewRecordWithReturnKey
        /// 在Body区传输objQxRolesEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
        /// </summary>
        /// <param name = "objQxRolesEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>
        [HttpPost("AddNewRecordWithReturnKey")]
        public ActionResult AddNewRecordWithReturnKey(clsQxRolesEN objQxRolesEN)
        {
            if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
            {
                clsPubVar_WebApi.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空,请检查!");
            }
            else
            {
                string strFunctionName = clsStackTrace.GetCurrFunction();
                Dictionary<string, string> dictParam = new();
                dictParam.Add("objQxRolesEN", JsonConvert.SerializeObject(objQxRolesEN));
                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            }
            try
            {
                clsQxRolesBL.AccessFldValueNull(objQxRolesEN);
                string strKey = clsQxRolesBL.AddNewRecordBySql2WithReturnKey(objQxRolesEN);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = strKey });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 通过JSON对象来修改记录对象
        /// 调用方法: Post /api/QxRolesApi/UpdateRecord
        /// 在Body区传输objQxRolesEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateRecord)
        /// </summary>
        /// <param name = "strQxRolesJSONObj">JSON对象字符串</param>
        /// <returns>是否成功</returns>
        [HttpPost("UpdateRecord")]
        public ActionResult UpdateRecord([FromBody] clsQxRolesEN objQxRolesEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            string strQxRolesJSONObj = clsJSON.GetJsonFromObj(objQxRolesEN);
            dictParam.Add("strQxRolesJSONObj", strQxRolesJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objQxRolesEN.RoleId) == true)
            {
                string strMsg = string.Format("修改记录时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                clsQxRolesBL.SetUpdFlag(objQxRolesEN);
                clsQxRolesBL.AccessFldValueNull(objQxRolesEN);
                bool bolResult = objQxRolesEN.Update();
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件来修改记录对象
        /// 调用方法: Post /api/QxRolesApi/UpdateWithCondition
        /// 在Body区传输objQxRolesEN的JSON对象和strWhereCond条件串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateWithCondition)
        /// </summary>
        /// <param name = "strQxRolesJSONObj">JSON对象字符串</param>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>是否成功</returns>
        [HttpPost("UpdateWithCondition")]
        public ActionResult UpdateWithCondition(clsQxRolesEN objQxRolesEN, string strWhereCond)
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
                clsQxRolesBL.AccessFldValueNull(objQxRolesEN);
                bool bolResult = objQxRolesEN.UpdateWithCondition(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:删除关键字所指定的记录
        /// 调用方法: DELETE /api/QxRolesApi/DelRecord/Id
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecord)
        /// </summary>
        /// <param name = "Id">给定的关键字值</param>
        /// <returns>返回删除的记录数</returns>
        [HttpDelete("DelRecord")]
        public ActionResult DelRecord(string Id)
        {
            string strRoleId = Id;
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {
                ["Id"] = strRoleId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("删除关键字所指定的记录,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                int intRecNum = clsQxRolesBL.DelRecord(strRoleId);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:同时删除多条记录,删除给定关键字列表的记录
        /// 调用方法: POST /api/QxRolesApi/DelQxRoless
        /// 在Body区传输arrRoleId(关键字值列表)的JSON串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecord)
        /// </summary>
        /// <param name = "arrRoleId">给定的关键字值列表</param>
        /// <returns>返回删除的记录数</returns>
        [HttpPost("DelQxRoless")]
        public ActionResult DelQxRoless([FromBody] string[] arrRoleId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            List<string> arrLst = new(arrRoleId);
            dictParam.Add("arrRoleId", clsArray.GetSqlInStrByArray(arrLst, true));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                int intRecNum = clsQxRolesBL.DelQxRoless(arrLst);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:同时删除多条记录,删除给定关键字列表的记录, 通过JSON串
        /// 调用方法: POST /api/QxRolesApi/DelRecords
        /// 在Body区传输strKeyIdLst字符串列表的JSON串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecords)
        /// </summary>
        /// <param name = "strKeyIdLst">给定的关键字值列表的JSON串</param>
        /// <returns>返回删除的记录数</returns>
        [HttpPost("DelRecords")]
        public ActionResult DelRecords([FromBody] string[] strKeyIdLst)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            List<string> arrKey = new(strKeyIdLst);
            dictParam.Add("strKeyIdLst", clsArray.GetSqlInStrByArray(arrKey, true));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (strKeyIdLst.Length == 0)
            {
                string strMsg = string.Format("根据关键字列表串删除记录时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                int intRecNum = clsQxRolesBL.DelQxRoless(arrKey);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:删除满足条件的多条记录
        /// 调用方法: POST /api/QxRolesApi/DelQxRolessByCond
        /// 在Body区传输{"strWhereCond":"1=1"}
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecordByCond)
        /// </summary>
        /// <param name = "strWhereCond">需要删除的记录条件</param>
        /// <returns>返回删除的记录数。</returns>
        [HttpGet("DelQxRolessByCond")]
        public ActionResult DelQxRolessByCond(string strWhereCond)
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
                int intRecNum = clsQxRolesBL.DelQxRolessByCond(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}