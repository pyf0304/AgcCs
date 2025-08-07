
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvUserCodePathExWApi
表名:vUserCodePath(00050205)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:00:40
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:系统设置
模块英文名:SystemSet
框架-层名:WebApi访问扩展层(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
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
using AgcCommBase;
using System.IO;
using System.Linq;

namespace AGC4WApi
{
    public static class clsvUserCodePathExWApi_Static
    {

          public static string UserCodePrjMainPathId(this clsvUserCodePathEN objUserCodePath, string strUserId)
        {
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjByCmPrjAppIdUserId_Cache_Dic(objUserCodePath.CMProjectAppRelaId, strUserId);
            return objUserCodePrjMainPath.UserCodePrjMainPathId;
        }
       
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// </summary>
        /// <param name = "objUserCodePathENS">源对象</param>
        /// <returns>目标对象=>clsvUserCodePathEN:objUserCodePathENT</returns>
        public static clsvUserCodePathENEx CopyToEx(this clsvUserCodePathEN objUserCodePathENS)
        {
            try
            {
                clsvUserCodePathENEx objUserCodePathENT = new clsvUserCodePathENEx();
                clsvUserCodePathWApi.CopyTo(objUserCodePathENS, objUserCodePathENT);
                return objUserCodePathENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// </summary>
        /// <param name = "objUserCodePathENS">源对象</param>
        /// <returns>目标对象=>clsvUserCodePathEN:objUserCodePathENT</returns>
        public static clsvUserCodePathEN CopyTo(this clsvUserCodePathENEx objUserCodePathENS)
        {
            try
            {
                clsvUserCodePathEN objUserCodePathENT = new clsvUserCodePathEN();
                clsvUserCodePathWApi.CopyTo(objUserCodePathENS, objUserCodePathENT);
                return objUserCodePathENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取在工程内的代码路径，例如设置的代码路径为：/SamplePrj_DAL/Class, 工程路径为/SamplePrj_DAL，则：工程内的代码路径为：/Class
        /// </summary>
        /// <param name="objUserCodePathEN">用户代码路径对象</param>
        /// <returns></returns>
        public static string PrjInnerCodePath(this clsvUserCodePathEN objUserCodePathEN)
        {
            if (objUserCodePathEN.ProjectPath == "/") return objUserCodePathEN.CodePath;
            if (string.IsNullOrEmpty(objUserCodePathEN.ProjectPath)) return objUserCodePathEN.CodePath;
            string strRealyCodePath = objUserCodePathEN.CodePath.Replace(objUserCodePathEN.ProjectPath, "");
            return strRealyCodePath;
        }
        public static string NewCodePathBackup(this clsvUserCodePathEN objUserCodePathEN, string strUserId, string strMachineName, string strPrjId)
        {

            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsPubFun4WApi.GetUserCodePrjMainPath(objUserCodePathEN.UserCodePrjMainPathId(strUserId), strPrjId);
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPath, strMachineName, strPrjId);

            string strNewCodePathBackup = string.Format("{0}{1}",
                                            objUserCodePrjMainPathEx.CodePathBackup, objUserCodePathEN.CodePathBackup);
            return strNewCodePathBackup;

        }


        public static string PrjFileName(this clsvUserCodePathEN objUserCodePathEN, string strUserId, string strMachineName, string strPrjId)
        {
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsPubFun4WApi.GetUserCodePrjMainPath(objUserCodePathEN.UserCodePrjMainPathId(strUserId), strPrjId);
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPath, strMachineName, strPrjId);

            string strPrjFileName = string.Format("{0}/{1}/{2}",
                    objUserCodePrjMainPathEx.CodePath, objUserCodePathEN.ProjectPath, objUserCodePathEN.ProjectFileName);
            strPrjFileName = strPrjFileName.Replace("\\/\\", "\\")
                                          .Replace("/", "\\").Replace("\\\\", "\\");
            return strPrjFileName;

        }


        public static string NewCodePath(this clsvUserCodePathEN objUserCodePathEN, string strUserId, string strMachineName, string strPrjId)
        {
            //var strPrjId = clsCMProjectExWApi.GetPrjIdByCmPrjIdCache(strCmPrjId);
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsPubFun4WApi.GetUserCodePrjMainPath(objUserCodePathEN.UserCodePrjMainPathId(strUserId), strPrjId);

            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPath, strMachineName, strPrjId);

            string strNewCodePathBackup = string.Format("{0}{1}",
                                            objUserCodePrjMainPathEx.CodePath, objUserCodePathEN.CodePath);
            return strNewCodePathBackup;

        }

        public static bool IsExistCodePathP(this clsvUserCodePathEN objUserCodePathEN, string strUserId, string strMachineName, string strPrjId)
        {

            string strNewCodePath = objUserCodePathEN.NewCodePath(strUserId, strMachineName, strPrjId);
            if (Directory.Exists(strNewCodePath) == false)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        public static string GetFullProjectPath1(this clsvUserCodePathEN objUserCodePathEN, clsUserCodePrjMainPathEN objUserCodePrjMainPath, string strMachineName, string strPrjId)
        {
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPath, strMachineName, strPrjId);

            if (objUserCodePathEN.ProjectPath == "/") return objUserCodePrjMainPathEx.CodePath;
            if (string.IsNullOrEmpty(objUserCodePathEN.ProjectPath)) return objUserCodePrjMainPathEx.CodePath;
            string strFullProjectPath = string.Format("{0}\\{1}", objUserCodePrjMainPathEx.CodePath, objUserCodePathEN.ProjectPath);
            strFullProjectPath = strFullProjectPath.Replace("\\/\\", "\\")
                    .Replace("/", "\\").Replace("\\\\", "\\").Replace("\\\\", "\\");
            return strFullProjectPath;
        }
    }

    /// <summary>
    /// v用户生成路径(vUserCodePath)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsvUserCodePathExWApi
    {
        //private static readonly string mstrApiControllerName = "vUserCodePathExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsvUserCodePathEN> arrvUserCodePathObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;
        private static string mstrPrjId4Cache = "";
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsvUserCodePathExWApi()
        {
        }
        /// <summary>
        /// 根据代码类型和语言类型获取用户代码项目主目录
        /// </summary>
        /// <param name="intApplicationTypeId">应用类型Id</param>
        /// <param name="strCodeTypeId">代码类型</param>
        /// <param name="ltLangType">语言类型</param>
        /// <param name="strCurrPrjId">当前工程Id</param>
        /// <param name="strUserId">当前用户Id</param>
        /// <returns></returns>
        public static clsvUserCodePathENEx GetObjByClassName(long lngCMProjectAppRelaId, string strCodeTypeId,
             string strCurrPrjId, string strCmPrjId, string strUserId, string strMachineName)
        {
           
            clsvUserCodePathEN objvUserCodePathEN = GetObjByCodeTypeId_Cache1(lngCMProjectAppRelaId, strCodeTypeId, strUserId, strCurrPrjId);
           
            clsUserCodePrjMainPathEN objUserCodePrjMainPathEN
                = clsUserCodePrjMainPathExWApi.GetObjByCmPrjAppIdUserId_Cache_Dic(lngCMProjectAppRelaId, strUserId);
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPathEN, strMachineName, strCurrPrjId);
            if (objUserCodePrjMainPathEx.CodePath == "")
            {
                string strCmPrjName = clsCMProjectWApi.GetNameByCmPrjIdCache(objUserCodePrjMainPathEx.CmPrjId());
                string strAppName = clsApplicationTypeWApi.GetNameByApplicationTypeIdCache(objUserCodePrjMainPathEx.ApplicationTypeId());

                string strErrMsg = $"Cm工程:{strCmPrjName}, 应用:{strAppName}在机器:{objUserCodePrjMainPathEx.MachineName}中生成代码路径为空，请检查！";
                throw new Exception(strErrMsg);
            }
            objvUserCodePathEN.NewCodePath = string.Format("{0}{1}",
                objUserCodePrjMainPathEx.CodePath, objvUserCodePathEN.CodePath);
            if (Directory.Exists(objvUserCodePathEN.NewCodePath) == false)
            {
                objvUserCodePathEN.IsExistCodePathP = false;
            }
            else
            {
                objvUserCodePathEN.IsExistCodePathP = true;
            }
            objvUserCodePathEN.NewCodePathBackup = string.Format("{0}{1}",
                                objUserCodePrjMainPathEx.CodePathBackup, objvUserCodePathEN.CodePathBackup);

            clsvUserCodePathENEx objvUserCodePathENEx = objvUserCodePathEN.CopyToEx();
            objvUserCodePathENEx.FolderName_Root = objUserCodePrjMainPathEx.CodePath;
            return objvUserCodePathENEx;
        }


        /// <summary>
        /// 根据代码类型Id和语言类型Id获取用户代码项目主目录
        /// </summary>
        /// <param name="strCodeTypeId">代码类型Id</param>
        /// <param name="intApplicationTypeId">应用类型Id</param>
        /// <param name="strCurrPrjId">当前工程Id</param>
        /// <param name="strUserId">当前用户Id</param>
        /// <returns></returns>
        public static clsvUserCodePathEN GetObjByCodeTypeId_Cache1(long lngCMProjectAppRelaId, string strCodeTypeId, string strUserId, string strCurrPrjId)
        {
            //if (string.IsNullOrEmpty(strUserId) == true)
            //{
            //    string strMsg = string.Format("当前用户(strUserId)没有设置，请联系管理员！({0})", clsStackTrace.GetCurrClassFunction());
            //    throw new Exception(strMsg);
            //}

            //if (string.IsNullOrEmpty(strCurrPrjId) == true)
            //{
            //    throw new Exception("当前项目没有设置，请联系管理员！");
            //}
            List<clsvUserCodePathEN> arrvUserCodePathObjLst_Cache = clsvUserCodePathWApi.GetObjLstCache(strCurrPrjId);

            var arrvUserCodePathObjLst_Sel = arrvUserCodePathObjLst_Cache.Where(x => x.CodeTypeId == strCodeTypeId
                    && x.CMProjectAppRelaId == lngCMProjectAppRelaId).ToList();
            
           
            if (arrvUserCodePathObjLst_Sel.Count > 0)
            {
                return arrvUserCodePathObjLst_Sel[0];
            }
            
            clsvUserCodePathWApi.ReFreshThisCache();
            StringBuilder sbMsg = new StringBuilder();
            clsvCodeType_SimEN objCodeTypeEN = null;
            try
            {
                objCodeTypeEN = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache(strCodeTypeId);
            }
            catch (Exception objException)
            {
                StringBuilder sbMsg1 = new StringBuilder();
                sbMsg1.AppendFormat("在获取CodeTypeId＝'{0}'的代码类型对象时出错，错误信息：{1}。", strCodeTypeId, objException.Message);
                throw new Exception(sbMsg1.ToString());
            }
            clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = clsUserCodePrjMainPathExWApi.GetObjByCmPrjAppIdUserId_Cache_Dic(lngCMProjectAppRelaId, strUserId);
            string strProgLangTypeName = clsProgLangTypeWApi.GetNameByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);

            sbMsg.AppendFormat("当前用户,您好！您还没有设置相关代码生成路径，代码类型：{1}({0})({2})，请设置！",                
                objCodeTypeEN.CodeTypeId,
                objCodeTypeEN.CodeTypeName, strProgLangTypeName);
            throw new Exception(sbMsg.ToString());
            //return null;
        }
        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        /// </summary>
        public static void InitListCacheExBak(string strCurrPrjId, string strUserId)
        {
            //检查缓存刷新机制
            string strMsg = "";
            if (clsProjectsWApi.objCommFun4WApi == null)
            {
                strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsWApi.objCommFun4WApi == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (clsCodeTypeWApi.objCommFun4WApi == null)
            {
                strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeWApi.objCommFun4WApi == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (clsUserCodePathWApi.objCommFun4WApi == null)
            {
                strMsg = string.Format("类clsUserCodePathBL没有刷新缓存机制(clsUserCodePathWApi.objCommFun4WApi == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (clsProgLangTypeWApi.objCommFun4WApi == null)
            {
                strMsg = string.Format("类clsProgLangTypeBL没有刷新缓存机制(clsProgLangTypeWApi.objCommFun4WApi == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (clsUsersWApi.objCommFun4WApi == null)
            {
                strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersWApi.objCommFun4WApi == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (clsUserStateWApi.objCommFun4WApi == null)
            {
                strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateWApi.objCommFun4WApi == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (clsUserIdentityWApi.objCommFun4WApi == null)
            {
                strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityWApi.objCommFun4WApi == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (clsDepartmentInfoWApi.objCommFun4WApi == null)
            {
                strMsg = string.Format("类clsDepartmentInfoBL没有刷新缓存机制(clsDepartmentInfoWApi.objCommFun4WApi == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (clsDepartmentTypeWApi.objCommFun4WApi == null)
            {
                strMsg = string.Format("类clsDepartmentTypeBL没有刷新缓存机制(clsDepartmentTypeWApi.objCommFun4WApi == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (strCurrPrjId != mstrPrjId4Cache)
            {
                clsvUserCodePathWApi.ReFreshThisCache();
            }
            //初始化列表缓存
            //string strWhereCond = string.Format("1 = 1 order by mId");
            string strWhereCond = string.Format("PrjId='{0}' And UserId='{1}'", strCurrPrjId,
                strUserId);
            if (arrvUserCodePathObjLst_Cache == null)
            {
                arrvUserCodePathObjLst_Cache = clsvUserCodePathWApi.GetObjLst(strWhereCond);
                mstrPrjId4Cache = strCurrPrjId;
            }
        }

        public static void GetRelaPath(ref clsvUserCodePathEN objvUserCodePathEN, string strUserId, string strMachineName, int intCmPrjAppId)
        {
            //clsvUserCodePathEN objvUserCodePathEN = GetObjBymId(lngMid);
            //if (objvUserCodePathEN.IsUsePrjMainPath == true)
            //{
            clsUserCodePrjMainPathEN objUserCodePrjMainPathEN
                = clsUserCodePrjMainPathExWApi.GetObjByCmPrjAppIdUserId_Cache_Dic(objvUserCodePathEN.CMProjectAppRelaId, strUserId);
            if (objUserCodePrjMainPathEN == null)
            {
                clsProjectsEN objProjectsEN = clsProjectsWApi.GetObjByPrjIdCache(objvUserCodePathEN.PrjId);
                clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(objvUserCodePathEN.ProgLangTypeId);
                string strMsg = string.Format("语言类型：{0}没有设置项目主目录。(工程:{1})({2})",
                    objProgLangTypeEN.ProgLangTypeName, objProjectsEN.PrjName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPathEN, strMachineName, objUserCodePrjMainPathEN.PrjId);

            objvUserCodePathEN.NewCodePath = string.Format("{0}{1}",
                objUserCodePrjMainPathEx.CodePath, objvUserCodePathEN.CodePath);
            objvUserCodePathEN.NewCodePathBackup = string.Format("{0}{1}",
                                objUserCodePrjMainPathEx.CodePathBackup, objvUserCodePathEN.CodePathBackup);
            objvUserCodePathEN.IsExistCodePathP = Directory.Exists(objUserCodePrjMainPathEx.CodePath);

            //return objvUserCodePathEN;
        }


    }
}