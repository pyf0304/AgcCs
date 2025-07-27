using AGC;
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.Entity;
using com.taishsoft.common;
using CommFunc4WebForm;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.UI;
using AGC.BusinessLogicEx;

namespace AGC.FunClass
{
    /// <summary>
    /// clsPubVar 的摘要说明
    /// </summary>
    public class clsPubVar
    {
        public clsPubVar()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        //public static TzGeneralPlatformDll2.MenuAndPotence objMenuAndPotence = null;// (clsSysParaEN.ConfigFileName)
        public static clsCommonSession objCommonSession = null; //new clsCommonSession();
        public static string CurrPrjId = "0005";
        public static string strCurrPrjId4Agc = "0005";//
        public static clsLog objLog = null;
        public static clsProjectsEN objCurrSelProjectEx = null;
        public static List<clsUserCodePathEN> arrUserCodePathENObjLst = null;

        public static string CurrWorkFlowId
        {
            get
            {
                string strWorkFlowId = clswf_WorkFlowBLEx.GetCurrUseWorkFlowIdCache(clsPubVar.CurrPrjId);
                return strWorkFlowId;
            }
        }
        public static clsProjectsEN objCurrSelProject
        {
            get
            {
                if (string.IsNullOrEmpty(CurrSelPrjId) == true)
                {
                    return null;
                }
                else
                {
                    clsProjectsEN objCurrSelProject1 = clsProjectsBL.GetObjByPrjIdCache(CurrSelPrjId);
                    return objCurrSelProject1;
                }
            }
        }

        public static bool CheckUserSession()
        {
            if (clsCommonSession.UserId == "")
            {
                clsCommonSession.seErrMessage = "登录用户（UserId）为空，请检查！";
                clsCommForWebForm.CheckUserId(clsCommonSession.UserId, clsSysParaEN.ErrorPage);
                //                System.Web.HttpContext.Current.Response.Redirect(clsSysParaEN.HomePage);
            }
            return true;
        }

