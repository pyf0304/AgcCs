
/*-- -- -- -- -- -- -- -- -- -- --
类名:ViewIdGCVariableRelaExApiController
表名:ViewIdGCVariableRela(00050631)
* 版本:2024.05.19.1(服务器:WIN-SRV103-116)
日期:2024/05/23 20:26:17
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
相关数据库:109.244.40.104,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成代码(GeneCode)
框架-层名:WA_服务扩展层(CS)(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.json;
using Comm.WebApi;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Net;
using System.Text;

namespace AGC.WebApi
{
    /// <summary>
    /// ViewIdGCVariableRelaExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ViewIdGCVariableRelaExApiController : ControllerBase
    {
        /// <summary>
        /// 获取界面变量
        /// 调用方法: Get /api/clsViewIdGCVariableRelaBLExApi/GetViewVar?strViewId=value&strPrjId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [AllowAnonymous]
        [HttpGet("GetViewVar")]
        public ActionResult GetViewVar(string strViewId, string strPrjId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsViewIdGCVariableRelaBLEx.GetViewVar(strViewId, strPrjId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        [AllowAnonymous]
        [HttpGet("GetViewVarAll")]
        public ActionResult GetViewVarAllByCmPrjId(string strCmPrjId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //dictParam.Add("strViewId", strViewId);
            dictParam.Add("strCmPrjId", strCmPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {

                var arrViewId = clsViewInfoCmPrjIdRelaBLEx.GetViewIdLstByCmPrjId(strCmPrjId);
                int intCount = 0;
                foreach (var strViewId in arrViewId)
                {
                    try
                    {
                        var srCondition = $"{conViewIdGCVariableRela.ViewId}='{strViewId}'";
                        var intRecNum = clsViewIdGCVariableRelaBL.GetRecCountByCond(srCondition);
                        if (intRecNum > 0) continue;
                        string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
                        var varResult = clsViewIdGCVariableRelaBLEx.GetViewVar(strViewId, strPrjId, strOpUserId);
                        if (varResult == true) intCount++;
                    }
                    catch (Exception objEx)
                    {
                        string strMsg = string.Format("当ViewId={0}时,{1}.(from {2})", strViewId, objEx.Message, clsStackTrace.GetCurrClassFunction());
                        return Ok(new { errorId = 1, errorMsg = strMsg });
                    }
                }
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 获取指定界面的所有变量名称列表（逗号分隔）
        /// 调用方法: GET /ViewIdGCVariableRelaEx/GetAllViewVarNames?strViewId=value&strPrjId=value
        /// </summary>
        /// <param name="strViewId">界面Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>返回变量名称列表（逗号分隔的字符串）</returns>
        [AllowAnonymous]
        [HttpGet("GetAllViewVarNames")]
        public ActionResult GetAllViewVarNames(string strViewId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                // 参数验证
                if (string.IsNullOrEmpty(strViewId))
                {
                    return Ok(new { errorId = 1, errorMsg = "参数 strViewId 不能为空", returnString = "" });
                }

                if (string.IsNullOrEmpty(strPrjId))
                {
                    return Ok(new { errorId = 1, errorMsg = "参数 strPrjId 不能为空", returnString = "" });
                }

                // 调用业务逻辑层方法
                string strResult = clsViewIdGCVariableRelaBLEx.GetAllViewVarNames(strViewId, strPrjId);

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    returnString = strResult ?? "",
                    varNames = string.IsNullOrEmpty(strResult) ? new string[0] : strResult.Split(',')
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg, returnString = "" });
            }
        }

        /// <summary>
        /// 获取指定界面的所有变量名称列表（POST方式）
        /// 调用方法: POST /ViewIdGCVariableRelaEx/GetAllViewVarNames
        /// </summary>
        /// <param name="request">包含界面Id和工程Id的请求对象</param>
        /// <returns>返回变量名称列表（逗号分隔的字符串）</returns>
        [AllowAnonymous]
        [HttpPost("GetAllViewVarNames")]
        public ActionResult GetAllViewVarNamesPost([FromBody] GetAllViewVarNamesRequest request)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();

            try
            {
                // 参数验证
                if (request == null)
                {
                    return Ok(new { errorId = 1, errorMsg = "请求参数不能为空", returnString = "" });
                }

                dictParam.Add("strViewId", request.ViewId ?? "");
                dictParam.Add("strPrjId", request.PrjId ?? "");
                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

                if (string.IsNullOrEmpty(request.ViewId))
                {
                    return Ok(new { errorId = 1, errorMsg = "参数 ViewId 不能为空", returnString = "" });
                }

                if (string.IsNullOrEmpty(request.PrjId))
                {
                    return Ok(new { errorId = 1, errorMsg = "参数 PrjId 不能为空", returnString = "" });
                }

                // 调用业务逻辑层方法
                string strResult = clsViewIdGCVariableRelaBLEx.GetAllViewVarNames(request.ViewId, request.PrjId);

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    returnString = strResult ?? "",
                    varNames = string.IsNullOrEmpty(strResult) ? new string[0] : strResult.Split(',')
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg, returnString = "" });
            }
        }
        /// <summary>
        /// 获取指定界面的所有界面变量对象列表
        /// 调用方法: GET /ViewIdGCVariableRelaEx/GetAllViewVariableObjs?strViewId=value&strPrjId=value
        /// </summary>
        /// <param name="strViewId">界面Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>返回界面变量对象列表</returns>
        [AllowAnonymous]
        [HttpGet("GetAllViewVariableObjs")]
        public ActionResult GetAllViewVariableObjs(string strViewId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                // 参数验证
                if (string.IsNullOrEmpty(strViewId))
                {
                    return Ok(new { errorId = 1, errorMsg = "参数 strViewId 不能为空", viewVariables = new List<clsViewVariable>() });
                }

                if (string.IsNullOrEmpty(strPrjId))
                {
                    return Ok(new { errorId = 1, errorMsg = "参数 strPrjId 不能为空", viewVariables = new List<clsViewVariable>() });
                }

                // 调用业务逻辑层方法
                List<clsViewVariable> arrViewVariables = clsViewIdGCVariableRelaBLEx.GetAllViewVariableObjs(strViewId, strPrjId);

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    viewVariables = arrViewVariables ?? new List<clsViewVariable>(),
                    totalCount = arrViewVariables?.Count ?? 0
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg, viewVariables = new List<clsViewVariable>() });
            }
        }

        /// <summary>
        /// 获取指定界面的所有界面变量对象列表（POST方式）
        /// 调用方法: POST /ViewIdGCVariableRelaEx/GetAllViewVariableObjs
        /// </summary>
        /// <param name="request">包含界面Id和工程Id的请求对象</param>
        /// <returns>返回界面变量对象列表</returns>
        [AllowAnonymous]
        [HttpPost("GetAllViewVariableObjs")]
        public ActionResult GetAllViewVariableObjsPost([FromBody] GetAllViewVarNamesRequest request)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();

            try
            {
                // 参数验证
                if (request == null)
                {
                    return Ok(new { errorId = 1, errorMsg = "请求参数不能为空", viewVariables = new List<clsViewVariable>() });
                }

                dictParam.Add("strViewId", request.ViewId ?? "");
                dictParam.Add("strPrjId", request.PrjId ?? "");
                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

                if (string.IsNullOrEmpty(request.ViewId))
                {
                    return Ok(new { errorId = 1, errorMsg = "参数 ViewId 不能为空", viewVariables = new List<clsViewVariable>() });
                }

                if (string.IsNullOrEmpty(request.PrjId))
                {
                    return Ok(new { errorId = 1, errorMsg = "参数 PrjId 不能为空", viewVariables = new List<clsViewVariable>() });
                }

                // 调用业务逻辑层方法
                List<clsViewVariable> arrViewVariables = clsViewIdGCVariableRelaBLEx.GetAllViewVariableObjs(request.ViewId, request.PrjId);

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    viewVariables = arrViewVariables ?? new List<clsViewVariable>(),
                    totalCount = arrViewVariables?.Count ?? 0
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg, viewVariables = new List<clsViewVariable>() });
            }
        }

        /// <summary>
        /// 获取所有界面变量名称的请求参数类
        /// </summary>
        public class GetAllViewVarNamesRequest
        {
            /// <summary>
            /// 界面Id
            /// </summary>
            public string ViewId { get; set; }

            /// <summary>
            /// 工程Id
            /// </summary>
            public string PrjId { get; set; }
        }
    }
}