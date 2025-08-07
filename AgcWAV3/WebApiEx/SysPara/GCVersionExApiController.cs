
/*-- -- -- -- -- -- -- -- -- -- --
类名:GCVersionExApiController
表名:GCVersion(00050500)
生成代码版本:2020.01.01.1
生成日期:2020/01/02 11:25:57
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:系统参数
模块英文名:SysPara
框架-层名:WA_服务扩展层(WA_SrvEx)
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
using Newtonsoft.Json.Linq; using Comm.WebApi;
using AGC.BusinessLogicEx;
using Newtonsoft.Json;

namespace AGC.WebApi
{
    /// <summary>
    /// GCVersionExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class GCVersionExApiController : GCVersionApiController
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public GCVersionExApiController()
        {
        }

        /// <summary>
        /// GetNewestVersionObj
        /// 调用方法: Get /api/GCVersionExApiControllerApi/GetNewestVersionObj?
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetNewestVersionObj")]
        public ActionResult GetNewestVersionObj()
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsGCVersionBLEx.GetNewestVersionObj();
                
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