
/*-- -- -- -- -- -- -- -- -- -- --
类名:SqlViewExApiController
表名:SqlView(00050245)
生成代码版本:2022.01.04.1
生成日期:2022/01/12 17:07:11
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)
相关数据库:109.244.40.104,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:Sql视图管理(SqlViewMan)
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

using com.taishsoft.common;
using com.taishsoft.datetime;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json.Linq; using Comm.WebApi;

namespace AGC.WebApi
{
    /// <summary>
    /// SqlViewExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class SqlViewExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public SqlViewExApiController()
        {
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
        /// </summary>
        /// <param name = "objSqlView">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        [HttpPost("EditRecordEx")]
        public ActionResult EditRecordEx([FromBody] clsSqlViewEN objSqlView)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            string strSqlViewJSONObj = clsJSON.GetJsonFromObj(objSqlView);
            dictParam.Add("strSqlViewJSONObj", strSqlViewJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            objSqlView._IsCheckProperty = true;
            try
            {
                bool bolResult = true;//如果要使用，解除注释---- objSqlView.EditRecordEx();
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
        /// 从Sql服务器中导入Sql视图
        /// 调用方法: Get /api/clsSqlViewBLExApi/CreateView4Sql?strSqlViewId=value&strPrjId=value&strUserId=value&strPrjDataBaseId=value&bolIsTry=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strSqlViewId">Sql视图Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <param name = "bolIsTry">是否尝试</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CreateView4Sql")]
        public ActionResult CreateView4Sql(string strSqlViewId, string strPrjId, string strUserId, string strPrjDataBaseId, bool bolIsTry)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strSqlViewId", strSqlViewId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            dictParam.Add("bolIsTry", bolIsTry.ToString());
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsSqlViewBLEx.CreateView4Sql(strSqlViewId, strPrjId, strUserId, strPrjDataBaseId, bolIsTry);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 导入Sql视图,从本系统(代码生成系统)中。
        /// 调用方法: Get /api/clsSqlViewBLExApi/ImportSqlViewBySqlViewName?strPrjId=value&strSqlViewName=value&strUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strSqlViewName">Sql视图名</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("ImportSqlViewBySqlViewName")]
        public ActionResult ImportSqlViewBySqlViewName(string strPrjId, string strSqlViewName, string strUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strSqlViewName", strSqlViewName);
            dictParam.Add("strUserId", strUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsSqlViewBLEx.ImportSqlViewBySqlViewName(strPrjId, strSqlViewName, strUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 从Sql服务器中导入Sql视图
        /// 调用方法: Get /api/clsSqlViewBLExApi/ImportSqlViewFromSqlServer?strPrjId=value&strSqlViewId=value&strUserId=value&strPrjDataBaseId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strSqlViewId">Sql视图Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("ImportSqlViewFromSqlServer")]
        public ActionResult ImportSqlViewFromSqlServer(string strPrjId, string strSqlViewId, string strUserId, string strPrjDataBaseId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strSqlViewId", strSqlViewId);
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsSqlViewBLEx.ImportSqlViewFromSqlServer(strPrjId, strSqlViewId, strUserId, strPrjDataBaseId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 字段分析,即可视图文本中,分析可相关字段,以及相关表等
        /// 调用方法: Get /api/clsSqlViewBLExApi/FieldAnalysis?strSqlViewId=value&strPrjId=value&strUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strSqlViewId">Sql视图Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("FieldAnalysis")]
        public ActionResult FieldAnalysis(string strSqlViewId, string strPrjId, string strUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strSqlViewId", strSqlViewId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strUserId", strUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsSqlViewBLEx.FieldAnalysis(strSqlViewId, strPrjId, strUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 生成Sql视图,即根据相关字段,以及相关表等,生成Sql视图文本
        /// 调用方法: Get /api/clsSqlViewBLExApi/GeneSqlView?strSqlViewId=value&strPrjId=value&strPrjDataBaseId=value&strUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strSqlViewId">Sql视图Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GeneSqlView")]
        public ActionResult GeneSqlView(string strSqlViewId, string strPrjId, string strPrjDataBaseId, string strUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strSqlViewId", strSqlViewId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            dictParam.Add("strUserId", strUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsSqlViewBLEx.GeneSqlView(strSqlViewId, strPrjId, strPrjDataBaseId, strUserId);
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