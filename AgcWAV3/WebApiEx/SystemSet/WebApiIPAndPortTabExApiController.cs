
/*-- -- -- -- -- -- -- -- -- -- --
类名:WebApiIPAndPortTabExApiController
表名:WebApiIPAndPortTab(00050529)
生成代码版本:2020.01.04.1
生成日期:2020/01/06 13:40:23
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:系统设置
模块英文名:SystemSet
框架-层名:WA_服务扩展层(WA_SrvEx)
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
    /// WebApiIPAndPortTabExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class WebApiIPAndPortTabExApiController : WebApiIPAndPortTabApiController
    {

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
        /// </summary>
        /// <param name = "objWebApiIPAndPortTab">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        [HttpPost("EditRecordEx")]
        public ActionResult EditRecordEx([FromBody]clsWebApiIPAndPortTabEN objWebApiIPAndPortTab)
        {

            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strWebApiIPAndPortTabJSONObj = clsJSON.GetJsonFromObj(objWebApiIPAndPortTab);
            dictParam.Add("strWebApiIPAndPortTabJSONObj", strWebApiIPAndPortTabJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            clsWebApiIPAndPortTabEN objWebApiIPAndPortTab_Cond = new clsWebApiIPAndPortTabEN();
            string strCondition = objWebApiIPAndPortTab_Cond
            .SetWebApiIPAndPort(objWebApiIPAndPortTab.WebApiIPAndPort, "=")
            .SetWebApiVirtualPath(objWebApiIPAndPortTab.WebApiVirtualPath, "=")
            .GetCombineCondition();
            objWebApiIPAndPortTab._IsCheckProperty = true;
            try
            {
                bool bolIsExist = clsWebApiIPAndPortTabBL.IsExistRecord(strCondition);
                bool bolResult = false;
                if (bolIsExist)
                {
                    objWebApiIPAndPortTab.mId = clsWebApiIPAndPortTabBL.GetFirstID_S(strCondition);
                    bolResult = objWebApiIPAndPortTab.UpdateWithCondition(strCondition);
                }
                else
                {
                    bolResult = objWebApiIPAndPortTab.AddNewRecord();
                }
              
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
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public WebApiIPAndPortTabExApiController()
        {
        }

    }
}