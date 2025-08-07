
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:vPrjTab_SimExApiController
 表名:vPrjTab_Sim(00050597)
 生成代码版本:2021.11.29.1
 生成日期:2021/11/30 00:10:53
 生成者:pyf
 生成服务器IP:109.244.40.104
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)
 相关数据库:109.244.40.104,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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

using com.taishsoft.common;
using com.taishsoft.datetime;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json.Linq; using Comm.WebApi;

namespace AGC.WebApi
{
 /// <summary>
 /// vPrjTab_SimExApiController 的摘要说明
 /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
 /// </summary>
[ApiController]
[Route("[controller]")]
public class vPrjTab_SimExApiController : ControllerBase
{ 

/// <summary>
/// 构造函数
 /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
/// </summary>
 public vPrjTab_SimExApiController()
 {
 }
        /// <summary>
        /// GetObjExLstByPrjIdEx
        /// 调用方法: Get /api/PrjTabExApiControllerApi/GetObjExLstByPrjIdEx?strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetObjExLstByPrjIdEx")]
        public ActionResult GetObjExLstByPrjIdEx(string strPrjId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsvPrjTab_SimBLEx.GetObjExLstByPrjIdEx(strPrjId);

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