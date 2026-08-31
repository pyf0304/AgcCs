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
using AGC.BusinessLogic;
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
        /// <summary>
        /// 从UserCodeRoot子目录导入项目文件到数据库
        /// </summary>
        /// <param name="request">导入请求参数</param>
        /// <returns>返回导入结果</returns>
        [AllowAnonymous]
        [HttpPost("ImportProjectFilesFromUserCodeRoot")]
        public ActionResult ImportProjectFilesFromUserCodeRoot([FromBody] ImportProjectFilesRequest request)
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
                int intResult = clsFileResourceBLEx.ImportProjectFilesFromUserCodeRoot(
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
        /// 统计UserCodeRoot子目录中符合导入条件的文件数量（不实际导入）
        /// </summary>
        /// <param name="request">导入请求参数</param>
        /// <returns>返回统计结果</returns>
        [AllowAnonymous]
        [HttpPost("CountProjectFilesFromUserCodeRoot")]
        public ActionResult CountProjectFilesFromUserCodeRoot([FromBody] ImportProjectFilesRequest request)
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

                int intResult = clsFileResourceBLEx.CountProjectFilesFromUserCodeRoot(
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
        /// 统计UserCodeRoot子目录中符合导入条件的文件数量（GET方式，用于测试）
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <param name="machineName">机器名（电脑名），如果为空则使用当前机器名</param>
        /// <param name="prjId">工程Id</param>
        /// <param name="cmPrjId">Cm工程Id</param>
        /// <param name="applicationTypeId">应用类型Id</param>
        /// <param name="useGitIgnore">是否使用 .gitignore 文件过滤，默认为 true</param>
        /// <returns>返回统计结果</returns>
        [AllowAnonymous]
        [HttpGet("CountProjectFilesFromUserCodeRoot")]
        public ActionResult CountProjectFilesFromUserCodeRootGet(
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

                int intResult = clsFileResourceBLEx.CountProjectFilesFromUserCodeRoot(
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

        /// <summary>
        /// 从UserCodeRoot子目录导入项目文件（GET方式，用于测试）
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <param name="machineName">机器名（电脑名），如果为空则使用当前机器名</param>
        /// <param name="prjId">工程Id</param>
        /// <param name="cmPrjId">Cm工程Id</param>
        /// <param name="applicationTypeId">应用类型Id</param>
        /// <param name="serverIp">服务器IP地址，如果为空则使用当前主机名</param>
        /// <param name="useGitIgnore">是否使用 .gitignore 文件过滤，默认为 true</param>
        /// <returns>返回导入结果</returns>
        [AllowAnonymous]
        [HttpGet("ImportProjectFilesFromUserCodeRoot")]
        public ActionResult ImportProjectFilesFromUserCodeRootGet(
            [FromQuery] string userId,
            [FromQuery] string machineName = "",
            [FromQuery] string prjId = "",
            [FromQuery] string cmPrjId = "",
            [FromQuery] int applicationTypeId = 0,
            [FromQuery] string serverIp = "",
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
                dictParam.Add("ServerIp", serverIp ?? "");
                dictParam.Add("UseGitIgnore", useGitIgnore.ToString());
                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

                // 调用业务逻辑层方法
                string strMsg;
                int intResult = clsFileResourceBLEx.ImportProjectFilesFromUserCodeRoot(
                    strUserId: userId,
                    strMachineName: machineName,
                    strPrjId: prjId,
                    strCmPrjId: cmPrjId,
                    intApplicationTypeId: applicationTypeId,
                    strServerIp: serverIp,
                    bolUseGitIgnore: useGitIgnore,
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
        /// 根据文件名获取CodeTypeId和TabId
        /// </summary>
        /// <param name="strFileName">文件名（包括扩展名）</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>返回文件类型信息</returns>
        [AllowAnonymous]
        [HttpGet("GetFileTypeInfoByFileName")]
        public ActionResult GetFileTypeInfoByFileName(string strFileName, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strFileName", strFileName ?? "");
            dictParam.Add("strPrjId", strPrjId ?? "");
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                // 参数验证
                if (string.IsNullOrEmpty(strFileName))
                {
                    return Ok(new
                    {
                        errorId = 1,
                        errorMsg = "文件名不能为空",
                        codeTypeId = "",
                        codeTypeName = "",
                        tabId = "",
                        tabName = "",
                        isMatched = false
                    });
                }

                if (string.IsNullOrEmpty(strPrjId))
                {
                    return Ok(new
                    {
                        errorId = 1,
                        errorMsg = "工程Id不能为空",
                        codeTypeId = "",
                        codeTypeName = "",
                        tabId = "",
                        tabName = "",
                        isMatched = false
                    });
                }

                // 调用业务逻辑层方法
                var result = clsFileResourceBLEx.GetFileTypeInfoByFileName(strFileName, strPrjId);

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = result.ErrorMessage ?? "",
                    codeTypeId = result.CodeTypeId ?? "",
                    codeTypeName = result.CodeTypeName ?? "",
                    tabId = result.TabId ?? "",
                    tabName = result.TabName ?? "",
                    isMatched = result.IsMatched
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new
                {
                    errorId = 1,
                    errorMsg = strMsg,
                    codeTypeId = "",
                    codeTypeName = "",
                    tabId = "",
                    tabName = "",
                    isMatched = false
                });
            }
        }

        /// <summary>
        /// 批量根据文件名获取CodeTypeId和TabId（POST方式）
        /// </summary>
        /// <param name="request">批量请求参数</param>
        /// <returns>返回文件类型信息列表</returns>
        [AllowAnonymous]
        [HttpPost("GetFileTypeInfoBatch")]
        public ActionResult GetFileTypeInfoBatch([FromBody] GetFileTypeInfoBatchRequest request)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();

            try
            {
                // 参数验证
                if (request == null)
                {
                    return Ok(new
                    {
                        errorId = 1,
                        errorMsg = "请求参数不能为空",
                        fileTypeInfoList = new List<object>()
                    });
                }

                dictParam.Add("PrjId", request.PrjId ?? "");
                dictParam.Add("FileNameCount", request.FileNames?.Count.ToString() ?? "0");
                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

                if (request.FileNames == null || request.FileNames.Count == 0)
                {
                    return Ok(new
                    {
                        errorId = 1,
                        errorMsg = "文件名列表不能为空",
                        fileTypeInfoList = new List<object>()
                    });
                }

                if (string.IsNullOrEmpty(request.PrjId))
                {
                    return Ok(new
                    {
                        errorId = 1,
                        errorMsg = "工程Id不能为空",
                        fileTypeInfoList = new List<object>()
                    });
                }

                // 调用业务逻辑层方法
                var resultList = clsFileResourceBLEx.GetFileTypeInfoBatch(request.FileNames, request.PrjId);

                // 转换为返回格式
                var fileTypeInfoList = resultList.Select(x => new
                {
                    fileName = request.FileNames[resultList.IndexOf(x)],
                    codeTypeId = x.CodeTypeId ?? "",
                    codeTypeName = x.CodeTypeName ?? "",
                    tabId = x.TabId ?? "",
                    tabName = x.TabName ?? "",
                    isMatched = x.IsMatched,
                    errorMessage = x.ErrorMessage ?? ""
                }).ToList();

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    totalCount = fileTypeInfoList.Count,
                    matchedCount = fileTypeInfoList.Count(x => x.isMatched),
                    fileTypeInfoList = fileTypeInfoList
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new
                {
                    errorId = 1,
                    errorMsg = strMsg,
                    fileTypeInfoList = new List<object>()
                });
            }
        }

        /// <summary>
        /// 根据文件名获取CodeTypeId和TabId（POST方式）
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns>返回文件类型信息</returns>
        [AllowAnonymous]
        [HttpPost("GetFileTypeInfoByFileName")]
        public ActionResult GetFileTypeInfoByFileNamePost([FromBody] GetFileTypeInfoRequest request)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();

            try
            {
                // 参数验证
                if (request == null)
                {
                    return Ok(new
                    {
                        errorId = 1,
                        errorMsg = "请求参数不能为空",
                        codeTypeId = "",
                        codeTypeName = "",
                        tabId = "",
                        tabName = "",
                        isMatched = false
                    });
                }

                dictParam.Add("FileName", request.FileName ?? "");
                dictParam.Add("PrjId", request.PrjId ?? "");
                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

                if (string.IsNullOrEmpty(request.FileName))
                {
                    return Ok(new
                    {
                        errorId = 1,
                        errorMsg = "文件名不能为空",
                        codeTypeId = "",
                        codeTypeName = "",
                        tabId = "",
                        tabName = "",
                        isMatched = false
                    });
                }

                if (string.IsNullOrEmpty(request.PrjId))
                {
                    return Ok(new
                    {
                        errorId = 1,
                        errorMsg = "工程Id不能为空",
                        codeTypeId = "",
                        codeTypeName = "",
                        tabId = "",
                        tabName = "",
                        isMatched = false
                    });
                }

                // 调用业务逻辑层方法
                var result = clsFileResourceBLEx.GetFileTypeInfoByFileName(request.FileName, request.PrjId);

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = result.ErrorMessage ?? "",
                    codeTypeId = result.CodeTypeId ?? "",
                    codeTypeName = result.CodeTypeName ?? "",
                    tabId = result.TabId ?? "",
                    tabName = result.TabName ?? "",
                    isMatched = result.IsMatched
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new
                {
                    errorId = 1,
                    errorMsg = strMsg,
                    codeTypeId = "",
                    codeTypeName = "",
                    tabId = "",
                    tabName = "",
                    isMatched = false
                });
            }
        }

        /// <summary>
        /// 获取指定工程的所有CodeTypeId列表
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strCmPrjId">Cm工程Id（可选）</param>
        /// <returns>返回CodeTypeId列表</returns>
        [AllowAnonymous]
        [HttpGet("GetCodeTypeIdList")]
        public ActionResult GetCodeTypeIdList(string strPrjId, string strCmPrjId = "")
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId ?? "");
            dictParam.Add("strCmPrjId", strCmPrjId ?? "");
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                // 参数验证
                if (string.IsNullOrEmpty(strPrjId))
                {
                    return Ok(new
                    {
                        errorId = 1,
                        errorMsg = "工程Id不能为空",
                        codeTypeIdList = new List<string>()
                    });
                }

                // 调用业务逻辑层方法
                List<string> arrCodeTypeId;
                if (string.IsNullOrEmpty(strCmPrjId))
                {
                    arrCodeTypeId = clsFileResourceBLEx.GetCodeTypeIdListByPrjId(strPrjId);
                }
                else
                {
                    arrCodeTypeId = clsFileResourceBLEx.GetCodeTypeIdListByPrjIdAndCmPrjId(strPrjId, strCmPrjId);
                }

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    count = arrCodeTypeId.Count,
                    codeTypeIdList = arrCodeTypeId
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new
                {
                    errorId = 1,
                    errorMsg = strMsg,
                    codeTypeIdList = new List<string>()
                });
            }
        }

        /// <summary>
        /// 获取指定工程的CodeTypeId统计信息
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strCmPrjId">Cm工程Id（可选）</param>
        /// <param name="bolIncludeFileNames">是否包含文件名列表（默认false）</param>
        /// <returns>返回CodeTypeId统计信息</returns>
        [AllowAnonymous]
        [HttpGet("GetCodeTypeStatistics")]
        public ActionResult GetCodeTypeStatistics(string strPrjId, string strCmPrjId = "", bool bolIncludeFileNames = false)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId ?? "");
            dictParam.Add("strCmPrjId", strCmPrjId ?? "");
            dictParam.Add("bolIncludeFileNames", bolIncludeFileNames.ToString());
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                // 参数验证
                if (string.IsNullOrEmpty(strPrjId))
                {
                    return Ok(new
                    {
                        errorId = 1,
                        errorMsg = "工程Id不能为空",
                        statistics = new List<object>()
                    });
                }

                // 调用业务逻辑层方法
                List<CodeTypeStatInfo> arrStatistics;
                if (string.IsNullOrEmpty(strCmPrjId))
                {
                    arrStatistics = clsFileResourceBLEx.GetCodeTypeStatisticsByPrjId(strPrjId, bolIncludeFileNames);
                }
                else
                {
                    arrStatistics = clsFileResourceBLEx.GetCodeTypeStatisticsByPrjIdAndCmPrjId(
                        strPrjId, strCmPrjId, bolIncludeFileNames);
                }

                // 转换为返回格式
                var statistics = arrStatistics.Select(x => new
                {
                    codeTypeId = x.CodeTypeId ?? "",
                    codeTypeName = x.CodeTypeName ?? "",
                    fileCount = x.FileCount,
                    fileNames = bolIncludeFileNames ? x.FileNames : null
                }).ToList();

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    totalTypes = statistics.Count,
                    totalFiles = statistics.Sum(x => x.fileCount),
                    statistics = statistics
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new
                {
                    errorId = 1,
                    errorMsg = strMsg,
                    statistics = new List<object>()
                });
            }
        }

        /// <summary>
        /// 根据CodeTypeId获取文件列表
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strCodeTypeId">代码类型Id</param>
        /// <param name="strCmPrjId">Cm工程Id（可选）</param>
        /// <returns>返回文件列表</returns>
        [AllowAnonymous]
        [HttpGet("GetFilesByCodeTypeId")]
        public ActionResult GetFilesByCodeTypeId(string strPrjId, string strCodeTypeId, string strCmPrjId = "")
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId ?? "");
            dictParam.Add("strCodeTypeId", strCodeTypeId ?? "");
            dictParam.Add("strCmPrjId", strCmPrjId ?? "");
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                // 参数验证
                if (string.IsNullOrEmpty(strPrjId))
                {
                    return Ok(new
                    {
                        errorId = 1,
                        errorMsg = "工程Id不能为空",
                        files = new List<object>()
                    });
                }

                if (string.IsNullOrEmpty(strCodeTypeId))
                {
                    return Ok(new
                    {
                        errorId = 1,
                        errorMsg = "CodeTypeId不能为空",
                        files = new List<object>()
                    });
                }

                // 调用业务逻辑层方法
                var arrFiles = clsFileResourceBLEx.GetFilesByCodeTypeId(strPrjId, strCodeTypeId, strCmPrjId);

                // 转换为返回格式
                var files = arrFiles.Select(x => new
                {
                    fileResourceId = x.FileResourceId,
                    fileName = x.FileName ?? "",
                    fileDirName = x.FileDirName ?? "",
                    extension = x.Extension ?? "",
                    tabId = x.TabId ?? "",
                    codeTypeId = x.CodeTypeId ?? "",
                    fileLength = x.FileLength,
                    creationTime = x.CreationTime ?? "",
                    lastWriteTime = x.LastWriteTime ?? ""
                }).ToList();

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    count = files.Count,
                    files = files
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new
                {
                    errorId = 1,
                    errorMsg = strMsg,
                    files = new List<object>()
                });
            }
        }


        [AllowAnonymous]
        [HttpPost("ImportFileListFromClient")]
        public ActionResult ImportFileListFromClient([FromBody] ImportFileListFromClientRequest request)
        {
            const string strRoute = "/FileResourceExApi/ImportFileListFromClient";
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>
            {
                ["route"] = strRoute,
                ["prjId"] = request?.PrjId ?? "",
                ["cmPrjId"] = request?.CmPrjId ?? "",
                ["fileCount"] = request?.FileList?.Count.ToString() ?? "0"
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                if (request == null)
                {
                    return BadRequest(new
                    {
                        errorId = 400,
                        errorMsg = "请求体不能为空",
                        totalCount = 0,
                        addedCount = 0,
                        updatedCount = 0,
                        ignoredCount = 0,
                        failedCount = 0,
                        failedFiles = new List<string>()
                    });
                }

                var arrFileList = (request.FileList ?? new List<ImportFileListFromClientItem>())
                    .Select(x => new ClientImportFileItem
                    {
                        FileName = x.FileName,
                        FileDirName = x.FileDirName,
                        Extension = x.Extension,
                        FileLength = x.FileLength,
                        CreationTime = x.CreationTime,
                        LastWriteTime = x.LastWriteTime
                    }).ToList();

                var result = clsFileResourceBLEx.ImportFileListFromClient(
                    request.UserId,
                    request.PrjId,
                    request.CmPrjId,
                    request.ApplicationTypeId,
                    request.ServerIp,
                    arrFileList);

                if (result.ErrorId == 400)
                {
                    return BadRequest(new
                    {
                        errorId = result.ErrorId,
                        errorMsg = result.ErrorMsg,
                        totalCount = result.TotalCount,
                        addedCount = result.AddedCount,
                        updatedCount = result.UpdatedCount,
                        ignoredCount = result.IgnoredCount,
                        failedCount = result.FailedCount,
                        failedFiles = result.FailedFiles
                    });
                }

                if (result.ErrorId == 401)
                {
                    return StatusCode(401, new
                    {
                        errorId = result.ErrorId,
                        errorMsg = result.ErrorMsg,
                        totalCount = result.TotalCount,
                        addedCount = result.AddedCount,
                        updatedCount = result.UpdatedCount,
                        ignoredCount = result.IgnoredCount,
                        failedCount = result.FailedCount,
                        failedFiles = result.FailedFiles
                    });
                }

                if (result.ErrorId == 403)
                {
                    return StatusCode(403, new
                    {
                        errorId = result.ErrorId,
                        errorMsg = result.ErrorMsg,
                        totalCount = result.TotalCount,
                        addedCount = result.AddedCount,
                        updatedCount = result.UpdatedCount,
                        ignoredCount = result.IgnoredCount,
                        failedCount = result.FailedCount,
                        failedFiles = result.FailedFiles
                    });
                }

                if (result.ErrorId == 500)
                {
                    return StatusCode(500, new
                    {
                        errorId = result.ErrorId,
                        errorMsg = result.ErrorMsg,
                        totalCount = result.TotalCount,
                        addedCount = result.AddedCount,
                        updatedCount = result.UpdatedCount,
                        ignoredCount = result.IgnoredCount,
                        failedCount = result.FailedCount,
                        failedFiles = result.FailedFiles
                    });
                }

                return Ok(new
                {
                    errorId = result.ErrorId,
                    errorMsg = result.ErrorMsg,
                    totalCount = result.TotalCount,
                    addedCount = result.AddedCount,
                    updatedCount = result.UpdatedCount,
                    ignoredCount = result.IgnoredCount,
                    failedCount = result.FailedCount,
                    failedFiles = result.FailedFiles
                });
            }
            catch (UnauthorizedAccessException ex)
            {
                clsPubVar_WebApi.objLog.WriteDebugLog(
                    $"[ImportFileListFromClient][403] route={strRoute}, prjId={request?.PrjId}, cmPrjId={request?.CmPrjId}, fileCount={request?.FileList?.Count ?? 0}, err={ex}");
                return StatusCode(403, new
                {
                    errorId = 403,
                    errorMsg = $"权限不足：{ex.Message}",
                    totalCount = 0,
                    addedCount = 0,
                    updatedCount = 0,
                    ignoredCount = 0,
                    failedCount = 0,
                    failedFiles = new List<string>()
                });
            }
            catch (Exception ex)
            {
                clsPubVar_WebApi.objLog.WriteDebugLog(
                    $"[ImportFileListFromClient][500] route={strRoute}, prjId={request?.PrjId}, cmPrjId={request?.CmPrjId}, fileCount={request?.FileList?.Count ?? 0}, err={ex}");
                return StatusCode(500, new
                {
                    errorId = 500,
                    errorMsg = $"服务端异常：{ex.Message}",
                    totalCount = 0,
                    addedCount = 0,
                    updatedCount = 0,
                    ignoredCount = 0,
                    failedCount = 0,
                    failedFiles = new List<string>()
                });
            }
        }

        /// <summary>
        /// 同步表的所属ByCm工程Id
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strCmPrjId">Cm工程Id</param>        
        /// <returns>返回CodeTypeId统计信息</returns>
        [AllowAnonymous]
        [HttpGet("SyncTabOwnershipByCmPrjId")]
        public ActionResult SyncTabOwnershipByCmPrjId(string strPrjId, string strCmPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId ?? "");
            dictParam.Add("strCmPrjId", strCmPrjId ?? "");

            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                // 参数验证
                if (string.IsNullOrEmpty(strPrjId))
                {
                    return Ok(new
                    {
                        errorId = 1,
                        errorMsg = "工程Id不能为空",
                        returnInt = 0
                    });
                }

                // 调用业务逻辑层方法
                int UpdatedCount = clsFileResourceBLEx.SyncTabOwnershipByCmPrjId(strPrjId, strCmPrjId);

                return Ok(new { errorId = 0, errorMsg = "", returnInt = UpdatedCount });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new
                {
                    errorId = 1,
                    errorMsg = strMsg,
                    returnInt = 0
                });
            }
        }

    }
}
/// <summary>
/// 获取文件类型信息的请求参数类
/// </summary>
public class GetFileTypeInfoRequest
{
    /// <summary>
    /// 文件名（包括扩展名）
    /// </summary>
    public string FileName { get; set; }

