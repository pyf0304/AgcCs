
/*-- -- -- -- -- -- -- -- -- -- --
类名:vDnFuncMap_SimExApiController
表名:vDnFuncMap_Sim(00050625)
* 版本:2023.07.16.1(服务器:PYF-THINKPAD)
日期:2023/07/18 17:14:42
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
相关数据库:109.244.40.104,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:AI模块(AIModule)
框架-层名:WA_服务扩展层(CS)(WA_SrvEx)
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
using AGC.BusinessLogicEx;

using com.taishsoft.common;
using com.taishsoft.datetime;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json.Linq;
using Comm.WebApi;
using AGC.BusinessLogic;
using Microsoft.AspNetCore.Authorization;

namespace AGC.WebApi
{
    /// <summary>
    /// vDnFuncMap_SimExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class vDnFuncMap_SimExApiController : ControllerBase
    {


        /// <summary>
        /// 根据DataNodeId获取对象，并且把UsedTimes加1
        /// 调用方法: Get /api/clsvDnFuncMap_SimBLExApi/GetObjByDnFuncMapIdEx?strDnFuncMapId=value&strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strDnFuncMapId">结点映射Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回是否存在?</returns>
         [AllowAnonymous]
        [HttpGet("GetObjByDnFuncMapIdEx")]
        public ActionResult GetObjByDnFuncMapIdEx(string strDnFuncMapId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strDnFuncMapId", strDnFuncMapId);
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsvDnFuncMap_SimBLEx.GetObjByDnFuncMapIdEx(strDnFuncMapId, strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnObj = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据OutDataNodeId获取对象列表，并且把UsedTimes加1
        /// 调用方法: Get /api/clsvDnFuncMap_SimBLExApi/GetObjLstByOutDataNodeIdEx?strOutDataNodeId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strOutDataNodeId">Out结点Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetObjLstByOutDataNodeIdEx")]
        public ActionResult GetObjLstByOutDataNodeIdEx(long strOutDataNodeId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strOutDataNodeId", strOutDataNodeId.ToString());
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsvDnFuncMap_SimBLEx.GetObjLstByOutDataNodeIdEx(strOutDataNodeId);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }



        /// <summary>
        /// 根据OutDataNodeId获取对象列表，并且把UsedTimes加1
        /// 调用方法: Get /api/clsvDnFuncMap_SimBLExApi/GetObjLstByOutDataNodeIdEx?strOutDataNodeId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strInDataNodeId">Out结点Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetObjLstByInDataNodeIdEx")]
        public ActionResult GetObjLstByInDataNodeIdEx(long strInDataNodeId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strInDataNodeId", strInDataNodeId.ToString());
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsvDnFuncMap_SimBLEx.GetObjLstByInDataNodeIdEx(strInDataNodeId);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据In-OutDataNodeId获取对象，并且把UsedTimes加1
        /// 调用方法: Get /api/clsvDnFuncMap_SimBLExApi/GetObjByInOutDataNodeIdEx?strInDataNodeId=value&strOutDataNodeId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strInDataNodeId">In结点Id</param>
        /// <param name = "strOutDataNodeId">Out结点Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetObjByInOutDataNodeIdEx")]
        public ActionResult GetObjByInOutDataNodeIdEx(long strInDataNodeId, long strOutDataNodeId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strInDataNodeId", strInDataNodeId.ToString());
            dictParam.Add("strOutDataNodeId", strOutDataNodeId.ToString());
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsvDnFuncMap_SimBLEx.GetObjByInOutDataNodeIdEx(strInDataNodeId, strOutDataNodeId);
                return Ok(new { errorId = 0, errorMsg = "", returnObj = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}