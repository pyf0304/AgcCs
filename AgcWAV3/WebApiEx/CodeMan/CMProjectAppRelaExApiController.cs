
/*-- -- -- -- -- -- -- -- -- -- --
类名:CMProjectAppRelaExApiController
表名:CMProjectAppRela(00050600)
生成代码版本:2021.12.24.1
生成日期:2021/12/24 11:59:52
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)
相关数据库:109.244.40.104,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:代码管理(CodeMan)
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
    /// CMProjectAppRelaExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class CMProjectAppRelaExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public CMProjectAppRelaExApiController()
        {
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
        /// </summary>
        /// <param name = "objCMProjectAppRela">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        [HttpPost("EditRecordEx")]
        public ActionResult EditRecordEx([FromBody] clsCMProjectAppRelaEN objCMProjectAppRela)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            string strCMProjectAppRelaJSONObj = clsJSON.GetJsonFromObj(objCMProjectAppRela);
            dictParam.Add("strCMProjectAppRelaJSONObj", strCMProjectAppRelaJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            objCMProjectAppRela._IsCheckProperty = true;
            try
            {
                bool bolResult = true;//如果要使用，解除注释---- objCMProjectAppRela.EditRecordEx();
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 删除Cm工程和应用关系
        /// 调用方法: Get /api/clsCMProjectAppRelaBLExApi/DelCmProjectApp?strCmPrjId=value&intApplicationTypeId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("DelCmProjectApp")]
        public ActionResult DelCmProjectApp(string strCmPrjId, int intApplicationTypeId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strCmPrjId", strCmPrjId);
            dictParam.Add("intApplicationTypeId", intApplicationTypeId.ToString());
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsCMProjectAppRelaBLEx.DelCmProjectApp(strCmPrjId, intApplicationTypeId);
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