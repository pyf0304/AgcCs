using System;
using System.Net;
using System.Collections;
using com.taishsoft.commdbforxml;

namespace EcardDataClass
{
	/// <summary>
	/// clsSysPara 的摘要说明。
	/// </summary>
	public class clsSysPara
	{
        public static string CurrPrjId = "0002";
        public static string CurrSelPrjId = "";
        public static string CurrDirectory;
        public static string strXMLFolder = @"\EduAdmin_Web\XML\";
		public static string strXMLFileName;	//用于定义SQL存储过程的XML文件名称。        
        /// <summary>
        /// 用于定义SQL存储过程的XML文件名称
        /// </summary>
        public static string strXmlSpParaFileName;	//用于定义SQL存储过程的XML文件名称。
        public static string ConfigFileName;
        //Xml数据源
        public static string strXmlDataSourceFileName = "";
        public static clsSpecSQLforXml objSpecSqlForXml = null;
        public static bool bolIsUseXmlDataSource = false;

        ///连接串名称
        public static string strConnectStrName = "";
        public static bool bolIsUseConnectStrName = false;


		//临时文件目录FOR WEB
        public static string TempWebFolder = @"\EduAdmin_Web\TempFiles\";
		public static string TempFileFolder;	//临时文件物理目录
		public static string FileSvrFileName;
		public static int intRecommendNum = 20;

		//书浏览器用
        public static string ErrorPage = "/EduAdmin_Web/Webform/error.aspx";
        public static string SuccessPage = "/EduAdmin_Web/Webform/success.aspx";
        //临时文件目录FOR WEB
        public static string CurrYear;	//当前学年
        public static string CurrTerm;	//当前学期
        public static string strUserId;		//当前登录的用户
        public static string strUserRoleId; //当前登录用户的角色，如果是一个角色时；
        public static string strUserIp;		//当前登录的用户IP
        public static string strUserStateId;		//当前登录用户的状态ID
        public static string strDepartmentId;//当前登录用户的部门ID
        public static ArrayList arrChRightName;
        public static ArrayList arrUserAllRoleIds;

        public static ArrayList arrobjRights;
        public static ArrayList arrRoleRightId;
        public static Hashtable htRightDict = new Hashtable();
        //public static string strExcelFullFileName;	//当前所选的EXCEL文件名
        public static string strConnectString4SnCrp1 = "";	//原教务管理系统的连接串
        public static string strConnectString4EduAdmin = "";	//新教务管理系统的连接串
        public static string strAppName = "";	//应用程序名
        
		public clsSysPara()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
        public static string GetAddressIP()
        {
            string server = Dns.GetHostName();
            IPHostEntry heserver = Dns.GetHostEntry(server);
            return heserver.AddressList[0].ToString();
        }

	}
}
