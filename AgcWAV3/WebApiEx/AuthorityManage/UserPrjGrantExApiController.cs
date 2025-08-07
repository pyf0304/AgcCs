
/*-- -- -- -- -- -- -- -- -- -- --
类名:UserPrjGrantExApiController
表名:UserPrjGrant(00050092)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:44:17
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:权限管理
模块英文名:AuthorityManage
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
using AgcCommBase;
using AGC.BusinessLogicEx;
using Newtonsoft.Json.Linq;
using Comm.WebApi;
using Newtonsoft.Json;

namespace AGC.WebApi
{
    /// <summary>
    /// UserPrjGrantExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class UserPrjGrantExApiController : UserPrjGrantApiController
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public UserPrjGrantExApiController()
        {
        }
        [HttpGet("GetObjByCmPrjId")]
        public ActionResult GetObjByCmPrjId(string CmPrjId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["CmPrjId"] = CmPrjId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(CmPrjId) == true)
            {
                string strMsg = string.Format("根据关键字获取对象时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
            try
            {
                clsCMProjectEN objCMProjectEN = clsCMProjectBL.GetObjByCmPrjId(CmPrjId);

                return Ok(new { errorId = 0, errorMsg = "", returnObj = objCMProjectEN });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }



        /// <summary>
        /// 根据关键字获取用户登录信息,用对象的形式表示.
        /// 调用方法: GET /api/UserPrjGrantExApi/GetUserLoginInfo?mId=value
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjByKeyId)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表对象</returns>
        [HttpGet("GetUserLoginInfo")]
        public ActionResult GetUserLoginInfo(long mId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["mId"] = mId.ToString()
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (mId <= 0)
            {
                string strMsg = string.Format("根据关键字获取用户登录信息时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());

                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                stuUserLoginInfo objUserLoginInfo = clsUserPrjGrantBLEx.GetUserLoginInfo(mId);
                clsPubVar_WebApi.objLog.WriteDebugLog(objUserLoginInfo.UserId);
                clsPubVar_WebApi.objLog.WriteDebugLog(objUserLoginInfo.UserId + objUserLoginInfo.UserName);
                //return objUserLoginInfo;

                return Ok(new { errorId = 0, errorMsg = "", returnObj = objUserLoginInfo });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        [HttpGet("GetUserLoginInfoByUserId")]
        public ActionResult GetUserLoginInfoByUserId(string strUserId, string strPrjId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserId"] = strUserId,
                ["strPrjId"] = strPrjId,
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strUserId) == true)
            {
                string strMsg = string.Format("根据关键字获取用户登录信息时，用户Id不能为空!({0})", clsStackTrace.GetCurrClassFunction());

                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                string strMsg = string.Format("根据关键字获取用户登录信息时，工程Id不能为空!({0})", clsStackTrace.GetCurrClassFunction());

                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                stuUserLoginInfo objUserLoginInfo = clsUserPrjGrantBLEx.GetUserLoginInfo(strUserId, strPrjId);
                clsPubVar_WebApi.objLog.WriteDebugLog(objUserLoginInfo.UserId);
                clsPubVar_WebApi.objLog.WriteDebugLog(objUserLoginInfo.UserId + objUserLoginInfo.UserName);
                //return objUserLoginInfo;

                return Ok(new { errorId = 0, errorMsg = "", returnObj = objUserLoginInfo });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }



        /// <summary>
        /// 获取某用户的按最后使用的项目
        /// 调用方法: Get /api/clsUserPrjGrantBLExApi/GetFirstObjByUserId?strUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetFirstObjByUserId")]
        public ActionResult GetFirstObjByUserId(string strUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strUserId", strUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsUserPrjGrantBLEx.GetFirstObjByUserId(strUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnObj = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

    }
}
