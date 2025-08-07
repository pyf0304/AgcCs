
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AGC.BusinessLogicEx;
using com.taishsoft.common;
using Newtonsoft.Json.Linq; using Comm.WebApi;

namespace AGC.WebApi
{
    /// <summary>
    /// ViewReferFilesExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class ViewReferFilesExApiController : ViewReferFilesApiController
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public ViewReferFilesExApiController()
        {
        }

        /// <summary>
        /// 从模板复制相关文件
        /// 调用方法: Get /api/clsViewReferFilesBLExApi/CopyFromTempplate?strViewId=value&strPrjId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CopyFromTempplate")]
        public ActionResult CopyFromTempplate(string strViewId, string strPrjId, string strOpUserId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsViewReferFilesBLEx.CopyFromTempplate(strViewId, strPrjId, strOpUserId);
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