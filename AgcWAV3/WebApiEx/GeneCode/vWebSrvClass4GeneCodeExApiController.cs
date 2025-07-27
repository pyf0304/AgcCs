
/*-- -- -- -- -- -- -- -- -- -- --
类名:vWebSrvClass4GeneCodeExApiController
表名:vWebSrvClass4GeneCode(00050372)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:45:07
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成C#代码
模块英文名:GeneCSharp
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; using Comm.WebApi;

namespace AGC.WebApi
{
    /// <summary>
    /// vWebSrvClass4GeneCodeExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class vWebSrvClass4GeneCodeExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public vWebSrvClass4GeneCodeExApiController()
        {
        }

        /// <summary>
        /// GetObjLstByUserIdAndCondition
        /// 调用方法: Get /api/vWebSrvClass4GeneCodeExApiControllerApi/GetObjLstByUserIdAndCondition?strUserId=value&strCondition=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strUserId">strUserId</param>
        /// <param name = "strCondition">条件</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetObjLstByUserIdAndCondition")]
        public ActionResult GetObjLstByUserIdAndCondition(string strUserId, string strCondition)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strCondition", strCondition);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsvWebSrvClass4GeneCodeBLEx.GetObjLstByUserIdAndCondition(strUserId, strCondition);
                
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