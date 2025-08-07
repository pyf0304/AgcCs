
/*-- -- -- -- -- -- -- -- -- -- --
类名:ViewInfoCmPrjIdRelaExApiController
表名:ViewInfoCmPrjIdRela(00050621)
* 版本:2023.02.24.1(服务器:WIN-SRV103-116)
日期:2023/03/01 22:31:21
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
相关数据库:109.244.40.104,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:界面管理(PrjInterface)
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

namespace AGC.WebApi
{
    /// <summary>
    /// ViewInfoCmPrjIdRelaExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ViewInfoCmPrjIdRelaExApiController : ControllerBase
    {

        /// <summary>
        /// 建立Cm工程与表的关系
        /// 调用方法: Get /api/clsViewInfoCmPrjIdRelaBLExApi/CreateRela?strCmPrjId=value&strViewId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <param name = "strViewId">表Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CreateRela")]
        public ActionResult CreateRela(string strCmPrjId, string strViewId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strCmPrjId", strCmPrjId);
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsViewInfoCmPrjIdRelaBLEx.CreateRela(strCmPrjId, strViewId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 删除Cm工程与表的关系
        /// 调用方法: Get /api/clsViewInfoCmPrjIdRelaBLExApi/DelRela?strCmPrjId=value&strViewId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <param name = "strViewId">表Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("DelRela")]
        public ActionResult DelRela(string strCmPrjId, string strViewId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strCmPrjId", strCmPrjId);
            dictParam.Add("strViewId", strViewId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsViewInfoCmPrjIdRelaBLEx.DelRela(strCmPrjId, strViewId);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}