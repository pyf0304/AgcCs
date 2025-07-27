using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{


    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_UserCodePrjMainPathEx : RelatedActions_UserCodePrjMainPath
    {
        public override bool UpdRelaTabDate(string strUserCodePrjMainPathId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsUserCodePrjMainPathBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objUserCodePrjMainPathENS">源对象</param>
        /// <returns>目标对象=>clsUserCodePrjMainPathEN:objUserCodePrjMainPathENT</returns>
        public static clsUserCodePrjMainPathENEx CopyToEx(this clsUserCodePrjMainPathEN objUserCodePrjMainPathENS)
        {
            try
            {
                clsUserCodePrjMainPathENEx objUserCodePrjMainPathENT = new clsUserCodePrjMainPathENEx();
                clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.CopyTo(objUserCodePrjMainPathENS, objUserCodePrjMainPathENT);
                return objUserCodePrjMainPathENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objUserCodePrjMainPathENS">源对象</param>
        /// <returns>目标对象=>clsUserCodePrjMainPathEN:objUserCodePrjMainPathENT</returns>
        public static clsUserCodePrjMainPathEN CopyTo(this clsUserCodePrjMainPathENEx objUserCodePrjMainPathENS)
        {
            try
            {
                clsUserCodePrjMainPathEN objUserCodePrjMainPathENT = new clsUserCodePrjMainPathEN();
                clsUserCodePrjMainPathBL.CopyTo(objUserCodePrjMainPathENS, objUserCodePrjMainPathENT);
                return objUserCodePrjMainPathENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 用户生成项目主路径(UserCodePrjMainPath)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsUserCodePrjMainPathBLEx : clsUserCodePrjMainPathBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsUserCodePrjMainPathDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsUserCodePrjMainPathDAEx UserCodePrjMainPathDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsUserCodePrjMainPathDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objUserCodePrjMainPathENS">源对象</param>
        /// <returns>目标对象=>clsUserCodePrjMainPathEN:objUserCodePrjMainPathENT</returns>
        public static clsUserCodePrjMainPathENEx CopyToEx(clsUserCodePrjMainPathEN objUserCodePrjMainPathENS)
        {
            try
            {
                clsUserCodePrjMainPathENEx objUserCodePrjMainPathENT = new clsUserCodePrjMainPathENEx();
                clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.CopyTo(objUserCodePrjMainPathENS, objUserCodePrjMainPathENT);
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

        public static clsUserCodePrjMainPathENEx CopyToExByMachineName(clsUserCodePrjMainPathEN objUserCodePrjMainPathENS, string strMachineName)
        {
            try
            {
                clsUserCodePrjMainPathENEx objUserCodePrjMainPathENT = new clsUserCodePrjMainPathENEx();
                clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.CopyTo(objUserCodePrjMainPathENS, objUserCodePrjMainPathENT);
                clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(objUserCodePrjMainPathENT.UserCodePrjMainPathId, strMachineName);
                if (objUserCodePrjMainPath_MachineName != null)
                {
                    objUserCodePrjMainPathENT.CodePath = objUserCodePrjMainPath_MachineName.CodePath;
                    objUserCodePrjMainPathENT.CodePathBackup = objUserCodePrjMainPath_MachineName.CodePathBackup;
                    objUserCodePrjMainPathENT.LogPath = objUserCodePrjMainPath_MachineName.LogPath;
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
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsUserCodePrjMainPathENEx> GetObjExLst(string strCondition)
        {
            List<clsUserCodePrjMainPathEN> arrObjLst = clsUserCodePrjMainPathBL.GetObjLst(strCondition);
            List<clsUserCodePrjMainPathENEx> arrObjExLst = new List<clsUserCodePrjMainPathENEx>();
            foreach (clsUserCodePrjMainPathEN objInFor in arrObjLst)
            {
                clsUserCodePrjMainPathENEx objUserCodePrjMainPathENEx = new clsUserCodePrjMainPathENEx();
                clsUserCodePrjMainPathBL.CopyTo(objInFor, objUserCodePrjMainPathENEx);
                arrObjExLst.Add(objUserCodePrjMainPathENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strUserCodePrjMainPathId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsUserCodePrjMainPathENEx GetObjExByUserCodePrjMainPathId(string strUserCodePrjMainPathId)
        {
            clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = clsUserCodePrjMainPathBL.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathENEx = new clsUserCodePrjMainPathENEx();
            clsUserCodePrjMainPathBL.CopyTo(objUserCodePrjMainPathEN, objUserCodePrjMainPathENEx);
            return objUserCodePrjMainPathENEx;
        }


        public static IDictionary<string, clsUserCodePrjMainPathEN> dicAppIdPrjIdUserId_UserCodePrjMainPath = null;
        //private static string mstrPrjId4Cache = "";

        /// <summary>
        /// 设置GC路径
        /// </summary>
        /// <param name="strOpUser">操作用户</param>
        /// <returns></returns>
        public static int SetGCPath(string strOpUserId, string strMachineName)
        {
            string strCurrDate = clsDateTime_Db.GetDataBaseDateTime14();
            string strCondition = string.Format("1=1");
            List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLst = clsUserCodePrjMainPathBL.GetObjLst(strCondition);
            List<clsUserCodePrjMainPathENEx> arrUserCodePrjMainPathExObjLst = arrUserCodePrjMainPathObjLst.Select(x=>CopyToExByMachineName(x,strMachineName)).ToList();
            int intCount = 0;
            foreach (clsUserCodePrjMainPathENEx objUserCodePrjMainPath in arrUserCodePrjMainPathExObjLst)
            {
                var objUserCodePrjMainPath_MachineName
                    = clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(objUserCodePrjMainPath.UserCodePrjMainPathId, strMachineName);

                var strPath = objUserCodePrjMainPath.CodePath;
                strPath = strPath.Replace("//", "/").Replace("/\\", "\\").Replace("\\\\", "\\");
                var objGCPath = clsGCPathBLEx.GetObjByGcPathName(strPath, objUserCodePrjMainPath.PrjId, objUserCodePrjMainPath.UserId);

                if (objGCPath == null)
                {
                    objGCPath = new clsGCPathEN();
                    objGCPath.SetGcPathName(strPath)
                        .SetPrjId(objUserCodePrjMainPath.PrjId)
                        .SetIsForMainPath(true)
                        .SetUserId(objUserCodePrjMainPath.UserId)
                        .SetUpdDate(strCurrDate)
                        .SetUpdUser(strOpUserId);
                    objGCPath.AddNewRecordWithMaxId();
                    if (objUserCodePrjMainPath_MachineName == null)
                    {
                        objUserCodePrjMainPath_MachineName = new clsUserCodePrjMainPath_MachineNameEN();
                        objUserCodePrjMainPath_MachineName.SetUserCodePrjMainPathId(objUserCodePrjMainPath.UserCodePrjMainPathId)
                            .SetMachineName(strMachineName);
                        objUserCodePrjMainPath_MachineName.GcPathId = objGCPath.GcPathId;
                        objUserCodePrjMainPath_MachineName.UpdDate = strCurrDate;
                        objUserCodePrjMainPath_MachineName.UpdUserId = strOpUserId;
                        //objUserCodePrjMainPath.IsTemplate = false;
                        objUserCodePrjMainPath_MachineName.Update();
                    }
                    else
                    {
                        objUserCodePrjMainPath_MachineName.GcPathId = objGCPath.GcPathId;
                        objUserCodePrjMainPath_MachineName.UpdDate = strCurrDate;
                        objUserCodePrjMainPath_MachineName.UpdUserId = strOpUserId;
                        //objUserCodePrjMainPath.IsTemplate = false;
                        clsUserCodePrjMainPath_MachineNameBL.UpdateBySql2(objUserCodePrjMainPath_MachineName);
                    }
                    intCount++;
                }
                else
                {
                    objUserCodePrjMainPath_MachineName.GcPathId = objGCPath.GcPathId;
                    objUserCodePrjMainPath_MachineName.UpdDate = strCurrDate;
                    objUserCodePrjMainPath_MachineName.UpdUserId = strOpUserId;
                    //objUserCodePrjMainPath.IsTemplate = false;
                    clsUserCodePrjMainPath_MachineNameBL.UpdateBySql2(objUserCodePrjMainPath_MachineName);
                    intCount++;
                }
            }
            return intCount;
        }

        public static int CopyUserCodePrjMainPathFromTemplate(string strPrjId, string strMachineName, string strUserId)
        {
            //clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
            string strCurrDate = clsDateTime_Db.GetDataBaseDateTime14();
            clsProjectsEN objProjects = clsProjectsBL.GetObjByPrjId(clsSysParaEN.CurrSelPrjId);
            string strCondition = string.Format("PrjId='0000' And IsTemplate='1'");
            List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPathENObjLst = clsUserCodePrjMainPathBL.GetObjLst(strCondition);
            int intCount = 0;
            foreach (clsUserCodePrjMainPathEN objUserCodePrjMainPathEN in arrUserCodePrjMainPathENObjLst)
            {
                var objUserCodePrjMainPath_MachineNameEx_S = CopyToExByMachineName(objUserCodePrjMainPathEN, strMachineName);
                strCondition = string.Format("PrjId='{0}'  And UserId='{1}' And {2}='{3}' ",
                                    strPrjId, strUserId,
                                   conUserCodePrjMainPath.CMProjectAppRelaId, objUserCodePrjMainPathEN.CMProjectAppRelaId);
                if (clsUserCodePrjMainPathBL.IsExistRecord(strCondition) == false)
                {
                    objUserCodePrjMainPathEN.UserCodePrjMainPathId = clsUserCodePrjMainPathBL.GetMaxStrId_S();
                    objUserCodePrjMainPathEN.PrjId = strPrjId;
                    objUserCodePrjMainPathEN.UserId = strUserId;
                    objUserCodePrjMainPathEN.UpdDate = strCurrDate;
                    objUserCodePrjMainPathEN.IncludeXmlPath = string.Format(objUserCodePrjMainPathEN.IncludeXmlPath.Replace("pyf", strUserId), objProjects.PrjDomain); ;
                    objUserCodePrjMainPathEN.CMProjectAppRelaId = objUserCodePrjMainPathEN.CMProjectAppRelaId;

                    objUserCodePrjMainPathEN.UpdUserId = strUserId;
                    objUserCodePrjMainPathEN.IsTemplate = false;

                    clsUserCodePrjMainPathBL.AddNewRecordBySql2(objUserCodePrjMainPathEN);
                    clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName = new clsUserCodePrjMainPath_MachineNameEN();
                    objUserCodePrjMainPath_MachineName.UserCodePrjMainPathId = objUserCodePrjMainPathEN.UserCodePrjMainPathId;
                    objUserCodePrjMainPath_MachineName.MachineName = strMachineName;
                    objUserCodePrjMainPath_MachineName.CodePath = string.Format(objUserCodePrjMainPath_MachineNameEx_S.CodePath.Replace("pyf", strUserId), objProjects.PrjDomain);
                    objUserCodePrjMainPath_MachineName.CodePathBackup = string.Format(objUserCodePrjMainPath_MachineNameEx_S.CodePathBackup.Replace("pyf", strUserId), objProjects.PrjDomain); ;
                    objUserCodePrjMainPath_MachineName.LogPath = string.Format(objUserCodePrjMainPath_MachineNameEx_S.LogPath.Replace("pyf", strUserId), objProjects.PrjDomain); ;
                    clsUserCodePrjMainPath_MachineNameBL.AddNewRecordBySql2(objUserCodePrjMainPath_MachineName);
                    intCount++;
                }
            }
            return intCount;
        }

        public static clsUserCodePrjMainPathENEx GetObjExByUserCodePrjMainPathIdCache(string userCodePrjMainPathId, string prjId, string strMachineName)
        {
            clsUserCodePrjMainPathEN objUserCodePrjMainPathEN
                = clsUserCodePrjMainPathBLEx.GetObjByUserCodePrjMainPathIdCache(userCodePrjMainPathId, prjId);
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = CopyToExByMachineName(objUserCodePrjMainPathEN, strMachineName);
            return objUserCodePrjMainPathEx;

        }

        public static string GetFileFromFolder(string strFolder, string strSimpleFileName)
        {
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("目录：{0}不存在！请检查！", strFolder);
                throw new Exception(strMsg);
            }
            DirectoryInfo objDirectory = new DirectoryInfo(strFolder);
            FileInfo[] arrFileInfoLst = objDirectory.GetFiles();
            foreach (FileInfo objFileInfo in arrFileInfoLst)
            {
                if (objFileInfo.Name == strSimpleFileName)
                {
                    //objFileInfo.
                    return objFileInfo.FullName;
                }

            }
            DirectoryInfo[] arrDirectoryInfoLst = objDirectory.GetDirectories();
            foreach (DirectoryInfo objDirectoryInfo in arrDirectoryInfoLst)
            {
                string strFindFile = GetFileFromFolder(objDirectoryInfo, strSimpleFileName);
                if (string.IsNullOrEmpty(strFindFile) == false)
                {
                    return strFindFile;
                }
            }
            return "";
        }


        public static string GetFileFromFolder(DirectoryInfo objDirectoryP, string strSimpleFileName)
        {

            FileInfo[] arrFileInfoLst = objDirectoryP.GetFiles();
            foreach (FileInfo objFileInfo in arrFileInfoLst)
            {
                if (objFileInfo.Name == strSimpleFileName)
                {
                    //objFileInfo.
                    return objFileInfo.FullName;
                }
            }
            DirectoryInfo[] arrDirectoryInfoLst = objDirectoryP.GetDirectories();
            foreach (DirectoryInfo objDirectoryInfo in arrDirectoryInfoLst)
            {
                string strFindFile = GetFileFromFolder(objDirectoryInfo, strSimpleFileName);
                if (string.IsNullOrEmpty(strFindFile) == false)
                {
                    return strFindFile;
                }
            }
            return "";
        }
        /// <summary>
        /// 根据代码类型Id和语言类型Id获取用户代码项目主目录
        /// </summary>
        /// <param name="intApplicationTypeId">应用类型Id</param>
        /// <param name="strCurrPrjId">当前工程Id</param>
        /// <param name="strUserId">用户Id</param>
        /// <returns>clsUserCodePrjMainPathEN</returns>
        public static clsUserCodePrjMainPathEN GetObjByCMProjectAppRelaIdCache(long intCMProjectAppRelaId, string strCurrPrjId, string strUserId)
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
            List<clsUserCodePrjMainPathEN> arrObjLstCache = clsUserCodePrjMainPathBL.GetObjLstCache(strCurrPrjId);


            foreach (clsUserCodePrjMainPathEN objUserCodePrjMainPathEN in arrObjLstCache)
            {
                if (intCMProjectAppRelaId == objUserCodePrjMainPathEN.CMProjectAppRelaId
                    && objUserCodePrjMainPathEN.PrjId == strCurrPrjId
                    && objUserCodePrjMainPathEN.UserId == strUserId)
                {
                    return objUserCodePrjMainPathEN;
                }
            }
            string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPathEN._CurrTabName, strCurrPrjId);
            CacheHelper.Remove(strKey);
            StringBuilder sbMsg = new StringBuilder();
            clsCMProjectAppRelaEN objCMProjectAppRelaEN = null;
            try
            {
                objCMProjectAppRelaEN =
                    clsCMProjectAppRelaBL.GetObjByCMProjectAppRelaIdCache(intCMProjectAppRelaId, strCurrPrjId);
            }
            catch (Exception objException)
            {
                StringBuilder sbMsg1 = new StringBuilder();
                sbMsg1.AppendFormat("在获取CMProjectAppRelaId＝[{0}]的Cm工程应用类型对象时出错，错误信息：{1}。", intCMProjectAppRelaId, objException.Message);
                throw new Exception(sbMsg1.ToString());
            }
            clsUsersEN objUsersEN = clsUsersBL.GetObjByUserId(strUserId);
            var objApplicationTypeEN = clsApplicationTypeBL.GetObjByApplicationTypeIdCache(objCMProjectAppRelaEN.ApplicationTypeId);
            sbMsg.AppendFormat("{0},您好！您还没有设置主代码生成路径：{1}，请设置！", objUsersEN.UserName, objApplicationTypeEN.ApplicationTypeName);
            throw new Exception(sbMsg.ToString());
            //return null;
        }

        public static clsUserCodePrjMainPathEN GetObjByCmPrjIdAppRelaIdPrjIdUserIdCache_Dic(long intCMProjectAppRelaId, string strUserId)
        {
            if (string.IsNullOrEmpty(strUserId) == true)
            {
                string strMsg = string.Format("当前用户(strUserId)没有设置，请联系管理员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            //if (string.IsNullOrEmpty(strCurrPrjId) == true)
            //{
            //    string strMsg = string.Format("当前项目没有设置，请联系管理员！({0})", clsStackTrace.GetCurrClassFunction());

            //    throw new Exception(strMsg);
            //}
            string strKey = string.Format("{0}{1}", intCMProjectAppRelaId, strUserId);
            clsUserCodePrjMainPathEN objUserCodePrjMainPath_Cond = new clsUserCodePrjMainPathEN();

            string strCondition = objUserCodePrjMainPath_Cond.SetCMProjectAppRelaId(intCMProjectAppRelaId, "=")
                                      .SetUserId(strUserId, "=")
                   .GetCombineCondition();

            if (dicAppIdPrjIdUserId_UserCodePrjMainPath == null)
            {
                dicAppIdPrjIdUserId_UserCodePrjMainPath = new Dictionary<string, clsUserCodePrjMainPathEN>();

                clsUserCodePrjMainPathEN objUserCodePrjMainPath_p = clsUserCodePrjMainPathBL.GetFirstObj_S(strCondition);

                dicAppIdPrjIdUserId_UserCodePrjMainPath.Add(strKey, objUserCodePrjMainPath_p);
            }
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = null;
            if (dicAppIdPrjIdUserId_UserCodePrjMainPath.ContainsKey(strKey) == false)
            {
                objUserCodePrjMainPath = clsUserCodePrjMainPathBL.GetFirstObj_S(strCondition);
                dicAppIdPrjIdUserId_UserCodePrjMainPath.Add(strKey, objUserCodePrjMainPath);
                return objUserCodePrjMainPath;
            }
            objUserCodePrjMainPath = dicAppIdPrjIdUserId_UserCodePrjMainPath[strKey];

            if (objUserCodePrjMainPath == null)
            {
                objUserCodePrjMainPath = clsUserCodePrjMainPathBL.GetFirstObj_S(strCondition);
                dicAppIdPrjIdUserId_UserCodePrjMainPath.Add(strKey, objUserCodePrjMainPath);
                return objUserCodePrjMainPath;
            }
            return objUserCodePrjMainPath;
        }


        ///// <summary>
        ///// 根据代码类型和语言类型获取用户代码项目主目录
        ///// </summary>
        ///// <param name="ltLangType">语言类型</param>
        ///// <param name="strCurrPrjId">当前工程Id</param>
        ///// <returns></returns>
        //public static clsUserCodePrjMainPathEN GetUserCodePrjMainPathObjByApplicationTypeId(int intApplicationTypeId, string strCurrPrjId, string strUserId)
        //{            
        //    //clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBLEx.GetProgLangTypeObjByLangTypeCache(ltLangType);
        //    clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = GetUserCodePrjMainPathObjByApplicationTypeId(intApplicationTypeId, strCurrPrjId, strUserId);
        //    return objUserCodePrjMainPathEN;
        //}


        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        /// <param name = "strPrjId">strPrjId</param>
        /// <param name = "bolIsUsePrjMainPath">bolIsUsePrjMainPath</param>
        public static void BindCbo_DistinctCodePath(System.Windows.Forms.ComboBox objComboBox,
            string strPrjId, bool bolIsUsePrjMainPath)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("{0} in (Select {0} From {1} where {2}='{3}' And {4}='{5}')",
                conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId,
                conUserCodePrjMainPath._CurrTabName,
                conUserCodePrjMainPath.PrjId, strPrjId, conUserCodePrjMainPath.IsUsePrjMainPath, bolIsUsePrjMainPath ? "1" : "0");
            List<string> arrCodePath = GetFldValue(conUserCodePrjMainPath_MachineName.CodePath, strCondition);
            arrCodePath.Sort();

            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conUserCodePrjMainPath_MachineName.CodePath;
            objComboBox.DisplayMember = conUserCodePrjMainPath_MachineName.CodePath;
            objComboBox.DataSource = arrCodePath;
            objComboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        /// <param name = "strPrjId">strPrjId</param>
        /// <param name = "bolIsUsePrjMainPath">bolIsUsePrjMainPath</param>
        public static void BindCbo_DistinctCodePathBackup(System.Windows.Forms.ComboBox objComboBox,
            string strPrjId, bool bolIsUsePrjMainPath)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("{0} in (Select {0} From {1} where {2}='{3}' And {4}='{5}')",
                conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId,
                conUserCodePrjMainPath._CurrTabName,
                conUserCodePrjMainPath.PrjId, strPrjId,
                conUserCodePrjMainPath.IsUsePrjMainPath, bolIsUsePrjMainPath ? "1" : "0");
            List<string> arrCodePath = clsUserCodePrjMainPath_MachineNameBL.GetFldValue(conUserCodePrjMainPath_MachineName.CodePathBackup, strCondition);
            arrCodePath.Sort();

            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conUserCodePrjMainPath_MachineName.CodePath;
            objComboBox.DisplayMember = conUserCodePrjMainPath_MachineName.CodePath;
            objComboBox.DataSource = arrCodePath;
            objComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
        /// </summary>
        /// <param name="strUserCodePrjMainPathId">表关键字</param>
        /// <param name="strCmPrjId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(string strUserCodePrjMainPathId, string strPrjId)
        {
            //string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            clsSpecSQLforSql objSQL;
            //获取连接对象
            objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
            //删除TeacherInfo本表中与当前对象有关的记录
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            try
            {
                //获取连接对象
                objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                //获取该连接对象中的事务
                objSqlTransaction = objConnection.BeginTransaction();
                //
                //删除与表:[UserCodePrjMainPath]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition = string.Format("{0} = '{1}'",
                conUserCodePrjMainPath.UserCodePrjMainPathId,
                strUserCodePrjMainPathId);
                //clsUserCodePathBL.DelUserCodePathsByCondWithTransaction_S(strCondition, strPrjId, objConnection, objSqlTransaction);
                clsUserCodePrjMainPath_MachineNameBL.DelUserCodePrjMainPath_MachineNamesByCondWithTransaction_S(strCondition, strPrjId, objConnection, objSqlTransaction);
                clsUserCodePrjMainPathBL.DelRecord(strUserCodePrjMainPathId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsUserCodePrjMainPathBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
                objException.Message,
                strUserCodePrjMainPathId, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                if (objSqlTransaction != null)
                {
                    objSqlTransaction.Rollback();
                }
                throw new Exception(strMsg);
            }
            finally
            {
                objConnection.Close();
            }
        }

        public new static bool DelRecordByCMProjectAppRelaIdEx(long strCMProjectAppRelaId, string strPrjId)
        {
            //string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            clsSpecSQLforSql objSQL;
            //获取连接对象
            objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
            //删除TeacherInfo本表中与当前对象有关的记录
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            try
            {
                //获取连接对象
                objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                //获取该连接对象中的事务
                objSqlTransaction = objConnection.BeginTransaction();
                //
                //删除与表:[UserCodePrjMainPath]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition_Machine = $"{conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId} in (select {conUserCodePrjMainPath.UserCodePrjMainPathId} from {conUserCodePrjMainPath._CurrTabName} where {conUserCodePrjMainPath.CMProjectAppRelaId} ={strCMProjectAppRelaId})";
                
                string strCondition = string.Format("{0} = {1}",
                conUserCodePrjMainPath.CMProjectAppRelaId,
                strCMProjectAppRelaId);

                //clsUserCodePathBL.DelUserCodePathsByCondWithTransaction_S(strCondition, strPrjId, objConnection, objSqlTransaction);
                clsUserCodePrjMainPath_MachineNameBL.DelUserCodePrjMainPath_MachineNamesByCondWithTransaction_S(strCondition_Machine, strPrjId, objConnection, objSqlTransaction);
                clsUserCodePrjMainPathBL.DelUserCodePrjMainPathsByCondWithTransaction_S(strCondition, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsUserCodePrjMainPathBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
                objException.Message,
                strCMProjectAppRelaId, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                if (objSqlTransaction != null)
                {
                    objSqlTransaction.Rollback();
                }
                throw new Exception(strMsg);
            }
            finally
            {
                objConnection.Close();
            }
        }

        public static int SetMinCmPrjIdAppTypeId()
        {
            List<clsUserCodePrjMainPathEN> arrObjLstCache = clsUserCodePrjMainPathBL.GetObjLst("1=1");

            int intCount = 0;
            foreach (clsUserCodePrjMainPathEN objUserCodePrjMainPathEN in arrObjLstCache)
            {
                var obj = clsCMProjectAppRelaBL.GetObjByCMProjectAppRelaIdCache(objUserCodePrjMainPathEN.CMProjectAppRelaId, objUserCodePrjMainPathEN.PrjId);
                var strWhere = $"{conCMProjectAppRela.CmPrjId} = '{obj.CmPrjId}' and {conCMProjectAppRela.ApplicationTypeId}={obj.ApplicationTypeId} order by {conCMProjectAppRela.CMProjectAppRelaId}";
                var arr = clsCMProjectAppRelaBL.GetObjLst(strWhere);
                if (objUserCodePrjMainPathEN.CMProjectAppRelaId!= arr[0].CMProjectAppRelaId)
                {
                    objUserCodePrjMainPathEN.CMProjectAppRelaId = arr[0].CMProjectAppRelaId;
                    objUserCodePrjMainPathEN.Update();
                    intCount++;
                }
            }
            return intCount;
        }

    }
}