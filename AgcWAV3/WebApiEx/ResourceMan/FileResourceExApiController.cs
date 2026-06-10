/*-- -- -- -- -- -- -- -- -- -- --
类名:FileResourceExApiController
表名:FileResource(00050539)
生成代码版本:2022.04.06.1
生成日期:2022/04/14 16:36:32
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)
相关数据库:109.244.40.104,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:资源管理(ResourceMan)
框架-层名:WA_服务扩展层(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.json;
using Comm.WebApi;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Text;

namespace AGC.WebApi
{
    /// <summary>
    /// 导入项目文件请求参数 DTO
    /// </summary>
    public class ImportProjectFilesRequest
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 机器名（电脑名），如果为空则使用当前机器名
        /// </summary>
        public string MachineName { get; set; }

        /// <summary>
        /// 工程Id
        /// </summary>
        public string PrjId { get; set; }

        /// <summary>
        /// Cm工程Id
        /// </summary>
        public string CmPrjId { get; set; }

        /// <summary>
        /// 应用类型Id
        /// </summary>
        public int ApplicationTypeId { get; set; }

        /// <summary>
        /// 服务器IP地址，如果为空则使用当前主机名
        /// </summary>
        public string ServerIp { get; set; }

        /// <summary>
        /// 是否使用 .gitignore 文件过滤，默认为 true
        /// </summary>
        public bool UseGitIgnore { get; set; } = true;
    }
    /// <summary>
    /// FileResourceExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class FileResourceExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public FileResourceExApiController()
        {
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
        /// </summary>
        /// <param name = "objFileResource">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        [HttpPost("EditRecordEx")]
        public ActionResult EditRecordEx([FromBody] clsFileResourceEN objFileResource)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            string strFileResourceJSONObj = clsJSON.GetJsonFromObj(objFileResource);
            dictParam.Add("strFileResourceJSONObj", strFileResourceJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            objFileResource._IsCheckProperty = true;
            try
            {
                bool bolResult = true;//如果要使用，解除注释---- objFileResource.EditRecordEx();
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
        /// 根据用户、电脑获取当前项目中的所有相关文件并导入到数据库
        /// </summary>
        /// <param name="request">导入请求参数</param>
        /// <returns>返回导入结果</returns>
        [AllowAnonymous]
        [HttpPost("ImportProjectFilesByUserAndComputer")]
        public ActionResult ImportProjectFilesByUserAndComputer([FromBody] ImportProjectFilesRequest request)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();

            try
            {
                // 记录日志
                dictParam.Add("UserId", request.UserId ?? "");
                dictParam.Add("MachineName", request.MachineName ?? "");
                dictParam.Add("PrjId", request.PrjId ?? "");
                dictParam.Add("CmPrjId", request.CmPrjId ?? "");
                dictParam.Add("ApplicationTypeId", request.ApplicationTypeId.ToString());
                dictParam.Add("ServerIp", request.ServerIp ?? "");
                dictParam.Add("UseGitIgnore", request.UseGitIgnore.ToString());
                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

                // 调用业务逻辑层方法
                string strMsg;
                int intResult = clsFileResourceBLEx.ImportProjectFilesByUserAndComputer(
                    strUserId: request.UserId,
                    strMachineName: request.MachineName,
                    strPrjId: request.PrjId,
                    strCmPrjId: request.CmPrjId,
                    intApplicationTypeId: request.ApplicationTypeId,
                    strServerIp: request.ServerIp,
                    bolUseGitIgnore: request.UseGitIgnore,
                    out strMsg);

                if (intResult >= 0)
                {
                    // 成功
                    return Ok(new
                    {
                        errorId = 0,
                        errorMsg = "",
                        message = strMsg,
                        importedCount = intResult
                    });
                }
                else
                {
                    // 失败
                    return Ok(new
                    {
                        errorId = 1,
                        errorMsg = strMsg,
                        message = strMsg,
                        importedCount = 0
                    });
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new
                {
                    errorId = 1,
                    errorMsg = strMsg,
                    message = strMsg,
                    importedCount = 0
                });
            }
        }

        /// <summary>
        /// 统计符合导入条件的文件数量（不实际导入）
        /// </summary>
        /// <param name="request">导入请求参数</param>
        /// <returns>返回统计结果</returns>
        [AllowAnonymous]
        [HttpPost("CountProjectFilesToImport")]
        public ActionResult CountProjectFilesToImport([FromBody] ImportProjectFilesRequest request)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            
            try
            {
                // 记录日志
                dictParam.Add("UserId", request.UserId ?? "");
                dictParam.Add("MachineName", request.MachineName ?? "");
                dictParam.Add("PrjId", request.PrjId ?? "");
                dictParam.Add("CmPrjId", request.CmPrjId ?? "");
                dictParam.Add("ApplicationTypeId", request.ApplicationTypeId.ToString());
                dictParam.Add("UseGitIgnore", request.UseGitIgnore.ToString());
                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

                // 调用业务逻辑层方法
                string strMsg;
                int intTotalFiles, intIgnoredByGitIgnore, intIgnoredByExcludePath, intAlreadyExists;
                
                int intResult = clsFileResourceBLEx.CountProjectFilesToImport(
                    strUserId: request.UserId,
                    strMachineName: request.MachineName,
                    strPrjId: request.PrjId,
                    strCmPrjId: request.CmPrjId,
                    intApplicationTypeId: request.ApplicationTypeId,
                    bolUseGitIgnore: request.UseGitIgnore,
                    out strMsg,
                    out intTotalFiles,
                    out intIgnoredByGitIgnore,
                    out intIgnoredByExcludePath,
                    out intAlreadyExists);

                if (intResult >= 0)
                {
                    // 成功
                    return Ok(new 
                    { 
                        errorId = 0, 
                        errorMsg = "", 
                        message = strMsg,
                        willImportCount = intResult,
                        totalFiles = intTotalFiles,
                        alreadyExists = intAlreadyExists,
                        ignoredByGitIgnore = intIgnoredByGitIgnore,
                        ignoredByExcludePath = intIgnoredByExcludePath
                    });
                }
                else
                {
                    // 失败
                    return Ok(new 
                    { 
                        errorId = 1, 
                        errorMsg = strMsg,
                        message = strMsg,
                        willImportCount = 0,
                        totalFiles = 0,
                        alreadyExists = 0,
                        ignoredByGitIgnore = 0,
                        ignoredByExcludePath = 0
                    });
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new 
                { 
                    errorId = 1, 
                    errorMsg = strMsg,
                    message = strMsg,
                    willImportCount = 0,
                    totalFiles = 0,
                    alreadyExists = 0,
                    ignoredByGitIgnore = 0,
                    ignoredByExcludePath = 0
                });
            }
        }

        /// <summary>
        /// 统计符合导入条件的文件数量（GET方式，用于测试）
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <param name="machineName">机器名（电脑名），如果为空则使用当前机器名</param>
        /// <param name="prjId">工程Id</param>
        /// <param name="cmPrjId">Cm工程Id</param>
        /// <param name="applicationTypeId">应用类型Id</param>
        /// <param name="useGitIgnore">是否使用 .gitignore 文件过滤，默认为 true</param>
        /// <returns>返回统计结果</returns>
        [AllowAnonymous]
        [HttpGet("CountProjectFilesToImport")]
        public ActionResult CountProjectFilesToImportGet(
            [FromQuery] string userId,
            [FromQuery] string machineName = "",
            [FromQuery] string prjId = "",
            [FromQuery] string cmPrjId = "",
            [FromQuery] int applicationTypeId = 0,
            [FromQuery] bool useGitIgnore = true)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            
            try
            {
                // 记录日志
                dictParam.Add("UserId", userId ?? "");
                dictParam.Add("MachineName", machineName ?? "");
                dictParam.Add("PrjId", prjId ?? "");
                dictParam.Add("CmPrjId", cmPrjId ?? "");
                dictParam.Add("ApplicationTypeId", applicationTypeId.ToString());
                dictParam.Add("UseGitIgnore", useGitIgnore.ToString());
                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

                // 调用业务逻辑层方法
                string strMsg;
                int intTotalFiles, intIgnoredByGitIgnore, intIgnoredByExcludePath, intAlreadyExists;
                
                int intResult = clsFileResourceBLEx.CountProjectFilesToImport(
                    strUserId: userId,
                    strMachineName: machineName,
                    strPrjId: prjId,
                    strCmPrjId: cmPrjId,
                    intApplicationTypeId: applicationTypeId,
                    bolUseGitIgnore: useGitIgnore,
                    out strMsg,
                    out intTotalFiles,
                    out intIgnoredByGitIgnore,
                    out intIgnoredByExcludePath,
                    out intAlreadyExists);

                if (intResult >= 0)
                {
                    // 成功
                    return Ok(new 
                    { 
                        errorId = 0, 
                        errorMsg = "", 
                        message = strMsg,
                        willImportCount = intResult,
                        totalFiles = intTotalFiles,
                        alreadyExists = intAlreadyExists,
                        ignoredByGitIgnore = intIgnoredByGitIgnore,
                        ignoredByExcludePath = intIgnoredByExcludePath
                    });
                }
                else
                {
                    // 失败
                    return Ok(new 
                    { 
                        errorId = 1, 
                        errorMsg = strMsg,
                        message = strMsg,
                        willImportCount = 0,
                        totalFiles = 0,
                        alreadyExists = 0,
                        ignoredByGitIgnore = 0,
                        ignoredByExcludePath = 0
                    });
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new 
                { 
                    errorId = 1, 
                    errorMsg = strMsg,
                    message = strMsg,
                    willImportCount = 0,
                    totalFiles = 0,
                    alreadyExists = 0,
                    ignoredByGitIgnore = 0,
                    ignoredByExcludePath = 0
                });
            }
        }

    }
}