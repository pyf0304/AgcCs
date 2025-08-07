
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
using System.Data.Common;

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
    }
}