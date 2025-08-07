
/*-- -- -- -- -- -- -- -- -- -- --
类名:Log4GeneViewCodeExApiController
表名:Log4GeneViewCode(00050280)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:39:59
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:日志管理
模块英文名:LogManage
框架-层名:WebApi扩展层(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using com.taishsoft.json;
using AGC.Entity;
using AGC.BusinessLogic;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;

using System.Net;
using AGC.BusinessLogicEx;
using Newtonsoft.Json.Linq; using Comm.WebApi;
using Microsoft.AspNetCore.Mvc;

namespace AGC.WebApi
{
    /// <summary>
    /// Log4GeneViewCodeExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class Log4GeneViewCodeExApiController : Log4GeneViewCodeApiController
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public Log4GeneViewCodeExApiController()
        {
        }

        /// <summary>
        /// AddLog4GeneViewCode
        /// 调用方法: Get /api/Log4GeneTabCodeExApiControllerApi/AddLog4GeneTabCode?strViewId=value&strUserId=value&strVersion=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strViewId">表Id</param>
        /// <param name = "strUserId">strUserId</param>
        /// <param name = "strVersion">版本</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("AddLog4GeneViewCode")]
        public ActionResult AddLog4GeneViewCode(string strViewId, string strUserId, string strVersion)
        {

            if (strVersion == "null") strVersion = "";
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewId", strViewId);            
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strVersion", strVersion);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, strUserId, dictParam);
            try
            {
                var varResult = clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(strViewId, strUserId, strVersion);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }
    }
}