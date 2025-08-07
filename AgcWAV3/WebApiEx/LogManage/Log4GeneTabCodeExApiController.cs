
/*-- -- -- -- -- -- -- -- -- -- --
类名:Log4GeneTabCodeExApiController
表名:Log4GeneTabCode(00050279)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:42:38
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
using Microsoft.AspNetCore.Mvc;
using System.Net;
using AGC.BusinessLogicEx;
using Newtonsoft.Json.Linq; using Comm.WebApi;

namespace AGC.WebApi
{
    /// <summary>
    /// Log4GeneTabCodeExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class Log4GeneTabCodeExApiController : Log4GeneTabCodeApiController
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public Log4GeneTabCodeExApiController()
        {
        }

        /// <summary>
        /// AddLog4GeneTabCode
        /// 调用方法: Get /api/Log4GeneTabCodeExApiControllerApi/AddLog4GeneTabCode?strTabId=value&intApplicationTypeId=value&strUserId=value&strVersion=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "intApplicationTypeId">intApplicationTypeId</param>
        /// <param name = "strUserId">strUserId</param>
        /// <param name = "strVersion">版本</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("AddLog4GeneTabCode")]
        public ActionResult AddLog4GeneTabCode(string strTabId, string strGCPathId, int intApplicationTypeId, string strUserId, string strVersion)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strGCPathId", strGCPathId);
            dictParam.Add("intApplicationTypeId", intApplicationTypeId.ToString());
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strVersion", strVersion);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, strUserId, dictParam);
            try
            {
                var varResult = clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(strTabId, strGCPathId, intApplicationTypeId, strUserId, strVersion);
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