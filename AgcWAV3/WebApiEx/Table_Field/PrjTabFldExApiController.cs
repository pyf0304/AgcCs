
using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using com.taishsoft.json;
using AGC.Entity;
using AGC.BusinessLogic;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json.Linq; using Comm.WebApi;
using AGC.BusinessLogicEx;

namespace AGC.WebApi
{
    /// <summary>
    /// PrjTabFldExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class PrjTabFldExApiController : PrjTabFldApiController
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public PrjTabFldExApiController()
        {
        }

        /// <summary>
        /// 扩展删除表字段
        /// 调用方法: Get /api/clsPrjTabFldBLExApi/DelRecordEx?strTabId=value&strFldId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strFldId">字段Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("DelRecordEx")]
        public ActionResult DelRecordEx(string strTabId, string strFldId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strFldId", strFldId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabFldBLEx.DelRecordEx(strTabId, strFldId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// 添加新记录
        /// 调用方法: Get /api/clsPrjTabFldBLExApi/AddNewRec?strTabId=value&strFldId=value&bolIsTabNullable=value&strUpdUser=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strFldId">字段Id</param>
        /// <param name = "bolIsTabNullable">表中是否可空</param>
        /// <param name = "strUpdUser">修改用户</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("AddNewRec")]
        public ActionResult AddNewRec(string strTabId, string strFldId, bool bolIsTabNullable, string strUpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strFldId", strFldId);
            dictParam.Add("bolIsTabNullable", bolIsTabNullable.ToString());
            dictParam.Add("strUpdUser", strUpdUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabFldBLEx.AddNewRec(strTabId, strFldId, bolIsTabNullable, strUpdUser);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 同步Sql字段信息到代码系统中
        /// 调用方法: Get /api/clsPrjTabFldBLExApi/SynchFieldFromColumnObj?strTabId=value&strColumn_Name=value&strTypeName=value&intFldLength=value&intFldPrecision=value&strIs_Nullable=value&strUpdUser=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strColumn_Name">字段列名</param>
        /// <param name = "strTypeName">类型名</param>
        /// <param name = "intFldLength">字段长度</param>
        /// <param name = "intFldPrecision">精度</param>
        /// <param name = "strIs_Nullable">是否可空</param>
        /// <param name = "strUpdUser">修改用户</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("SynchFieldFromColumnObj")]
        public ActionResult SynchFieldFromColumnObj(string strTabId, string strColumn_Name, string strTypeName,
            int intFldLength, int intFldPrecision, bool bolIs_Nullable, string strUpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strColumn_Name", strColumn_Name);
            dictParam.Add("strTypeName", strTypeName);
            dictParam.Add("intFldLength", intFldLength.ToString());
            dictParam.Add("intFldPrecision", intFldPrecision.ToString());
            dictParam.Add("bolIs_Nullable", bolIs_Nullable.ToString());
            dictParam.Add("strUpdUser", strUpdUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabFldBLEx.SynchFieldFromColumnObj(strTabId, strColumn_Name, strTypeName, intFldLength, intFldPrecision, bolIs_Nullable, strUpdUser);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 根据FldId获取相关的TabId列表
        /// 调用方法: Get /api/clsPrjTabFldBLExApi/getTabIdLstByFldId?strFldId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strFldId">字段Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("getTabIdLstByFldId")]
        public ActionResult getTabIdLstByFldId(string strFldId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strFldId", strFldId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabFldBLEx.getTabIdLstByFldId(strFldId);
                return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", varResult) });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 为表字段替换一个新的字段
        /// 调用方法: Get /api/clsPrjTabFldBLExApi/ReplaceFldName?lngMid=value&strFldName=value&strUpdUser=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "lngMid">lngMid</param>
        /// <param name = "strFldName">字段名</param>
        /// <param name = "strUpdUser">修改用户</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("ReplaceFldName")]
        public ActionResult ReplaceFldName(long lngMid, string strFldName, string strUpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("lngMid", lngMid.ToString());
            dictParam.Add("strFldName", strFldName);
            dictParam.Add("strUpdUser", strUpdUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabFldBLEx.ReplaceFldName(lngMid, strFldName, strUpdUser);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 为字段设置一个新标题
        /// 调用方法: Get /api/clsPrjTabFldBLExApi/SetNewCaption?lngMid=value&strCaption=value&strUpdUser=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "lngMid">lngMid</param>
        /// <param name = "strCaption">标题</param>
        /// <param name = "strUpdUser">修改用户</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("SetNewCaption")]
        public ActionResult SetNewCaption(long lngMid, string strCaption, string strUpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("lngMid", lngMid.ToString());
            dictParam.Add("strCaption", strCaption);
            dictParam.Add("strUpdUser", strUpdUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabFldBLEx.SetNewCaption(lngMid, strCaption, strUpdUser);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 把记录移到新的位置
        /// 调用方法: Get /api/clsPrjTabFldBLExApi/MoveRecTo?lngMid=value&intNewSeqNum=value&strTabId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "lngMid">lngMid</param>
        /// <param name = "intNewSeqNum">新的序号</param>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("MoveRecTo")]
        public ActionResult MoveRecTo(long lngMid, int intNewSeqNum, string strTabId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("lngMid", lngMid.ToString());
            dictParam.Add("intNewSeqNum", intNewSeqNum.ToString());
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabFldBLEx.MoveRecTo(lngMid, intNewSeqNum, strTabId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 复制一些字段到其他表,并同步到数据库
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "arrMid">关键字列表</param>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpPost("CopyToPrjTab")]
        public ActionResult CopyToPrjTab([FromBody] clsCopyToPrjTab myData)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //string strJSONString = string.Join(",", arrMid);
            //dictParam.Add("arrMid", strJSONString);
            //dictParam.Add("strTabId", strTabId);
            //dictParam.Add("strPrjId", strPrjId);
            //dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            //dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {

                List<string> lstMId_Str = new List<string>(myData.arrKeyIds);
                var varResult = clsPrjTabFldBLEx.CopyToPrjTab(lstMId_Str, myData.strTabId, myData.strPrjId, myData.strPrjDataBaseId, myData.strOpUser);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        [HttpPost("CopyToPrjTabBak")]
        public ActionResult CopyToPrjTabBak([FromBody] string[] arrMid, string strTabId, string strPrjId, string strPrjDataBaseId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strJSONString = string.Join(",", arrMid);
            dictParam.Add("arrMid", strJSONString);
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                List<string> lstMId_Str = new List<string>(arrMid);
                var varResult = clsPrjTabFldBLEx.CopyToPrjTab(lstMId_Str, strTabId, strPrjId, strPrjDataBaseId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
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
        /// 检查表字段，并回溯修改字段表的错误信息
        /// 调用方法: Get /api/clsPrjTabFldBLExApi/CheckTabFldsUp?strTabId=value&strCmPrjId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CheckTabFldsUp")]
        public ActionResult CheckTabFldsUp(string strTabId, string strPrjId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabFldBLEx.CheckTabFldsUp(strTabId, strPrjId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 获取TabId列表的所有对象列表
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "arrTabId">TabId列表</param>
        /// <returns>返回是否存在?</returns>
        [HttpPost("GetObjLstByTabIdLst")]
        public ActionResult GetObjLstByTabIdLst([FromBody] List<string> arrTabId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strJSONString = string.Join(",", arrTabId);
            dictParam.Add("arrTabId", strJSONString);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabFldBLEx.GetObjLstByTabIdLst(arrTabId);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 刷新某FldId的相关表的修改日期，即使用过该FldId的相关表都刷新一下日期
        /// 调用方法: Get /api/clsPrjTabFldBLExApi/RefreshUpdDate4ReleTab?strFldId=value&strUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strFldId">字段Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("RefreshUpdDate4ReleTab")]
        public ActionResult RefreshUpdDate4ReleTab(string strFldId, string strUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strFldId", strFldId);
            dictParam.Add("strUserId", strUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPrjTabFldBLEx.RefreshUpdDate4ReleTab(strFldId, strUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

    }
    public class clsCopyToPrjTab
    {
        //clsPrjTabFldExWApi.js:628 {"arrKeyIds":["40436","156781"],"strTabId":"00050127","strPrjId":"0005","strPrjDataBaseId":"0005","strOpUser":"pyf"}
        public string[] arrKeyIds { set; get; }
        public string strTabId { set; get; }
        public string strPrjId { set; get; }
        public string strPrjDataBaseId { set; get; }
        public string strOpUser { set; get; }
    }
}