using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public interface ICheckPrjFileState
    {
        bool CheckPrjFileState(string strPrjFileName);
    }
    public static class clsUserCodePathBLEx_Static
    {
        public static string UserCodePrjMainPathId(this clsUserCodePathEN objUserCodePath, string strUserId)
        {
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsUserCodePrjMainPathBLEx.GetObjByCmPrjIdAppRelaIdPrjIdUserIdCache_Dic(objUserCodePath.CMProjectAppRelaId, strUserId);
            return objUserCodePrjMainPath.UserCodePrjMainPathId;
        }

        public static void CheckPrjFileState(this clsUserCodePathEN objUserCodePath, ICheckPrjFileState objCheckPrjFileState, string strUserId, string strMachineName)
        {
            if (string.IsNullOrEmpty(objUserCodePath.ProjectFileName) == true)
            {
                objUserCodePath.SetPrjFileStateId(enumPrjFileState.None_01)
                    .Update();
                return;
            }
            string strPrjFileName = objUserCodePath.PrjFileName(strUserId, strMachineName);
            if (File.Exists(strPrjFileName) == false)
            {
                objUserCodePath.SetPrjFileStateId(enumPrjFileState.FileNotExist_02)
                .Update();
                return;
            }
            bool bolIsCanOpen = objCheckPrjFileState.CheckPrjFileState(strPrjFileName);

            if (bolIsCanOpen)
            {
                objUserCodePath.SetPrjFileStateId(enumPrjFileState.ProjectCanOpen_04)
             .Update();
                return;
            }
            else
            {
                objUserCodePath
                    .SetPrjFileStateId(enumPrjFileState.ProjectCannotOpen_03)
                    .Update();
                return;
            }

        }

        /// <summary>
        /// 获取对象扩展信息
        /// </summary>
        /// <param name="objUserCodePathEx"></param>
        /// <returns></returns>
        public static void GetObjExInfo(this clsUserCodePathENEx objUserCodePathEx, string strUserId, string strMachineName)
        {
            objUserCodePathEx.NewCodePath = objUserCodePathEx.NewCodePath(strUserId, strMachineName);
            objUserCodePathEx.NewCodePathBackup = objUserCodePathEx.NewCodePathBackup(strUserId, strMachineName);
            objUserCodePathEx.IsExistCodePathP = objUserCodePathEx.IsExistCodePathP(strUserId, strMachineName);
            objUserCodePathEx.PrjFileName = objUserCodePathEx.PrjFileName(strUserId, strMachineName);
            objUserCodePathEx.PrjInnerCodePath = objUserCodePathEx.PrjInnerCodePath();
            objUserCodePathEx.FullCodeBackupPath = objUserCodePathEx.NewCodePathBackup;
            objUserCodePathEx.FullCodePath = objUserCodePathEx.NewCodePath;

            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsPubVar4BLEx.GetUserCodePrjMainPath(objUserCodePathEx.UserCodePrjMainPathId(strUserId));

            objUserCodePathEx.FullProjectPath = objUserCodePathEx.GetFullProjectPath(objUserCodePrjMainPath, strMachineName);
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objUserCodePathENS">源对象</param>
        /// <returns>目标对象=>clsUserCodePathEN:objUserCodePathENT</returns>
        public static clsUserCodePathENEx CopyToEx(this clsUserCodePathEN objUserCodePathENS)
        {
            try
            {
                clsUserCodePathENEx objUserCodePathENT = new clsUserCodePathENEx();
                clsUserCodePathBL.CopyTo(objUserCodePathENS, objUserCodePathENT);
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
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objUserCodePathENS">源对象</param>
        /// <returns>目标对象=>clsUserCodePathEN:objUserCodePathENT</returns>
        public static clsUserCodePathEN CopyTo(this clsUserCodePathENEx objUserCodePathENS)
        {
            try
            {
                clsUserCodePathEN objUserCodePathENT = new clsUserCodePathEN();
                clsUserCodePathBL.CopyTo(objUserCodePathENS, objUserCodePathENT);
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
        public static string PrjInnerCodePath(this clsUserCodePathEN objUserCodePathEN)
        {
            if (objUserCodePathEN.ProjectPath == "/") return objUserCodePathEN.CodePath;
            if (string.IsNullOrEmpty(objUserCodePathEN.ProjectPath)) return objUserCodePathEN.CodePath;
            string strRealyCodePath = objUserCodePathEN.CodePath.Replace(objUserCodePathEN.ProjectPath, "");
            return strRealyCodePath;
        }
        public static string NewCodePathBackup(this clsUserCodePathEN objUserCodePathEN, string strUserId, string strMachineName)
        {
            
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsPubVar4BLEx.GetUserCodePrjMainPath(objUserCodePathEN.UserCodePrjMainPathId(strUserId));
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathBLEx.CopyToExByMachineName(objUserCodePrjMainPath, strMachineName);
       string strNewCodePathBackup = string.Format("{0}{1}",
                                            objUserCodePrjMainPathEx.CodePathBackup, objUserCodePathEN.CodePathBackup);
            return strNewCodePathBackup;

        }


        public static string PrjFileName(this clsUserCodePathEN objUserCodePathEN, string strUserId, string strMachineName)
        {
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsPubVar4BLEx.GetUserCodePrjMainPath(objUserCodePathEN.UserCodePrjMainPathId(strUserId));
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathBLEx.CopyToExByMachineName(objUserCodePrjMainPath, strMachineName);

            string strPrjFileName = string.Format("{0}/{1}/{2}",
                    objUserCodePrjMainPathEx.CodePath, objUserCodePathEN.ProjectPath, objUserCodePathEN.ProjectFileName);
            strPrjFileName = strPrjFileName.Replace("\\/\\", "\\")
                                          .Replace("/", "\\").Replace("\\\\", "\\");
            return strPrjFileName;

        }


        public static string NewCodePath(this clsUserCodePathEN objUserCodePathEN, string strUserId, string strMachineName)
        {
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsPubVar4BLEx.GetUserCodePrjMainPath(objUserCodePathEN.UserCodePrjMainPathId(strUserId));
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathBLEx.CopyToExByMachineName(objUserCodePrjMainPath, strMachineName);

            string strNewCodePathBackup = string.Format("{0}{1}",
                                            objUserCodePrjMainPathEx.CodePath, objUserCodePathEN.CodePath);
            return strNewCodePathBackup;

        }

        public static bool IsExistCodePathP(this clsUserCodePathEN objUserCodePathEN, string strUserId, string strMachineName)
        {

            string strNewCodePath = objUserCodePathEN.NewCodePath(strUserId, strMachineName);
            if (Directory.Exists(strNewCodePath) == false)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        public static string GetFullProjectPath(this clsUserCodePathEN objUserCodePathEN, clsUserCodePrjMainPathEN objUserCodePrjMainPath, string strMachineName)
        {
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathBLEx.CopyToExByMachineName(objUserCodePrjMainPath, strMachineName);

            if (objUserCodePathEN.ProjectPath == "/")
            {
                return objUserCodePrjMainPathEx.CodePath;
            }
            if (string.IsNullOrEmpty(objUserCodePathEN.ProjectPath)) return objUserCodePrjMainPathEx.CodePath;
            string strFullProjectPath = string.Format("{0}\\{1}", objUserCodePrjMainPathEx.CodePath, objUserCodePathEN.ProjectPath);
            strFullProjectPath = strFullProjectPath.Replace("\\/\\", "\\")
                    .Replace("/", "\\").Replace("\\\\", "\\").Replace("\\\\", "\\");
            return strFullProjectPath;
        }
    }

    /// <summary>
    /// 用户代码路径逻辑扩展层
    /// </summary>
    public class clsUserCodePathBLEx : clsUserCodePathBL
    {
        //private static string mstrPrjId4Cache = "";
        //private static int mintApplicationTypeId = 0;
        /// <summary>
        /// 设置GC路径
        /// </summary>
        /// <param name="strOpUser">操作用户</param>
        /// <returns></returns>
        public static int SetGCPath(string strUserId, string strMachineName, string strOpUserId)
        {
            string strCurrDate = clsDateTime_Db.GetDataBaseDateTime14();
            string strCondition = string.Format("1=1");
            List<clsUserCodePathEN> arrUserCodePathObjLst = clsUserCodePathBL.GetObjLst(strCondition);
       
            int intCount = 0;
            foreach (clsUserCodePathEN objUserCodePath in arrUserCodePathObjLst)
            {
                string strUserCodePrjMainPathId = objUserCodePath.UserCodePrjMainPathId(strUserId);

                clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = clsUserCodePrjMainPathBL.GetObjByUserCodePrjMainPathIdCache(strUserCodePrjMainPathId, 
                    objUserCodePath.PrjId);
                    if (objUserCodePrjMainPathEN == null)
                    {
                    continue;
                    }
                clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathBLEx.CopyToExByMachineName(objUserCodePrjMainPathEN, strMachineName);

                var strPath = string.Format("{0}/{1}", objUserCodePrjMainPathEx.CodePath , objUserCodePath.CodePath);
                strPath = strPath.Replace("//", "/").Replace("/\\","\\").Replace("\\\\", "\\");
                var objGCPath = clsGCPathBLEx.GetObjByGcPathName(strPath, objUserCodePath.PrjId, objUserCodePrjMainPathEN.UserId);

                if (objGCPath == null)
                {
                    objGCPath = new clsGCPathEN();
                    objGCPath.SetGcPathName(strPath).
                        SetPrjId(objUserCodePath.PrjId)
                        .SetUserId(objUserCodePrjMainPathEN.UserId)
                        .SetUpdDate(strCurrDate)
                        .SetUpdUser(strOpUserId);
                    objGCPath.AddNewRecordWithMaxId();

                    objUserCodePath.GcPathId = objGCPath.GcPathId;
                    objUserCodePath.UpdDate = strCurrDate;
                    objUserCodePath.UpdUserId = strOpUserId;
                    //objUserCodePath.IsTemplate = false;
                    clsUserCodePathBL.UpdateBySql2(objUserCodePath);
                    intCount++;
                }
                else
                {
                    objUserCodePath.GcPathId = objGCPath.GcPathId;
                    objUserCodePath.UpdDate = strCurrDate;
                    objUserCodePath.UpdUserId = strOpUserId;
                    //objUserCodePath.IsTemplate = false;
                    clsUserCodePathBL.UpdateBySql2(objUserCodePath);
                    intCount++;
                }
            }
            return intCount;
        }



        //public static bool CopyUserCodePathFromTemplate(string strUserId, int intApplicationTypeId)
        //{
        //    //clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
        //    string strCurrDate = clsDateTime_Db.GetDataBaseDateTime14();
        //    string strCondition = string.Format("IsTemplate='1' And {0}={1}", conUserCodePath.ApplicationTypeId, intApplicationTypeId);
        //    List<clsUserCodePathEN> arrUserCodePathENObjLst = clsUserCodePathBL.GetObjLst(strCondition);
        //    foreach (clsUserCodePathEN objUserCodePathEN in arrUserCodePathENObjLst)
        //    {
        //        strCondition = string.Format("{0}='{1}' And CodeTypeId='{2}' ",
        //                             conUserCodePath.UserCodePrjMainPathId, objUserCodePathEN.UserCodePrjMainPathId,
        //                             objUserCodePathEN.CodeTypeId);
        //        if (clsUserCodePathBL.IsExistRecord(strCondition) == false)
        //        {
        //            objUserCodePathEN.UpdDate = strCurrDate;
        //            objUserCodePathEN.CodePath = objUserCodePathEN.CodePath.Replace("pyf", strUserId);
        //            objUserCodePathEN.CodePathBackup = objUserCodePathEN.CodePathBackup.Replace("pyf", strUserId);

        //            objUserCodePathEN.UpdUserId = strUserId;
        //            objUserCodePathEN.IsTemplate = false;
        //            clsUserCodePathBL.AddNewRecordBySql2(objUserCodePathEN);
        //        }
        //    }
        //    return true;
        //}


        //public static int CopyUserCodePathFromTemplate(string strPrjId, string strUserId, int intApplicationTypeId)
        //{
        //    //clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
        //    clsProjectsEN objProjects = clsProjectsBL.GetObjByPrjId(clsSysParaEN.CurrSelPrjId);
        //    string strCurrDate = clsDateTime_Db.GetDataBaseDateTime14();
        //    string strCondition = string.Format("PrjId='0000' And IsTemplate='1' And {0}={1}",
        //        convUserCodePath.ApplicationTypeId, intApplicationTypeId);
        //    List<clsvUserCodePathEN> arrUserCodePathENObjLst = clsvUserCodePathBL.GetObjLst(strCondition);
        //    Hashtable objHashtable = new Hashtable();
        //    //ht.Add("1", "1111");
        //    //ht.Add("2", "2222");
        //    //ht.Add("3", "3333");
        //    //ht.Add("4", "4444");
        //    int intCount = 0;
        //    foreach (clsvUserCodePathEN objvUserCodePathEN in arrUserCodePathENObjLst)
        //    {
        //        string strUserCodePrjMainPathId = objvUserCodePathEN.UserCodePrjMainPathId;
        //        string strUserCodePrjMainPathId_T = "";

        //        if (objHashtable.ContainsKey(strUserCodePrjMainPathId) == true)
        //        {
        //            strUserCodePrjMainPathId_T = objHashtable[strUserCodePrjMainPathId].ToString();
        //        }
        //        else
        //        {
        //            clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = clsUserCodePrjMainPathBL.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
        //            if (objUserCodePrjMainPathEN == null)
        //            {
        //                string strMsg = string.Format("关键字记录不存在！({2})({0})(关键字：[{1}])",
        //                   clsStackTrace.GetCurrClassFunction(), strUserCodePrjMainPathId, clsUserCodePrjMainPathEN._CurrTabName);
        //                throw new Exception(strMsg);
        //            }
        //            strCondition = string.Format("{0}='{1}' And {2}='{3}' And {4}='{5}'",
        //            conUserCodePrjMainPath.PrjId, strPrjId,
        //            conUserCodePrjMainPath.UserId, strUserId,
        //            conUserCodePrjMainPath.CMProjectAppRelaId, objUserCodePrjMainPathEN.CMProjectAppRelaId);

        //            clsUserCodePrjMainPathEN objUserCodePrjMainPathEN_T = clsUserCodePrjMainPathBL.GetFirstObj_S(strCondition);
        //            if (objUserCodePrjMainPathEN_T == null)
        //            {
        //                string strMsg = string.Format("条件记录不存在！({0})(条件：[{1}])",
        //                    clsStackTrace.GetCurrClassFunction(), strCondition);
        //                throw new Exception(strMsg);
        //            }
        //            strUserCodePrjMainPathId_T = objUserCodePrjMainPathEN_T.UserCodePrjMainPathId;
        //            objHashtable.Add(strUserCodePrjMainPathId, strUserCodePrjMainPathId_T);

        //        }
        //        strCondition = string.Format(" {0}='{1}' and {2}='{3}'",
        //            conUserCodePath.CodeTypeId, objvUserCodePathEN.CodeTypeId,
        //           conUserCodePath.UserCodePrjMainPathId, strUserCodePrjMainPathId_T);
        //        if (clsUserCodePathBL.IsExistRecord(strCondition) == false)
        //        {

        //            clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
        //            objUserCodePathEN.UserCodePrjMainPathId = strUserCodePrjMainPathId_T;
        //            objUserCodePathEN.CodeTypeId = objvUserCodePathEN.CodeTypeId;
        //            objUserCodePathEN.UpdDate = strCurrDate;
        //            objUserCodePathEN.CodePath = string.Format(objvUserCodePathEN.CodePath.Replace("pyf", strUserId), objProjects.PrjDomain);
        //            objUserCodePathEN.CodePathBackup = string.Format(objvUserCodePathEN.CodePathBackup.Replace("pyf", strUserId), objProjects.PrjDomain);
        //            objUserCodePathEN.ProjectFileName = string.Format(objvUserCodePathEN.ProjectFileName.Replace("pyf", strUserId), objProjects.PrjDomain);
        //            objUserCodePathEN.ProjectPath = string.Format(objvUserCodePathEN.ProjectPath.Replace("pyf", strUserId), objProjects.PrjDomain);
        //            objUserCodePathEN.SuffixPath = objvUserCodePathEN.SuffixPath;
        //            objUserCodePathEN.IsGeneCode = objvUserCodePathEN.IsGeneCode;
        //            objUserCodePathEN.UpdUserId = strUserId;
        //            objUserCodePathEN.IsTemplate = false;
        //            clsUserCodePathBL.AddNewRecordBySql2(objUserCodePathEN);
        //            intCount++;
        //        }
        //    }
        //    return intCount;
        //}
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

        public static clsUserCodePathEN GetObjByCodeTypeIdCacheBak(string strCodeTypeId, int intCMProjectAppRelaId, string strCurrPrjId, string strUserId)
        {
            // string strUserCodePrjMainPathId =             clsUserCodePrjMainPathBLEx.GetObjByApplicationTypeId();
            clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = clsUserCodePrjMainPathBLEx.GetObjByCMProjectAppRelaIdCache(intCMProjectAppRelaId, strCurrPrjId, strUserId);
            if (objUserCodePrjMainPathEN == null)
            {
                string strMsg = string.Format("Cm工程应用Id:{0}, 工程Id:{1}, 用户Id:{2}找不到相应的用户工程主路径,请添加相应的用户工程主路径。(In {3})",
                    intCMProjectAppRelaId, strCurrPrjId, strUserId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return GetObjByCodeTypeIdCache(intCMProjectAppRelaId, strCodeTypeId, strCurrPrjId, strUserId);

        }

        /// <summary>
        /// 根据代码类型Id和语言类型Id获取用户代码项目主目录
        /// </summary>
        /// <param name="intApplicationTypeId">应用类型Id</param>
        /// <param name="strCodeTypeId">代码类型Id</param>
        /// <param name="strCurrPrjId">当前工程Id</param>
        /// <param name="strUserId">当前用户Id</param>
        /// <returns></returns>
        public static clsUserCodePathEN GetObjByCodeTypeIdCache(long intCMProjectAppRelaId, string strCodeTypeId, 
            string strCurrPrjId, string strUserId)
        {
            if (string.IsNullOrEmpty(strUserId) == true)
            {
                string strMsg = string.Format("当前用户(strUserId)没有设置，请联系管理员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            if (string.IsNullOrEmpty(strCurrPrjId) == true)
            {
                throw new Exception("当前项目没有设置，请联系管理员！");
            }
           
            //if (clsUserCodePathBL.arrUserCodePathObjLstCache == null)
            //{
            //    string strCondition = string.Format( "{0} in (Select {0} From {1} Where {2}={3} and PrjId='{4}' And UserId='{5}')",
            //        conUserCodePath.UserCodePrjMainPathId,
            //        conUserCodePrjMainPath._CurrTabName,
            //        conUserCodePrjMainPath.ApplicationTypeId, intApplicationTypeId,
            //        strCurrPrjId,
            //       strUserId);
            //    clsUserCodePathBL.arrUserCodePathObjLstCache = clsUserCodePathBL.GetObjLst(strCondition);
            //    mstrPrjId4Cache = strCurrPrjId;
            //    mintApplicationTypeId = intApplicationTypeId;
            //}
            List<clsUserCodePathEN> arrObjLstCache = clsUserCodePathBL.GetObjLstCache(strCurrPrjId);

            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsUserCodePrjMainPathBLEx.GetObjByCmPrjIdAppRelaIdPrjIdUserIdCache_Dic(intCMProjectAppRelaId, strUserId);
            
            foreach (clsUserCodePathEN objUserCodePathEN in arrObjLstCache)
            {
                if (objUserCodePathEN.CodeTypeId == strCodeTypeId
                    && objUserCodePrjMainPath.CMProjectAppRelaId == objUserCodePathEN.CMProjectAppRelaId)
                {
                    return objUserCodePathEN;
                }
            }
            CacheHelper.Remove(clsUserCodePathEN._CurrTabName);
            StringBuilder sbMsg = new StringBuilder();
            clsCodeTypeEN objCodeTypeEN = null;
            try
            {
                objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            }
            catch (Exception objException)
            {
                StringBuilder sbMsg1 = new StringBuilder();
                sbMsg1.AppendFormat("在获取CodeTypeId＝'{0}'的代码类型对象时出错，错误信息：{1}。", strCodeTypeId, objException.Message);
                throw new Exception(sbMsg1.ToString());
            }
            clsUsersEN objUsersEN = clsUsersBL.GetObjByUserId(strUserId);

            sbMsg.AppendFormat("{0},您好！您还没有设置代码生成路径：{1}，请设置！", objUsersEN.UserName, objCodeTypeEN.CodeTypeName);
            throw new Exception(sbMsg.ToString());
            //return null;
        }

        /// <summary>
        /// 根据代码类型和语言类型获取用户代码项目主目录
        /// </summary>
        /// <param name="cnClassName">代码类型</param>
        /// <param name="ltLangType">语言类型</param>
        /// <param name="strCurrPrjId">当前工程Id</param>
        /// <returns></returns>
        //public static clsUserCodePathEN GetUserCodePathObjByClassName1(clsPubConst.ClsName cnClassName, 
        //    clsPubConst.LangType ltLangType, string strCurrPrjId, string strUserId)
        //{
        //    string strClassName = clsPubConst.GetClassNameStringByClassName(cnClassName);
        //    clsCodeTypeEN objCodeTypeEN = clsCodeTypeBLEx.GetObjByClassNameCacheExBak(cnClassName);
        //    clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBLEx.GetObjByLangTypeCache(ltLangType);
        //    clsUserCodePathEN objUserCodePathEN = GetObjByCodeTypeIdCache(this.ApplicationTypeId, 
        //        objCodeTypeEN.CodeTypeId, strCurrPrjId, strUserId);
        //    return objUserCodePathEN;
        //}
        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        /// <param name = "strUserCodePrjMainPathId">strUserCodePrjMainPathId</param>
        public static void BindCbo_DistinctCodePath(System.Windows.Forms.ComboBox objComboBox,
            long strCMProjectAppRelaId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("{0}='{1}' ",
                conUserCodePath.CMProjectAppRelaId, strCMProjectAppRelaId);
            List<string> arrCodePath = GetFldValue(conUserCodePath.CodePath, strCondition);
            arrCodePath.Sort();
            if (arrCodePath.Count == 0) return;
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conUserCodePath.CodePath;
            objComboBox.DisplayMember = conUserCodePath.CodePath;
            objComboBox.DataSource = arrCodePath;
            objComboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        /// <param name = "strUserCodePrjMainPathId">strUserCodePrjMainPathId</param>        
        public static void BindCbo_DistinctCodePathBackup(System.Windows.Forms.ComboBox objComboBox, long strCMProjectAppRelaId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("{0}='{1}'",
                conUserCodePath.CMProjectAppRelaId, strCMProjectAppRelaId);
            List<string> arrCodePath = GetFldValue(conUserCodePath.CodePathBackup, strCondition);
            arrCodePath.Sort();

            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conUserCodePath.CodePath;
            objComboBox.DisplayMember = conUserCodePath.CodePath;
            objComboBox.DataSource = arrCodePath;
            objComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 设置需要生成代码
        /// </summary>
        /// <param name="lngMid"></param>
        /// <returns></returns>
        public static bool SetIsGeneCode(long lngMid)
        {
            //conUserCodePath.UserCodePathId;
            //conUserCodePath.mId
            clsUserCodePathEN obj = clsUserCodePathBL.GetObjBymId(lngMid);
            obj.IsGeneCode = true;
            return clsUserCodePathBL.UpdateBySql2(obj);
        }
        /// <summary>
        /// 设置不需要生成代码
        /// </summary>
        /// <param name="lngMid"></param>
        /// <returns></returns>
        public static bool SetIsNotGeneCode(long lngMid)
        {
            //conUserCodePath.UserCodePathId;
            //conUserCodePath.mId
            clsUserCodePathEN obj = clsUserCodePathBL.GetObjBymId(lngMid);
            obj.IsGeneCode = false;
            return clsUserCodePathBL.UpdateBySql2(obj);
        }
        public static clsUserCodePathENEx GetObjExByClassName(int intApplicationTypeId,  string strCodeTypeId, 
                   string strCurrPrjId, string strMachineName, string strUserId)
        {
            //string strClassName = clsPubConst.GetClassNameStringByClassName(cnClassName);
            //clsCodeTypeEN objCodeTypeEN = clsCodeTypeBLEx.GetObjByClassNameCacheEx(cnClassName);

            //clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBLEx.GetObjByLangTypeCache(ltLangType);
            clsUserCodePathEN objUserCodePathEN = GetObjByCodeTypeIdCache(intApplicationTypeId, strCodeTypeId, strCurrPrjId, strUserId);
            clsUserCodePathENEx objUserCodePathENEx = objUserCodePathEN.CopyToEx();

            //clsUserCodePrjMainPathEN objUserCodePrjMainPathEN
            //    = clsUserCodePrjMainPathBLEx.GetObjByUserCodePrjMainPathIdCache(objUserCodePathEN.UserCodePrjMainPathId);

            objUserCodePathENEx.NewCodePath = objUserCodePathEN.NewCodePath(strUserId, strMachineName);
            objUserCodePathENEx.IsExistCodePathP = objUserCodePathEN.IsExistCodePathP(strUserId, strMachineName);
            objUserCodePathENEx.NewCodePathBackup = objUserCodePathEN.NewCodePathBackup(strUserId, strMachineName);

            //if (Directory.Exists(objUserCodePathEN.NewCodePath) == false)
            //{
            //    objUserCodePathEN.IsExistCodePathP = false;
            //}
            //else
            //{
            //    objUserCodePathEN.IsExistCodePathP = true;
            //}
            //objUserCodePathEN.NewCodePathBackup = string.Format("{0}{1}",
            //                    objUserCodePrjMainPathEN.CodePathBackup, objUserCodePathEN.CodePathBackup);

            //}
            //else
            //{
            //    objUserCodePathEN.NewCodePath = string.Format("{0}",
            //                        objUserCodePathEN.CodePath);
            //    objUserCodePathEN.NewCodePathBackup = string.Format("{0}",
            //                        objUserCodePathEN.CodePathBackup);

            //}
            return objUserCodePathENEx;
        }
   

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsUserCodePathDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsUserCodePathDAEx UserCodePathDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsUserCodePathDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="lngmId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(long lngmId, string strPrjId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserCodePathDA.GetSpecSQLObj();
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
                //删除与表:[UserCodePath]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition = string.Format("{0} = '{1}'",
                conUserCodePath.mId,
                lngmId);
                clsUserCodePathBL.DelUserCodePathsByCondWithTransaction_S(strCondition, strPrjId, objConnection, objSqlTransaction);
                //
                clsUserCodePathBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsUserCodePathBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                lngmId, clsStackTrace.GetCurrClassFunction());
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
            objSQL = clsUserCodePathDA.GetSpecSQLObj();
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
                //删除与表:[UserCodePath]相关的表的代码，需要时去除注释，编写相关的代码
                
                string strCondition = string.Format("{0} = {1}",
                conUserCodePath.CMProjectAppRelaId,
                strCMProjectAppRelaId);

                //clsUserCodePathBL.DelUserCodePathsByCondWithTransaction_S(strCondition, strPrjId, objConnection, objSqlTransaction);
                
                clsUserCodePathBL.DelUserCodePathsByCondWithTransaction_S(strCondition, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsUserCodePathBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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


        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsUserCodePathENEx> GetObjExLst(string strCondition)
        {
            List<clsUserCodePathEN> arrObjLst = clsUserCodePathBL.GetObjLst(strCondition);
            List<clsUserCodePathENEx> arrObjExLst = new List<clsUserCodePathENEx>();
            foreach (clsUserCodePathEN objInFor in arrObjLst)
            {
                clsUserCodePathENEx objUserCodePathENEx = new clsUserCodePathENEx();
                clsUserCodePathBL.CopyTo(objInFor, objUserCodePathENEx);
                arrObjExLst.Add(objUserCodePathENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsUserCodePathENEx GetObjExBymId(long lngmId)
        {
            clsUserCodePathEN objUserCodePathEN = clsUserCodePathBL.GetObjBymId(lngmId);
            clsUserCodePathENEx objUserCodePathENEx = new clsUserCodePathENEx();
            clsUserCodePathBL.CopyTo(objUserCodePathEN, objUserCodePathENEx);
            return objUserCodePathENEx;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
        /// </summary>
        /// <param name = "objUserCodePathENS">源对象</param>
        /// <param name = "objUserCodePathENT">目标对象</param>
        public static clsUserCodePathEN CopyTo(clsvUserCodePathEN objUserCodePathENS)
        {
            clsUserCodePathEN objUserCodePathENT = new clsUserCodePathEN();
            objUserCodePathENT.mId = objUserCodePathENS.mId; //mId
            objUserCodePathENT.CodeTypeId = objUserCodePathENS.CodeTypeId; //代码类型Id
            objUserCodePathENT.CMProjectAppRelaId = objUserCodePathENS.CMProjectAppRelaId; //生成主目录Id
            
            objUserCodePathENT.IsGeneCode = objUserCodePathENS.IsGeneCode; //是否生成代码
            objUserCodePathENT.ProjectFileName = objUserCodePathENS.ProjectFileName; //工程文件名
            objUserCodePathENT.ProjectPath = objUserCodePathENS.ProjectPath; //工程路径
            objUserCodePathENT.PrjFileStateId = objUserCodePathENS.PrjFileStateId; //工程文件状态Id
            objUserCodePathENT.CodePath = objUserCodePathENS.CodePath; //代码路径
            objUserCodePathENT.CodePathBackup = objUserCodePathENS.CodePathBackup; //备份代码路径
            objUserCodePathENT.SuffixPath = objUserCodePathENS.SuffixPath; //后缀路径
            objUserCodePathENT.IsTemplate = objUserCodePathENS.IsTemplate; //是否模板
            objUserCodePathENT.IsExistCodePath = objUserCodePathENS.IsExistCodePath; //是否存在代码路径
            objUserCodePathENT.IsExistCodePathBackup = objUserCodePathENS.IsExistCodePathBackup; //是否存在备份路径
            objUserCodePathENT.UpdDate = objUserCodePathENS.UpdDate; //修改日期
            objUserCodePathENT.UpdUserId = objUserCodePathENS.UpdUserId; //修改用户Id
            objUserCodePathENT.Memo = objUserCodePathENS.Memo; //说明
            return objUserCodePathENT;
        }
        public static int RemoveReduplicateRec()
        {
            int ret = 0;
            var strCondition = $"1=1 order by {conUserCodePath.CMProjectAppRelaId}, {conUserCodePath.CodeTypeId}, {conUserCodePath.CodePath} desc, {conUserCodePath.ProjectPath} desc";
            var arrUserCodePath = clsUserCodePathBL.GetObjLst(strCondition);
            int intLen = arrUserCodePath.Count;
            for( int i = 0;i< intLen; i++)
            {
                var objCurr = arrUserCodePath[i];
                if (objCurr.Memo != "") continue;
                for (int j = i+1; j < intLen; j++)
                {
                    var objNext = arrUserCodePath[j];
                    if (objNext.CMProjectAppRelaId != objCurr.CMProjectAppRelaId) break;
                    if (objNext.CodeTypeId != objCurr.CodeTypeId) break;
                    if (objNext.CodePath.Length == 0)
                    {
                        objNext.Memo = "del";
                        objNext.Update();
                        ret++;
                    }
                    else if (objNext.CodePath == objCurr.CodePath)
                    {
                        objNext.Memo = "del";
                        objNext.Update();
                        ret++;
                    }
                    else
                    {
                        objNext.Memo = "dup-pre";
                        objNext.Update();
                        ret++;
                    }
                }
            }
                return ret;
        }
    }
}
