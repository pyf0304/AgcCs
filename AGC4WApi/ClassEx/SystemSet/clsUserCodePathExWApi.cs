
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsUserCodePathExWApi
表名:UserCodePath(00050204)
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
using System.IO;
using System.Linq;
using AGC.BusinessLogic;

namespace AGC4WApi
{
    public interface ICheckPrjFileState
    {
        bool CheckPrjFileState(string strPrjFileName);
    }

   

    public static class clsUserCodePathExWApi_Static
    {

        public static void CheckPrjFileState(this clsUserCodePathEN objUserCodePath, long lngCmPrjAppId, string strUserId, ICheckPrjFileState objCheckPrjFileState)
        {
            if (string.IsNullOrEmpty(objUserCodePath.ProjectFileName) == true)
            {
                objUserCodePath.SetPrjFileStateId(enumPrjFileStateWA.None_01)
                    .Update();
                return;
            }
            string strMachineName = Environment.MachineName;
            string strPrjFileName = objUserCodePath.PrjFileName(strUserId, strMachineName, objUserCodePath.PrjId);
            if (File.Exists(strPrjFileName) == false)
            {
                objUserCodePath.SetPrjFileStateId(enumPrjFileStateWA.FileNotExist_02)
                .Update();
                string strMsg = string.Format("项目文件不存在！文件:{0}.", strPrjFileName);
                throw new Exception(strMsg);
                //                return;
            }
            bool bolIsCanOpen = objCheckPrjFileState.CheckPrjFileState(strPrjFileName);

            if (bolIsCanOpen)
            {
                objUserCodePath.SetPrjFileStateId(enumPrjFileStateWA.ProjectCanOpen_04)
                    .SetPrjId(clsSysParaEN.CurrSelPrjId)
             .Update();
                return;
            }
            else
            {
                objUserCodePath
                    .SetPrjFileStateId(enumPrjFileStateWA.ProjectCannotOpen_03)
                    .SetPrjId(clsSysParaEN.CurrSelPrjId)
                    .Update();
                return;
            }

        }
        public static string UserCodePrjMainPathId(this clsUserCodePathEN objUserCodePath, string strUserId)
        {            
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjByCmPrjAppIdUserId_Cache_Dic(objUserCodePath.CMProjectAppRelaId, strUserId);
            if (objUserCodePrjMainPath == null) return "";
            return objUserCodePrjMainPath.UserCodePrjMainPathId;
        }
        /// <summary>
        /// 获取对象扩展信息
        /// </summary>
        /// <param name="objUserCodePathEx"></param>
        /// <returns></returns>
        public static void GetObjExInfo11(this clsUserCodePathENEx objUserCodePathEx, string strUserId, string strMachineName, string strPrjId)
        {
            objUserCodePathEx.NewCodePath = objUserCodePathEx.NewCodePath(strUserId, strMachineName, strPrjId);
            objUserCodePathEx.NewCodePathBackup = objUserCodePathEx.NewCodePathBackup(strUserId, strMachineName, strPrjId);
            objUserCodePathEx.IsExistCodePathP = objUserCodePathEx.IsExistCodePathP(strUserId, strMachineName, strPrjId);
            objUserCodePathEx.PrjFileName = objUserCodePathEx.PrjFileName(strUserId, strMachineName, strPrjId);
            objUserCodePathEx.PrjInnerCodePath = objUserCodePathEx.PrjInnerCodePath();
            objUserCodePathEx.FullCodeBackupPath = objUserCodePathEx.NewCodePathBackup;
            objUserCodePathEx.FullCodePath = objUserCodePathEx.NewCodePath;

            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsPubFun4WApi.GetUserCodePrjMainPath(objUserCodePathEx.UserCodePrjMainPathId(strUserId), strPrjId);

            objUserCodePathEx.FullProjectPath = objUserCodePathEx.GetFullProjectPath1(objUserCodePrjMainPath, strMachineName, strPrjId);
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// </summary>
        /// <param name = "objUserCodePathENS">源对象</param>
        /// <returns>目标对象=>clsUserCodePathEN:objUserCodePathENT</returns>
        public static clsUserCodePathENEx CopyToEx(this clsUserCodePathEN objUserCodePathENS)
        {
            try
            {
                clsUserCodePathENEx objUserCodePathENT = new clsUserCodePathENEx();
                clsUserCodePathWApi.CopyTo(objUserCodePathENS, objUserCodePathENT);
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
        /// <returns>目标对象=>clsUserCodePathEN:objUserCodePathENT</returns>
        public static clsUserCodePathEN CopyTo(this clsUserCodePathENEx objUserCodePathENS)
        {
            try
            {
                clsUserCodePathEN objUserCodePathENT = new clsUserCodePathEN();
                clsUserCodePathWApi.CopyTo(objUserCodePathENS, objUserCodePathENT);
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
        public static string NewCodePathBackup(this clsUserCodePathEN objUserCodePathEN, string strUserId, string strMachineName, string strPrjId)
        {

            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsPubFun4WApi.GetUserCodePrjMainPath(objUserCodePathEN.UserCodePrjMainPathId(strUserId), strPrjId);
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPath, strMachineName, strPrjId);

            string strNewCodePathBackup = string.Format("{0}{1}",
                                            objUserCodePrjMainPathEx.CodePathBackup, objUserCodePathEN.CodePathBackup);
            return strNewCodePathBackup;

        }


        public static string PrjFileName(this clsUserCodePathEN objUserCodePathEN, string strUserId, string strMachineName, string strPrjId)
        {
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsPubFun4WApi.GetUserCodePrjMainPath(objUserCodePathEN.UserCodePrjMainPathId(strUserId), strPrjId);
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPath, strMachineName, strPrjId);

            string strPrjFileName = string.Format("{0}/{1}/{2}",
                    objUserCodePrjMainPathEx.CodePath, objUserCodePathEN.ProjectPath, objUserCodePathEN.ProjectFileName);
            strPrjFileName = strPrjFileName.Replace("\\/\\", "\\")
                                          .Replace("/", "\\").Replace("\\\\", "\\");
            return strPrjFileName;

        }


        public static string NewCodePath(this clsUserCodePathEN objUserCodePathEN, string strUserId, string strMachineName, string strPrjId)
        {
            //var strPrjId = clsCMProjectExWApi.GetPrjIdByCmPrjIdCache(strCmPrjId);
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsPubFun4WApi.GetUserCodePrjMainPath(objUserCodePathEN.UserCodePrjMainPathId(strUserId), strPrjId);

            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPath, strMachineName, strPrjId);

            string strNewCodePathBackup = string.Format("{0}{1}",
                                            objUserCodePrjMainPathEx.CodePath, objUserCodePathEN.CodePath);
            return strNewCodePathBackup;

        }

        public static bool IsExistCodePathP(this clsUserCodePathEN objUserCodePathEN, string strUserId, string strMachineName, string strPrjId)
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


        public static string GetFullProjectPath1(this clsUserCodePathEN objUserCodePathEN, clsUserCodePrjMainPathEN objUserCodePrjMainPath, string strMachineName, string strPrjId)
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
    /// 用户生成路径(UserCodePath)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsUserCodePathExWApi
    {
        //private static readonly string mstrApiControllerName = "UserCodePathExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsUserCodePathEN> arrUserCodePathObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;
        private static string mstrPrjId4Cache = "";
        private static long mlngCMProjectAppRelaId = 0;
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsUserCodePathExWApi()
        {
        }
        public static clsUserCodePathENEx GetObjExByClassName(long strCMProjectAppRelaId, string strCodeTypeId,
                string strCurrPrjId,  string strMachineName, string strUserId)
        {

            clsUserCodePathEN objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCacheEx(strCMProjectAppRelaId, strCodeTypeId, strCurrPrjId, strUserId);
            clsUserCodePathENEx objUserCodePathENEx = objUserCodePathEN.CopyToEx();
            objUserCodePathENEx.NewCodePath = objUserCodePathEN.NewCodePath(strUserId, strMachineName, strCurrPrjId);
            objUserCodePathENEx.IsExistCodePathP = objUserCodePathEN.IsExistCodePathP(strUserId, strMachineName, strCurrPrjId);
            objUserCodePathENEx.NewCodePathBackup = objUserCodePathEN.NewCodePathBackup(strUserId, strMachineName, strCurrPrjId);

            return objUserCodePathENEx;
        }

        public static clsUserCodePathENEx GetObjExByCmPrjId(long intCMProjectAppRelaId, string strCmPrjId, string strCodeTypeId,
          string strCurrPrjId, string strMachineName, string strUserId)
        {
            var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(intCMProjectAppRelaId, strCurrPrjId, strMachineName, strUserId); 
            clsUserCodePathEN objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCacheEx(objUserCodePrjMainPath.CMProjectAppRelaId, strCodeTypeId, strCmPrjId, strUserId);
            clsUserCodePathENEx objUserCodePathENEx = objUserCodePathEN.CopyToEx();
            objUserCodePathENEx.NewCodePath = objUserCodePathEN.NewCodePath(strUserId, strMachineName, strCmPrjId);
            objUserCodePathENEx.IsExistCodePathP = objUserCodePathEN.IsExistCodePathP(strUserId, strMachineName, strCmPrjId);
            objUserCodePathENEx.NewCodePathBackup = objUserCodePathEN.NewCodePathBackup(strUserId, strMachineName, strCmPrjId);
            return objUserCodePathENEx;
        }
        /// <summary>
        /// 根据代码类型Id和语言类型Id获取用户代码项目主目录
        /// </summary>
        /// <param name="intApplicationTypeId">应用类型Id</param>
        /// <param name="strCodeTypeId">代码类型Id</param>
        /// <param name="strCurrPrjId">当前工程Id</param>
        /// <param name="strUserId">当前用户Id</param>
        /// <returns></returns>
        public static clsUserCodePathEN GetObjByCodeTypeIdCacheEx(long lngCMProjectAppRelaId, string strCodeTypeId,
            string strPrjId, string strUserId)
        {
    
            if (string.IsNullOrEmpty(strUserId) == true)
            {
                string strMsg = string.Format("当前用户(strUserId)没有设置，请联系管理员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            if (strPrjId.Length != 4)
            {
                throw new Exception("字段[strCmPrjId]的长度应该等于6!");
            }
            //string strPrjId = clsCMProjectExWApi.GetPrjIdByCmPrjIdCache(strCmPrjId);
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                throw new Exception("当前项目没有设置，请联系管理员！");
            }
            if (strPrjId != mstrPrjId4Cache)
            {
                arrUserCodePathObjLst_Cache = null;
            }
            if (mlngCMProjectAppRelaId != lngCMProjectAppRelaId)
            {
                arrUserCodePathObjLst_Cache = null;
            }

            if (arrUserCodePathObjLst_Cache == null)
            {
                string strCondition = $"{conUserCodePath.CMProjectAppRelaId}={lngCMProjectAppRelaId} ";// and {conUserCodePath.CodeTypeId}='{strCodeTypeId}'";
                arrUserCodePathObjLst_Cache = clsUserCodePathWApi.GetObjLst(strCondition);
                mstrPrjId4Cache = strPrjId;
                mlngCMProjectAppRelaId = lngCMProjectAppRelaId;
            }
            //clsUserCodePrjMainPathEN objUserCodePrjMainPath 
            //    = clsUserCodePrjMainPathExWApi.GetObjByCmPrjAppIdUserId_Cache_Dic(lngCMProjectAppRelaId, strUserId);

            foreach (clsUserCodePathEN objUserCodePathEN in arrUserCodePathObjLst_Cache)
            {
                if (objUserCodePathEN.CodeTypeId == strCodeTypeId
                    && objUserCodePathEN.CMProjectAppRelaId == lngCMProjectAppRelaId)
                {
                    return objUserCodePathEN;
                }
            }
            arrUserCodePathObjLst_Cache = null;
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
            clsUsersEN objUsersEN = clsUsersWApi.GetObjByUserId(strUserId);
            sbMsg.AppendFormat("{0},您好！您还没有设置代码生成路径：{1}，请设置！", objUsersEN.UserName, objCodeTypeEN.CodeTypeName);
            throw new Exception(sbMsg.ToString());
            //return null;
        }


        public static List< clsUserCodePathEN> GetObjLstByUserCodePrjMainPathIdCache(string strUserCodePrjMainPathId, string strUserId, string strPrjId)
        {

            var arrUserCodePathObjLst_Cache = clsUserCodePathWApi.GetObjLstCache(strPrjId);
            var arrUserCodePathObjLst_Sel = arrUserCodePathObjLst_Cache.Where(x => x.UserCodePrjMainPathId(strUserId) == strUserCodePrjMainPathId).ToList();
            return arrUserCodePathObjLst_Sel;
            //return null;
        }



        //public static bool CopyUserCodePathFromTemplate(string strUserId, int intApplicationTypeId)
        //{
        //    //clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
        //    string strCurrDate = SqlWApi.DateTime_GetDataBaseDateTime14();
        //    string strCondition = string.Format("{0}={1} and {2} in (select {2} from {3} where {4}='0000')", 
        //        conUserCodePath.ApplicationTypeId, intApplicationTypeId, 
        //        conUserCodePath.UserCodePrjMainPathId, 
        //        conUserCodePrjMainPath._CurrTabName, conUserCodePrjMainPath.PrjId);
        //    List<clsUserCodePathEN> arrUserCodePathENObjLst = clsUserCodePathWApi.GetObjLst(strCondition);
        //    foreach (clsUserCodePathEN objUserCodePathEN in arrUserCodePathENObjLst)
        //    {
        //        strCondition = string.Format("{0}='{1}' And CodeTypeId='{2}' ",
        //                             conUserCodePath.UserCodePrjMainPathId, objUserCodePathEN.UserCodePrjMainPathId,
        //                             objUserCodePathEN.CodeTypeId);
        //        if (clsUserCodePathWApi.IsExistRecord(strCondition) == false)
        //        {
        //            objUserCodePathEN.UpdDate = strCurrDate;
        //            objUserCodePathEN.CodePath = objUserCodePathEN.CodePath.Replace("pyf", strUserId);
        //            objUserCodePathEN.CodePathBackup = objUserCodePathEN.CodePathBackup.Replace("pyf", strUserId);

        //            objUserCodePathEN.UpdUserId = strUserId;
        //            objUserCodePathEN.IsTemplate = false;
        //            clsUserCodePathWApi.AddNewRecord(objUserCodePathEN);
        //        }
        //    }
        //    return true;
        //}
      

        //public static int CopyUserCodePathFromTemplate(string strPrjId, string strUserId, string strUserCodePrjMainPathId_T)
        //{
        //    clsUserCodePrjMainPathEN objUserCodePrjMainPathEN_T = clsUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId_T);
        //    if (objUserCodePrjMainPathEN_T == null)
        //    {
        //        string strMsg = string.Format("关键字记录不存在！({2})({0})(关键字：[{1}])",
        //           clsStackTrace.GetCurrClassFunction(), strUserCodePrjMainPathId_T, clsUserCodePrjMainPathEN._CurrTabName);
        //        throw new Exception(strMsg);
        //    }

        //    //clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
        //    clsProjectsEN objProjects = clsProjectsWApi.GetObjByPrjId(clsSysParaEN.CurrSelPrjId);
        //    string strCurrDate = SqlWApi.DateTime_GetDataBaseDateTime14();
        //    string strCondition = string.Format("{2}='0000' And {0}={1}",
        //        convUserCodePath.CMProjectAppRelaId, objUserCodePrjMainPathEN_T.CMProjectAppRelaId, convUserCodePath.PrjId);
        //    List<clsvUserCodePathEN> arrUserCodePathENObjLst = clsvUserCodePathWApi.GetObjLst(strCondition);
        //    //Hashtable objHashtable = new Hashtable();
        //    //ht.Add("1", "1111");
        //    //ht.Add("2", "2222");
        //    //ht.Add("3", "3333");
        //    //ht.Add("4", "4444");
        //    int intCount = 0;
        //    foreach (clsvUserCodePathEN objvUserCodePathEN in arrUserCodePathENObjLst)
        //    {
        //        string strUserCodePrjMainPathId = objvUserCodePathEN.UserCodePrjMainPathId;


        //        //if (objHashtable.ContainsKey(strUserCodePrjMainPathId) == true)
        //        //{
        //        //    strUserCodePrjMainPathId_T = objHashtable[strUserCodePrjMainPathId].ToString();
        //        //}
        //        //else
        //        //{
        //        clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = clsUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
        //        if (objUserCodePrjMainPathEN == null)
        //        {
        //            string strMsg = string.Format("关键字记录不存在！({2})({0})(关键字：[{1}])",
        //               clsStackTrace.GetCurrClassFunction(), strUserCodePrjMainPathId, clsUserCodePrjMainPathEN._CurrTabName);
        //            throw new Exception(strMsg);
        //        }


        //        //objHashtable.Add(strUserCodePrjMainPathId, strUserCodePrjMainPathId_T);

        //        //}
        //        strCondition = string.Format(" {0}='{1}' and {2}='{3}'",
        //            conUserCodePath.CodeTypeId, objvUserCodePathEN.CodeTypeId,
        //           conUserCodePath.UserCodePrjMainPathId(strUserId), strUserCodePrjMainPathId_T);
        //        if (clsUserCodePathWApi.IsExistRecord(strCondition) == false)
        //        {
        //            clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
        //            objUserCodePathEN.UserCodePrjMainPathId = strUserCodePrjMainPathId_T;
        //            objUserCodePathEN.PrjId = objvUserCodePathEN.PrjId;
        //            objUserCodePathEN.CodeTypeId = objvUserCodePathEN.CodeTypeId;
        //            objUserCodePathEN.TabMainTypeId = objvUserCodePathEN.TabMainTypeId;
        //            objUserCodePathEN.UserId = clsSysParaEN.strUserId;

        //            objUserCodePathEN.UpdDate = strCurrDate;
        //            objUserCodePathEN.CodePath = string.Format(objvUserCodePathEN.CodePath.Replace("pyf", strUserId), objProjects.PrjDomain);
        //            objUserCodePathEN.CodePathBackup = string.Format(objvUserCodePathEN.CodePathBackup.Replace("pyf", strUserId), objProjects.PrjDomain);
        //            objUserCodePathEN.ProjectFileName = string.Format(objvUserCodePathEN.ProjectFileName.Replace("pyf", strUserId), objProjects.PrjDomain);
        //            objUserCodePathEN.ProjectPath = string.Format(objvUserCodePathEN.ProjectPath.Replace("pyf", strUserId), objProjects.PrjDomain);
        //            objUserCodePathEN.SuffixPath = objvUserCodePathEN.SuffixPath;
        //            objUserCodePathEN.IsGeneCode = objvUserCodePathEN.IsGeneCode;
        //            objUserCodePathEN.UpdUserId = strUserId;
        //            objUserCodePathEN.IsTemplate = false;
        //            clsUserCodePathWApi.AddNewRecord(objUserCodePathEN);
        //            intCount++;
        //        }
        //    }
        //    return intCount;
        //}
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
        /// <summary>
        /// 设置需要生成代码
        /// </summary>
        /// <param name="lngMid"></param>
        /// <returns></returns>
        public static bool SetIsGeneCode(long lngMid)
        {
            //conUserCodePath.UserCodePathId;
            //conUserCodePath.mId
            clsUserCodePathEN obj = clsUserCodePathWApi.GetObjBymId(lngMid);
            obj.IsGeneCode = true;
            obj.sfUpdFldSetStr = obj.getsfUpdFldSetStr();
            return clsUserCodePathWApi.UpdateRecord(obj);
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
            clsUserCodePathEN obj = clsUserCodePathWApi.GetObjBymId(lngMid);
            obj.IsGeneCode = false;
            obj.sfUpdFldSetStr = obj.getsfUpdFldSetStr();

            return clsUserCodePathWApi.UpdateRecord(obj);
        }
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
            string strCondition = string.Format("{0}={1} ",
                conUserCodePath.CMProjectAppRelaId, strCMProjectAppRelaId);
            List<string> arrCodePath = clsUserCodePathWApi.GetFldValue(conUserCodePath.CodePath, strCondition);
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
            string strCondition = string.Format("{0}={1}",
                conUserCodePath.CMProjectAppRelaId, strCMProjectAppRelaId);
            List<string> arrCodePath = clsUserCodePathWApi.GetFldValue(conUserCodePath.CodePathBackup, strCondition);
            arrCodePath.Sort();

            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conUserCodePath.CodePath;
            objComboBox.DisplayMember = conUserCodePath.CodePath;
            objComboBox.DataSource = arrCodePath;
            objComboBox.SelectedIndex = 0;
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
    }
}