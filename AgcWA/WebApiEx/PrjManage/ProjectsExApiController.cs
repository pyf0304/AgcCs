
/*-- -- -- -- -- -- -- -- -- -- --
类名:ProjectsExApiController
表名:Projects(00050002)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:39:06
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:工程管理
模块英文名:PrjManage
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
using AGC.BusinessLogicEx;
using Newtonsoft.Json.Linq; using Comm.WebApi;

namespace AGC.WebApi
{
    /// <summary>
    /// ProjectsExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class ProjectsExApiController : ProjectsApiController
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public ProjectsExApiController()
        {
        }


        /// <summary>
        /// CheckCheckedTabField
        /// 调用方法: Get /api/ProjectsExApiControllerApi/CheckCheckedTabField?strPrjId=value&strPrjDataBaseId=value&strUserId=value&arrTabIdLst=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strPrjDataBaseId">strPrjDataBaseId</param>
        /// <param name = "strUserId">strUserId</param>
        /// <param name = "arrTabIdLst">arrTabIdLst</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CheckCheckedTabField")]
        public ActionResult CheckCheckedTabField(string strPrjId, string strPrjDataBaseId, string strUserId, List<string> arrTabIdLst)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            dictParam.Add("strUserId", strUserId);
            string strJSONString = string.Join(",", arrTabIdLst);
            dictParam.Add("arrTabIdLst", strJSONString);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsTabCheckStatusBLEx.CheckCheckedTabField(strPrjId, strPrjDataBaseId, strUserId, arrTabIdLst);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// CheckAllTabField
        /// 调用方法: Get /api/ProjectsExApiControllerApi/CheckAllTabField?strPrjId=value&strPrjDataBaseId=value&strUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strPrjDataBaseId">strPrjDataBaseId</param>
        /// <param name = "strUserId">strUserId</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CheckAllTabField")]
        public ActionResult CheckAllTabField(string strPrjId, string strPrjDataBaseId, string strUserId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            dictParam.Add("strUserId", strUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsTabCheckStatusBLEx.CheckAllTabField(strPrjId, strPrjDataBaseId, strUserId);
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