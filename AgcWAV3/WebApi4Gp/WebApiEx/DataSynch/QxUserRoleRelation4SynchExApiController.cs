
/*-- -- -- -- -- -- -- -- -- -- --
类名:QxUserRoleRelation4SynchExApiController
表名:QxUserRoleRelation4Synch(00140092)
生成代码版本:2019.03.21.2
生成日期:2019/03/22 17:03:37
生成者:
生成服务器IP:109.244.40.104
工程名称:统一平台
工程ID:0014
相关数据库:109.244.40.104,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:数据同步
模块英文名:DataSynch
框架-层名:WebApi扩展层(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using Comm.WebApi;
using com.taishsoft.common;
using com.taishsoft.json;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;

namespace GeneralPlatform.WebApi
{
    /// <summary>
    /// QxUserRoleRelation4SynchExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class QxUserRoleRelation4SynchExApiController : QxUserRoleRelation4SynchApiController
    {

        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/QxUserRoleRelation4SynchApi/AddNewRecord
        /// 在Body区传输objQxUserRoleRelation4SynchEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
        /// </summary>
        /// <param name = "objQxUserRoleRelation4SynchEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost("AddNewRecordEx")]
        public ActionResult AddNewRecordEx([FromBody]clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strQxUserRoleRelation4SynchJSONObj = clsJSON.GetJsonFromObj(objQxUserRoleRelation4SynchEN);
            dictParam.Add("strQxUserRoleRelation4SynchJSONObj", strQxUserRoleRelation4SynchJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                bool bolResult = false;
                string strCondition = string.Format("{0}='{1}' and {2}='{3}' and {4}='{5}'",
                    conQxUserRoleRelation4Synch.IpAddress, objQxUserRoleRelation4SynchEN.IpAddress,
                    conQxUserRoleRelation4Synch.UserId, objQxUserRoleRelation4SynchEN.UserId,
                    conQxUserRoleRelation4Synch.RoleId, objQxUserRoleRelation4SynchEN.RoleId
                    );

                if (clsQxUserRoleRelation4SynchBL.IsExistRecord(strCondition) == false)
                {
                    bolResult = clsQxUserRoleRelation4SynchBL.AddNewRecordBySql2(objQxUserRoleRelation4SynchEN);
                }
           
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                //return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [HttpGet("Plus")]
        public ActionResult Plus(int a, int b)
        {
            //调用方法：~/api/MyCalc/Plus?a=2&b=3
            int intCount =  a + b;
            return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
        }
    }
}