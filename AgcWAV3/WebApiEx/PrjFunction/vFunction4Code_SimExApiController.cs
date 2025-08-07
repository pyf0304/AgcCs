
/*-- -- -- -- -- -- -- -- -- -- --
类名:vFunction4Code_SimExApiController
表名:vFunction4Code_Sim(00050602)
生成代码版本:2022.01.17.1
生成日期:2022/01/20 01:23:52
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)
相关数据库:109.244.40.104,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:函数管理(PrjFunction)
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
using Newtonsoft.Json.Linq;
using Comm.WebApi;

namespace AGC.WebApi
{
    /// <summary>
    /// vFunction4Code_SimExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class vFunction4Code_SimExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public vFunction4Code_SimExApiController()
        {
        }

        /// <summary>
        /// 根据FuncId4Code获取对象，并且把UsedTimes加1
        /// 调用方法: Get /api/clsvFunction4Code_SimBLExApi/GetObjByFuncId4CodeEx?strFuncId4Code=value&strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strFuncId4Code">函数Id4Code</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetObjByFuncId4CodeEx")]
        public ActionResult GetObjByFuncId4CodeEx(string strFuncId4Code)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strFuncId4Code", strFuncId4Code);
            
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsvFunction4Code_SimBLEx.GetObjByFuncId4CodeEx(strFuncId4Code);
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