        public static int _CurrIndex { get; set; }
        //private static string mstrPrjId = "";
        //public static string CurrSelPrjId1
        //{
        //    set
        //    {
        //        mstrPrjId = value;
        //        clsSysParaEN.CurrSelPrjId = value;
        //        if (string.IsNullOrEmpty(mstrPrjId) == false)
        //        {
        //            clsPubVar.objCurrSelProject = new clsProjectsEN(mstrPrjId, true);
        //        }
        //    }
        //    get
        //    {
        //        return mstrPrjId;
        //    }
        //}
        /// <summary>
        /// 当前选择的项目
        /// </summary>
        public static string CurrSelPrjId
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["CurrSelPrjId"] != null)
                {
                    return System.Web.HttpContext.Current.Session["CurrSelPrjId"].ToString();
                }
                else
                {
                    return "";
                }
            }
            set
            {
                System.Web.HttpContext.Current.Session.Add("CurrSelPrjId", value);
            }
        }
        public static string CurrCmPrjId
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["CurrCmPrjId"] != null)
                {
                    return System.Web.HttpContext.Current.Session["CurrCmPrjId"].ToString();
                }
                else
                {
                    return "";
                }
            }
            set
            {
                System.Web.HttpContext.Current.Session.Add("CurrCmPrjId", value);
            }
        }
        public static string CurrPrjDataBaseId
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["CurrPrjDataBaseId"] != null)
                {
                    return System.Web.HttpContext.Current.Session["CurrPrjDataBaseId"].ToString();
                }
                else
                {
                    return "";
                }
            }
            set
            {
                System.Web.HttpContext.Current.Session.Add("CurrPrjDataBaseId", value);
            }
        }

        public static string CurrDataBaseTypeId
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["CurrDataBaseTypeId"] != null)
                {
                    return System.Web.HttpContext.Current.Session["CurrDataBaseTypeId"].ToString();
                }
                else
                {
                    return "";
                }
            }
            set
            {
                System.Web.HttpContext.Current.Session.Add("CurrDataBaseTypeId", value);
            }
        }
        public static clsUserCodePathEN GetUserCodePathObjByCodeTypeId1(string strCodeTypeId)
        {
            if (string.IsNullOrEmpty(clsSysParaEN.strUserId) == true)
            {
                throw new Exception("当前用户(clsSysParaEN.strUserId)没有设置，请联系管理员！");
            }

            if (string.IsNullOrEmpty(clsPubVar.CurrSelPrjId) == true)
            {
                throw new Exception("当前项目没有设置，请联系管理员！");
            }
            if (arrUserCodePathENObjLst == null)
            {
                string strCondition = string.Format("PrjId='{0}' And UserId='{1}'", clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);

                arrUserCodePathENObjLst = clsUserCodePathBL.GetObjLst(strCondition);
            }
            foreach (clsUserCodePathEN objUserCodePathEN in arrUserCodePathENObjLst)
            {
                if (objUserCodePathEN.CodeTypeId == strCodeTypeId)
                {
                    return objUserCodePathEN;
                }
            }
            arrUserCodePathENObjLst = null;
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
            clsUsersEN objUsersEN = clsUsersBL.GetObjByUserId(clsSysParaEN.strUserId);

            sbMsg.AppendFormat("{0},您好！您还没有设置代码生成路径：{1}，请设置！", objUsersEN.UserName, objCodeTypeEN.CodeTypeName);
            throw new Exception(sbMsg.ToString());
            //return null;
        }
        public static clsUserCodePathEN GetUserCodePathObjByCodeTypeId(string strCodeTypeId, string strPrjId, string strUserId)
        {
            if (string.IsNullOrEmpty(strUserId) == true)
            {
                throw new Exception("当前用户(strUserId)没有设置，请联系管理员！");
            }

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                throw new Exception("当前项目没有设置，请联系管理员！");
            }
            if (arrUserCodePathENObjLst == null)
            {
                string strCondition = string.Format("PrjId='{0}' And UserId='{1}'", strPrjId, strUserId);

                arrUserCodePathENObjLst = clsUserCodePathBL.GetObjLst(strCondition);
            }
            foreach (clsUserCodePathEN objUserCodePathEN in arrUserCodePathENObjLst)
            {
                if (objUserCodePathEN.CodeTypeId == strCodeTypeId)
                {
                    return objUserCodePathEN;
                }
            }
            arrUserCodePathENObjLst = null;
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
            clsUsersEN objUsersEN = new clsUsersEN(clsSysParaEN.strUserId);
            clsUsersBL.GetUsers(ref objUsersEN);
            sbMsg.AppendFormat("{0},您好！您还没有设置代码生成路径：{1}，请设置！", objUsersEN.UserName, objCodeTypeEN.CodeTypeName);
            throw new Exception(sbMsg.ToString());
            //return null;
        }
        /// <summary>
        /// 初始化需要导出的Excel文件
        /// </summary>
        /// <param name="thisPage">当前页面对象</param>
        /// <param name="strFolderName">下载路径</param>
        /// <param name="strDownLoadFileName">下载文件名</param>
        /// <returns>是否成功</returns>
        public static bool InitExcelFile(Page thisPage, string strFolderName, string strDownLoadFileName)
        {

            if (string.IsNullOrEmpty(strFolderName) == true)
            {
                clsCommonJsFunc.Alert(thisPage, string.Format("目录变量:strFolderName为空，请联系管理员！"));
                return false;
            }

            if (string.IsNullOrEmpty(strDownLoadFileName) == true)
            {
                clsCommonJsFunc.Alert(thisPage, string.Format("目录变量:strDownLoadFileName为空，请联系管理员！"));
                return false;
            }

            if (Directory.Exists(strFolderName) == false)
            {
                clsCommonJsFunc.Alert(thisPage, string.Format("目录:{0}不存在，请检查！", strFolderName));
                return false;
            }
            string strSamXlsFile = strFolderName + clsMyConfig.SamXlsFileName;
            if (File.Exists(strSamXlsFile) == false)
            {
                clsCommonJsFunc.Alert(thisPage, string.Format("Excel导出样例文件:{0}不存在，请检查！", strSamXlsFile));
                return false;
            }
            if (File.Exists(strDownLoadFileName) == true)
            {
                File.Delete(strDownLoadFileName);
            }

            File.Copy(strSamXlsFile, strDownLoadFileName);
            return true;
        }

    }
}