using AGC.BusinessLogicEx;
using com.taishsoft.commdb;
using com.taishsoft.common;
using Comm.WebApi;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;

namespace AGC.WebApiEx
{
    [ApiController]
    [Route("[controller]")]
    public class SqlApiController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet("DateTime_GetDataBaseDateTime14")]
        public ActionResult DateTime_GetDataBaseDateTime14()
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
           
            try
            {
                string strDateTime = clsDateTime_Db.GetDataBaseDateTime14();         
                
                return Ok(new { errorId = 0, errorMsg = "", returnStr = strDateTime });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        [HttpGet("DateTime_GetDataBaseDateTime")]
        public ActionResult DateTime_GetDataBaseDateTime()
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                DateTime strDateTime = clsDateTime_Db.GetDataBaseDateTime();            
                
                return Ok(new { errorId = 0, errorMsg = "", returnStr = strDateTime.ToString() });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/SqlApi/GetDataTable?strWhereCond=v1&strTabName=v2
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <param name = "strTabName">给定表名</param>
        /// <returns>返回DataTable</returns>
        [HttpGet("GetDataTable")]
        public ActionResult GetDataTable([FromQuery]string strCurrPrjDataBaseId, string strTabName, int intRecNum, string strWhereCond, string? strOrderBy)
        {

            if (strOrderBy == "null") strOrderBy = "";
            strWhereCond = strWhereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strCurrPrjDataBaseId"] = strCurrPrjDataBaseId,
                ["strTabName"] = strTabName,
                ["intRecNum"] = intRecNum.ToString(),
                ["strWhereCond"] = strWhereCond,
                ["strOrderBy"] = strOrderBy ?? ""
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strWhereCond) == true)
            {
                string strMsg = string.Format("根据条件获取DataTable，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
            if (string.IsNullOrEmpty(strTabName) == true)
            {
                string strMsg = string.Format("根据条件获取DataTable，表名不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
            try
            {
                //                DataTable objDT = clsCMClassBL.GetDataTable(strWhereCond, strTabName);
                DataTable objDT = clsTablesBLEx.GetDataTableByTop(strCurrPrjDataBaseId, strTabName, intRecNum, strWhereCond, strOrderBy);
                var arrDT = JsonConvert.SerializeObject(objDT);
                return Ok(new { errorId = 0, errorMsg = "", returnDataTable = arrDT });
            }
            catch (Exception objException)
            {
                clsGeneralTab.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                string strMsg = string.Format("在获取表内容（GetDataTableByTabName）时出错！表名：{0},出错信息：{1}。({2})",
                       strTabName, objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/SqlApi/GetColumnObjList?strCurrPrjDataBaseId=v1&strTabName=v2
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <param name = "strTabName">给定表名</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("GetColumnObjList")]
        public ActionResult GetColumnObjList( string strTabName, string strCurrPrjDataBaseId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strCurrPrjDataBaseId"] = strCurrPrjDataBaseId,
                ["strTabName"] = strTabName,
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strCurrPrjDataBaseId) == true)
            {
                string strMsg = string.Format("根据条件获取对象列表，PrjDataBaseId不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            if (string.IsNullOrEmpty(strTabName) == true)
            {
                string strMsg = string.Format("根据条件获取对象列表，表名不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                //                DataTable objDT = clsCMClassBL.GetDataTable(strWhereCond, strTabName);
                var arrColumnsObjLst = clsTablesBLEx.GetColumnObjList(strTabName, strCurrPrjDataBaseId);                
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrColumnsObjLst });
            }
            catch (Exception objException)
            {
                clsGeneralTab.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                string strMsg = string.Format("根据条件获取对象列表（GetColumnObjList）时出错！表名：{0},出错信息：{1}。({2})",
                       strTabName, objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }


        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/SqlApi/GetColumnObjList?strCurrPrjDataBaseId=v1&strTabName=v2
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <param name = "strTabName">给定表名</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("IsExistTable")]
        public ActionResult IsExistTable(string strTabName, string strCurrPrjDataBaseId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strCurrPrjDataBaseId"] = strCurrPrjDataBaseId,
                ["strTabName"] = strTabName,
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strCurrPrjDataBaseId) == true)
            {
                string strMsg = string.Format("根据条件获取对象列表，PrjDataBaseId不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
            if (string.IsNullOrEmpty(strTabName) == true)
            {
                string strMsg = string.Format("根据条件获取对象列表，表名不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
            try
            {
                //                DataTable objDT = clsCMClassBL.GetDataTable(strWhereCond, strTabName);
                var bolIsExist = clsTablesBLEx.IsExistTable(strTabName, strCurrPrjDataBaseId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolIsExist });
            }
            catch (Exception objException)
            {
                clsGeneralTab.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                string strMsg = string.Format("判断是否存在表时出错！表名：{0},出错信息：{1}。({2})",
                       strTabName, objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }


        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/SqlApi/GetDataTable?strCurrPrjDataBaseId=v1&strTabName=v2
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <param name = "strTabName">给定表名</param>
        /// <param name = "strKeyFldName">关键字段名</param>
        /// <param name = "strKeyValue">关键字段值</param>
        /// <param name = "bolIsNumurable">是否数值型</param>
        /// <returns>返回DataTable</returns>
        [HttpGet("GetDataTableByKey")]
        public ActionResult GetDataTableByKey(string strCurrPrjDataBaseId, string strTabName, string strKeyFldName, string strKeyValue, bool bolIsNumurable)
        {

            //strWhereCond = strWhereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strCurrPrjDataBaseId"] = strCurrPrjDataBaseId,
                ["strTabName"] = strTabName,
                ["strKeyFldName"] = strKeyFldName.ToString(),
                ["strKeyValue"] = strKeyValue,
                ["bolIsNumurable"] = bolIsNumurable.ToString()
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strKeyFldName) == true)
            {
                string strMsg = string.Format("根据关键字获取DataTable，关键字段不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
            if (string.IsNullOrEmpty(strTabName) == true)
            {
                string strMsg = string.Format("根据条件获取DataTable，表名不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
            try
            {
                //                DataTable objDT = clsCMClassBL.GetDataTable(strWhereCond, strTabName);
                DataTable objDT = clsTablesBLEx.GetDataTableByKey(strCurrPrjDataBaseId, strTabName, strKeyFldName, strKeyValue, bolIsNumurable);
                var arrDT = JsonConvert.SerializeObject(objDT);
                return Ok(new { errorId = 0, errorMsg = "", returnDataTable = arrDT });
            }
            catch (Exception objException)
            {
                clsGeneralTab.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                string strMsg = string.Format("在获取表内容（GetDataTableByTabName）时出错！表名：{0},出错信息：{1}。({2})",
                       strTabName, objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }


        /// <summary>
        /// 获取数据库中所有表
        /// 调用方法: GET /api/SqlApi/GetTableAndViewsByCond?strCurrPrjDataBaseId=v1&strWhereCond=v2
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <param name = "strCurrPrjDataBaseId">strCurrPrjDataBaseId</param>
        /// <returns>返回DataTable</returns>
        [HttpGet("GetTableAndViewsByCond")]
        public ActionResult GetTableAndViewsByCond(string strCurrPrjDataBaseId, string strWhereCond)
        {
            //public static DataTable GetTableAndViewsByCond(string strPrjDataBaseId, string strWhereCond)            

                //strWhereCond = strWhereCond.Replace("'% ", "'%");
                string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strCurrPrjDataBaseId"] = strCurrPrjDataBaseId,
                ["strWhereCond"] = strWhereCond
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strCurrPrjDataBaseId) == true)
            {
                string strMsg = string.Format("根据关键字获取DataTable，PrjDataBaseId段不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
            if (string.IsNullOrEmpty(strWhereCond) == true)
            {
                string strMsg = string.Format("根据条件获取DataTable，条件(strWhereCond)不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
            try
            {
                //                DataTable objDT = clsCMClassBL.GetDataTable(strWhereCond, strTabName);
                DataTable objDT = clsTablesBLEx.GetTableAndViewsByCond(strCurrPrjDataBaseId, strWhereCond);
                var arrDT = JsonConvert.SerializeObject(objDT);
                return Ok(new { errorId = 0, errorMsg = "", returnDataTable = arrDT });
            }
            catch (Exception objException)
            {
                clsGeneralTab.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                string strMsg = string.Format("在获取Sql服务器表数据（GetTableAndViewsByCond）时出错！PrjDataBaseId：{0},条件:[{1}]出错信息：{2}。({3})",
                       strCurrPrjDataBaseId, strWhereCond, objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

    }
}