
/*-- -- -- -- -- -- -- -- -- -- --
类名:FeatureRegionFldsExApiController
表名:FeatureRegionFlds(00050452)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:45:46
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:区域管理
模块英文名:RegionManage
框架-层名:WebApi扩展层(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
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
using Newtonsoft.Json;
using AgcWA.WebApi;

namespace AGC.WebApi
{
   
    /// <summary>
    /// FeatureRegionFldsExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class FeatureRegionFldsExApiController : FeatureRegionFldsApiController
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public FeatureRegionFldsExApiController()
        {
        }

        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/FeatureRegionFldsApi/AddNewRecord
        /// 在Body区传输objFeatureRegionFldsEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
        /// </summary>
        /// <param name = "objFeatureRegionFldsEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost("AddFeatureRegionFldsRecordSave")]
        public ActionResult AddFeatureRegionFldsRecordSave([FromBody]stuFeatureRegionFlds4Save objFeatureRegionFlds4Save)
        {
          
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
           
            try
            {
                string lngRegionId = objFeatureRegionFlds4Save.RegionId;
                string strUserId = objFeatureRegionFlds4Save.UserId;
                clsFeatureRegionFldsEN objFeatureRegionFlds = JsonConvert.DeserializeObject<clsFeatureRegionFldsEN>(objFeatureRegionFlds4Save.objString);
                MyJsonConvert<clsFeatureRegionFldsEN> loginConvert = new MyJsonConvert<clsFeatureRegionFldsEN>();
                clsFeatureRegionFldsEN objFeatureRegionFlds2 = loginConvert.ToObj(objFeatureRegionFlds4Save.objString);


                dictParam.Add("objString", objFeatureRegionFlds4Save.objString);
                dictParam.Add("strUserId", strUserId);
                dictParam.Add("lngRegionId", lngRegionId.ToString());

                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
                if (string.IsNullOrEmpty(objFeatureRegionFlds.ViewFeatureId) == true || clsFeatureRegionFldsBL.IsExist(objFeatureRegionFlds.ViewFeatureId) == true)
                {
                    objFeatureRegionFlds.ViewFeatureId = clsFeatureRegionFldsBL.GetMaxStrId_S();
                }

                bool bolResult =clsFeatureRegionFldsBLEx.AddFeatureRegionFldsRecordSave(lngRegionId, objFeatureRegionFlds4Save.ApplicationTypeId,
                    objFeatureRegionFlds4Save.TabId, objFeatureRegionFlds, strUserId);
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
        /// 导入相关字段
        /// 调用方法: Get /api/clsQryRegionFldsBLExApi/ImportRelaFlds?strRegionId=value&strPrjId=value&strUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strRegionId">区域Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("ImportRelaFlds")]
        public ActionResult ImportRelaFlds(string strRegionId, string strPrjId, string strUserId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strRegionId", strRegionId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strUserId", strUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsFeatureRegionFldsBLEx.ImportRelaFlds(strRegionId, strPrjId, strUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }


      

        /// <summary>
        /// 重序
        /// 调用方法: Get /api/clsFeatureRegionFldsBLExApi/ReOrder?strRegionId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strRegionId">区域Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("ReOrder")]
        public ActionResult ReOrder(string strRegionId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strRegionId", strRegionId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                clsFeatureRegionFldsBLEx.ReOrder(strRegionId);
                
                return Ok(new { errorId = 0, errorMsg = "", returnStr = "true" });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// 调用方法: Get /api/clsFeatureRegionFldsBLExApi/DelRecordEx?strViewFeatureId=value&strPrjId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strViewFeatureId">界面功能Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("DelRecordEx")]
        public ActionResult DelRecordEx(string strViewFeatureId, string strPrjId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strViewFeatureId", strViewFeatureId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsFeatureRegionFldsBLEx.DelRecordEx(strViewFeatureId, strPrjId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 检查区域控件，并回溯修改界面的错误信息
        /// 调用方法: Get /api/clsFeatureRegionFldsBLExApi/CheckRegionFldsUp?strRegionId=value&strCmPrjId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strRegionId">区域Id</param>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CheckRegionFldsUp")]
        public ActionResult CheckRegionFldsUp(string strRegionId, string strCmPrjId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strRegionId", strRegionId);
            dictParam.Add("strCmPrjId", strCmPrjId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsFeatureRegionFldsBLEx.CheckRegionFldsUp(strRegionId, strCmPrjId, strOpUserId);
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