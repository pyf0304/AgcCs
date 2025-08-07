
/*-- -- -- -- -- -- -- -- -- -- --
类名:vDataNode_SimExApiController
表名:vDataNode_Sim(00050592)
生成代码版本:2021.11.07.2
生成日期:2021/11/09 01:39:36
生成者:pyf
生成服务器IP:109.244.40.104
工程名称:AGC
工程ID:0005
相关数据库:109.244.40.104,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:AI模块
模块英文名:AIModule
框架-层名:WA_服务扩展层(WA_SrvEx)
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
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json.Linq;
using Comm.WebApi;
using Microsoft.AspNetCore.Authorization;

namespace AGC.WebApi
{
    /// <summary>
    /// vDataNode_SimExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class vDataNode_SimExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public vDataNode_SimExApiController()
        {
        }

        /// <summary>
        /// 根据DataNodeId获取对象，并且把UsedTimes加1
        /// 调用方法: Get /api/clsvDataNode_SimBLExApi/GetObjByDataNodeIdEx?strPrjId=value&strDataNodeId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strDataNodeId">数据结点Id</param>
        /// <returns>返回是否存在?</returns>
        [AllowAnonymous]
        [HttpGet("GetObjByDataNodeIdEx")]
        public ActionResult GetObjByDataNodeIdEx(long strDataNodeId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strDataNodeId", strDataNodeId.ToString());
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsvDataNode_SimBLEx.GetObjByDataNodeIdEx(strDataNodeId, strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnObj = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 根据TabId获取对象列表，并且把UsedTimes加1
        /// 调用方法: Get /api/clsvDataNode_SimBLExApi/GetObjLstByTabIdEx?strTabId=value&strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetObjLstByTabIdEx")]
        public ActionResult GetObjLstByTabIdEx(string strTabId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsvDataNode_SimBLEx.GetObjLstByTabIdEx(strTabId);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}