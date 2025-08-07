
/*-- -- -- -- -- -- -- -- -- -- --
类名:GCVariablePrjIdRelaExApiController
表名:GCVariablePrjIdRela(00050617)
* 版本:2023.02.18.1(服务器:WIN-SRV103-116)
日期:2023/02/18 15:38:27
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
using Microsoft.AspNetCore.Authorization;

namespace AGC.WebApi
{
    /// <summary>
    /// GCVariablePrjIdRelaExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class GCVariablePrjIdRelaExApiController : ControllerBase
    {

        /// <summary>
        /// 修改某工程下的FldId,与PrjId 不相符的
        /// 调用方法: Get /api/clsGCVariablePrjIdRelaBLExApi/UpdFldIdByPrjId?strPrjId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [AllowAnonymous]
        [HttpGet("UpdFldIdByPrjId")]
        public ActionResult UpdFldIdByPrjId(string strPrjId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsGCVariablePrjIdRelaBLEx.UpdFldIdByPrjId(strPrjId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 修改某工程下的VarId的FldId,
        /// 调用方法: Get /api/clsGCVariablePrjIdRelaBLExApi/UpdFldIdByVarId?strPrjId=value&strVarId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strVarId">变量Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("UpdFldIdByVarId")]
        public ActionResult UpdFldIdByVarId(string strPrjId, string strVarId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strVarId", strVarId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsGCVariablePrjIdRelaBLEx.UpdFldIdByVarId(strPrjId, strVarId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}