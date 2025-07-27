using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using Comm.WebApi;
using AGCWA.PubFun;
using com.taishsoft.common;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;
using GeneralPlatform.Entity;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Microsoft.AspNetCore.Mvc;
using Comm.PubFun;
using Microsoft.AspNetCore.Authorization;

namespace GeneralPlatform.WebApi
{
    [ApiController]
    [Route("[controller]")]
    public class LoginApiController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet("test")]
        public ActionResult test()
        {
            //调用方法：~/api/MyCalc/Plus?a=2&b=3
            var returnStr = "Hello world!";            
            return Ok(new { errorId = 0, errorMsg = "", ReturnStr = returnStr });
        }
              
        [HttpPost("Plus2")]
        public ActionResult Plus2([FromBody]string value)
        {
            string strA = value;// 
            //string strB = HttpContext.Current.Request.Form[0];
            int a = 11;
            int b = 22;
            var intCount = a + b;
            return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
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
            var intCount = a + b;
            return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
        }
        [HttpGet("Minus")]
        public ActionResult Minus(int a, int b)
        {
            var intCount = a - b;
            return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
        }

        [HttpGet("Multiply")]
        public ActionResult Multiply(int a, int b)
        {
            var intCount = a * b;
            return Ok(new { errorId = 0, errorMsg = "", returnFloat = intCount });
        }

        [HttpGet("Divided")]
        public ActionResult Divided(int a, int b)
        {
            var intCount = a / b;
            return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
        }
        private string Gene_Token(string strUserId)
        {
            AuthInfo authInfo = new AuthInfo()
            {
                UserId = strUserId,
                Expires = DateTime.Now.AddDays(1)
            };
            string secretKey = ConfigHelper.GetSectionValue("JwtSettings:SigningKey");// "matanzhang";//口令加密秘钥（应该写到配置文件中）
            byte[] key = Encoding.UTF8.GetBytes(secretKey);
            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();//加密方式
            IJsonSerializer serializer = new JsonNetSerializer();//序列化Json
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();//base64加解密
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);//JWT编码
            var token = encoder.Encode(authInfo, key);//生成令牌
            return token;

        }


        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strUserPassword">口令</param>
        /// <returns>成功返回True，不成功返回False</returns>
        [HttpPost("UserLogin")]
        public ActionResult UserLogin([FromBody]stuLoginPara objLoginPara)
        {
            //在Google浏览器直接调用的方法代码
            //var url = "http://localhost:28524/GPWA/LoginApi/UserLogin";
            //var params = { LoginName: '00701', UserPassword: '222222', QxPrjId: '0062',EffectiveDate: ''};
            //var xhr = new XMLHttpRequest();
            //xhr.open("POST", url, true);
            //xhr.setRequestHeader("Content-Type", "application/json");
            //xhr.onload = function(e) {
            //    if (xhr.readyState === 4)
            //    {
            //        if (xhr.status === 200)
            //        {
            //            console.log(xhr.responseText);
            //        }
            //        else
            //        {
            //            console.error(xhr.statusText);
            //        }
            //    }
            //};
            //xhr.onerror = function(e) {
            //    console.error(xhr.statusText);
            //};
            //xhr.send(JSON.stringify (params));
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = objLoginPara.GetDictParam();
            //dictParam.Add("strLoginName", objLoginPara.LoginName);
            //dictParam.Add("strUserPassword", "已经隐藏");
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            string strMsg = "";
            string strUserId = clsQxUserLoginNameBLEx.GetUserIdByLoginName(objLoginPara.LoginName);
            clsQxUsersEN objUsers = clsQxUsersBL.GetObjByUserIdCache(strUserId);
            bool bolResult = false;
            if (objUsers == null)
            {
                strMsg = string.Format("用户:{0}不存在！(In {1})", objLoginPara.LoginName, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                bolResult = false;
                
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
            }
            if (objUsers.Password != objLoginPara.UserPassword)
            {
                strMsg = string.Format("用户:{0}存在,口令不正确！(In {1})", objLoginPara.LoginName, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                bolResult = false;
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
            }
            strMsg = string.Format("用户:{0}登录成功！(In {1})", objLoginPara.LoginName, clsStackTrace.GetCurrClassFunction());
            clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
            bolResult = true;
            var strToken = Gene_Token(objLoginPara.LoginName);
            return Ok(new { errorId = 0, errorMsg = "", token = strToken, returnBool = bolResult });
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strUserPassword">口令</param>
        /// <returns>成功返回True，不成功返回False</returns>
        [HttpPost("UserLogin2")]
        public ActionResult UserLogin2([FromBody]string strLoginName, string strUserPassword)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strLoginName", strLoginName);
            dictParam.Add("strUserPassword", "已经隐藏");
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            string strUserId = clsQxUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);
            clsQxUsersEN objUsers = null;
            var returnStr = "";
            try
            {
                objUsers = clsQxUsersBL.GetObjByUserId(strUserId);

            }
            catch (Exception objException)
            {                
                return Ok(new { errorId = 0, errorMsg = objException.Message });
            }
            if (objUsers == null)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                returnStr = "false";
            }
            if (objUsers.Password != strUserPassword)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                returnStr = "false";
            }
            returnStr = "true";
            var strToken = Gene_Token(strLoginName);
            return Ok(new { errorId = 0, errorMsg = "", token = strToken, ReturnStr = returnStr });

        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strUserPassword">口令</param>
        /// <param name="strEffectiveDate">有效日期</param>
        /// <returns>成功返回"true"，不成功返回"false", 超过有效期返回"EffectiveDateError"</returns>
        [HttpPost("UserLoginWithEffectiveDate")]
        public ActionResult UserLoginWithEffectiveDate([FromBody]string strLoginName, string strUserPassword, string strEffectiveDate)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strLoginName", strLoginName);
            dictParam.Add("strUserPassword", "已经隐藏");
            dictParam.Add("strEffectiveDate", strEffectiveDate);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            string strUserId = clsQxUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);
            clsQxUsersEN objUsers = null;
            var returnStr = "";
            try
            {
                objUsers = clsQxUsersBL.GetObjByUserId(strUserId);

            }
            catch (Exception objException)
            {
                return Ok(new { errorId = 0, errorMsg = objException.Message });
            }
            if (objUsers == null)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                returnStr = "false";
            }
            if (objUsers.Password != strUserPassword)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                returnStr = "false";
            }
            if (string.IsNullOrEmpty(objUsers.EffitiveEndDate) == true)
            {
                returnStr = "true";
            }
