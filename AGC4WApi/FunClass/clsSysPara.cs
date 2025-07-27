using System;

namespace AGC4WApi
{
    /// <summary>
    /// clsSysPara。
    /// </summary>
    class clsSysPara
    {
        /// <summary>
        /// 当前工程ID
        /// </summary>
        public static string CurrPrjId = "0005";
        /// <summary>
        /// 
        /// </summary>
        public static string CurrSelPrjId = "";
        /// <summary>
        /// 
        /// </summary>
        public static string strUserId = "";
        /// <summary>
        /// 
        /// </summary>
        public static string strXMLFolder = @"~\XML\";
        ///// <summary>
        ///// 
        ///// </summary>
        //public static string strXMLFileName;	//用于定义SQL存储过程的XML文件名称。
        /// <summary>
        /// 
        /// </summary>
        public static string strXMLDirectory = @"D:\tempFile\";
        ///// <summary>
        ///// 用于定义SQL存储过程的XML文件名称
        ///// </summary>
        //public static string strXmlSpParaFileName;	//用于定义SQL存储过程的XML文件名称。
        ///// <summary>
        ///// 
        ///// </summary>
        //public static string ConfigFileName;

        /// <summary>
        /// Xml数据源
        /// </summary>
        public static string strXmlDataSourceFileName = "";
        /// <summary>
        /// 
        /// </summary>
        public static bool bolIsUseXmlDataSource = false;

        ///连接串名称
        public static string strConnectStrName = "";
        /// <summary>
        /// 
        /// </summary>
        public static bool bolIsUseConnectStrName = false;

        /// <summary>
        /// 临时文件目录FOR WEB
        /// </summary>
        public static string TempWebFolder = @"~\TempFiles\";
        ///// <summary>
        ///// 
        ///// </summary>
        //public static string TempFileFolder;	//临时文件物理目录
        /// <summary>
        /// 
        /// </summary>
        public static string UpLoadFilesWebFolder = @"~\UpLoadFiles\";
        /// <summary>
        /// 
        /// </summary>
        public static string UpLoadFilesFolder = "";	//上传文件物理目录
        /// <summary>
        /// 
        /// </summary>
        public static string DownLoadFilesWebFolder = @"~\DownLoadFiles\";
        /// <summary>
        /// 
        /// </summary>
        public static string DownLoadFilesFolder = "";	//下载文件物理目录
        ///// <summary>
        ///// 
        ///// </summary>
        //public static string FileSvrFileName;
        /// <summary>
        /// 
        /// </summary>
        public static string ErrorPage = @"~/Webform/Index/wfmError.htm";
        /// <summary>
        /// 
        /// </summary>
        public static string SuccessPage = @"~/Webform/success.aspx";

        /// <summary>
        /// 当前机器的IPAddress
        /// </summary>
        private static String strCurrIPAddressAndPort = "202.121.48.247";//"127.0.0.1";String.Empty;

        public static String CurrIPAddressAndPort
        {
            get { 
                if (bolIsUseBackupIpAddressAndCurrPrx == true)
                {
                    return clsSysPara.strCurrIPAddressAndPort2;
                }
                else
                {
                    return clsSysPara.strCurrIPAddressAndPort; 
                }
            }
            set { clsSysPara.strCurrIPAddressAndPort = value; }
        }

        /// <summary>
        /// 当前机器的IPAddress(备用)
        /// </summary>
        public static String strCurrIPAddressAndPort2 = "202.121.48.246";//"127.0.0.1";String.Empty;


        /// <summary>
        /// 是否使用备用的统一平台服务地址
        /// </summary>
        public static bool bolIsUseBackupIpAddressAndCurrPrx = false;//是否使用备用的统一平台服务地址;
    
        /// <summary>
        /// 
        /// </summary>
        public static String strCurrIPAddressAndPort_Local = "localhost:9259";//"127.0.0.1";String.Empty;

        /// <summary>
        /// 当前机器的端口号
        /// </summary>
        private static String strCurrPrx = "Jwc_GP_WS";// String.Empty;

        public static String CurrPrx
        {
            get
            {
                if (bolIsUseBackupIpAddressAndCurrPrx == true)
                {
                    return clsSysPara.strCurrPrx2;
                }
                else
                {
                    return clsSysPara.strCurrPrx;
                }
            }
            set { clsSysPara.strCurrPrx = value; }
        }

        /// <summary>
        /// 当前机器的端口号（备用）
        /// </summary>
        public static String strCurrPrx2 = "Jwc_GP_WS";// String.Empty;

        /// <summary>
        /// 是否本机调试状态
        /// </summary>
        public static bool bolIsLocalHost = false;
    }
}