    /// <summary>
    /// 工程Id
    /// </summary>
    public string PrjId { get; set; }
}

/// <summary>
/// 批量获取文件类型信息的请求参数类
/// </summary>
public class GetFileTypeInfoBatchRequest
{
    /// <summary>
    /// 文件名列表（包括扩展名）
    /// </summary>
    public List<string> FileNames { get; set; }

    /// <summary>
    /// 工程Id
    /// </summary>
    public string PrjId { get; set; }
}


public class ClientFileItem
{
    public string FileName { get; set; }
    public string FileDirName { get; set; }
    public string Extension { get; set; }
    public long? FileLength { get; set; }
    public string CreationTime { get; set; }
    public string LastWriteTime { get; set; }
}

public class ImportFileListFromClientRequest
{
    public string UserId { get; set; }
    public string PrjId { get; set; }
    public string CmPrjId { get; set; }
    public int ApplicationTypeId { get; set; }
    public string ServerIp { get; set; }
    public List<ImportFileListFromClientItem> FileList { get; set; }
}

public class ImportFileListFromClientItem
{
    public string FileName { get; set; }
    public string FileDirName { get; set; }
    public string Extension { get; set; }
    public long? FileLength { get; set; }
    public string CreationTime { get; set; }
    public string LastWriteTime { get; set; }
}
