
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:vFieldTab_Sim3ExApiController
 表名:vFieldTab_Sim3(00050590)
 生成代码版本:2021.11.07.2
 生成日期:2021/11/09 01:39:41
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
using Newtonsoft.Json.Linq; using Comm.WebApi;
using AGC.BusinessLogic;

namespace AGC.WebApi
{
 /// <summary>
 /// vFieldTab_Sim3ExApiController 的摘要说明
 /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
 /// </summary>
[ApiController]
[Route("[controller]")]
public class vFieldTab_Sim3ExApiController : ControllerBase
{ 

/// <summary>
/// 构造函数
 /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
/// </summary>
 public vFieldTab_Sim3ExApiController()
 {
 }
        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/vFieldTab_Sim3Api/GetObjLst?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("GetObjLstByCmPrjId")]
        public ActionResult GetObjLstByCmPrjId(string strCmPrjId)
        {            
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {
                ["strCmPrjId"] = strCmPrjId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strCmPrjId) == true)
            {
                string strMsg = string.Format("根据条件获取对象列表，strCmPrjId不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {                
                List<clsvFieldTab_SimEN> arrvFieldTab_Sim3ObjLst = clsvFieldTab_SimBLEx.GetObjLstByCmPrjId(strCmPrjId, "1=1");
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrvFieldTab_Sim3ObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        [HttpGet("GetObjLstByCmPrjIdByCond")]
        public ActionResult GetObjLstByCmPrjId(string strCmPrjId, string strCondition)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {
                ["strCmPrjId"] = strCmPrjId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strCmPrjId) == true)
            {
                string strMsg = string.Format("根据条件获取对象列表，strCmPrjId不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                List<clsvFieldTab_SimEN> arrvFieldTab_Sim3ObjLst = clsvFieldTab_SimBLEx.GetObjLstByCmPrjId(strCmPrjId, strCondition);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrvFieldTab_Sim3ObjLst });
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