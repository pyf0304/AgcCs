/*-- -- -- -- -- -- -- -- -- -- --
类名:UserCodePathExApiController
表名:UserCodePath(00050204)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:43:28
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:系统设置
模块英文名:SystemSet
框架-层名:WebApi扩展层(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.common;
using Comm.WebApi;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AGC.WebApi
{
    /// <summary>
    /// UserCodePathExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class UserCodePathExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public UserCodePathExApiController()
        {
        }

        /// <summary>
        /// 设置GC路径
        /// 调用方法: Get /api/UserCodePathExApi/SetGCPath?strUserId=value&strMachineName=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strMachineName">机器名</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回设置的路径数量</returns>
        [HttpGet("SetGCPath")]
        public ActionResult SetGCPath(string strUserId, string strMachineName, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strMachineName", strMachineName);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsUserCodePathBLEx.SetGCPath(strUserId, strMachineName, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 移除重复记录
        /// 调用方法: Get /api/UserCodePathExApi/RemoveReduplicateRec
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <returns>返回移除的记录数量</returns>
        [AllowAnonymous]
        [HttpGet("RemoveReduplicateRec")]
        public ActionResult RemoveReduplicateRec()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsUserCodePathBLEx.RemoveReduplicateRec();
                return Ok(new { errorId = 0, errorMsg = "", returnInt = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 获取用户生成代码路径
        /// 调用方法: Get /api/UserCodePathExApi/GetUserGCCodePath?strUserId=value&strMachineName=value&strPrjId=value&strCmPrjId=value&intApplicationTypeId=value&strCodeTypeId=value
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strMachineName">机器名称</param>
        /// <param name="strPrjId">项目ID</param>
        /// <param name="strCmPrjId">CM工程ID</param>
        /// <param name="intApplicationTypeId">应用类型ID</param>
        /// <param name="strCodeTypeId">代码类型ID</param>
        /// <returns>返回用户生成代码路径</returns>
        [AllowAnonymous]
        [HttpGet("GetUserGCCodePath")]
        public ActionResult GetUserGCCodePath(
            string strUserId,
            string strMachineName,
            string strPrjId,
            string strCmPrjId,
            int intApplicationTypeId,
            string strCodeTypeId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>
            {
                ["strUserId"] = strUserId,
                ["strMachineName"] = strMachineName,
                ["strPrjId"] = strPrjId,
                ["strCmPrjId"] = strCmPrjId,
                ["intApplicationTypeId"] = intApplicationTypeId.ToString(),
                ["strCodeTypeId"] = strCodeTypeId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                string strCodePath = clsUserCodePathBLEx.GetUserGCCodePath(
                    strUserId,
                    strMachineName,
                    strPrjId,
                    strCmPrjId,
                    intApplicationTypeId,
                    strCodeTypeId);

                return Ok(new { errorId = 0, errorMsg = "", codePath = strCodePath });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg, codePath = "" });
            }
        }

        /// <summary>
        /// 获取用户生成代码路径详细信息
        /// 调用方法: Get /api/UserCodePathExApi/GetUserGCCodePathInfo?strUserId=value&strMachineName=value&strPrjId=value&strCmPrjId=value&intApplicationTypeId=value&strCodeTypeId=value
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strMachineName">机器名称</param>
        /// <param name="strPrjId">项目ID</param>
        /// <param name="strCmPrjId">CM工程ID</param>
        /// <param name="intApplicationTypeId">应用类型ID</param>
        /// <param name="strCodeTypeId">代码类型ID</param>
        /// <returns>返回用户生成代码路径详细信息对象</returns>
        [HttpGet("GetUserGCCodePathInfo")]
        public ActionResult GetUserGCCodePathInfo(
            string strUserId,
            string strMachineName,
            string strPrjId,
            string strCmPrjId,
            int intApplicationTypeId,
            string strCodeTypeId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>
            {
                ["strUserId"] = strUserId,
                ["strMachineName"] = strMachineName,
                ["strPrjId"] = strPrjId,
                ["strCmPrjId"] = strCmPrjId,
                ["intApplicationTypeId"] = intApplicationTypeId.ToString(),
                ["strCodeTypeId"] = strCodeTypeId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                clsUserCodePathENEx objUserCodePathEx = clsUserCodePathBLEx.GetUserGCCodePathInfo(
                    strUserId,
                    strMachineName,
                    strPrjId,
                    strCmPrjId,
                    intApplicationTypeId,
                    strCodeTypeId);

                return Ok(new { errorId = 0, errorMsg = "", data = objUserCodePathEx });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg, data = (object)null });
            }
        }

        /// <summary>
        /// 获取用户生成代码路径及备份路径
        /// 调用方法: Get /api/UserCodePathExApi/GetUserGCCodePathWithBackup?strUserId=value&strMachineName=value&strPrjId=value&strCmPrjId=value&intApplicationTypeId=value&strCodeTypeId=value
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strMachineName">机器名称</param>
        /// <param name="strPrjId">项目ID</param>
        /// <param name="strCmPrjId">CM工程ID</param>
        /// <param name="intApplicationTypeId">应用类型ID</param>
        /// <param name="strCodeTypeId">代码类型ID</param>
        /// <returns>返回用户生成代码路径及备份路径</returns>
        [AllowAnonymous]
        [HttpGet("GetUserGCCodePathWithBackup")]
        public ActionResult GetUserGCCodePathWithBackup(
            string strUserId,
            string strMachineName,
            string strPrjId,
            string strCmPrjId,
            int intApplicationTypeId,
            string strCodeTypeId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>
            {
                ["strUserId"] = strUserId,
                ["strMachineName"] = strMachineName,
                ["strPrjId"] = strPrjId,
                ["strCmPrjId"] = strCmPrjId,
                ["intApplicationTypeId"] = intApplicationTypeId.ToString(),
                ["strCodeTypeId"] = strCodeTypeId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                // 调用业务逻辑层获取代码路径和备份路径
                var (rootPath, codePath, CodePath4Share, codePathBackup, CodePathBackup4Share) = clsUserCodePathBLEx.GetUserGCCodePathWithBackup(
                    strUserId,
                    strMachineName,
                    strPrjId,
                    strCmPrjId,
                    intApplicationTypeId,
                    strCodeTypeId);

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    rootPath = rootPath,
                    codePath = codePath,
                    codePath4Share = CodePath4Share,
                    codePathBackup = codePathBackup,
                    codePathBackup4Share = CodePathBackup4Share,
                    strUserId = strUserId,
                    strPrjId = strPrjId,
                    strCmPrjId = strCmPrjId,
                    intApplicationTypeId = intApplicationTypeId,
                    strCodeTypeId = strCodeTypeId
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new
                {
                    errorId = 1,
                    errorMsg = strMsg,
                    codePath = "",
                    codePathBackup = ""
                });
            }
        }

        /// <summary>
        /// 设置用户生成代码路径及备份路径
        /// 调用方法: Post /api/UserCodePathExApi/SetUserGCCodePathWithBackup
        /// </summary>
        /// <param name="request">请求参数对象</param>
        /// <returns>返回设置结果</returns>
        [AllowAnonymous]
        [HttpPost("SetUserGCCodePathWithBackup")]
        public ActionResult SetUserGCCodePathWithBackup([FromBody] SetUserGCCodePathRequest request)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>
            {
                ["strUserId"] = request.StrUserId,
                ["strMachineName"] = request.StrMachineName,
                ["strPrjId"] = request.StrPrjId,
                ["strCmPrjId"] = request.StrCmPrjId,
                ["intApplicationTypeId"] = request.IntApplicationTypeId.ToString(),
                ["strCodeTypeId"] = request.StrCodeTypeId,
                ["strCodePath"] = request.StrCodePath,
                ["strCodePath4Share"] = request.StrCodePath4Share,
                ["strCodePathBackup"] = request.StrCodePathBackup,
                ["strCodePathBackup4Share"] = request.StrCodePathBackup4Share
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            
            try
            {
                // 调用业务逻辑层设置代码路径和备份路径
                bool bolResult = clsUserCodePathBLEx.SetUserGCCodePathWithBackup(
                    request.StrUserId,
                    request.StrMachineName,
                    request.StrPrjId,
                    request.StrCmPrjId,
                    request.IntApplicationTypeId,
                    request.StrCodeTypeId,
                    request.StrCodePath,
                    request.StrCodePath4Share,
                    request.StrCodePathBackup,
                    request.StrCodePathBackup4Share);

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    success = bolResult,
                    message = bolResult ? "代码路径设置成功" : "代码路径设置失败",
                    strUserId = request.StrUserId,
                    strCodeTypeId = request.StrCodeTypeId
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new
                {
                    errorId = 1,
                    errorMsg = strMsg,
                    success = false,
                    message = "代码路径设置失败"
                });
            }
        }

        /// <summary>
        /// 测试设置用户生成代码路径及备份路径
        /// 调用方法: Get /api/UserCodePathExApi/TestSetUserGCCodePathWithBackup
        /// </summary>
        /// <returns>返回测试结果</returns>
        [AllowAnonymous]
        [HttpGet("TestSetUserGCCodePathWithBackup")]
        public ActionResult TestSetUserGCCodePathWithBackup()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            
            try
            {
                // 调用业务逻辑层的测试函数
                string strTestResult = clsUserCodePathBLEx.TestSetUserGCCodePathWithBackup();

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    success = true,
                    testResult = strTestResult,
                    message = "测试执行完成"
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new
                {
                    errorId = 1,
                    errorMsg = strMsg,
                    success = false,
                    testResult = "",
                    message = "测试执行失败"
                });
            }
        }

        /// <summary>
        /// 测试设置用户生成代码路径及备份路径（快速版）
        /// 调用方法: Get /api/UserCodePathExApi/TestSetUserGCCodePathWithBackup_Quick?strTestCodePath=value&strTestCodePathBackup=value
        /// </summary>
        /// <param name="strTestCodePath">测试代码路径（可选）</param>
        /// <param name="strTestCodePathBackup">测试备份路径（可选）</param>
        /// <returns>返回测试结果</returns>
        [AllowAnonymous]
        [HttpGet("TestSetUserGCCodePathWithBackup_Quick")]
        public ActionResult TestSetUserGCCodePathWithBackup_Quick(
            string strTestCodePath = null,
            string strTestCodePathBackup = null)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>
            {
                ["strTestCodePath"] = strTestCodePath ?? "null",
                ["strTestCodePathBackup"] = strTestCodePathBackup ?? "null"
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            
            try
            {
                // 调用业务逻辑层的快速测试函数
                bool bolResult = clsUserCodePathBLEx.TestSetUserGCCodePathWithBackup_Quick(
                    strTestCodePath,
                    strTestCodePathBackup);

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    success = bolResult,
                    testCodePath = strTestCodePath,
                    testCodePathBackup = strTestCodePathBackup,
                    message = bolResult ? "快速测试成功" : "快速测试失败"
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new
                {
                    errorId = 1,
                    errorMsg = strMsg,
                    success = false,
                    message = "快速测试执行失败"
                });
            }
        }
    }

    /// <summary>
    /// 设置用户生成代码路径请求参数
    /// </summary>
    public class SetUserGCCodePathRequest
    {
        public string StrUserId { get; set; }
        public string StrMachineName { get; set; }
        public string StrPrjId { get; set; }
        public string StrCmPrjId { get; set; }
        public int IntApplicationTypeId { get; set; }
        public string StrCodeTypeId { get; set; }
        public string StrCodePath { get; set; }
        public string StrCodePathBackup { get; set; }
        public string StrCodePath4Share { get; set; }
        public string StrCodePathBackup4Share { get; set; }

    }
}