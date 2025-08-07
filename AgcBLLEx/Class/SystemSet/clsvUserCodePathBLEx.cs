
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvUserCodePathBLEx
表名:vUserCodePath
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC
工程ID:0005
模块中文名:系统设置
模块英文名:SystemSet
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public static class clsvUserCodePathBLEx_Static
    {
        public static string UserCodePrjMainPathIdBL(this clsvUserCodePathEN objUserCodePath, string strUserId)
        {
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsUserCodePrjMainPathBLEx.GetObjByCmPrjIdAppRelaIdPrjIdUserIdCache_Dic(objUserCodePath.CMProjectAppRelaId, strUserId);
            return objUserCodePrjMainPath.UserCodePrjMainPathId;
        }
        /// <summary>
        /// 获取在工程内的代码路径，例如设置的代码路径为：/SamplePrj_DAL/Class, 工程路径为/SamplePrj_DAL，则：工程内的代码路径为：/Class
        /// </summary>
        /// <param name="objvUserCodePathEN">用户代码路径对象</param>
        /// <returns></returns>
        public static string GetPrjInnerCodePath(this clsvUserCodePathEN objvUserCodePathEN)
        {
            if (objvUserCodePathEN.ProjectPath == "/") return objvUserCodePathEN.CodePath;
            if (string.IsNullOrEmpty(objvUserCodePathEN.ProjectPath)) return objvUserCodePathEN.CodePath;
            string strRealyCodePath = objvUserCodePathEN.CodePath.Replace(objvUserCodePathEN.ProjectPath, "");
            return strRealyCodePath;
        }

        public static string GetFullProjectPath(this clsvUserCodePathEN objvUserCodePathEN, clsUserCodePrjMainPathENEx objUserCodePrjMainPath)
        {
            if (objvUserCodePathEN.ProjectPath == "/") return objUserCodePrjMainPath.CodePath;
            if (string.IsNullOrEmpty(objvUserCodePathEN.ProjectPath)) return objUserCodePrjMainPath.CodePath;
            string strFullProjectPath = string.Format("{0}\\{1}", objUserCodePrjMainPath.CodePath, objvUserCodePathEN.ProjectPath);
            strFullProjectPath = strFullProjectPath.Replace("\\/\\", "\\")
                    .Replace("/", "\\").Replace("\\\\","\\").Replace("\\\\", "\\");
            return strFullProjectPath;
        }
    }
    /// <summary>
    /// v用户生成路径(vUserCodePath)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvUserCodePathBLEx : clsvUserCodePathBL
    {
        //private static string mstrPrjId4Cache = "";
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvUserCodePathDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvUserCodePathDAEx vUserCodePathDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvUserCodePathDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCacheEx(string strCurrPrjId, string strUserId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsProjectsBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsCodeTypeBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsUserCodePathBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsUserCodePathBL没有刷新缓存机制(clsUserCodePathBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsProgLangTypeBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsProgLangTypeBL没有刷新缓存机制(clsProgLangTypeBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsUsersBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsUserStateBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsUserIdentityBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsDepartmentInfoBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsDepartmentInfoBL没有刷新缓存机制(clsDepartmentInfoBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsDepartmentTypeBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsDepartmentTypeBL没有刷新缓存机制(clsDepartmentTypeBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (strCurrPrjId != mstrPrjId4Cache)
        //    {
        //        clsvUserCodePathBL.ReFreshThisCache();
        //    }
        //    //初始化列表缓存
        //    //string strWhereCond = string.Format("1 = 1 order by mId");
        //    string strWhereCond = string.Format("PrjId='{0}' And UserId='{1}'", strCurrPrjId,
        //        strUserId);
        //    if (arrvUserCodePathObjLstCache == null)
        //    {
        //        arrvUserCodePathObjLstCache = new clsvUserCodePathDA().GetObjLst(strWhereCond);
        //        mstrPrjId4Cache = strCurrPrjId;
        //    }
        //}


        /// <summary>
        /// 根据代码类型Id和语言类型Id获取用户代码项目主目录
        /// </summary>
        /// <param name="strCodeTypeId">代码类型Id</param>
        /// <param name="intApplicationTypeId">应用类型Id</param>
        /// <param name="strCurrPrjId">当前工程Id</param>
        /// <param name="strUserId">当前用户Id</param>
        /// <returns></returns>
        public static clsvUserCodePathEN GetObjByCodeTypeIdCache1(long lngCMProjectAppRelaId, string strCodeTypeId, string strCurrPrjId)
        {
            if (lngCMProjectAppRelaId == 0)
            {
                string strMsg = string.Format("当前(lngCMProjectAppRelaId)没有设置，请联系管理员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            if (string.IsNullOrEmpty(strCurrPrjId) == true)
            {
                throw new Exception("当前项目没有设置，请联系管理员！");
            }
            //InitListCacheEx(strCurrPrjId, strUserId);
            List<clsvUserCodePathEN> arrObjLstCache = clsvUserCodePathBL.GetObjLstCache(strCurrPrjId);

            IEnumerable<clsvUserCodePathEN> arrvUserCodePathObjLst_Sel1 =
from objvUserCodePathEN in arrObjLstCache
where objvUserCodePathEN.CodeTypeId == strCodeTypeId
&& objvUserCodePathEN.CMProjectAppRelaId == lngCMProjectAppRelaId
select objvUserCodePathEN;


            List<clsvUserCodePathEN> arrvUserCodePathObjLst_Sel = new List<clsvUserCodePathEN>();
            foreach (clsvUserCodePathEN obj in arrvUserCodePathObjLst_Sel1)
            {
                arrvUserCodePathObjLst_Sel.Add(obj);
            }
            if (arrvUserCodePathObjLst_Sel.Count > 0)
            {
                return arrvUserCodePathObjLst_Sel[0];
            }

           
            clsvUserCodePathBL.ReFreshThisCache();
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
            

            sbMsg.AppendFormat("管理员还没有设置相关代码生成路径，代码类型：{1}({0})({2})，请设置！", 
                            objCodeTypeEN.CodeTypeId,
                objCodeTypeEN.CodeTypeName, clsProgLangTypeBL.GetNameByProgLangTypeIdCache( objCodeTypeEN.ProgLangTypeId));
            throw new Exception(sbMsg.ToString());
            //return null;
        }


        /// <summary>
        /// 根据代码类型和语言类型获取用户代码项目主目录
        /// </summary>
        /// <param name="cnClassName">代码类型</param>
        /// <param name="ltLangType">语言类型</param>
        /// <param name="strCurrPrjId">当前工程Id</param>
        /// <param name="strUserId">当前用户Id</param>
        /// <returns></returns>
        public static clsvUserCodePathEN GetObjBymIdExBak20180621(long lngMid, string strUserId, string strMachineName)
        {
            clsvUserCodePathEN objvUserCodePathEN = GetObjBymId(lngMid);
            //if (objvUserCodePathEN.IsUsePrjMainPath == true)
            //{
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEN
                = clsUserCodePrjMainPathBLEx.GetObjExByUserCodePrjMainPathIdCache(objvUserCodePathEN.UserCodePrjMainPathIdBL(strUserId), objvUserCodePathEN.PrjId, strMachineName);
            if (objUserCodePrjMainPathEN == null)
            {
                clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(objvUserCodePathEN.PrjId);
                clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objvUserCodePathEN.ProgLangTypeId);
                string strMsg = string.Format("语言类型：{0}没有设置项目主目录。(工程:{1})({2})",
                    objProgLangTypeEN.ProgLangTypeName, objProjectsEN.PrjName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            objvUserCodePathEN.NewCodePath = string.Format("{0}{1}",
                objUserCodePrjMainPathEN.CodePath, objvUserCodePathEN.CodePath);
            objvUserCodePathEN.NewCodePathBackup = string.Format("{0}{1}",
                                objUserCodePrjMainPathEN.CodePathBackup, objvUserCodePathEN.CodePathBackup);

           
            return objvUserCodePathEN;
        }
        public static void GetRelaPath(ref clsvUserCodePathEN objvUserCodePathEN,string strUserId, string strMachineName)
        {
            //clsvUserCodePathEN objvUserCodePathEN = GetObjBymId(lngMid);
            //if (objvUserCodePathEN.IsUsePrjMainPath == true)
            //{
            clsUserCodePrjMainPathEN objUserCodePrjMainPathEN
                = clsUserCodePrjMainPathBLEx.GetObjByUserCodePrjMainPathIdCache(objvUserCodePathEN.UserCodePrjMainPathIdBL(strUserId), objvUserCodePathEN.PrjId);
            if (objUserCodePrjMainPathEN == null)
            {
                clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(objvUserCodePathEN.PrjId);
                clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objvUserCodePathEN.ProgLangTypeId);
                string strMsg = string.Format("语言类型：{0}没有设置项目主目录。(工程:{1})({2})",
                    objProgLangTypeEN.ProgLangTypeName, objProjectsEN.PrjName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathBLEx.CopyToExByMachineName(objUserCodePrjMainPathEN, strMachineName);
            objvUserCodePathEN.NewCodePath = string.Format("{0}{1}",
                objUserCodePrjMainPathEx.CodePath, objvUserCodePathEN.CodePath);
            objvUserCodePathEN.NewCodePathBackup = string.Format("{0}{1}",
                                objUserCodePrjMainPathEx.CodePathBackup, objvUserCodePathEN.CodePathBackup);


            //return objvUserCodePathEN;
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
        public static clsvUserCodePathEN GetObjByClassName(int intApplicationTypeId, string strCodeTypeId,
            clsPubConst.LangType ltLangType, string strCurrPrjId, string strMachineName, string strUserId)
        {
            if (string.IsNullOrEmpty(strUserId) == true)
            {
                string strMsg = string.Format("当前用户(strUserId)没有设置，请联系管理员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            //string strClassName = clsPubConst.GetClassNameStringByClassName(cnClassName);
            //clsCodeTypeEN objCodeTypeEN = clsCodeTypeBLEx.GetObjByClassNameCacheEx(cnClassName);

            //clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBLEx.GetObjByLangTypeCache(ltLangType);
            clsvUserCodePathEN objvUserCodePathEN = GetObjByCodeTypeIdCache1(intApplicationTypeId, strCodeTypeId, strCurrPrjId);
            //if (objvUserCodePathEN.IsUsePrjMainPath == true)
            //{
            clsUserCodePrjMainPathEN objUserCodePrjMainPathEN
                = clsUserCodePrjMainPathBLEx.GetObjExByUserCodePrjMainPathIdCache(objvUserCodePathEN.UserCodePrjMainPathIdBL(strUserId), objvUserCodePathEN.PrjId, strMachineName);
            //    if (objUserCodePrjMainPathEN == null)
            //    {
            //        clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(strCurrPrjId);
            //        string strMsg = string.Format("语言类型：{0}没有设置项目主目录。(工程:{1})({2})",
            //            objProgLangTypeEN.ProgLangTypeName, objProjectsEN.PrjName, clsStackTrace.GetCurrClassFunction());
            //        throw new Exception(strMsg);
            //    }
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathBLEx.CopyToExByMachineName(objUserCodePrjMainPathEN, strMachineName);

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

            
            return objvUserCodePathEN;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "intApplicationTypeId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsvUserCodePathEN> GetObjLstByApplicationTypeIdExCache(int intApplicationTypeId, string strPrjId)
        {
            //初始化列表缓存
            List<clsvUserCodePathEN> arrObjLstCache = clsvUserCodePathBL.GetObjLstCache(strPrjId);

            IEnumerable<clsvUserCodePathEN> arrvUserCodePathObjLst_Sel1 =
            from objvUserCodePathEN in arrObjLstCache
            where objvUserCodePathEN.ApplicationTypeId == intApplicationTypeId
            select objvUserCodePathEN;
            List<clsvUserCodePathEN> arrvUserCodePathObjLst_Sel = new List<clsvUserCodePathEN>();
            foreach (clsvUserCodePathEN obj in arrvUserCodePathObjLst_Sel1)
            {
                arrvUserCodePathObjLst_Sel.Add(obj);
            }
            if (arrvUserCodePathObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrvUserCodePathObjLst_Sel;
        }

    }
}