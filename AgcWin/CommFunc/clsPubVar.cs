using AGC.Entity;
using AGC4WApi;
using com.taishsoft.common;

using System.Collections.Generic;

namespace AGC_CSWin
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
        public static clsLog objLog = null;// new clsLog();

        public static bool bolIsDispMenu = false;
        //public static TzGeneralPlatformDll2.MenuAndPotence objMenuAndPotence = null;// (clsSysParaEN.ConfigFileName)
        public static MdiForm objMainForm =  null;  //   new MdiForm();
        public static clsProjectsEN objCurrSelProjectEN = null;
        //public static clsProjectsEN objCurrSelProjectEN = null;
        //public static clsProjectsENEx objCurrSelProjectENEx = null;
        public static List<clsUserCodePathEN> arrUserCodePathENObjLst = null;
        public static List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPathENObjLst = null;
        
        private static string mstrSqlStatement = "";//SQL语句
        /// <summary>
        /// 当前需要执行的SQL语句
        /// </summary>
        public static string SqlStatement
        {
            get { return clsPubVar.mstrSqlStatement; }
            set { clsPubVar.mstrSqlStatement = value; }
        }

        private static string mstrCurrPrjId = "0005";
        private static string mstrCurrSelPrjId = "";

        public static string CurrPrjDataBaseId;
        public static string CurrSelPrjId
        {
            set
            {
                mstrCurrSelPrjId = value;
                clsSysParaEN.CurrSelPrjId = value;
                if (string.IsNullOrEmpty(mstrCurrSelPrjId) == false)
                {
                    if (clsSysParaEN.bolIsUseXmlDataSource == true)
                    {
                        clsPubVar.objCurrSelProjectEN = new clsProjectsEN(mstrCurrSelPrjId);
                        //clsPubVar.objCurrSelProjectEN.GetProjectsForXml();
                    }
                    else
                    {
                        clsPubVar.objCurrSelProjectEN = clsProjectsWApi.GetObjByPrjId(mstrCurrSelPrjId);
                        //clsPubVar.objCurrSelProjectENEx = clsProjectsExWApi.GetProjectsENExObjByPrjId(mstrPrjId);
 
                    }
                }
            }
            get
            {
                return mstrCurrSelPrjId;
            }
        }
        public static string WS_Url
        {
            get
            {
                string strWS_Url = System.Configuration.ConfigurationManager.AppSettings["WS_Url"].ToString();
                return strWS_Url;
            }
        }

        public static string CurrPrjId
        {
            get
            {
                return mstrCurrPrjId;
            }

            set
            {
                mstrCurrPrjId = value;
            }
        }
        public static string CmPrjId
        {
            get;set;
        }
        //public static bool AccessUserCodePathException(string strId)
        //{

        //}
    }
}