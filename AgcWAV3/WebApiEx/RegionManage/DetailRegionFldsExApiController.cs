
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
using Newtonsoft.Json.Linq; using Comm.WebApi;

namespace AGC.WebApi
{
    /// <summary>
    /// DetailRegionFldsExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class DetailRegionFldsExApiController : DetailRegionFldsApiController
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public DetailRegionFldsExApiController()
        {
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
        /// </summary>
        /// <param name = "objDetailRegionFlds">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        [HttpPost("EditRecordEx")]
        //public ActionResult EditRecordEx([FromBody]clsDetailRegionFldsEN objDetailRegionFlds)
        //{

        //    string strFunctionName = clsStackTrace.GetCurrFunction();
        //    Dictionary<string, string> dictParam = new Dictionary<string, string>();
        //    string strDetailRegionFldsJSONObj = clsJSON.GetJsonFromObj(objDetailRegionFlds);
        //    dictParam.Add("strDetailRegionFldsJSONObj", strDetailRegionFldsJSONObj);
        //    clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
        //    objDetailRegionFlds._IsCheckProperty = true;
        //    try
        //    {
        //        bool bolResult = objDetailRegionFlds.EditRecordEx();
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
        /// 调用方法: Get /api/clsDGRegionFldsBLExApi/ImportRelaFlds?strRegionId=value&strPrjId=value&strUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strRegionId">区域Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>返回是否存在?</returns>
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
                var varResult = clsDetailRegionFldsBLEx.ImportRelaFlds(strRegionId, strPrjId, strUserId);
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
        /// 调用方法: Get /api/clsDetailRegionFldsBLExApi/AdjustSequenceNumber?strDirect=value&lngMid=value
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
                var varResult = clsDetailRegionFldsBLEx.AdjustSequenceNumber(strDirect, lngMid);
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
        /// 调用方法: Get /api/clsDetailRegionFldsBLExApi/ReOrder?strRegionId=value
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
                clsDetailRegionFldsBLEx.ReOrder(strRegionId);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = "true" });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// 导入扩展字段
        /// 调用方法: Get /api/clsDetailRegionFldsBLExApi/ImportExtendFld?lngMid=value&strPrjId=value&strCmPrjId=value&strUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "lngMid">lngMid</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("ImportExtendFld")]
        public ActionResult ImportExtendFld(long lngMid, string strPrjId, string strUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("lngMid", lngMid.ToString());            
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strUserId", strUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDetailRegionFldsBLEx.ImportExtendFld(lngMid, strPrjId, strUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 检查区域控件，并回溯修改界面的错误信息
        /// 调用方法: Get /api/clsDetailRegionFldsBLExApi/CheckRegionFldsUp?strRegionId=value&strCmPrjId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strRegionId">区域Id</param>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CheckRegionFldsUp")]
        public ActionResult CheckRegionFldsUp(string strRegionId, string strCmPrjId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strRegionId", strRegionId);
            dictParam.Add("strCmPrjId", strCmPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDetailRegionFldsBLEx.CheckRegionFldsUp(strRegionId, strCmPrjId, strOpUserId);
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