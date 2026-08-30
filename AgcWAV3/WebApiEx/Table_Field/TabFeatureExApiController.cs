using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using com.taishsoft.common;
using Comm.WebApi;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace AGC.WebApi
{
    /// <summary>
    /// TabFeatureExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class TabFeatureExApiController : TabFeatureApiController
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public TabFeatureExApiController()
        {
        }

        /// <summary>
        /// 添加“调整记录次序”表功能（后端实现调用）— 调用方法示例: GET /api/TabFeatureExApi/AddAdjustOrderNum? strTabId = value & strFeatureId = value & strPrjId = value & strOpUserId = value
        /// </summary>
        /// <param name="strTabId">表Id</param>
        /// <param name="strFeatureId">功能Id（通常为 enumPrjFeature.Tab_AdjustOrderNum_0167）</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strOpUserId">操作用户Id</param>
        [HttpGet("AddAdjustOrderNum")]
        public ActionResult AddAdjustOrderNum(string strTabId, string strFeatureId, string strPrjId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strFeatureId", strFeatureId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                var varResult = clsTabFeatureFldsBLEx.AddAdjustOrderNum(strTabId, strFeatureId, strPrjId, strOpUserId);

                // 刷新相关缓存，保持一致性
                clsTabFeatureBL.ReFreshCache(strPrjId);
                clsTabFeatureFldsBL.ReFreshCache(strPrjId);

                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
        /// <summary>
        /// 扩展删除表功能
        /// 调用方法: Get /api/clsTabFeatureBLExApi/DelRecordEx?strTabFeatureId=value&strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabFeatureId">表功能Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("DelRecordEx")]
        public ActionResult DelRecordEx(string strTabFeatureId, string strPrjId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabFeatureId", strTabFeatureId);
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsTabFeatureBLEx.DelRecordEx(strTabFeatureId, strPrjId);
                clsTabFeatureBL.ReFreshCache(strPrjId);
                clsTabFeatureFldsBL.ReFreshCache(strPrjId);

                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// 生成绑定函数4CSharp
        /// 调用方法: Get /api/clsTabFeatureBLExApi/GC_DdlBindFunction4CSharp?strTabFeatureId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabFeatureId">表功能Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GC_DdlBindFunction4CSharp")]
        public ActionResult GC_DdlBindFunction4CSharp(string strTabFeatureId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabFeatureId", strTabFeatureId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsTabFeatureBLEx.GC_DdlBindFunction4CSharp(strTabFeatureId);

                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }


        /// <summary>
        /// 生成绑定函数4TypeScript
        /// 调用方法: Get /api/clsTabFeatureBLExApi/GC_DdlBindFunctionInDiv4TypeScript?strTabFeatureId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabFeatureId">表功能Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GC_DdlBindFunctionInDiv4TypeScript")]
        public ActionResult GC_DdlBindFunctionInDiv4TypeScript(string strTabFeatureId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabFeatureId", strTabFeatureId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsTabFeatureBLEx.GC_DdlBindFunctionInDiv4TypeScript(strTabFeatureId);

                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// 添加表功能
        /// 调用方法: Get /api/clsTabFeatureBLExApi/AddTabFeature?strTabId=value&strFeatureId=value&strPrjId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strFeatureId">功能Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("AddTabFeature")]
        public ActionResult AddTabFeature(string strTabId, string strFeatureId, string strPrjId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strFeatureId", strFeatureId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsTabFeatureBLEx.AddTabFeature(strTabId, strFeatureId, strPrjId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
        /// <summary>
        /// 检查表功能字段
        /// 调用方法: Get /api/clsTabFeatureBLExApi/CheckTabFeatureFld?strTabFeatureId=value&strPrjId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabFeatureId">表功能Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CheckTabFeatureFld")]
        public ActionResult CheckTabFeatureFld(string strTabFeatureId, string strPrjId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabFeatureId", strTabFeatureId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsTabFeatureBLEx.CheckTabFeatureFld(strTabFeatureId, strPrjId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
        /// <summary>
        /// 根据TabId获取FeatureId列表
        /// 调用方法: Get /TabFeatureExApi/GetFeatureIdLstByTabId?strTabId=value
        /// </summary>
        /// <param name="strTabId">表Id</param>
        /// <returns>FeatureId列表</returns>
        [HttpGet("GetTabFeatureIdLstByTabId")]
        public ActionResult GetTabFeatureIdLstByTabId(string strTabId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            if (string.IsNullOrEmpty(strTabId) == true)
            {
                string strMsg = string.Format("参数[strTabId]不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }

            try
            {
                var varResult = clsTabFeatureBLEx.GetTabFeatureIdLstByTabId(strTabId);
                return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", varResult) });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
        /// <summary>
        /// 根据CmPrjId获取该Cm工程下所有有下拉框功能(Tab_BindDdl_0173)的TabId列表
        /// 调用方法: Get /TabFeatureExApi/GetTabIdLstWithBindDdlByCmPrjId?strCmPrjId=value
        /// </summary>
        /// <param name="strCmPrjId">CM工程Id</param>
        /// <returns>TabId列表</returns>
        [HttpGet("GetTabIdLstWithBindDdlByCmPrjId")]
        public ActionResult GetTabIdLstWithBindDdlByCmPrjId(string strCmPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strCmPrjId", strCmPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            if (string.IsNullOrEmpty(strCmPrjId) == true)
            {
                string strMsg = string.Format("参数[strCmPrjId]不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }

            try
            {
                var varResult = clsTabFeatureBLEx.GetTabIdLstWithBindDdlByCmPrjId(strCmPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", varResult) });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}