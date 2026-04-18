using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.common;
using Comm.WebApi;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using static AGC.Entity.CopyTaskStatusResultDto;

namespace AGC.WebApi
{
    /// <summary>
    /// ViewInfoExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ViewInfoExApiController : ControllerBase
    {



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
        [AllowAnonymous]
        [HttpGet("ImportRegionAndFlds1")]
        public ActionResult ImportRegionAndFlds1([FromQuery] string strViewId, string strRegionTypeId, string strOpUserId, string? strRegionName)
        {
            if (strRegionName == "null") strRegionName = "";
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strRegionTypeId", strRegionTypeId);
            dictParam.Add("strOpUserId", strOpUserId);
            dictParam.Add("strRegionName", strRegionName ?? "");
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
        [AllowAnonymous]
        [HttpGet("CheckRegionFlds")]
        public ActionResult CheckRegionFlds(string strViewId, string strPrjDataBaseId, string strCmPrjId, string strUpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            dictParam.Add("strCmPrjId", strCmPrjId);
            dictParam.Add("strUpdUser", strUpdUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsViewInfoBLEx.CheckRegionFlds(strViewId, strPrjDataBaseId, strCmPrjId, strUpdUser);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
        /// <summary>
        /// 从工程表同步信息
        /// 调用方法: Get /api/clsViewInfoBLExApi/SynchInfoFromPrjTab?strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回是否存在?</returns>
        [AllowAnonymous]
        [HttpGet("SynchInfoFromPrjTab")]
        public ActionResult SynchInfoFromPrjTab(string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsViewInfoBLEx.SynchInfoFromPrjTab(strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
        /// <summary>
        /// 启动或恢复复制任务（只创建/恢复任务，不执行复制）
        /// 调用方法: Get /api/ViewInfoExApi/StartOrResumeCopyTask?strTarPrjId=value&strSouViewId=value&strUserId=value&strConflictStrategy=value
        /// </summary>
        /// <param name="strTarPrjId">目标工程ID</param>
        /// <param name="strSouViewId">源界面ID</param>
        /// <param name="strUserId">操作用户ID</param>
        /// <param name="strConflictStrategy">冲突策略: skip/overwrite/rename</param>
        /// <returns>返回任务信息</returns>
        [HttpGet("StartOrResumeCopyTask")]
        public ActionResult StartOrResumeCopyTask(string strTarPrjId, string strSouViewId, string strUserId, string strConflictStrategy)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTarPrjId", strTarPrjId);
            dictParam.Add("strSouViewId", strSouViewId);
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strConflictStrategy", strConflictStrategy);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                StartOrResumeCopyTaskResultDto result = clsViewInfoBLEx.StartOrResumeCopyTask(
                    strTarPrjId, strSouViewId, strUserId, strConflictStrategy);
                return Ok(result);
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("{0}.(from {1})", ex.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);

                StartOrResumeCopyTaskResultDto errorResult = new StartOrResumeCopyTaskResultDto
                {
                    status = "Failed",
                    message = strMsg
                };
                return Ok(errorResult);
            }
        }

        /// <summary>
        /// 执行复制任务（真正执行复制逻辑）
        /// 调用方法: Get /api/ViewInfoExApi/ExecuteCopyTask?taskId=value
        /// </summary>
        /// <param name="taskId">任务ID</param>
        /// <returns>返回执行结果</returns>
        [HttpGet("ExecuteCopyTask")]
        public ActionResult ExecuteCopyTask(long lngTaskId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("taskId", lngTaskId.ToString());
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                ExecuteCopyTaskResultDto result = clsViewInfoBLEx.ExecuteCopyTask(lngTaskId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("{0}.(from {1})", ex.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);

                ExecuteCopyTaskResultDto errorResult = new ExecuteCopyTaskResultDto
                {
                    success = false,
                    message = strMsg
                };
                return Ok(errorResult);
            }
        }

        /// <summary>
        /// 查询复制任务状态
        /// 调用方法: Get /api/ViewInfoExApi/GetCopyTaskStatus?taskId=value
        /// </summary>
        /// <param name="taskId">任务ID</param>
        /// <returns>返回任务状态</returns>
        [HttpGet("GetCopyTaskStatus")]
        public ActionResult GetCopyTaskStatus(long lngTaskId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("lngTaskId", lngTaskId.ToString());
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                GetCopyTaskStatusResultDto result = clsViewInfoBLEx.GetCopyTaskStatus(lngTaskId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("{0}.(from {1})", ex.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);

                GetCopyTaskStatusResultDto errorResult = new GetCopyTaskStatusResultDto
                {
                    status = "Failed",
                    message = strMsg
                };
                return Ok(errorResult);
            }
        }

        /// <summary>
        /// 取消复制任务
        /// 调用方法: Get /api/ViewInfoExApi/CancelCopyTask?taskId=value&strUserId=value
        /// </summary>
        /// <param name="taskId">任务ID</param>
        /// <param name="strUserId">操作用户ID</param>
        /// <returns>返回取消结果</returns>
        [HttpGet("CancelCopyTask")]
        public ActionResult CancelCopyTask(long taskId, string strUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("taskId", taskId.ToString());
            dictParam.Add("strUserId", strUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                bool result = clsViewInfoBLEx.CancelCopyTask(taskId, strUserId);
                return Ok(new { success = result, message = result ? "任务已取消" : "取消任务失败" });
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("{0}.(from {1})", ex.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { success = false, message = strMsg });
            }
        }

        /// <summary>
        /// 根据目标工程和源界面查询复制任务状态
        /// 调用方法: Get /api/ViewInfoExApi/GetCopyTaskStatusByView?strTarPrjId=value&strSouViewId=value
        /// </summary>
        /// <param name="strTarPrjId">目标工程ID</param>
        /// <param name="strSouViewId">源界面ID</param>
        /// <returns>返回任务状态</returns>
        [HttpGet("GetCopyTaskStatusByView")]
        public ActionResult GetCopyTaskStatusByView(string strTarPrjId, string strSouViewId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTarPrjId", strTarPrjId);
            dictParam.Add("strSouViewId", strSouViewId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                if (string.IsNullOrEmpty(strTarPrjId) || string.IsNullOrEmpty(strSouViewId))
                {
                    return Ok(new
                    {
                        errorId = 1,
                        errorMsg = "参数不能为空: strTarPrjId, strSouViewId"
                    });
                }

                CopyTaskStatusResultDto result = clsViewInfoBLEx.GetCopyTaskStatusByView(strTarPrjId, strSouViewId);

                return Ok(new
                {
                    errorId = 0,
                    errorMsg = "",
                    returnObj = result
                });
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("{0}.(from {1})", ex.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);

                return Ok(new
                {
                    errorId = 1,
                    errorMsg = strMsg
                });
            }
        }
    }
}