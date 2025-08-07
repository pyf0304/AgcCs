
/*-- -- -- -- -- -- -- -- -- -- --
类名:AppCodeTypeRelaExApiController
表名:AppCodeTypeRela(00050418)
生成代码版本:2021.11.07.2
生成日期:2021/11/07 23:36:13
生成者:pyf
生成服务器IP:109.244.40.104
工程名称:AGC
工程ID:0005
相关数据库:109.244.40.104,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成代码
模块英文名:GeneCode
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

namespace AGC.WebApi
{
    /// <summary>
    /// AppCodeTypeRelaExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class AppCodeTypeRelaExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public AppCodeTypeRelaExApiController()
        {
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
        /// </summary>
        /// <param name = "objAppCodeTypeRela">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        [HttpPost("EditRecordEx")]
        public ActionResult EditRecordEx([FromBody] clsAppCodeTypeRelaEN objAppCodeTypeRela)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strAppCodeTypeRelaJSONObj = clsJSON.GetJsonFromObj(objAppCodeTypeRela);
            dictParam.Add("strAppCodeTypeRelaJSONObj", strAppCodeTypeRelaJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            objAppCodeTypeRela._IsCheckProperty = true;
            try
            {
                bool bolResult = true;//如果要使用，解除注释---- objAppCodeTypeRela.EditRecordEx();
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

    }
}