else            if (objUsers.EffitiveEndDate.CompareTo(strEffectiveDate) < 0)
            {
                returnStr = "EffectiveDateError";
            }
            returnStr = "true";            
            var strToken = Gene_Token(strLoginName);
            return Ok(new { errorId = 0, errorMsg = "", token = strToken, ReturnStr = returnStr });

        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strUserPassword">口令</param>
        /// <returns>成功返回True，不成功返回False</returns>
        [HttpPost("UserLoginByPrjId")]
        public ActionResult UserLoginByPrjId([FromBody]string strLoginName, string strUserPassword, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strLoginName", strLoginName);
            dictParam.Add("strUserPassword", "已经隐藏");
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            string strUserId = clsQxUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);
            clsQxUsersEN objUsers = clsQxUsersBL.GetObjByUserId(strUserId);

            var bolResult = false;
            string strCondition = string.Format("UserId='{0}' And {2}='{1}'", strUserId, strPrjId,
                conQxPrjUserRelation.QxPrjId);
            if (clsQxPrjUserRelationBL.IsExistRecord(strCondition) == false)
            {
                bolResult = false;
            }
            if (objUsers == null)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                bolResult = false;
            }
            if (objUsers.Password != strUserPassword)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                bolResult = false;
            }
            bolResult = true;
            var strToken = Gene_Token(strLoginName);
            return Ok(new { errorId = 0, errorMsg = "", token = strToken, returnBool = bolResult });

        }

        /// <summary>
        /// 根据用户名、口令、工程id，进行登录，最终获取用户关系视图对象列表
        /// </summary>
        /// <param name="strLoginName">登录名</param>
        /// <param name="strUserPassword">口令</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>获取用户关系视图对象列表，或不成功则返回空的对象列表</returns>
        [HttpPost("GetObjLstByUserLoginByPrjIdBak")]
        public ActionResult GetObjLstByUserLoginByPrjIdBak([FromBody]string strLoginName, string strUserPassword, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strLoginName", strLoginName);
            dictParam.Add("strUserPassword", "已经隐藏");
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            string strUserId = clsQxUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);
            clsQxUsersEN objUsers = clsQxUsersBL.GetObjByUserId(strUserId);


            string strCondition = string.Format("UserId='{0}' And {2}='{1}'", strUserId, strPrjId,
                conQxPrjUserRelation.QxPrjId);
            if (clsQxPrjUserRelationBL.IsExistRecord(strCondition) == false)
            {
                
                string strMsg = string.Format("条件记录不存在.(from {0})", clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            if (objUsers == null)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
             
                string strMsg = string.Format("用户名或密码错误.(from {0})", clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            if (objUsers.Password != strUserPassword)
            {

                string strMsg = string.Format("用户名或密码错误.(from {0})", clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            strCondition = string.Format(" {0}='{1}' And {2}='{3}'",
                conQxUserRoleRelation.QxPrjId, strPrjId,
                conQxUserRoleRelation.UserId, strUserId);
            List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLst = clsvQxUserRoleRelationBL.GetObjLst(strCondition);            
            return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrvQxUserRoleRelationObjLst });
        }

        /// <summary>
        /// 根据用户名、口令、工程id，进行登录，最终获取用户关系视图JSON对象列表
        /// </summary>
        /// <param name="strLoginName">登录名</param>
        /// <param name="strUserPassword">口令</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>获取用户关系视图JSON对象列表，或不成功则返回空的对象列表</returns>
        [HttpPost("GetObjLstByUserLoginByPrjId")]
        public ActionResult GetObjLstByUserLoginByPrjId(string strLoginName, string strUserPassword, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strLoginName", strLoginName);
            dictParam.Add("strUserPassword", "已经隐藏");
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            string strUserId = clsQxUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);
            clsQxUsersEN objUsers = clsQxUsersBL.GetObjByUserId(strUserId);


            string strCondition = string.Format("UserId='{0}' And {2}='{1}'", strUserId, strPrjId,
                conQxPrjUserRelation.QxPrjId);
            if (clsQxPrjUserRelationBL.IsExistRecord(strCondition) == false)
            {
                string strMsg = string.Format("根据条件:{0}的记录不存在!({1})", strCondition, clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
                
            }
            if (objUsers == null)
            {
                string strMsg = string.Format("用户名或密码错误!({0})", clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
                
            }
            if (objUsers.Password != strUserPassword)
            {
                string strMsg = string.Format("用户名或密码错误!({0})", clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);

            }
            strCondition = string.Format(" {0}='{1}' And {2}='{3}'",
                conQxUserRoleRelation.QxPrjId, strPrjId,
                conQxUserRoleRelation.UserId, strUserId);
            List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLst = clsvQxUserRoleRelationBL.GetObjLst(strCondition);

            //List<clsvQxUserRoleRelationEN_Sim> arrvQxUserRoleRelationObj_SimLst = clsvQxUserRoleRelationBL.GetSimObjLstFromObjLst(arrvQxUserRoleRelationObjLst);
  
            return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrvQxUserRoleRelationObjLst });
        }

        /// <summary>
        /// 根据用户登录名获取用户Id
        /// </summary>
        /// <param name="strLoginName">用户登录名</param>        
        /// <returns>返回strUserId</returns>
        [HttpGet("GetUserIdByLoginName")]
        public ActionResult GetUserIdByLoginName(string strLoginName)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strLoginName", strLoginName);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            string strUserId = clsQxUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);                        
            return Ok(new { errorId = 0, errorMsg = "", ReturnStr = strUserId });
        }
    }
}