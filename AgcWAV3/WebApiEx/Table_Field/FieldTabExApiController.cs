
/*-- -- -- -- -- -- -- -- -- -- --
类名:FieldTabExApiController
表名:FieldTab(00050021)
生成代码版本:2021.11.07.2
生成日期:2021/11/09 01:38:24
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
using Newtonsoft.Json.Linq;
using Comm.WebApi;

namespace AGC.WebApi
{
    /// <summary>
    /// FieldTabExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class FieldTabExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public FieldTabExApiController()
        {
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
        /// </summary>
        /// <param name = "objFieldTab">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        [HttpPost("EditRecordEx")]
        public ActionResult EditRecordEx([FromBody] clsFieldTabEN objFieldTab)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strFieldTabJSONObj = clsJSON.GetJsonFromObj(objFieldTab);
            dictParam.Add("strFieldTabJSONObj", strFieldTabJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            objFieldTab._IsCheckProperty = true;
            try
            {
                bool bolResult = true;//如果要使用，解除注释---- objFieldTab.EditRecordEx();
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 导入字段到表FieldTab中
        /// 调用方法: Get /api/clsFieldTabBLExApi/ImportFldToFieldTab?strFldName=value&strCaption=value&strTypeName=value&intFldLength=value&intFldPrecision=value&bolIsNull=value&strPrjId=value&strUpdUser=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strFldName">字段名</param>
        /// <param name = "strCaption">标题</param>
        /// <param name = "strTypeName">类型名</param>
        /// <param name = "intFldLength">字段长度</param>
        /// <param name = "intFldPrecision">精度</param>
        /// <param name = "bolIsNull">是否可空</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUpdUser">修改用户</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("ImportFldToFieldTab")]
        public ActionResult ImportFldToFieldTab(string strFldName, string strCaption, string strTypeName, int intFldLength, int intFldPrecision, bool bolIsNull, string strPrjId, string strUpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strFldName", strFldName);
            dictParam.Add("strCaption", strCaption);
            dictParam.Add("strTypeName", strTypeName);
            dictParam.Add("intFldLength", intFldLength.ToString());
            dictParam.Add("intFldPrecision", intFldPrecision.ToString());
            dictParam.Add("bolIsNull", bolIsNull.ToString());
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strUpdUser", strUpdUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsFieldTabBLEx.ImportFldToFieldTab(strFldName, strCaption, strTypeName, intFldLength, intFldPrecision, bolIsNull, strPrjId, strUpdUser);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 添加新记录
        /// 调用方法: Get /api/clsFieldTabBLExApi/AddNewRec?strFldName=value&strCaption=value&strDataTypeId=value&intFldLength=value&intFldPrecision=value&bolIsNull=value&strPrjId=value&strUpdUser=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strFldName">字段名</param>
        /// <param name = "strCaption">标题</param>
        /// <param name = "strDataTypeId">数据类型Id</param>
        /// <param name = "intFldLength">字段长度</param>
        /// <param name = "intFldPrecision">精度</param>
        /// <param name = "bolIsNull">是否可空</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUpdUser">修改用户</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("AddNewRec")]
        public ActionResult AddNewRec(string strFldName, string strCaption, string strDataTypeId, int intFldLength, int intFldPrecision, bool bolIsNull, string strPrjId, string strUpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strFldName", strFldName);
            dictParam.Add("strCaption", strCaption);
            dictParam.Add("strDataTypeId", strDataTypeId);
            dictParam.Add("intFldLength", intFldLength.ToString());
            dictParam.Add("intFldPrecision", intFldPrecision.ToString());
            dictParam.Add("bolIsNull", bolIsNull.ToString());
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strUpdUser", strUpdUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsFieldTabBLEx.AddNewRec(strFldName, strCaption, strDataTypeId, intFldLength, intFldPrecision, bolIsNull, strPrjId, strUpdUser);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
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
        /// <param name = "arrFldId">字段列表</param>
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
            string strJSONString = string.Join(",", myData.arrKeyIds);
            dictParam.Add("arrFldId", strJSONString);
            dictParam.Add("strTabId", myData.strTabId);
            dictParam.Add("strPrjId", myData.strPrjId);
            dictParam.Add("strPrjDataBaseId", myData.strPrjDataBaseId);
            dictParam.Add("strOpUserId", myData.strOpUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsFieldTabBLEx.CopyToPrjTab(myData.arrKeyIds, myData.strTabId, myData.strPrjId, myData.strPrjDataBaseId, myData.strOpUser);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 为字段Id修改表数
        /// 调用方法: Get /api/clsFieldTabBLExApi/UpdateTabNumForFldId?strFldId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strFldId">字段Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("UpdateTabNumForFldId")]
        public ActionResult UpdateTabNumForFldId(string strFldId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strFldId", strFldId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsFieldTabBLEx.UpdateTabNumForFldId(strFldId);
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