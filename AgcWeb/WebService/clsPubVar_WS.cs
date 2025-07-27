using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using CommFunc4WebForm;
using com.taishsoft.encrypt;
using System.Text;
using System.IO;

using com.taishsoft.common;

namespace AGC.WebSrv
{
    /// <summary>
    /// clsPubVar 的摘要说明
    /// </summary>
    public class clsPubVar_WS
    {
        public clsPubVar_WS()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            
        }
        public static clsLog objLog = new clsLog();// null;

        public static string strPrjId = "0001";//当前工程ID
        public static string strCurrPrjId4Agc = "0014";//

        //public static TzGeneralPlatformDll2.MenuAndPotence objMenuAndPotence = null;// (clsSysParaEN.ConfigFileName)
      
        /// <summary>
        /// 获取登录BB的脚本代码
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns></returns>
        public static string GetGPLoginScript(string strUserId)
        {
            string c1 = string.Empty;
            string strKey = clsEncrypt.MD5(strUserId + "gpintegration");
            strKey = strKey.ToUpper();
            //http://202.121.49.7/webapps/login/
//            c1 = "<script language='javascript'>window.open('http://202.121.63.10/GeneralPlatformTZ/quick_index.aspx?userid=" + strUserId + "&key=" + strKey + "'); </script>";
            c1 = "<script language='javascript'>window.open('index_quick.aspx?userid=" + strUserId + "&key=" + strKey + "'); </script>";
            return c1;
        }

        /// <summary>
        /// 获取当前WEB项目的虚拟根目录
        /// </summary>
        /// <returns></returns>
        public static string GetVirtualRoot()
        {
            string strApp1 = System.Web.HttpContext.Current.Request.ApplicationPath;
            return strApp1;
        }

       
        public static bool InsertCard_State(DataTable objDT)
        {
            bool bolIsExist = false;
            foreach (DataColumn objDC in objDT.Columns)
            {
                string strColumnName = objDC.ColumnName;
                if (strColumnName.Equals("Card_State", StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    bolIsExist = true;
                }
            }
            if (bolIsExist == false)
            {
                DataColumn dcCard_State = new DataColumn();
                dcCard_State.DataType = System.Type.GetType("System.String");
                dcCard_State.ColumnName = "Card_State";
                //dcCard_State.AutoIncrement = true;
                objDT.Columns.Add(dcCard_State);
            }
            return true;
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