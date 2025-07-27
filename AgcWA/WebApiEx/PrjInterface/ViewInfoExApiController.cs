using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AGC.BusinessLogicEx;
using com.taishsoft.common;
using Newtonsoft.Json.Linq; using Comm.WebApi;

namespace AGC.WebApi
{
    /// <summary>
    /// ViewInfoExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class ViewInfoExApiController : ViewInfoApiController
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public ViewInfoExApiController()
        {
        }

        /// <summary>
        /// 生成区域和字段
        /// 调用方法: Get /api/clsViewInfoBLExApi/ImportRegionAndFlds1?strViewId=value&strRegionTypeId=value&strOpUserId=value&strRegionName=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <param name = "strRegionTypeId">区域类型Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <param name = "strRegionName">区域名称</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("ImportRegionAndFlds1")]
        public ActionResult ImportRegionAndFlds1(string strViewId, string strRegionTypeId, string strOpUserId, string strRegionName)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strRegionTypeId", strRegionTypeId);
            dictParam.Add("strOpUserId", strOpUserId);
            dictParam.Add("strRegionName", strRegionName);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsViewInfoBLEx.ImportRegionAndFlds1(strViewId, strRegionTypeId, strOpUserId, strRegionName);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }


        /// <summary>
        /// 为界面设置修改日期
        /// 调用方法: Get /api/clsViewInfoBLExApi/SetViewUpdDate?strViewId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("SetViewUpdDate")]
        public ActionResult SetViewUpdDate(string strViewId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewId", strViewId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsViewInfoBLEx.SetViewUpdDate(strViewId);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = varResult });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }



        /// <summary>
        /// 扩展删除界面
        /// 调用方法: Get /api/clsViewInfoBLExApi/DelRecordEx?strViewId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("DelRecordEx")]
        public ActionResult DelRecordEx(string strViewId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewId", strViewId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsViewInfoBLEx.DelRecordEx(strViewId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// 设置Cm工程Id
        /// 调用方法: Get /api/clsViewInfoBLExApi/SetCmPrjId?strViewId=value&strRegionId=value&strUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <param name = "strRegionId">区域Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("SetCmPrjId")]
        public ActionResult SetCmPrjId(string strViewId, string strCmPrjId, string strUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strCmPrjId", strCmPrjId);
            dictParam.Add("strUserId", strUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsViewInfoBLEx.SetCmPrjId(strViewId, strCmPrjId, strUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 检查区域字段
        /// 调用方法: Get /api/clsViewInfoBLExApi/CheckRegionFlds?strViewId=value&strCmPrjId=value&strUpdUser=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <param name = "strUpdUser">修改用户</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CheckRegionFlds")]
        public ActionResult CheckRegionFlds(string strViewId, string strCmPrjId, string strUpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strCmPrjId", strCmPrjId);
            dictParam.Add("strUpdUser", strUpdUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsViewInfoBLEx.CheckRegionFlds(strViewId, strCmPrjId, strUpdUser);
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