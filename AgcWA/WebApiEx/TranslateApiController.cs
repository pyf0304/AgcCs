using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using Comm.WebApi;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace AGC.WebApiEx
{
    public class TranslateApiController : ControllerBase
    {
      
        [HttpGet("GetFieldCnNameByFieldName")]
        public string GetFieldCnNameByFieldName(string strPrjId, string strTabName, string strFieldName)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strPrjId"] = strPrjId,
                ["strTabName"] = strTabName,
                ["strFieldName"] = strFieldName
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strFieldName) == true)
            {
                string strMsg = string.Format("根据字段名获取中文名时，字段名不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
            }
            try
            {
                string strFieldCnName = clsFieldTabBLEx.GetFieldCnNameByFieldName(strPrjId, strTabName, strFieldName);
                return strFieldCnName;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
                return null;
            }
        }        
    }
}