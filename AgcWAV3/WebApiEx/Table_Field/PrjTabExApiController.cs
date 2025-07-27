using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.common;
using Comm.WebApi;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AGC.WebApi
{
    /// <summary>
    /// PrjTabExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class PrjTabExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public PrjTabExApiController()
        {
        }
    
        [HttpGet("SetUpdDate")]
        public ActionResult SetUpdDate(string strTabId, string strUserId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strUserId", strUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.SetUpdDate(strTabId, strUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// p_Init_Log4GeneTabCode
        /// 调用方法: Get /api/PrjTabExApiControllerApi/p_Init_Log4GeneTabCode?strPrjId=value&strUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">strUserId</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("p_Init_Log4GeneTabCode")]
        public ActionResult p_Init_Log4GeneTabCode(string strPrjId, string strUserId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strUserId", strUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.p_Init_Log4GeneTabCode(strPrjId, strUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// GetObjExLstByPrjIdEx
        /// 调用方法: Get /api/PrjTabExApiControllerApi/GetObjExLstByPrjIdEx?strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetObjExLstByPrjIdEx")]
        public ActionResult GetObjExLstByPrjIdEx(string strPrjId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.GetObjExLstByPrjIdEx(strPrjId);

                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// IsExistTabNameInCommonTable
        /// 调用方法: Get /api/PrjTabExApiControllerApi/IsExistTabNameInCommonTable?strTabName=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strTabName">表名</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("IsExistTabNameInCommonTable")]
        public ActionResult IsExistTabNameInCommonTable(string strTabName)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabName", strTabName);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.IsExistTabNameInCommonTable(strTabName);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }


        /// <summary>
        /// SetPrjTabFldNullBySQLTab
        /// 调用方法: Get /api/PrjTabExApiControllerApi/SetPrjTabFldNullBySQLTab?strTabId=value&strPrjId=value&strPrjDataBaseId=value&strUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strPrjDataBaseId">strPrjDataBaseId</param>
        /// <param name = "strUserId">strUserId</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("SetPrjTabFldNullBySQLTab")]
        public ActionResult SetPrjTabFldNullBySQLTab(string strTabId, string strPrjId, string strPrjDataBaseId, string strUserId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            dictParam.Add("strUserId", strUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                clsProjectsEN objProjects = clsProjectsBL.GetObjByPrjId(strPrjId);
                var varResult = clsTabCheckStatusBLEx.SetPrjTabFldNullBySQLTab(strTabId, objProjects, strPrjDataBaseId, strUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// 扩展删除表
        /// 调用方法: Get /api/clsPrjTabBLExApi/DelRecordEx?strTabId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("DelRecordEx")]
        public ActionResult DelRecordEx(string strTabId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.DelRecordEx(strTabId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }
        /// <summary>
        /// 根据条件分页获取JSON对象列表
        /// 调用方法: GET /api/PrjTabApi/GetObjLstByPager?intPageIndex=v1&intPageSize=v2&strOrderBy=v3&strWhereCond=v4&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByPager)
        /// </summary>
        /// <param name = "objPagerPara">分页获取记录的参数对象</param>
        /// <returns>返回JSON对象列表</returns>
        [HttpPost("GetObjLstByPagerEx")]
        public ActionResult GetObjLstByPagerEx([FromBody] stuPagerPara objPagerPara)
        {
            objPagerPara.whereCond = objPagerPara.whereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objPagerPara.whereCond) == true)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            if (objPagerPara.pageSize <= 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，每页记录数:[{0}]不能小于等于0!({1})", objPagerPara.pageSize, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            if (objPagerPara.pageIndex <= 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，页序号:[{0}]不能小于等于0!({1})", objPagerPara.pageIndex, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            List<clsPrjTabEN> arrPrjTabObjLst;
            try
            {
                arrPrjTabObjLst = clsPrjTabBLEx.GetObjLstByPagerEx(objPagerPara);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrPrjTabObjLst });
        }

        /// <summary>
        /// 删除Sql表中某些字段
        /// 调用方法: Get /api/clsPrjTabBLExApi/AlterTab4DropColumn?strTabId=value&strColumn_Name=value&strPrjDataBaseId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strColumn_Name">字段列名</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("AlterTab4DropColumn")]
        public ActionResult AlterTab4DropColumn(string strTabId, string strColumn_Name, string strPrjDataBaseId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strColumn_Name", strColumn_Name);
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.AlterTab4DropColumn(strTabId, strColumn_Name, strPrjDataBaseId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 向Sql表中添加字段
        /// 调用方法: Get /api/clsPrjTabBLExApi/AlterTab4AddField?lngMid=value&strPrjDataBaseId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "lngMid">lngMid</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("AlterTab4AddField")]
        public ActionResult AlterTab4AddField(long lngMid, string strPrjDataBaseId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("lngMid", lngMid.ToString());
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.AlterTab4AddField(lngMid, strPrjDataBaseId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 根据代码系统的字段信息修改Sql字段信息
        /// 调用方法: Get /api/clsPrjTabBLExApi/AlterTab4UpdateField?lngMid=value&strPrjDataBaseId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "lngMid">lngMid</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("AlterTab4UpdateField")]
        public ActionResult AlterTab4UpdateField(long lngMid, string strPrjDataBaseId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("lngMid", lngMid.ToString());
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.AlterTab4UpdateField(lngMid, strPrjDataBaseId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据表Id获取相关的视图表Id
        /// 调用方法: Get /api/clsPrjTabBLExApi/GetRelaViewTabIdByTabId?strTabId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetRelaViewTabIdByTabId")]
        public ActionResult GetRelaViewTabIdByTabId(string strTabId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.GetRelaViewTabIdByTabIdCache(strTabId, strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 根据视图的表Id获取相关的主表Id
        /// 调用方法: Get /api/clsPrjTabBLExApi/GetRelaTabIdByViewTabId?strViewTabId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strViewTabId">代表视图的表Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetRelaTabIdByViewTabId")]
        public ActionResult GetRelaTabIdByViewTabId(string strViewTabId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewTabId", strViewTabId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.GetRelaTabIdByViewTabId(strViewTabId);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 获取给定表(视图)为主表的相关子结点表
        /// 调用方法: Get /api/clsPrjTabBLExApi/GetRelaViewTabIdLstByTabId?strTabId=value&strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetRelaViewTabIdLstByTabId")]
        public ActionResult GetRelaViewTabIdLstByTabId(string strTabId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.GetRelaViewTabIdLstByTabId(strTabId, strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", varResult) });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 设置视图的所有字段的序号,根据视图的相关主表
        /// 调用方法: Get /api/clsPrjTabBLExApi/SetFldOrderNum4ViewByRelaTabId?strViewTabId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strViewTabId">代表视图的表Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("SetFldOrderNum4ViewByRelaTabId")]
        public ActionResult SetFldOrderNum4ViewByRelaTabId(string strViewTabId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewTabId", strViewTabId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.SetFldOrderNum4ViewByRelaTabId(strViewTabId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 把同一个工程的一个表复制到新表中,同时复制相关对象,以及该对象相关的字段。
        /// 调用方法: Get /api/clsPrjTabBLExApi/CopyPrjTabInSameProject?strSouPrjId=value&strSouTabId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strSouPrjId">源工程Id</param>
        /// <param name = "strSouTabId">源表Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CopyPrjTabInSameProject")]
        public ActionResult CopyPrjTabInSameProject(string strSouPrjId, string strSouCmPrjId, string strSouTabId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strSouPrjId", strSouPrjId);
            dictParam.Add("strSouCmPrjId", strSouCmPrjId);
            
            dictParam.Add("strSouTabId", strSouTabId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.CopyPrjTabInSameProject(strSouPrjId, strSouCmPrjId, strSouTabId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 获取给定表(视图)获取主键信息，为Web使用
        /// 调用方法: Get /api/clsPrjTabBLExApi/GetPrimaryTypeInfo?strTabId=value&strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetPrimaryTypeHtmlInfo")]
        public ActionResult GetPrimaryTypeHtmlInfo(string strTabId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.GetPrimaryTypeHtmlInfo(strTabId, strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 检查表字段
        /// 调用方法: Get /api/clsPrjTabBLExApi/CheckTabFlds?strTabId=value&strCmPrjId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [AllowAnonymous]
        [HttpGet("CheckTabFlds")]
        public ActionResult CheckTabFlds(string strTabId, string strPrjDataBaseId, string strCmPrjId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            dictParam.Add("strCmPrjId", strCmPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.CheckTabFlds(strTabId, strPrjDataBaseId, strCmPrjId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 导入Sql中的数据表到代码系统
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "arrSqlTable">Sql表对象列表</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpPost("ImportSqlTab")]
        public ActionResult ImportSqlTab([FromBody] clsImportSqlTab myData)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strJSONString = string.Join(",", myData.arrSqlTable);
            dictParam.Add("arrSqlTable", strJSONString);
            dictParam.Add("strPrjId", myData.strPrjId);
            dictParam.Add("strPrjDataBaseId", myData.strPrjDataBaseId);
            dictParam.Add("strOpUserId", myData.strOpUser);

            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                if (string.IsNullOrEmpty(myData.strPrjId) == true)
                {
                    string strMsg = string.Format("工程Id不能为空！(from {0})", clsStackTrace.GetCurrClassFunction());
                    return Ok(new { errorId = 1, errorMsg = strMsg });
                }
                if (string.IsNullOrEmpty(myData.strPrjDataBaseId) == true)
                {
                    string strMsg = string.Format("工程数据库Id不能为空！(from {0})", clsStackTrace.GetCurrClassFunction());
                    return Ok(new { errorId = 1, errorMsg = strMsg });
                }
                if (string.IsNullOrEmpty(myData.strOpUser) == true)
                {
                    string strMsg = string.Format("操作用户不能为空！(from {0})", clsStackTrace.GetCurrClassFunction());
                    return Ok(new { errorId = 1, errorMsg = strMsg });
                }
                //List<stuSqlTable> arrSqlTable =Json new List<stuSqlTable>(objImportSqlTab.arrSqlTable);

                List<stuSqlTable> arrSqlTable = JsonConvert.DeserializeObject<List<stuSqlTable>>(myData.arrSqlTable); //获取需要循环获取：foreach (var item in list)


                    var varResult = clsPrjTabBLEx.ImportSqlTab(arrSqlTable, myData.strPrjId, myData.strPrjDataBaseId, myData.strOpUser);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 获取某表的记录数
        /// 调用方法: Get /api/clsPrjTabBLExApi/GetTabRecNum?strTabId=value&strPrjDataBaseId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetTabRecNum")]
        public ActionResult GetTabRecNum(string strTabId, string strPrjDataBaseId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.GetTabRecNum(strTabId, strPrjDataBaseId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 设置表是否共享，同时也修改相关界面的共享性
        /// 调用方法: Get /api/clsPrjTabBLExApi/SetIsShare?strTabId=value&bolIsShare=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "bolIsShare">是否共享</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [AllowAnonymous]
        [HttpGet("SetIsShare")]
        public ActionResult SetIsShare(string strTabId, bool bolIsShare, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("bolIsShare", bolIsShare.ToString());
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.SetIsShare(strTabId, bolIsShare, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        [HttpGet("IsAppiedInViewList")]
        public ActionResult IsAppiedInViewList(string strTabId, string strPrjId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.IsAppiedInViewList(strTabId, strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }


        [HttpGet("IsAppiedInViewList4CmPrjId")]
        public ActionResult IsAppiedInViewList4CmPrjId(string strTabId, string strCmPrjId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strCmPrjId", strCmPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabBLEx.IsAppiedInViewList4CmPrjId(strTabId, strCmPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }
    }
    public class clsImportSqlTab
    {
        //clsPrjTabFldExWApi.js:628 {"arrKeyIds":["40436","156781"],"strTabId":"00050127","strPrjId":"0005","strPrjDataBaseId":"0005","strOpUser":"pyf"}
        public string arrSqlTable { set; get; }
        public string strPrjId { set; get; }
        public string strPrjDataBaseId { set; get; }
        public string strOpUser { set; get; }
    }
}