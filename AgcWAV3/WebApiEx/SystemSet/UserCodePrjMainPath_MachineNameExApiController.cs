
/*-- -- -- -- -- -- -- -- -- -- --
类名:UserCodePrjMainPath_MachineNameExApiController
表名:UserCodePrjMainPath_MachineName(00050614)
生成代码版本:2022.11.24.1
生成日期:2022/12/03 19:33:29
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
相关数据库:109.244.40.104,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:系统设置(SystemSet)
框架-层名:WA_服务扩展层(CS)(WA_SrvEx)
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
    /// UserCodePrjMainPath_MachineNameExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>


    [ApiController]
    [Route("[controller]")]
    public class UserCodePrjMainPath_MachineNameExApiController : ControllerBase
    {
        /// <summary>
        /// 根据当前项目与应用类型，获取生成代码根目录。
        /// </summary>
        /// <param name="strPrjId">当前项目Id</param>
        /// <param name="strCmPrjId">当前CM工程Id</param>
        /// <param name="intApplicationTypeId">当前应用类型Id</param>
        /// <returns>生成代码根目录</returns>
        [AllowAnonymous]
        [HttpGet("GetGeneCodeRootPath")]
        public ActionResult GetGeneCodeRootPath(string strUserId, string strMachineName, string strPrjId, string strCmPrjId, int intApplicationTypeId)
        {
            string strFunctionName = nameof(GetGeneCodeRootPath);
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strMachineName", strMachineName);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strCmPrjId", strCmPrjId);
            dictParam.Add("intApplicationTypeId", intApplicationTypeId.ToString());
            try
            {
                // 这里直接调用 DAL 层 BLEx
                string strRootPath = clsUserCodePrjMainPath_MachineNameBLEx.GetUserGCRootPath(
                    strUserId,
                    strMachineName,
                    strPrjId,
                    strCmPrjId,
                    intApplicationTypeId);

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    returnStr = strRootPath,
                    strPrjId,
                    strCmPrjId,
                    intApplicationTypeId,
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, strFunctionName);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 根据当前项目与应用类型，获取生成代码根目录及备份目录。
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strMachineName">机器名称</param>
        /// <param name="strPrjId">当前项目Id</param>
        /// <param name="strCmPrjId">当前CM工程Id</param>
        /// <param name="intApplicationTypeId">当前应用类型Id</param>
        /// <returns>返回生成代码根目录和备份目录</returns>
        [AllowAnonymous]
        [HttpGet("GetUserGCRootPathWithBackup")]
        public ActionResult GetUserGCRootPathWithBackup(
            string strUserId,
            string strMachineName,
            string strPrjId,
            string strCmPrjId,
            int intApplicationTypeId)
        {
            string strFunctionName = nameof(GetUserGCRootPathWithBackup);
            Dictionary<string, string> dictParam = new Dictionary<string, string>
            {
                ["strUserId"] = strUserId,
                ["strMachineName"] = strMachineName,
                ["strPrjId"] = strPrjId,
                ["strCmPrjId"] = strCmPrjId,
                ["intApplicationTypeId"] = intApplicationTypeId.ToString()
            };

            try
            {
                // 调用业务逻辑层获取代码路径和备份路径
                var (codePath, codePathBackup) = clsUserCodePrjMainPath_MachineNameBLEx.GetUserGCRootPathWithBackup(
                    strUserId,
                    strMachineName,
                    strPrjId,
                    strCmPrjId,
                    intApplicationTypeId);

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    codePath = codePath,
                    codePathBackup = codePathBackup,
                    strPrjId = strPrjId,
                    strCmPrjId = strCmPrjId,
                    intApplicationTypeId = intApplicationTypeId
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, strFunctionName);
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
        /// 设置用户生成代码根目录及备份目录
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strMachineName">机器名称</param>
        /// <param name="strPrjId">当前项目Id</param>
        /// <param name="strCmPrjId">当前CM工程Id</param>
        /// <param name="intApplicationTypeId">当前应用类型Id</param>
        /// <param name="strCodePath">代码路径</param>
        /// <param name="strCodePathBackup">备份代码路径</param>
        /// <returns>返回是否设置成功</returns>
        [AllowAnonymous]
        [HttpPost("SetUserGCRootPathWithBackup")]
        public ActionResult SetUserGCRootPathWithBackup(
            [FromBody] SetUserGCRootPathRequest request)
        {
            string strFunctionName = nameof(SetUserGCRootPathWithBackup);
            Dictionary<string, string> dictParam = new Dictionary<string, string>
            {
                ["strUserId"] = request.StrUserId,
                ["strMachineName"] = request.StrMachineName,
                ["strPrjId"] = request.StrPrjId,
                ["strCmPrjId"] = request.StrCmPrjId,
                ["intApplicationTypeId"] = request.IntApplicationTypeId.ToString(),
                ["strCodePath"] = request.StrCodePath,
                ["strCodePathBackup"] = request.StrCodePathBackup
            };

            try
            {
                // 调用业务逻辑层设置代码路径和备份路径
                bool bolResult = clsUserCodePrjMainPath_MachineNameBLEx.SetUserGCRootPathWithBackup(
                    request.StrUserId,
                    request.StrMachineName,
                    request.StrPrjId,
                    request.StrCmPrjId,
                    request.IntApplicationTypeId,
                    request.StrCodePath,
                    request.StrCodePathBackup);

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    success = bolResult,
                    message = bolResult ? "路径设置成功" : "路径设置失败"
                });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, strFunctionName);
                return Ok(new
                {
                    errorId = 1,
                    errorMsg = strMsg,
                    success = false,
                    message = "路径设置失败"
                });
            }
        }
    }

    /// <summary>
    /// 设置用户生成代码根路径请求参数
    /// </summary>
    public class SetUserGCRootPathRequest
    {
        public string StrUserId { get; set; }
        public string StrMachineName { get; set; }
        public string StrPrjId { get; set; }
        public string StrCmPrjId { get; set; }
        public int IntApplicationTypeId { get; set; }
        public string StrCodePath { get; set; }
        public string StrCodePathBackup { get; set; }
    }
}
