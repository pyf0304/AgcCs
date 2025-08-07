
/*-- -- -- -- -- -- -- -- -- -- --
类名:vPrjTabFld_SimExApiController
表名:vPrjTabFld_Sim(00050589)
生成代码版本:2021.11.07.2
生成日期:2021/11/09 01:39:53
生成者:pyf
生成服务器IP:109.244.40.104
工程名称:AGC
工程ID:0005
相关数据库:109.244.40.104,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护
模块英文名:Table_Field
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
using AGC.BusinessLogic;
using System.Web;
using Microsoft.AspNetCore.Authorization;
namespace AGC.WebApi
{
    /// <summary>
    /// vPrjTabFld_SimExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class vPrjTabFld_SimExApiController : ControllerBase
    {

        /// <summary>
        /// 根据FldId和FldTypeId获取相关的对象列表
        /// 调用方法: Get /api/clsvPrjTabFld_SimBLExApi/getObjLstByFldIdAndFldType?strFldId=value&strFldTypeId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strFldId">字段Id</param>
        /// <param name = "strFldTypeId">字段类型Id</param>
        /// <returns>返回是否存在?</returns>
        [AllowAnonymous]
        [HttpGet("getObjLstByFldIdAndFldType")]
        public ActionResult getObjLstByFldIdAndFldType(string strFldId, string strFldTypeId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strFldId", strFldId);
            dictParam.Add("strFldTypeId", strFldTypeId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsvPrjTabFld_SimBLEx.getObjLstByFldIdAndFldType(strFldId, strFldTypeId);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }

}
