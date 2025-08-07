
/*-- -- -- -- -- -- -- -- -- -- --
类名:UserCodePrjMainPath_MachineNameExApiController
表名:UserCodePrjMainPath_MachineName(00140106)
生成代码版本:2022.12.04.1
生成日期:2022/12/06 10:30:27
生成者:pyf
生成服务器IP:
工程名称:统一平台(0014)
CM工程:统一平台Web(变量首字母不限定)-全部函数集
相关数据库:109.244.40.104,9433GeneralPlatformTz
PrjDataBaseId:0218
模块中文名:系统设置(SystemSet)
框架-层名:WA_服务扩展层(CS)(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
using AGC.Entity;
using com.taishsoft.common;
using com.taishsoft.json;
using Comm.WebApi;
using GeneralPlatform.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GeneralPlatform.WebApi
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
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public UserCodePrjMainPath_MachineNameExApiController()
        {
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
        /// </summary>
        /// <param name = "objUserCodePrjMainPath_MachineName">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        [HttpPost("EditRecordEx")]
        public ActionResult EditRecordEx([FromBody] clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            string strUserCodePrjMainPath_MachineNameJSONObj = clsJSON.GetJsonFromObj(objUserCodePrjMainPath_MachineName);
            dictParam.Add("strUserCodePrjMainPath_MachineNameJSONObj", strUserCodePrjMainPath_MachineNameJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            objUserCodePrjMainPath_MachineName._IsCheckProperty = true;
            try
            {
                bool bolResult = true;//如果要使用，解除注释---- objUserCodePrjMainPath_MachineName.EditRecordEx();
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
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