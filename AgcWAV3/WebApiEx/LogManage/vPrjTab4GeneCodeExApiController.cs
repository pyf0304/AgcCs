
/*-- -- -- -- -- -- -- -- -- -- --
类名:vPrjTab4GeneCodeExApiController
表名:vPrjTab4GeneCode(00050284)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:45:00
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
using Newtonsoft.Json;

namespace AGC.WebApi
{
    /// <summary>
    /// vPrjTab4GeneCodeExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class vPrjTab4GeneCodeExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public vPrjTab4GeneCodeExApiController()
        {
        }


        /// <summary>
        /// fn_getObjLstByUserId
        /// 调用方法: Get /api/vPrjTab4GeneCodeExApiControllerApi/fn_getObjLstByUserId?strUserId=value&intApplicationTypeId=value&strCondition=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strUserId">strUserId</param>
        /// <param name = "intApplicationTypeId">intApplicationTypeId</param>
        /// <param name = "strCondition">条件</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("fn_getObjLstByUserIdBak")]
        public ActionResult fn_getObjLstByUserIdBak(string strUserId, int intApplicationTypeId, string strCondition)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("intApplicationTypeId", intApplicationTypeId.ToString());
            dictParam.Add("strCondition", strCondition);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsvPrjTab4GeneCodeBLEx.fn_getObjLstByUserIdBak(strUserId, intApplicationTypeId, strCondition);

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