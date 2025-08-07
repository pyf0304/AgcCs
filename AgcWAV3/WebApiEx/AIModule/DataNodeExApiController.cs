
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.common;
using Comm.WebApi;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AGC.WebApi
{
    /// <summary>
    /// DataNodeExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class DataNodeExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public DataNodeExApiController()
        {
        }

        /// <summary>
        /// 功能:同时删除多条记录,删除给定关键字列表的记录
        /// 调用方法: POST /api/DataNodeApi/DelDataNodes
        /// 在Body区传输arrDataNodeId(关键字值列表)的JSON串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecord)
        /// </summary>
        /// <param name = "arrDataNodeId">给定的关键字值列表</param>
        /// <returns>返回删除的记录数</returns>
        [HttpGet("ImportNode4KeyAndName")]
        public ActionResult ImportNode4KeyAndName(string strPrjId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //List<string> arrLst = new List<string>(arrDataNodeId);
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                int intRecNum = clsDataNodeBLEx.ImportNode4KeyAndName(strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        [HttpGet("ImportSameSourceBy4KeyNode")]
        public ActionResult ImportSameSourceBy4KeyNode(string strCmPrjId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //List<string> arrLst = new List<string>(arrDataNodeId);
            dictParam.Add("strCmPrjId", strCmPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                int intRecNum = clsDataNodeBLEx.ImportSameSourceBy4KeyNode(strCmPrjId);

                return Ok(new { errorId = 0, errorMsg = "", ReturnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }



        //        /// <summary>
        //        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        //        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
        //        /// </summary>
        //        /// <param name = "objDataNode">需要修改的实体对象</param>
        //        /// <returns>修改是否成功？</returns>
        //        [HttpPost("EditRecordEx")]
        //public ActionResult EditRecordEx([FromBody]clsDataNodeEN objDataNode)
        //{

        //string strFunctionName = clsStackTrace.GetCurrFunction();
        //Dictionary<string, string> dictParam = new Dictionary<string, string>();
        //string strDataNodeJSONObj = clsJSON.GetJsonFromObj(objDataNode);
        //dictParam.Add("strDataNodeJSONObj", strDataNodeJSONObj);
        //clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
        //objDataNode._IsCheckProperty = true;
        // try
        // {
        //bool bolResult = objDataNode.EditRecordEx();
        //jobjReturn["ReturnBool"] = bolResult;
        //return jobjReturn;
        //}
        // catch (Exception objException)
        // {
        //string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
        //clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
        //return Ok(new { errorId = 1, errorMsg = strMsg});
        // }
        // }
        /// <summary>
        /// 在CM工程中获取与表Id相关的所有数据结点，即以该表的字段作为起点的所有相关结点
        /// 调用方法: Get /api/clsDataNodeBLExApi/GetConnectedNodeByTabId?strTabId=value&strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strPrjId">CM工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetConnectedNodeByTabId")]
        public ActionResult GetConnectedNodeByTabId(string strTabId, string strPrjId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDataNodeBLEx.GetConnectedNodeByTabId(strTabId, strPrjId);

                return Ok(new { errorId = 0, errorMsg = "", ReturnObjLst = varResult });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }


        /// <summary>
        /// 在CM工程中获取结点的所有前驱结点列表
        /// 调用方法: Get /api/clsDataNodeBLExApi/GetConnectedNode_Prev?strEndNodeId=value&strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strEndNodeId">末端结点Id</param>
        /// <param name = "strPrjId">CM工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetConnectedNode_Prev")]
        public ActionResult GetConnectedNode_Prev(long strEndNodeId, string strPrjId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strEndNodeId", strEndNodeId.ToString());
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDataNodeBLEx.GetConnectedNode_Prev(strEndNodeId, strPrjId);

                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// 在CM工程中获取结点的所有连接结点列表
        /// 调用方法: Get /api/clsDataNodeBLExApi/GetConnectedNode?strStartNodeId=value&strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strStartNodeId">开始结点</param>
        /// <param name = "strPrjId">CM工程Id</param>
        /// <returns>返回是否存在?</returns>
        [AllowAnonymous]
        [HttpGet("GetConnectedNode")]
        public ActionResult GetConnectedNode(long strStartNodeId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strStartNodeId", strStartNodeId.ToString());
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDataNodeBLEx.GetConnectedNode(strStartNodeId, strPrjId);
                if (varResult == null) varResult = new List<clsDataNodeEN>();
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 获取两个端点之间的路径，以结点列表的形式
        /// 调用方法: Get /api/clsDataNodeBLExApi/GetGraphPath?strStartNodeId=value&strEndNodeId=value&strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strStartNodeId">开始结点</param>
        /// <param name = "strEndNodeId">末端结点Id</param>
        /// <param name = "strPrjId">CM工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetGraphPath")]
        public ActionResult GetGraphPath(long strStartNodeId, long strEndNodeId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strStartNodeId", strStartNodeId.ToString());
            dictParam.Add("strEndNodeId", strEndNodeId.ToString());
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDataNodeBLEx.GetGraphPath(strStartNodeId, strEndNodeId, strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:同时删除多条记录,删除给定关键字列表的记录
        /// 调用方法: POST /api/DataNodeApi/DelDataNodes
        /// 在Body区传输arrDnFuncMapId(关键字值列表)的JSON串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecord)
        /// </summary>
        /// <param name = "arrDnFuncMapId">给定的关键字值列表</param>
        /// <returns>返回删除的记录数</returns>
        [HttpPost("DelDataNodesExBak")]
        public ActionResult DelDataNodesExBak([FromBody] string[] arrDnFuncMapId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            List<string> arrLst = new(arrDnFuncMapId);

            dictParam.Add("arrDnFuncMapId", clsArray.GetSqlInStrByArray(arrLst, true));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                int intRecNum = 0;// clsDataNodeBLEx.DelDataNodesEx(arrLst);
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
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// 调用方法: Get /api/clsDataNodeBLExApi/DelRecordEx?strDataNodeId=value&strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strDataNodeId">数据结点Id</param>
        /// <param name = "strPrjId">CM工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("DelRecordEx")]
        public ActionResult DelRecordEx(long strDataNodeId, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strDataNodeId", strDataNodeId.ToString());
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDataNodeBLEx.DelRecordEx(strDataNodeId, strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
        /// <summary>
        /// 检查结点，如果有结点的相关表为空，或者相关表的缓存模式不正确就抛错.
        /// 调用方法: Get /api/clsDataNodeBLExApi/CheckDataNode?strDataNodeId=value&strPrjId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strDataNodeId">数据结点Id</param>
        /// <param name = "strPrjId">CM工程Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CheckDataNode")]
        public ActionResult CheckDataNode(long strDataNodeId, string strPrjId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strDataNodeId", strDataNodeId.ToString());
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDataNodeBLEx.CheckDataNode(strDataNodeId, strPrjId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 检查结点，如果有结点的相关表为空，或者相关表的缓存模式不正确就抛错.
        /// 调用方法: Get /api/clsDataNodeBLExApi/CheckDataNodeByCmPrjId?strPrjId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strPrjId">CM工程Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CheckDataNodeByPrjId")]
        public ActionResult CheckDataNodeByPrjId(string strPrjId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDataNodeBLEx.CheckDataNodeByPrjId(strPrjId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据关键字获取结点标准名称
        /// 调用方法: Get /api/clsDataNodeBLExApi/GetStandardDataNodeName?lngDataNodeId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "lngDataNodeId">结点关键字</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetStandardDataNodeName")]
        public ActionResult GetStandardDataNodeName(long lngDataNodeId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("lngDataNodeId", lngDataNodeId.ToString());
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDataNodeBLEx.GetStandardDataNodeName(lngDataNodeId);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 设置某工程下所有结点标准名称
        /// 调用方法: Get /api/clsDataNodeBLExApi/SetAllStandardDataNodeName?strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回是否存在?</returns>
        [AllowAnonymous]
        [HttpGet("SetAllStandardDataNodeName")]
        public ActionResult SetAllStandardDataNodeName(string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsDataNodeBLEx.SetAllStandardDataNodeName(strPrjId);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}