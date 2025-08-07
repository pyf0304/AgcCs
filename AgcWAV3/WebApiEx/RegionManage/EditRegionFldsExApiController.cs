
/*-- -- -- -- -- -- -- -- -- -- --
类名:EditRegionFldsExApiController
表名:EditRegionFlds(00050116)
生成代码版本:2021.02.03.1
生成日期:2021/02/06 04:16:32
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
*/
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
using Microsoft.AspNetCore.Authorization;

namespace AGC.WebApi
{
    /// <summary>
    /// EditRegionFldsExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>

    [ApiController]
    [Route("[controller]")]
    public class EditRegionFldsExApiController : ControllerBase
    {
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public EditRegionFldsExApiController()
        {
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
        /// </summary>
        /// <param name = "objEditRegionFlds">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        //[HttpPost("EditRecordEx")]
        //public ActionResult EditRecordEx([FromBody]clsEditRegionFldsEN objEditRegionFlds)
        //{

        //    string strFunctionName = clsStackTrace.GetCurrFunction();
        //    Dictionary<string, string> dictParam = new Dictionary<string, string>();
        //    string strEditRegionFldsJSONObj = clsJSON.GetJsonFromObj(objEditRegionFlds);
        //    dictParam.Add("strEditRegionFldsJSONObj", strEditRegionFldsJSONObj);
        //    clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
        //    objEditRegionFlds._IsCheckProperty = true;
        //    try
        //    {
        //        bool bolResult = objEditRegionFlds.EditRecordEx();
        //        return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
        //        clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
        //                return Ok(new { errorId = 1, errorMsg = strMsg});

        //    }
        //}

        /// <summary>
        /// 导入相关字段
        /// 调用方法: Get /api/clsEditRegionFldsBLExApi/ImportRelaFlds?strRegionId=value&strPrjId=value&strUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strRegionId">区域Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>返回是否存在?</returns>

        [AllowAnonymous]
        [HttpGet("ImportRelaFlds")]
        public ActionResult ImportRelaFlds(string strRegionId, string strPrjId, string strUserId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strRegionId", strRegionId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strUserId", strUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsEditRegionFldsBLEx.ImportRelaFlds(strRegionId, strPrjId, strUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }


        /// <summary>
        /// 调整序号
        /// 调用方法: Get /api/clsEditRegionFldsBLExApi/AdjustSequenceNumber?strDirect=value&lngMid=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strDirect">调整方向</param>
        /// <param name = "lngMid">lngMid</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("AdjustSequenceNumber")]
        public ActionResult AdjustSequenceNumber(string strDirect, long lngMid)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strDirect", strDirect);
            dictParam.Add("lngMid", lngMid.ToString());
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsEditRegionFldsBLEx.AdjustSequenceNumber(strDirect, lngMid);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }


        /// <summary>
        /// 重序
        /// 调用方法: Get /api/clsEditRegionFldsBLExApi/ReOrder?strRegionId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strRegionId">区域Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("ReOrder")]
        public ActionResult ReOrder(string strRegionId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strRegionId", strRegionId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                clsEditRegionFldsBLEx.ReOrder(strRegionId);

                return Ok(new { errorId = 0, errorMsg = "", returnStr = "true" });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// 检查区域控件，并回溯修改界面的错误信息
        /// 调用方法: Get /api/clsEditRegionFldsBLExApi/CheckRegionFldsUp?strRegionId=value&strCmPrjId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strRegionId">区域Id</param>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CheckRegionFldsUp")]
        public ActionResult CheckRegionFldsUp(string strRegionId, string strViewId, string strCmPrjId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strRegionId", strRegionId);
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strCmPrjId", strCmPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsEditRegionFldsBLEx.CheckRegionFldsUp(strRegionId, strViewId, strCmPrjId, strOpUserId);
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