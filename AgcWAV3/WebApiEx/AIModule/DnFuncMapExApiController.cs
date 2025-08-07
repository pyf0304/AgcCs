
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:DnFuncMapExApiController
 表名:DnFuncMap(00050549)
 * 版本:2023.01.20.1(服务器:WIN-SRV103-116)
 日期:2023/01/30 11:08:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
 框架-层名:WA_服务扩展层(CS)(WA_SrvEx)
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

using com.taishsoft.common;
using com.taishsoft.datetime;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json.Linq; 
using Comm.WebApi;
using AGC.BusinessLogic;
using Microsoft.AspNetCore.Authorization;

namespace AGC.WebApi
{
 /// <summary>
 /// DnFuncMapExApiController 的摘要说明
 /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
 /// </summary>
[ApiController]
[Route("[controller]")]
public class DnFuncMapExApiController : ControllerBase
{

        /// <summary>
        /// 检查结点关系，如果有结点关系的相关表为空，或者相关表的缓存模式不正确就抛错.
        /// 调用方法: Get /api/clsDnFuncMapBLExApi/CheckDnFuncMapByCmPrjId?strCmPrjId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CheckDnFuncMapByPrjId")]
        public ActionResult CheckDnFuncMapByPrjId(string strPrjId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDnFuncMapBLEx.CheckDnFuncMapByPrjId(strPrjId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
  

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public DnFuncMapExApiController()
        {
        }

        ///// <summary>
        ///// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        ///// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
        ///// </summary>
        ///// <param name = "objDnFuncMap">需要修改的实体对象</param>
        ///// <returns>修改是否成功？</returns>
        //[HttpPost("EditRecordEx")]
        //public ActionResult EditRecordEx([FromBody]clsDnFuncMapEN objDnFuncMap)
        //{

        //    string strFunctionName = clsStackTrace.GetCurrFunction();
        //    Dictionary<string, string> dictParam = new Dictionary<string, string>();
        //    string strDnFuncMapJSONObj = clsJSON.GetJsonFromObj(objDnFuncMap);
        //    dictParam.Add("strDnFuncMapJSONObj", strDnFuncMapJSONObj);
        //    clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
        //    objDnFuncMap._IsCheckProperty = true;
        //    try
        //    {
        //        bool bolResult = objDnFuncMap.EditRecordEx();
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
        /// 获取环的结点列表
        /// 调用方法: Get /api/clsDnFuncMapBLExApi/GetRingNodeLst?strCmPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetRingNodeLst")]
        public ActionResult GetRingNodeLst(string strCmPrjId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strCmPrjId", strCmPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDnFuncMapBLEx.GetRingNodeLst(strCmPrjId);

                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }


        /// <summary>
        /// 获取环的边列表
        /// 调用方法: Get /api/clsDnFuncMapBLExApi/GetRingEdgeLst?strCmPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetRingEdgeLst")]
        public ActionResult GetRingEdgeLst(string strCmPrjId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strCmPrjId", strCmPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDnFuncMapBLEx.GetRingEdgeLst(strCmPrjId);
                if (varResult == null)
                {
                    return Ok(new { errorId = 0, errorMsg = "", returnStrLst = "" });
                }

                return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", varResult) });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// 根据输入，输出结点获取相关路径列表, 从缓存的对象列表中获取.没有就返回null.
        /// 调用方法: Get /api/clsDnFuncMapBLExApi/GetGraphPath?strStartNodeId=value&strEndNodeId=value&strCmPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strStartNodeId">开始结点</param>
        /// <param name = "strEndNodeId">末端结点Id</param>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <returns>返回是否存在?</returns>
        [AllowAnonymous]
        [HttpGet("GetGraphPath")]
        public ActionResult GetGraphPath(long strStartNodeId, long strEndNodeId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strStartNodeId", strStartNodeId.ToString());
            dictParam.Add("strEndNodeId", strEndNodeId.ToString());
            if (strStartNodeId == 15423)
            {
                string ss = "";
            }
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDnFuncMapBLEx.GetGraphPath(strStartNodeId, strEndNodeId, strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:获取某一条件的记录数
        /// 调用方法: GET /api/DnFuncMapApi/GetRecCountByCond?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetRecCountByCond)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>某一条件的记录数</returns>
        [HttpGet("GetRecCountByCondNoCache")]
        public ActionResult GetRecCountByCondNoCache(string strWhereCond)
        {
            strWhereCond = strWhereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {
                ["strWhereCond"] = strWhereCond
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strWhereCond) == true)
            {
                string strMsg = string.Format("获取某一条件的记录数，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                strWhereCond += string.Format(" and tabId in (select TabId from PrjTab where cachemodeid not in ('02', '03', '04'))");
                int intCount = clsDnFuncMapBL.GetRecCountByCond(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
        /// <summary>
        /// 根据条件分页获取JSON对象列表
        /// 调用方法: GET /api/DnFuncMapApi/GetObjLstByPager?intPageIndex=v1&intPageSize=v2&strOrderBy=v3&strWhereCond=v4&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByPager)
        /// </summary>
        /// <param name = "objPagerPara">分页获取记录的参数对象</param>
        /// <returns>返回JSON对象列表</returns>
        [HttpPost("GetObjLstByPagerNoCache")]
        public ActionResult GetObjLstByPagerNoCache([FromBody] stuPagerPara objPagerPara)
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
            List<clsDnFuncMapEN> arrDnFuncMapObjLst;
            try
            {
                objPagerPara.whereCond += string.Format(" and tabId in (select TabId from PrjTab where cachemodeid not in ('02', '03', '04'))");
                arrDnFuncMapObjLst = clsDnFuncMapBL.GetObjLstByPager(objPagerPara);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrDnFuncMapObjLst });
        }

        /// <summary>
        /// 功能:同时删除多条记录,删除给定关键字列表的记录
        /// 调用方法: POST /api/DnFuncMapApi/DelDnFuncMaps
        /// 在Body区传输arrDnFuncMapId(关键字值列表)的JSON串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecord)
        /// </summary>
        /// <param name = "arrDnFuncMapId">给定的关键字值列表</param>
        /// <returns>返回删除的记录数</returns>
        [HttpPost("DelDnFuncMapsEx")]
        public ActionResult DelDnFuncMapsEx([FromBody] string[] arrDnFuncMapId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            List<string> arrLst = new(arrDnFuncMapId);
            dictParam.Add("arrDnFuncMapId", clsArray.GetSqlInStrByArray(arrLst, true));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                int intRecNum = clsDnFuncMapBLEx.DelDnFuncMapsEx(arrLst);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据TabId获取相关的FldId列表
        /// 调用方法: Get /api/clsPrjTabFldBLExApi/GetFldIdLstByTabIdCache?strTabId=value&strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetFldIdLstByTabIdCache")]
        public ActionResult GetFldIdLstByTabIdCache(string strTabId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabFldBLEx.GetFldIdLstByTabIdCache(strTabId, strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", varResult) });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
        /// <summary>
        /// 扩展删除在删除的同时，删除引用的路径
        /// 调用方法: Get /api/clsDnFuncMapBLExApi/DelRecordEx?strDnFuncMapId=value&strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strDnFuncMapId">结点映射Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回是否存在?</returns>
        [AllowAnonymous]
        [HttpGet("DelRecordEx")]
        public ActionResult DelRecordEx(string strDnFuncMapId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strDnFuncMapId", strDnFuncMapId);
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDnFuncMapBLEx.DelRecordEx(strDnFuncMapId, strPrjId);
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