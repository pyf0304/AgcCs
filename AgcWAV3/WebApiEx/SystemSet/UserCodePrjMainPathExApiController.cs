
/*-- -- -- -- -- -- -- -- -- -- --
类名:UserCodePrjMainPathExApiController
表名:UserCodePrjMainPath(00050338)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:44:54
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
using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using com.taishsoft.json;
using AGC.Entity;
using AGC.BusinessLogic;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json.Linq; using Comm.WebApi;
using AGC.BusinessLogicEx;
using Microsoft.AspNetCore.Authorization;

namespace AGC.WebApi
{
    /// <summary>
    /// UserCodePrjMainPathExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserCodePrjMainPathExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public UserCodePrjMainPathExApiController()
        {
        }

        /// <summary>
        /// 设置GC路径
        /// 调用方法: Get /api/clsUserCodePrjMainPathBLExApi/SetGCPath?strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("SetGCPath")]
        public ActionResult SetGCPath(string strMachineName, string strOpUserId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsUserCodePrjMainPathBLEx.SetGCPath(strMachineName, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// 扩展删除
        /// 调用方法: Get /api/clsUserCodePrjMainPathBLExApi/DelRecordEx?strUserCodePrjMainPathId=value&strCmPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strUserCodePrjMainPathId">生成主目录Id</param>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <returns>返回是否存在?</returns>
        [AllowAnonymous]
        [HttpGet("DelRecordEx")]
        public ActionResult DelRecordEx(string strUserCodePrjMainPathId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strUserCodePrjMainPathId", strUserCodePrjMainPathId);
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsUserCodePrjMainPathBLEx.DelRecordEx(strUserCodePrjMainPathId, strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
        [AllowAnonymous]
        [HttpGet("SetMinCmPrjIdAppTypeId")]
        public ActionResult SetMinCmPrjIdAppTypeId()
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
                        clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsUserCodePrjMainPathBLEx.SetMinCmPrjIdAppTypeId();
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