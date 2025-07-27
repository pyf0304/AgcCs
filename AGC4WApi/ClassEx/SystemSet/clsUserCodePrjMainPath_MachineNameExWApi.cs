
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsUserCodePrjMainPath_MachineNameExWApi
表名:UserCodePrjMainPath_MachineName(00050614)
生成代码版本:2022.11.24.1
生成日期:2022/12/03 19:33:51
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:系统设置(SystemSet)
框架-层名:WA_访问扩展层(CS)(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Collections;
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;
using System.Collections.Generic;
using com.taishsoft.json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace AGC4WApi
{
    public static class clsUserCodePrjMainPath_MachineNameExWApi_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvUserCodePrjMainPath_MachineNameENS">源对象</param>
        /// <returns>目标对象=>clsvUserCodePrjMainPath_MachineNameEN:objvUserCodePrjMainPath_MachineNameENT</returns>
        public static clsUserCodePrjMainPath_MachineNameENEx CopyToEx(this clsUserCodePrjMainPath_MachineNameEN objvUserCodePrjMainPath_MachineNameENS)
        {
            try
            {
                clsUserCodePrjMainPath_MachineNameENEx objvUserCodePrjMainPath_MachineNameENT = new clsUserCodePrjMainPath_MachineNameENEx();
                clsUserCodePrjMainPath_MachineNameWApi.CopyTo(objvUserCodePrjMainPath_MachineNameENS, objvUserCodePrjMainPath_MachineNameENT);
                return objvUserCodePrjMainPath_MachineNameENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000068)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static int ApplicationTypeId(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
        {
            try
            {
                var objUserCodePrjMainPath = clsUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathIdCache(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,
                    objUserCodePrjMainPath_MachineNameEN.PrjId);
                clsCMProjectAppRelaEN objCMProjectAppRelaEN = clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaIdCache(objUserCodePrjMainPath.CMProjectAppRelaId, 
                    objUserCodePrjMainPath.PrjId);
                if (objCMProjectAppRelaEN == null) return 0;
                return objCMProjectAppRelaEN.ApplicationTypeId;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000069)获取ApplicationTypeId数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static string ApplicationTypeName(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
        {
            try
            {
                var objUserCodePrjMainPath = clsUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathIdCache(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,
                    objUserCodePrjMainPath_MachineNameEN.PrjId);
                if (objUserCodePrjMainPath == null) return "";
                clsCMProjectAppRelaEN objCMProjectAppRelaEN = clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaIdCache(objUserCodePrjMainPath.CMProjectAppRelaId,
                    objUserCodePrjMainPath.PrjId);
                if (objCMProjectAppRelaEN == null) return "";
                return objCMProjectAppRelaEN.ApplicationTypeName();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000069)获取ApplicationTypeId数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }


        public static string CmPrjId(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
        {
            try
            {
                var objUserCodePrjMainPath = clsUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathIdCache(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,
    objUserCodePrjMainPath_MachineNameEN.PrjId);

                clsCMProjectAppRelaEN objApplicationTypeEN = clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaIdCache(objUserCodePrjMainPath.CMProjectAppRelaId, 
                    objUserCodePrjMainPath.PrjId);
                return objApplicationTypeEN.CmPrjId;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000070)获取CmPrjId数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

    }


    /// <summary>
    /// 用户生成项目主路径_PC(UserCodePrjMainPath_MachineName)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsUserCodePrjMainPath_MachineNameExWApi
    {
        private static readonly string mstrApiControllerName = "UserCodePrjMainPath_MachineNameExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsUserCodePrjMainPath_MachineNameEN> arrUserCodePrjMainPath_MachineNameObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        //public static void SetIsExistCodePath(string userCodePrjMainPathId, string machineName, bool v)
        //{
        //    var objUserCodePrjMainPath_MachineNameEN = clsUserCodePrjMainPath_MachineNameWApi.GetObjByUserCodePrjMainPathId(userCodePrjMainPathId, machineName);
        //    if (objUserCodePrjMainPath_MachineNameEN != null)
        //    {
        //        objUserCodePrjMainPath_MachineNameEN.IsExistCodePath = true;
        //        objUserCodePrjMainPath_MachineNameEN.Update();
        //    }
        //}

        /// <summary>
        /// 扩展删除
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strUserCodePrjMainPathId">生成主目录Id</param>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <returns>返回对象列表</returns>
        public static bool DelRecordEx(string strUserCodePrjMainPathId, string strCmPrjId)
        {
            string strAction = "DelRecordEx";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserCodePrjMainPathId"] = strUserCodePrjMainPathId,
                ["strCmPrjId"] = strCmPrjId,
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["ErrorId"] == 0)
                    {
                        var varResult = (bool)jobjReturn["ReturnBool"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("扩展删除出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        public static void SetGcPathIs(string userCodePrjMainPathId, string machineName, string strGcPathId)
        {
            
            var objUserCodePrjMainPath_MachineNameEN = clsUserCodePrjMainPath_MachineNameWApi.GetObjByKeyLst(userCodePrjMainPathId, machineName);
            if (objUserCodePrjMainPath_MachineNameEN != null)
            {
                objUserCodePrjMainPath_MachineNameEN.GcPathId = strGcPathId;
                objUserCodePrjMainPath_MachineNameEN.Update();
            }
        }

        public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstByUserCodePrjMainPathId(string userCodePrjMainPathId)
        {
            string strCondition = string.Format("{0}='{1}'", conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId, userCodePrjMainPathId);
            var arrUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameWApi.GetObjLst(strCondition);
            return arrUserCodePrjMainPath_MachineName;
        }

        public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstByUserCodePrjMainPathIdCache(string userCodePrjMainPathId, string strPrjId)
        {
            var arrObjLst = clsUserCodePrjMainPath_MachineNameWApi.GetObjLstCache(strPrjId);
            var arrUserCodePrjMainPath_MachineName = arrObjLst.Where(x=>x.UserCodePrjMainPathId == userCodePrjMainPathId).ToList();
            return arrUserCodePrjMainPath_MachineName;
        }
    }
}