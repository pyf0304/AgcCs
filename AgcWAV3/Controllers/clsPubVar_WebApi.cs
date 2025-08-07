using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections;

using com.taishsoft.encrypt;
using System.Text;
using System.IO;
using com.taishsoft.common;

namespace Comm.WebApi
{
    /// <summary>
    /// clsPubVar 的摘要说明
    /// </summary>
    public class clsPubVar_WebApi
    {
        public clsPubVar_WebApi()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            
        }
        public static clsLog objLog = null;//new clsLog();// 

        public static string strPrjId = "0001";//当前工程ID
        public static string strCurrPrjId4AgcCs = "0014";//

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
        //public static string GetVirtualRoot()
        //{
        //    string strApp1 = System.Web.HttpContext.Current.Request.ApplicationPath;
        //    return strApp1;
        //}

       
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

       
    }
}