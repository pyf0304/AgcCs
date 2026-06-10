
/*-- -- -- -- -- -- -- -- -- -- --
类名:ViewFeatureFldsExApiController
表名:ViewFeatureFlds(00050453)
生成代码版本:2021.11.07.2
生成日期:2021/11/09 01:39:45
生成者:pyf
生成服务器IP:109.244.40.104
工程名称:AGC
工程ID:0005
相关数据库:109.244.40.104,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:区域管理
模块英文名:RegionManage
框架-层名:WA_服务扩展层(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.commdb;
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
    /// ViewFeatureFldsExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ViewFeatureFldsExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public ViewFeatureFldsExApiController()
        {
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// </summary>
        /// <param name = "objViewFeatureFlds">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        [HttpPost("EditRecordEx")]
        public ActionResult EditRecordEx([FromBody] clsViewFeatureFldsEN objViewFeatureFlds)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strViewFeatureFldsJSONObj = clsJSON.GetJsonFromObj(objViewFeatureFlds);
            dictParam.Add("strViewFeatureFldsJSONObj", strViewFeatureFldsJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            objViewFeatureFlds._IsCheckProperty = true;
            try
            {
                bool bolResult = objViewFeatureFlds.EditRecordEx();
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
        /// 根据界面ID获取功能区下拉框选项信息列表
        /// 调用方法: Get /ViewFeatureFldsExApi/GetDdlOptionInfoLstByViewId?strViewId=value&strPrjId=value
        /// </summary>
        /// <param name = "strViewId">界面ID</param>
        /// <param name = "strPrjId">工程ID</param>
        /// <returns>返回下拉框选项信息列表</returns>
        [AllowAnonymous]
        [HttpGet("GetDdlOptionInfoLstByViewId")]
        public ActionResult GetDdlOptionInfoLstByViewId(string strViewId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var arrDdlOptionsInfo = clsViewFeatureFldsBLEx.GetDdlOptionInfoLstByViewId(strViewId, strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", data = arrDdlOptionsInfo });
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