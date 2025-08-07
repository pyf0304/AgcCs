
/*-- -- -- -- -- -- -- -- -- -- --
类名:Function4CodeExApiController
表名:Function4Code(00050386)
生成代码版本:2021.11.07.2
生成日期:2021/11/09 01:38:34
生成者:pyf
生成服务器IP:109.244.40.104
工程名称:AGC
工程ID:0005
相关数据库:109.244.40.104,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:函数管理
模块英文名:PrjFunction
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
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json.Linq;
using Comm.WebApi;

namespace AGC.WebApi
{
    /// <summary>
    /// Function4CodeExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class Function4CodeExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public Function4CodeExApiController()
        {
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
        /// </summary>
        /// <param name = "objFunction4Code">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        [HttpPost("EditRecordEx")]
        public ActionResult EditRecordEx([FromBody] clsFunction4CodeEN objFunction4Code)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strFunction4CodeJSONObj = clsJSON.GetJsonFromObj(objFunction4Code);
            dictParam.Add("strFunction4CodeJSONObj", strFunction4CodeJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            objFunction4Code._IsCheckProperty = true;
            try
            {
                bool bolResult = true;//如果要使用，解除注释---- objFunction4Code.EditRecordEx();
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
        /// 生成函数代码4Class
        /// 调用方法: Get /api/clsFunction4CodeBLExApi/GeneCode4Class?strClassName=value&strCodeTypeId=value&strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strClassName">类名</param>
        /// <param name = "strCodeTypeId">代码类型Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GeneCode4Class")]
        public ActionResult GeneCode4Class(string strClassName, string strCodeTypeId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strClassName", strClassName);
            dictParam.Add("strCodeTypeId", strCodeTypeId);
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsFunction4CodeBLEx.GeneCode4Class(strClassName, strCodeTypeId, strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 生成函数代码V2
        /// 调用方法: Get /api/clsFunction4CodeBLExApi/GeneCodeV2?strWorkFlowId=value&strFuncId4Code=value&strCodeTypeId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strWorkFlowId">工作流Id</param>
        /// <param name = "strFuncId4Code">函数Id4Code</param>
        /// <param name = "strCodeTypeId">代码类型Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GeneCodeV2")]
        public ActionResult GeneCodeV2(string strWorkFlowId, string strFuncId4Code, string strCodeTypeId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strWorkFlowId", strWorkFlowId);
            dictParam.Add("strFuncId4Code", strFuncId4Code);
            dictParam.Add("strCodeTypeId", strCodeTypeId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsFunction4CodeBLEx.GeneCodeV2(strWorkFlowId, strFuncId4Code, strCodeTypeId);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 计算函数签名
        /// 调用方法: Get /api/clsFunction4CodeBLExApi/CalcFunctionSignature?strFuncId4Code=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strFuncId4Code">函数Id4Code</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CalcFunctionSignature")]
        public ActionResult CalcFunctionSignature(string strFuncId4Code)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strFuncId4Code", strFuncId4Code);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsFunction4CodeBLEx.CalcFunctionSignature(strFuncId4Code);
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