
/*-- -- -- -- -- -- -- -- -- -- --
类名:QxUsersExApiController
表名:QxUsers(00140015)
生成代码版本:2019.03.24.1
生成日期:2019/03/24 09:50:27
生成者:
生成服务器IP:109.244.40.104
工程名称:统一平台
工程ID:0014
相关数据库:109.244.40.104,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:用户管理
模块英文名:UserManage
框架-层名:WebApi扩展层(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using com.taishsoft.common;
using com.taishsoft.json;
using Comm.WebApi;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;
using GeneralPlatform.Entity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace GeneralPlatform.WebApi
{
    /// <summary>
    /// QxUsersExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class QxUsersExApiController : QxUsersApiController
    {
        /// <summary>
        /// 测试WebApi 两个数相加
        /// 调用方法: GET /api/QxUsersExApi/Plus?a=1&b=2
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

        /// <summary>
        /// 功能:同时删除多条记录,删除给定关键字列表的记录
        /// 调用方法: POST /api/QxUsersExApi/SynDataToOtherServer
        /// 在Body区传输arrUserId(关键字值列表)的JSON串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecord)
        /// </summary>
        /// <param name = "arrUserId">给定的关键字值列表</param>
        /// <param name = "strServerId">目标同步服务器Id</param>
        /// <returns>返回删除的记录数</returns>
        [HttpPost("SynDataToOtherServer")]
        public ActionResult SynDataToOtherServer([FromBody]string[] arrUserId, string strServerId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            List<string> arrLst = new List<string>(arrUserId);
            dictParam.Add("arrUserId", clsArray.GetSqlInStrByArray(arrLst, true));
            dictParam.Add("strServerId", strServerId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                int intRecNum = clsQxUsersBLEx.SynDataToOtherServer(arrLst, strServerId);
               
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
                
                return Ok(new { errorId = 0, errorMsg = strMsg, returnInt = 0 });
            }
        }



        /// <summary>
        /// 获取用户的所有子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        [HttpGet("GetRoleIdLstByUserId")]
        public ActionResult GetRoleIdLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{1} = '{0}'", strPrjId, conQxRoles.QxPrjId);
            sbCondition.AppendFormat(" and RoleId in (Select RoleId from {1} where userid = '{0}')",
                strUserId, clsQxUserRoleRelationEN._CurrTabName);
            List<clsQxRolesEN> arrUserRoleObjLst = clsQxRolesBL.GetObjLst(sbCondition.ToString());
            List<string> arrRoleIdLst = new List<string>();
            foreach (clsQxRolesEN objUserRoles in arrUserRoleObjLst)
            {
                arrRoleIdLst.Add(objUserRoles.RoleId);
            }
                        
            return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", arrRoleIdLst) });
        }

        [HttpGet("GetRoleNameLstByUserId")]
        public ActionResult GetRoleNameLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{1} = '{0}'", strPrjId, conQxRoles.QxPrjId);
            sbCondition.AppendFormat(" and RoleId in (Select RoleId from {1} where userid = '{0}')",
                strUserId, clsQxUserRoleRelationEN._CurrTabName);
            List<clsQxRolesEN> arrUserRoleObjLst = clsQxRolesBL.GetObjLst(sbCondition.ToString());
            List<string> arrRoleIdLst = new List<string>();
            foreach (clsQxRolesEN objUserRoles in arrUserRoleObjLst)
            {
                arrRoleIdLst.Add(objUserRoles.RoleName);
            }

            return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", arrRoleIdLst) });
        }


        /// <summary>
        /// 获取用户的所有子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        [HttpGet("GetPotenceIdLstByUserId")]
        public ActionResult GetPotenceIdLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }


            //        select * from prjpotence
            //where Qxprjid = '0072'
            //    and potenceid in 
            //    (select potenceid from userGroupPotence
            //            where RoleId in 
            //                (select RoleId from userRoleRelation where UserId= 'pyf01' and Qxprjid = '0072')
            //    )
            StringBuilder sbCondition4Potence2 = new StringBuilder();
            sbCondition4Potence2.AppendFormat("{1} = '{0}'", strPrjId, conQxPrjPotence.QxPrjId);
            sbCondition4Potence2.AppendFormat(" and potenceid in ");
            sbCondition4Potence2.AppendFormat(" (select potenceid from {0} where RoleId in  ", clsQxUserGroupPotenceEN._CurrTabName);
            sbCondition4Potence2.AppendFormat("(select RoleId from {2} where UserId= '{0}' and {3} = '{1}')",
                strUserId, strPrjId, clsQxUserRoleRelationEN._CurrTabName, conQxUserRoleRelation.QxPrjId);
            sbCondition4Potence2.Append(")");
            List<clsQxPrjPotenceEN> arrPrjPotenceObjLst = clsQxPrjPotenceBL.GetObjLst(sbCondition4Potence2.ToString());
            List<string> arrPotenceIdLst = new List<string>();
            foreach (clsQxPrjPotenceEN objPrjPotence in arrPrjPotenceObjLst)
            {
                arrPotenceIdLst.Add(objPrjPotence.PotenceId);
            }
                        
            return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", arrPotenceIdLst) });
        }

        [HttpGet("GetPotenceNameLstByUserId")]
        public ActionResult GetPotenceNameLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }


            //        select * from prjpotence
            //where Qxprjid = '0072'
            //    and potenceid in 
            //    (select potenceid from userGroupPotence
            //            where RoleId in 
            //                (select RoleId from userRoleRelation where UserId= 'pyf01' and Qxprjid = '0072')
            //    )
            StringBuilder sbCondition4Potence2 = new StringBuilder();
            sbCondition4Potence2.AppendFormat("{1} = '{0}'", strPrjId, conQxPrjPotence.QxPrjId);
            sbCondition4Potence2.AppendFormat(" and potenceid in ");
            sbCondition4Potence2.AppendFormat(" (select potenceid from {0} where RoleId in  ", clsQxUserGroupPotenceEN._CurrTabName);
            sbCondition4Potence2.AppendFormat("(select RoleId from {2} where UserId= '{0}' and {3} = '{1}')",
                strUserId, strPrjId, clsQxUserRoleRelationEN._CurrTabName, conQxUserRoleRelation.QxPrjId);
            sbCondition4Potence2.Append(")");
            List<clsQxPrjPotenceEN> arrPrjPotenceObjLst = clsQxPrjPotenceBL.GetObjLst(sbCondition4Potence2.ToString());
            List<string> arrPotenceIdLst = new List<string>();
            foreach (clsQxPrjPotenceEN objPrjPotence in arrPrjPotenceObjLst)
            {
                arrPotenceIdLst.Add(objPrjPotence.PotenceName);
            }

            return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", arrPotenceIdLst) });
        }

        /// <summary>
        /// 获取用户的有关某权限的标志ID列表
        /// Description = "作者:潘以锋 功能:获取用户的有关某权限的标志ID列表 参数:strUserId(用户ID),strPotenceId(权限ID), strPrjId(工程ID) 返回值:标志名称列表,用List<string>表示")
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        [HttpGet("GetSymbolIdLstByPotenceId")]
        public ActionResult GetSymbolIdLstByPotenceId(string strUserId, string strPotenceId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolId = clsQxUsersBLEx.GetSymbolIdLstByPotenceId(strUserId, strPotenceId, strPrjId);
            
            return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", lstSymbolId) });
        }
        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// (Description = "作者:潘以锋 功能:获取用户的有关某权限的标志名称列表 参数:strUserId(用户ID),strPotenceId(权限ID), strPrjId(工程ID) 返回值:标志名称列表,用List<string>表示")
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        [HttpGet("GetSymbolNameLstByPotenceId")]
        public ActionResult GetSymbolNameLstByPotenceId(string strUserId, string strPotenceId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolName = clsQxUsersBLEx.GetSymbolNameLstByPotenceId(strUserId, strPotenceId, strPrjId);
            
            return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", lstSymbolName) });
        }

        /// <summary>
        /// 获取用户的有关某权限的标志ID列表
        /// (Description = "作者:潘以锋 功能:获取用户的有关某权限的标志ID列表 参数:strUserId(用户ID),strPotenceId(权限ID), strPrjId(工程ID) 返回值:标志名称列表,用List<string>表示")
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        [HttpGet("GetSymbolIdLstByPotenceName")]
        public ActionResult GetSymbolIdLstByPotenceName(string strUserId, string strPotenceName, string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolId = clsQxUsersBLEx.GetSymbolIdLstByPotenceName(strUserId, strPotenceName, strPrjId);
            
            return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", lstSymbolId) });
        }


        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// (Description = "作者:潘以锋 功能:获取用户的有关某权限的标志名称列表 参数:strUserId(用户ID),strPotenceId(权限ID), strPrjId(工程ID) 返回值:标志名称列表,用List<string>表示")
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        [HttpGet("GetSymbolNameLstByPotenceName")]
        public ActionResult GetSymbolNameLstByPotenceName(string strUserId, string strPotenceName, string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolName = clsQxUsersBLEx.GetSymbolNameLstByPotenceName(strUserId, strPotenceName, strPrjId);
            
            return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", lstSymbolName) });
        }

        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// (Description = "作者:潘以锋 功能:获取用户的有关某权限的标志名称列表 参数:strUserId(用户ID),strPotenceId(权限ID), strPrjId(工程ID),strRoleId(所给角色ID) 返回值:标志名称列表,用List<string>表示")
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <param name="strRoleId">有关某角色</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        [HttpGet("GetSymbolNameLstByPotenceName4CurrRoleId")]
        public ActionResult GetSymbolNameLstByPotenceName4CurrRoleId(string strUserId, string strPotenceName, string strPrjId, string strRoleId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolName = clsQxUsersBLEx.GetSymbolNameLstByPotenceName4CurrRoleId(strUserId, strPotenceName, strPrjId, strRoleId);
            
            return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", lstSymbolName) });
        }

        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// (Description = "作者:潘以锋 功能:获取某角色的有关某权限的标志名称列表 参数:strPotenceId(权限ID), strPrjId(工程ID),strRoleId(所给角色ID) 返回值:标志名称列表,用List<string>表示")
        /// </summary>
        /// <param name="strPrjId">当前工程</param>
        /// <param name="strRoleId">有关某角色</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        [HttpGet("GetSymbolNameLstByPotenceName4CurrRoleId2")]
        public ActionResult GetSymbolNameLstByPotenceName4CurrRoleId2(string strPotenceName, string strPrjId, string strRoleId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolName = clsQxUsersBLEx.GetSymbolNameLstByPotenceName4CurrRoleId2(strPotenceName, strPrjId, strRoleId);
            
            return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", lstSymbolName) });
        }

        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [HttpGet("IsHavePotenceName")]
        public ActionResult IsHavePotenceName(string strPrjId, string strUserId, string strPotenceName)
        {
            var bolResult = clsQxUsersBLEx.IsHavePotenceName(strPrjId, strUserId, strPotenceName);
            return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
        }
        /// <summary>
        /// 是否包含某权限Id
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [HttpGet("IsHavePotenceId")]
        public ActionResult IsHavePotenceId(string strPrjId, string strUserId, string strPotenceId)
        {
            var bolResult = clsQxUsersBLEx.IsHavePotenceId(strPrjId, strUserId, strPotenceId);
            return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
        }
        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [HttpGet("GetQxPrjPotenceObjByPotenceName")]
        public clsQxPrjPotenceEN GetQxPrjPotenceObjByPotenceName(string strPrjId, string strUserId, string strPotenceName)
        {
            return clsQxUsersBLEx.GetQxPrjPotenceObjByPotenceName(strPrjId, strUserId, strPotenceName);
        }

        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [HttpGet("GetQxPrjPotenceObjByPotenceName4CurrRole")]
        public clsQxPrjPotenceEN GetQxPrjPotenceObjByPotenceName4CurrRole(string strPrjId, string strUserId, string strRoleId, string strPotenceName)
        {
            return clsQxUsersBLEx.GetQxPrjPotenceObjByPotenceName4CurrRole(strPrjId, strUserId, strRoleId, strPotenceName);
        }
        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [HttpGet("IsHavePotenceNameAndSymbol")]
        public ActionResult IsHavePotenceNameAndSymbol(string strPrjId, string strUserId, string strPotenceName, string strSymbolName)
        {
            var bolResult = clsQxUsersBLEx.IsHavePotenceNameAndSymbol(strPrjId, strUserId, strPotenceName, strSymbolName);
            return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
        }

        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [HttpGet("IsHavePotenceNameAndSymbol4CurrRole")]
        public ActionResult IsHavePotenceNameAndSymbol4CurrRole(string strPrjId, string strUserId, string strRoleId, string strPotenceName, string strSymbolName)
        {
            var bolResult = clsQxUsersBLEx.IsHavePotenceNameAndSymbol4CurrRole(strPrjId, strUserId, strRoleId, strPotenceName, strSymbolName);
            return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
        }



        /// <summary>
        /// 修改给定用户的系统口令
        /// </summary>
        /// <param name="strOldPassword">用户当前的密码，用以验证</param>
        /// <param name="strNewPassword">用户需要修改的新密码</param>
        /// <returns>修改成功，返回true，失败返回false</returns>
        [HttpPost("Change_QxUserPassword")]
        public ActionResult Change_QxUserPassword([FromBody]stuChangePasswordPara objChangePasswordPara)
        {
            var bolResult = clsQxUsersBLEx.Change_QxUserPassword(objChangePasswordPara.UserId, objChangePasswordPara.NewPassword, objChangePasswordPara.OldPassword);
            return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
        }
        /// <summary>
        /// 修改给定用户的系统口令
        /// </summary>
        /// <param name="strNewPassword">用户需要修改的新密码</param>
        /// <returns>修改成功，返回true，失败返回false</returns>
        [HttpPost("Change_QxUserPassword2")]
        public ActionResult Change_QxUserPassword2([FromBody]stuChangePasswordPara objChangePasswordPara)
        {
            var bolResult = clsQxUsersBLEx.Change_QxUserPassword(objChangePasswordPara.UserId, objChangePasswordPara.NewPassword);
            return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
        }


        [HttpGet("Users_DelRecord")]
        public ActionResult Users_DelRecord(string strUserId)
        {
            int intResult = clsQxUsersBL.DelRecord(strUserId);
 
            return Ok(new { errorId = 0, errorMsg = "", returnInt = intResult });
        }

        /// <summary>
        /// 根据用户Id（UserId）获取入校年月
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>入校年月</returns>
        [HttpGet("GetEnterSchoolDateByUserId")]
        public ActionResult GetEnterSchoolDateByUserId(string strUserId)
        {
            string strEnterSchoolDate = clsQxUsersBLEx.GetEnterSchoolDateByUserId(strUserId);            
            return Ok(new { errorId = 0, errorMsg = "", ReturnStr = strEnterSchoolDate });
        }
        /// <summary>
        /// 根据用户Id（UserId）获取入校年
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>入校年</returns>
        [HttpGet("GetEnterSchoolYearByUserId")]
        public ActionResult GetEnterSchoolYearByUserId(string strUserId)
        {
            string strEnterSchoolDate = clsQxUsersBLEx.GetEnterSchoolYearByUserId(strUserId);
            
            return Ok(new { errorId = 0, errorMsg = "", ReturnStr = strEnterSchoolDate });
        }
        /// <summary>
        /// 根据用户Id（UserId）获取用户名
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>用户名</returns>
        [HttpGet("GetUserNameByUserId")]
        public ActionResult GetUserNameByUserId(string strUserId)
        {
            string strUserName = clsQxUsersBLEx.GetUserNameByUserId(strUserId);            
            return Ok(new { errorId = 0, errorMsg = "", ReturnStr = strUserName });
        }


        /// <summary>
        /// 为用户设置角色
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strRoleId">当前角色</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>是否成功？</returns>
        [HttpGet("CreateUserRoleRelation")]
        public ActionResult CreateUserRoleRelation(string strUserId, string strRoleId, string strPrjId)
        {
            var bolResult = clsQxUsersBLEx.CreateUserRoleRelation(strUserId, strRoleId, strPrjId);
       
            return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
        }
        /// <summary>
        /// 根据部门ID获取该部门的二级管理员ID
        /// </summary>
        /// <param name="strDepartmentId">部门ID</param>
        /// <returns>二级管理员ID？</returns>
        [HttpGet("GetManager2IdByDepartmentId")]
        public ActionResult GetManager2IdByDepartmentId(string strDepartmentId)
        {
            string strUserId = clsQxUsersBLEx.GetManager2IdByDepartmentId(strDepartmentId);
            
            return Ok(new { errorId = 0, errorMsg = "", ReturnStr = strUserId });
        }


        /// <summary>
        /// 添加新用户，附加角色和工程
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "objQxUsers">用户对象</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strRoleId">角色Id</param>
        /// <param name = "strUpdUser">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpPost("AddNewUsers")]
        public JObject AddNewUsers([FromBody]stuUserEx objUserEx)
        {
            JObject jobjReturn = new JObject();
            jobjReturn["ErrorId"] = 0;
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strJSONString = clsJSON.GetJsonFromObj(objUserEx);
            dictParam.Add("objQxUsers", strJSONString);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                clsQxUsersEN objQxUsers = new clsQxUsersEN();

                objQxUsers.UserId = objUserEx.UserId;    //用户ID
                objQxUsers.UserName = objUserEx.UserName;    //用户名
                var objDepartment = clsQxDepartmentInfoBLEx.GetObjByDepartmentNameCache(objUserEx.DepartmentName);
                if (objDepartment != null) objQxUsers.DepartmentId = objDepartment.DepartmentId;    //部门Id

                var objQxUserState = clsQxUserStateBLEx.GetObjByUserStateNameCache(objUserEx.UserStateName);
                if (objQxUserState != null) objQxUsers.UserStateId = objQxUserState.UserStateId;    //用户状态Id        
                objQxUsers.Password = objUserEx.Password;    //口令
                objQxUsers.EffitiveBeginDate = objUserEx.EffitiveBeginDate;    //有效开始日期
                objQxUsers.EffitiveEndDate = objUserEx.EffitiveEndDate;    //有效结束日期
                objQxUsers.StuTeacherId = objUserEx.StuTeacherId;    //学工号
                var objQxUserIdentity = clsQxUserIdentityBLEx.GetObjByIdentityDescCache(objUserEx.IdentityName);
                if (objQxUserIdentity != null) objQxUsers.IdentityId = objQxUserIdentity.IdentityId;    //身份编号        
                objQxUsers.OpenId = objUserEx.openid;    //微信openid
                objQxUsers.Email = objUserEx.Email;    //邮箱
                objQxUsers.PhoneNumber = objUserEx.PhoneNumber;    //电话号码
                objQxUsers.UpdDate = objUserEx.UpdDate;    //修改日期
                objQxUsers.UpdUser = objUserEx.UpdUser;    //修改用户
                objQxUsers.Memo = objUserEx.Memo;    //备注               
                                                     //objQxUsers.RoleName;
                                                     //objQxUsers.PrjId;
                clsQxRolesEN objQxUserRoles = clsQxRolesBLEx.GetObjByRoleNameCache(objUserEx.RoleName);
                if (objQxUserRoles == null)
                {
                    string strMsg = string.Format("角色名:[{0}]在角色表中不存在！(from {1})", objUserEx.RoleName, clsStackTrace.GetCurrClassFunction());
                    jobjReturn["ErrorId"] = 1;
                    jobjReturn["ErrorMsg"] = strMsg;
                    return jobjReturn;
                }
                string strRoleId = objQxUserRoles.RoleId;
                var varResult = clsQxUsersBLEx.AddNewUsers(objQxUsers, objUserEx.PrjId, strRoleId, objUserEx.UpdUser);
                jobjReturn["ReturnBool"] = varResult;
                return jobjReturn;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                jobjReturn["ErrorId"] = 1;
                jobjReturn["ErrorMsg"] = strMsg;
                return jobjReturn;
            }
        }
    }
}
