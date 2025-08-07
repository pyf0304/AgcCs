
/*-- -- -- -- -- -- -- -- -- -- --
类名:CodeTypeExApiController
表名:CodeType(00050203)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:42:24
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:系统参数
模块英文名:SysPara
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
using Newtonsoft.Json.Linq; using Comm.WebApi;
using AGC.BusinessLogicEx;
using Newtonsoft.Json;

namespace AGC.WebApi
{
    /// <summary>
    /// CodeTypeExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class CodeTypeExApiController : CodeTypeApiController
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public CodeTypeExApiController()
        {
        }

        /// <summary>
        /// GetCodeTypeObjLstByApplicationType4Back
        /// 调用方法: Get /api/CodeTypeExApiControllerApi/GetCodeTypeObjLstByApplicationType4Back?intApplicationTypeId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "intApplicationTypeId">intApplicationTypeId</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetCodeTypeObjLstByApplicationType4Back")]
        public ActionResult GetCodeTypeObjLstByApplicationType4Back(int intApplicationTypeId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("intApplicationTypeId", intApplicationTypeId.ToString());
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsCodeTypeBLEx.GetCodeTypeObjLstByApplicationType4Back(intApplicationTypeId);

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