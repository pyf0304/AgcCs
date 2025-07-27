
/*-- -- -- -- -- -- -- -- -- -- --
类名:UserDefaValue_LocalExApiController
表名:UserDefaValue_Local(00050089)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:44:16
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:用户管理
模块英文名:UserManage
框架-层名:WebApi扩展层(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AGC.BusinessLogicEx;
using com.taishsoft.common;
using Newtonsoft.Json.Linq; 
using Comm.WebApi;
using Microsoft.AspNetCore.Authorization;

namespace AGC.WebApi
{
    /// <summary>
    /// UserDefaValue_LocalExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class UserDefaValue_LocalExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public UserDefaValue_LocalExApiController()
        {
        }

        /// <summary>
        /// 设置用户缺省值
        /// 调用方法: Get /api/clsUserDefaValue_LocalBLExApi/setUserDefaValue?strCurrPrjId=value&strCurrSelPrjId=value&strUserId=value&strDefaValName=value&strUserDefaValue=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCurrPrjId">当前工程Id</param>
        /// <param name = "strCurrSelPrjId">当前用户选择的工程Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strDefaValName">缺省值名</param>
        /// <param name = "strUserDefaValue">用户缺省值</param>
        /// <returns>返回是否存在?</returns>
        [AllowAnonymous]
        [HttpGet("setUserDefaValue")]
        public ActionResult setUserDefaValue(string strCurrPrjId, string strCurrSelPrjId, string strUserId, string strDefaValName, string strUserDefaValue)
        {
            if (strCurrSelPrjId == "null") strCurrSelPrjId = "";
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strCurrPrjId", strCurrPrjId);
            dictParam.Add("strCurrSelPrjId", strCurrSelPrjId);
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strDefaValName", strDefaValName);
            dictParam.Add("strUserDefaValue", strUserDefaValue);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                if (string.IsNullOrEmpty(strCurrSelPrjId)) { strCurrSelPrjId = strCurrPrjId; }
                var varResult = clsUserDefaValue_LocalBLEx.setUserDefaValue(strCurrPrjId, strCurrSelPrjId, strUserId, strDefaValName, strUserDefaValue);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }



        /// <summary>
        /// 获取用户缺省值
        /// 调用方法: Get /api/clsUserDefaValue_LocalBLExApi/getUserDefaValue?strCurrPrjId=value&strCurrSelPrjId=value&strUserId=value&strDefaValName=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCurrPrjId">当前选择的工程Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strDefaValName">缺省值名</param>
        /// <returns>返回是否存在?</returns>
        [AllowAnonymous]
        [HttpGet("getUserDefaValue")]
        public ActionResult getUserDefaValue(string strCurrPrjId, string strCurrSelPrjId, string strUserId, string strDefaValName)
        {
            if (strCurrSelPrjId == "null") strCurrSelPrjId = "";
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strCurrPrjId", strCurrPrjId);
            if (string.IsNullOrEmpty(strCurrSelPrjId) == true)
            {
                dictParam.Add("strCurrSelPrjId", strCurrPrjId);
            }
            else
            {
                dictParam.Add("strCurrSelPrjId", strCurrSelPrjId);
            }
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strDefaValName", strDefaValName);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsUserDefaValue_LocalBLEx.getUserDefaValue(strCurrPrjId, strCurrSelPrjId, strUserId, strDefaValName);
                
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }
    }
}