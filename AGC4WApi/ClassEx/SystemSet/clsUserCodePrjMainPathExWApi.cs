
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsUserCodePrjMainPathExWApi
表名:UserCodePrjMainPath(00050338)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:01:48
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
using System.Linq;
using Newtonsoft.Json.Linq;
using AGC.BusinessLogic;

namespace AGC4WApi
{
    public static class clsUserCodePrjMainPathExWApi_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvUserCodePrjMainPathENS">源对象</param>
        /// <returns>目标对象=>clsvUserCodePrjMainPathEN:objvUserCodePrjMainPathENT</returns>
        public static clsUserCodePrjMainPathENEx CopyToEx(this clsUserCodePrjMainPathEN objvUserCodePrjMainPathENS)
        {
            try
            {
                clsUserCodePrjMainPathENEx objvUserCodePrjMainPathENT = new clsUserCodePrjMainPathENEx();
                clsUserCodePrjMainPathWApi.CopyTo(objvUserCodePrjMainPathENS, objvUserCodePrjMainPathENT);
                return objvUserCodePrjMainPathENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000068)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static int ApplicationTypeId(this clsUserCodePrjMainPathEN objvUserCodePrjMainPathEN)
        {
            try
            {

                clsCMProjectAppRelaEN objApplicationTypeEN = clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaIdCache(objvUserCodePrjMainPathEN.CMProjectAppRelaId, objvUserCodePrjMainPathEN.PrjId);
                if (objApplicationTypeEN == null) return 0;
                return objApplicationTypeEN.ApplicationTypeId;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000069)获取ApplicationTypeId数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static string CmPrjId(this clsUserCodePrjMainPathEN objvUserCodePrjMainPathEN)
        {
            try
            {
                clsCMProjectAppRelaEN objApplicationTypeEN = clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaIdCache(objvUserCodePrjMainPathEN.CMProjectAppRelaId, objvUserCodePrjMainPathEN.PrjId);
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
    /// 用户生成项目主路径(UserCodePrjMainPath)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsUserCodePrjMainPathExWApi
    {
        private static readonly string mstrApiControllerName = "UserCodePrjMainPathExApi";
        public static IDictionary<string, clsUserCodePrjMainPathEN> dicAppIdPrjIdUserId_UserCodePrjMainPath = null;
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsUserCodePrjMainPathExWApi()
        {
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存中获取
        /// </summary>
        /// <param name="strCmPrjId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<clsUserCodePrjMainPathENEx> GetObjLstByCmPrjIdAppIdCache(long lngCMProjectAppRelaId, string strPrjId, string strMachineName)
        {
            //const strThisFuncName = "GetObjLstByCmPrjId_Cache";
            var arrUserCodePrjMainPathObjLst_Cache = clsUserCodePrjMainPathWApi.GetObjLstCache(strPrjId);
            try
            {
                var arrUserCodePrjMainPath_Sel = arrUserCodePrjMainPathObjLst_Cache.Where(x => x.CMProjectAppRelaId == lngCMProjectAppRelaId).ToList();

                if (arrUserCodePrjMainPath_Sel.Count > 0)
                {
                    var arrObjEx = new List<clsUserCodePrjMainPathENEx>();
                    foreach (var objInFor in arrUserCodePrjMainPath_Sel)
                    {
                        var objEx = CopyToExByMachineName(objInFor, strMachineName, strPrjId);
                        arrObjEx.Add(objEx);
                    }
                    return arrObjEx;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception objException)
            {
                var strMsg = string.Format("错误:[{0}]. \n根据工程Id:[{1}]获取相应的对象列表不成功!(in {2})", objException.Message, strPrjId, clsStackTrace.GetCurrClassFunction());
                clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }


        public static clsUserCodePrjMainPathEN GetObjByCmPrjAppIdUserId_Cache_Dic(long lngCMProjectAppRelaId, string strUserId)
        {
            if (string.IsNullOrEmpty(strUserId) == true)
            {
                string strMsg = string.Format("当前用户(strUserId)没有设置，请联系管理员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            if (lngCMProjectAppRelaId == 0)
            {
                string strMsg = string.Format("当前CM项目没有设置，请联系管理员！({0})", clsStackTrace.GetCurrClassFunction());

                throw new Exception(strMsg);
            }
            string strKey = string.Format("{0}{1}", lngCMProjectAppRelaId, strUserId);
            clsUserCodePrjMainPathEN objUserCodePrjMainPath_Cond = new clsUserCodePrjMainPathEN();

            string strCondition = objUserCodePrjMainPath_Cond.SetCMProjectAppRelaId(lngCMProjectAppRelaId, "=")
                   .SetUserId(strUserId, "=")
                   .GetCombineCondition();

            if (dicAppIdPrjIdUserId_UserCodePrjMainPath == null)
            {
                dicAppIdPrjIdUserId_UserCodePrjMainPath = new Dictionary<string, clsUserCodePrjMainPathEN>();

                clsUserCodePrjMainPathEN objUserCodePrjMainPath_p = clsUserCodePrjMainPathWApi.GetFirstObj(strCondition);

                dicAppIdPrjIdUserId_UserCodePrjMainPath.Add(strKey, objUserCodePrjMainPath_p);
            }
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = null;
            if (dicAppIdPrjIdUserId_UserCodePrjMainPath.ContainsKey(strKey) == false)
            {
                objUserCodePrjMainPath = clsUserCodePrjMainPathWApi.GetFirstObj(strCondition);
                dicAppIdPrjIdUserId_UserCodePrjMainPath.Add(strKey, objUserCodePrjMainPath);
                return objUserCodePrjMainPath;
            }
            objUserCodePrjMainPath = dicAppIdPrjIdUserId_UserCodePrjMainPath[strKey];
            bool bolIsExist = dicAppIdPrjIdUserId_UserCodePrjMainPath.ContainsKey(strKey);
            if (objUserCodePrjMainPath == null && bolIsExist == false)
            {
                objUserCodePrjMainPath = clsUserCodePrjMainPathWApi.GetFirstObj(strCondition);
                if (objUserCodePrjMainPath != null) dicAppIdPrjIdUserId_UserCodePrjMainPath.Add(strKey, objUserCodePrjMainPath);
                else dicAppIdPrjIdUserId_UserCodePrjMainPath.Add(strKey, objUserCodePrjMainPath);
                return objUserCodePrjMainPath;
            }
            return objUserCodePrjMainPath;
        }
        /// <summary>
        /// 根据代码类型Id和语言类型Id获取用户代码项目主目录
        /// </summary>
        /// <param name="intApplicationTypeId">应用类型Id</param>
        /// <param name="strCurrPrjId">当前工程Id</param>
        /// <param name="strCmPrjId">CM工程Id</param>
        /// <param name="strUserId">用户Id</param>
        /// <returns>clsUserCodePrjMainPathEN</returns>
        public static clsUserCodePrjMainPathENEx GetObjExByCMProjectAppRelaIdCache(long lngCMProjectAppRelaId, string strCurrPrjId, string strMachineName, string strUserId)
        {
            if (string.IsNullOrEmpty(strUserId) == true)
            {
                string strMsg = string.Format("当前用户(strUserId)没有设置，请联系管理员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            if (string.IsNullOrEmpty(strCurrPrjId) == true)
            {
                string strMsg = string.Format("当前项目没有设置，请联系管理员！({0})", clsStackTrace.GetCurrClassFunction());

                throw new Exception(strMsg);
            }

            List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLst_Cache = clsUserCodePrjMainPathWApi.GetObjLstCache(strCurrPrjId);

            clsCMProjectAppRelaEN objCMProjectAppRela = null;
            try
            {
                objCMProjectAppRela =
                    clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, strCurrPrjId);
            }
            catch (Exception objException)
            {
                StringBuilder sbMsg1 = new StringBuilder();
                sbMsg1.AppendFormat("在获取Cm工程应用类型Id＝[{0}]的Cm工程应用类型对象时出错，错误信息：{1}。", lngCMProjectAppRelaId, objException.Message);
                throw new Exception(sbMsg1.ToString());
            }
            var arrUserCodePrjMainPath_Sel = arrUserCodePrjMainPathObjLst_Cache.Where(x => x.CMProjectAppRelaId == lngCMProjectAppRelaId
                                 && x.PrjId == strCurrPrjId
                                 && x.UserId == strUserId);
            if (arrUserCodePrjMainPath_Sel.Count() == 1)
            {
                var objUserCodePrjMainPathEx = CopyToExByMachineName(arrUserCodePrjMainPath_Sel.First(), strMachineName, objCMProjectAppRela.PrjId);

                return objUserCodePrjMainPathEx;
            }
            if (arrUserCodePrjMainPath_Sel.Count() == 0)
            {
                clsUserCodePrjMainPathWApi.ReFreshCache(strCurrPrjId);

                string strMsg = string.Format("根据Cm工程应用类型:{0},用户:{1}(工程Id:{2})的用户代码主路径没有设置，请联系管理员！({3})",
               lngCMProjectAppRelaId, strUserId, strCurrPrjId,
               clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
                //return null;
            }

            arrUserCodePrjMainPath_Sel = arrUserCodePrjMainPathObjLst_Cache.Where(x => x.CMProjectAppRelaId == lngCMProjectAppRelaId
                       && x.PrjId == strCurrPrjId
                       && x.UserId == strUserId
                       );
            if (arrUserCodePrjMainPath_Sel.Count() == 1)
            {
                var objUserCodePrjMainPathEx = CopyToExByMachineName(arrUserCodePrjMainPath_Sel.First(), strMachineName, objCMProjectAppRela.PrjId);

                return objUserCodePrjMainPathEx;
            }
            if (arrUserCodePrjMainPath_Sel.Count() == 0)
            {
                string strMsg = string.Format("根据应用类型:{0},用户:{1}, CmPrjId:{2}(工程Id:{3})的用户代码主路径没有设置，请联系管理员！({4})",
                    objCMProjectAppRela.ApplicationTypeName(), strUserId, objCMProjectAppRela.CmPrjId, strCurrPrjId,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }


            return null;
        }
        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache()
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsUserCodePrjMainPathWApi.objCommFun4WApi == null)
        //    {
        //        strMsg = string.Format("类clsUserCodePrjMainPathBL没有刷新缓存机制(clsUserCodePrjMainPathWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    //初始化列表缓存
        //    string strWhereCond = string.Format("1 = 1 order by UserCodePrjMainPathId");
        //    if (arrUserCodePrjMainPathObjLst_Cache == null)
        //    {
        //        arrUserCodePrjMainPathObjLst_Cache = clsUserCodePrjMainPathWApi.GetObjLst(strWhereCond);
        //    }
        //}
        public static int CopyUserCodePrjMainPathFromTemplateBak(string strPrjId, string strMachineName, string strUserId)
        {
            //clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
            string strCurrDate = SqlWApi.DateTime_GetDataBaseDateTime14();
            clsProjectsEN objProjects = clsProjectsWApi.GetObjByPrjId(clsSysParaEN.CurrSelPrjId);
            //string strCondition = string.Format("PrjId='0000' ");
            //List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPathENObjLst = clsUserCodePrjMainPathWApi.GetObjLst(strCondition);
            List<clsCMProjectEN> arrCmProject = clsCMProjectExWApi.GetObjLstByPrjIdExCache(strPrjId);
            List<clsApplicationTypeEN> arrAppType = clsApplicationTypeWApi.GetObjLstCache();
            arrAppType = arrAppType.Where(x => x.IsVisible == true).ToList();
            int intCount = 0;
            foreach (clsCMProjectEN objCMProjectEN in arrCmProject)
            {
                foreach (clsApplicationTypeEN objApplicationTypeEN in arrAppType)
                {
                    long lngCMProjectAppRelaId_New = clsCMProjectAppRelaExWApi.AddCMProjectAppRelaId(objCMProjectEN.CmPrjId, objApplicationTypeEN.ApplicationTypeId, strPrjId);

                    clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = null;
                    string strCondition = string.Format("PrjId='{0}'  And UserId='{1}' And {2}='{3}' ",
                                           strPrjId, strUserId,
                                          conUserCodePrjMainPath.CMProjectAppRelaId, lngCMProjectAppRelaId_New);
                    objUserCodePrjMainPathEN = clsUserCodePrjMainPathWApi.GetFirstObj(strCondition);
                    if (clsUserCodePrjMainPathWApi.IsExistRecord(strCondition) == false)
                    {
                        objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
                        objUserCodePrjMainPathEN.UserCodePrjMainPathId = clsUserCodePrjMainPathWApi.GetMaxStrId();
                        objUserCodePrjMainPathEN.PrjId = strPrjId;
                        //objUserCodePrjMainPathEN.CmPrjId = strCmPrjId;

                        objUserCodePrjMainPathEN.UserId = strUserId;
                        objUserCodePrjMainPathEN.UpdDate = strCurrDate;
                        objUserCodePrjMainPathEN.IncludeXmlPath = "";// string.Format(objUserCodePrjMainPathEN.IncludeXmlPath.Replace("pyf", strUserId), objProjects.PrjDomain); ;
                        objUserCodePrjMainPathEN.CMProjectAppRelaId = lngCMProjectAppRelaId_New;

                        objUserCodePrjMainPathEN.UpdUserId = strUserId;
                        objUserCodePrjMainPathEN.IsTemplate = false;

                        objUserCodePrjMainPathEN.AddNewRecord();
                    }

                    var objUserCodePrjMainPath_MachineName = new clsUserCodePrjMainPath_MachineNameEN();
                    clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPathEN, strMachineName, strPrjId);

                    objUserCodePrjMainPath_MachineName.UserCodePrjMainPathId = objUserCodePrjMainPathEN.UserCodePrjMainPathId;
                    objUserCodePrjMainPath_MachineName.MachineName = strMachineName;
                    objUserCodePrjMainPath_MachineName.CodePath = string.Format(objUserCodePrjMainPathEx.CodePath.Replace("pyf", strUserId), objProjects.PrjDomain);
                    objUserCodePrjMainPath_MachineName.CodePathBackup = string.Format(objUserCodePrjMainPathEx.CodePathBackup.Replace("pyf", strUserId), objProjects.PrjDomain);
                    objUserCodePrjMainPath_MachineName.LogPath = string.Format(objUserCodePrjMainPathEx.LogPath.Replace("pyf", strUserId), objProjects.PrjDomain);
                    if (objUserCodePrjMainPath_MachineName.CodePath == "") objUserCodePrjMainPath_MachineName.CodePath = "null";
                    if (objUserCodePrjMainPath_MachineName.CodePathBackup == "") objUserCodePrjMainPath_MachineName.CodePathBackup = "null";
                    objUserCodePrjMainPath_MachineName.PrjId = strPrjId;
                    string strCondition2 = $"{conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId} ='{objUserCodePrjMainPath_MachineName.UserCodePrjMainPathId}'";
                    strCondition2 += $" and MachineName = '{objUserCodePrjMainPath_MachineName.MachineName}'";
                    if (clsUserCodePrjMainPath_MachineNameWApi.IsExistRecord(strCondition2) == false)
                    {
                        objUserCodePrjMainPath_MachineName.AddNewRecord();
                    }
                    else
                    {
                        objUserCodePrjMainPath_MachineName.Update();
                    }

                    intCount++;

                }
            }
            return intCount;
        }


        public static int CreateUserCodePrjMainPathByCmProjectApp(long lngCMProjectAppRelaId, string strPrjId, string strMachineName, string strUserId)
        {
            //clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
            string strCurrDate = SqlWApi.DateTime_GetDataBaseDateTime14();
            clsProjectsEN objProjects = clsProjectsWApi.GetObjByPrjId(clsSysParaEN.CurrSelPrjId);
            //string strCondition = string.Format("PrjId='0000' ");
            clsCMProjectAppRelaEN objCMProjectAppRela = clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaId(lngCMProjectAppRelaId);


            int intCount = 0;


            clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = null;
            string strCondition = string.Format("PrjId='{0}'  And UserId='{1}' And {2}='{3}' ",
                                   strPrjId, strUserId,
                                  conUserCodePrjMainPath.CMProjectAppRelaId, lngCMProjectAppRelaId);
            objUserCodePrjMainPathEN = clsUserCodePrjMainPathWApi.GetFirstObj(strCondition);
            if (clsUserCodePrjMainPathWApi.IsExistRecord(strCondition) == false)
            {
                objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
                objUserCodePrjMainPathEN.UserCodePrjMainPathId = clsUserCodePrjMainPathWApi.GetMaxStrId();
                objUserCodePrjMainPathEN.PrjId = strPrjId;
                //objUserCodePrjMainPathEN.CmPrjId = strCmPrjId;

                objUserCodePrjMainPathEN.UserId = strUserId;
                objUserCodePrjMainPathEN.UpdDate = strCurrDate;
                objUserCodePrjMainPathEN.IncludeXmlPath = "";// string.Format(objUserCodePrjMainPathEN.IncludeXmlPath.Replace("pyf", strUserId), objProjects.PrjDomain); ;
                objUserCodePrjMainPathEN.CMProjectAppRelaId = lngCMProjectAppRelaId;

                objUserCodePrjMainPathEN.UpdUserId = strUserId;
                objUserCodePrjMainPathEN.IsTemplate = false;
                objUserCodePrjMainPathEN.InUse = true;

                objUserCodePrjMainPathEN.AddNewRecord();
            }

            var objUserCodePrjMainPath_MachineName = new clsUserCodePrjMainPath_MachineNameEN();
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPathEN, strMachineName, strPrjId);

            objUserCodePrjMainPath_MachineName.UserCodePrjMainPathId = objUserCodePrjMainPathEN.UserCodePrjMainPathId;
            objUserCodePrjMainPath_MachineName.MachineName = strMachineName;
            objUserCodePrjMainPath_MachineName.CodePath = string.Format(objUserCodePrjMainPathEx.CodePath.Replace("pyf", strUserId), objProjects.PrjDomain);
            objUserCodePrjMainPath_MachineName.CodePathBackup = string.Format(objUserCodePrjMainPathEx.CodePathBackup.Replace("pyf", strUserId), objProjects.PrjDomain);
            objUserCodePrjMainPath_MachineName.LogPath = string.Format(objUserCodePrjMainPathEx.LogPath.Replace("pyf", strUserId), objProjects.PrjDomain);
            if (objUserCodePrjMainPath_MachineName.CodePath == "") objUserCodePrjMainPath_MachineName.CodePath = "null";
            if (objUserCodePrjMainPath_MachineName.CodePathBackup == "") objUserCodePrjMainPath_MachineName.CodePathBackup = "null";
            objUserCodePrjMainPath_MachineName.PrjId = strPrjId;
            string strCondition2 = $"{conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId} ='{objUserCodePrjMainPath_MachineName.UserCodePrjMainPathId}'";
            strCondition2 += $" and MachineName = '{objUserCodePrjMainPath_MachineName.MachineName}'";
            if (clsUserCodePrjMainPath_MachineNameWApi.IsExistRecord(strCondition2) == false)
            {
                objUserCodePrjMainPath_MachineName.AddNewRecord();
            }
            else
            {
                objUserCodePrjMainPath_MachineName.Update();
            }
            clsUserCodePrjMainPath_MachineNameWApi.ReFreshCache(strPrjId);
            intCount++;


            return intCount;
        }


        public static clsUserCodePrjMainPathENEx CopyToExByMachineName(clsUserCodePrjMainPathEN objUserCodePrjMainPathENS, string strMachineName, string strPrjId)
        {
            try
            {

                clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameWApi.GetObjByKeyLstCache(objUserCodePrjMainPathENS.UserCodePrjMainPathId,
                    strMachineName, strPrjId);
                if (objUserCodePrjMainPath_MachineName == null)
                {
                    string strCmPrjName = clsCMProjectWApi.GetNameByCmPrjIdCache(objUserCodePrjMainPathENS.CmPrjId());
                    string strAppName = clsApplicationTypeWApi.GetNameByApplicationTypeIdCache(objUserCodePrjMainPathENS.ApplicationTypeId());

                    string strErrMsg = $"Cm工程:{strCmPrjName}, 应用:{strAppName}在机器:{strMachineName}中对象为空，请检查！";
                    throw new Exception(strErrMsg);
                }
                clsUserCodePrjMainPathENEx objUserCodePrjMainPathENT = new clsUserCodePrjMainPathENEx();
                clsUserCodePrjMainPathWApi.CopyTo(objUserCodePrjMainPathENS, objUserCodePrjMainPathENT);

                if (objUserCodePrjMainPath_MachineName != null)
                {
                    objUserCodePrjMainPathENT.CodePath = objUserCodePrjMainPath_MachineName.CodePath;
                    objUserCodePrjMainPathENT.CodePathBackup = objUserCodePrjMainPath_MachineName.CodePathBackup;
                    objUserCodePrjMainPathENT.LogPath = objUserCodePrjMainPath_MachineName.LogPath;
                    objUserCodePrjMainPathENT.GcPathId = objUserCodePrjMainPath_MachineName.GcPathId;

                    objUserCodePrjMainPathENT.MachineName = objUserCodePrjMainPath_MachineName.MachineName;

                }
                return objUserCodePrjMainPathENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 扩展删除
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strUserCodePrjMainPathId">生成主目录Id</param>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <returns>返回对象列表</returns>
        public static bool DelRecordEx(string strUserCodePrjMainPathId, string strPrjId)
        {
            string strAction = "DelRecordEx";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserCodePrjMainPathId"] = strUserCodePrjMainPathId,
                ["strPrjId"] = strPrjId,
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (bool)jobjReturn["returnBool"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
    }
}