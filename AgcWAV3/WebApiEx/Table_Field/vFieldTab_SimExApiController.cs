
/*-- -- -- -- -- -- -- -- -- -- --
类名:vFieldTab_SimExApiController
表名:vFieldTab_Sim(00050590)
生成代码版本:2022.05.07.1
生成日期:2022/10/27 02:32:21
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
相关数据库:109.244.40.104,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护(Table_Field)
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
using Newtonsoft.Json.Linq; using Comm.WebApi;

namespace AGC.WebApi
{
    /// <summary>
    /// vFieldTab_SimExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class vFieldTab_SimExApiController : ControllerBase
    {
        [HttpGet("GetObjLstByCmPrjId")]
        public ActionResult GetObjLstByCmPrjId(string strCmPrjId, string strCondition)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {
                ["strCmPrjId"] = strCmPrjId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strCmPrjId) == true)
            {
                string strMsg = string.Format("根据条件获取对象列表，strCmPrjId不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                List<clsvFieldTab_SimEN> arrvFieldTab_SimObjLst = clsvFieldTab_SimBLEx.GetObjLstByCmPrjId(strCmPrjId, strCondition);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrvFieldTab_SimObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

    }
}