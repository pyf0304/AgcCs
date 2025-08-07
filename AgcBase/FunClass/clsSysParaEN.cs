using System;
using System.Text;
using System.Collections;
using com.taishsoft.commdbforxml;
using System.Collections.Generic;
using com.taishsoft.common;

namespace AGC.Entity
{
	/// <summary>
	/// clsSysPara 的摘要说明。
	/// </summary>
	public partial class clsSysParaEN
	{
        /// <summary>
        /// 日志记录对象
        /// </summary>
        public static clsLog objLog = null;// new clsLog();
        /// <summary>
        /// 日志记录对象
        /// </summary>
        public static clsLog objErrorLog = null;//new clsLog();
        /// <summary>
        /// 是否使用任务队列，可以依次执行，延后执行
        /// </summary>
        public static bool spIsUseQueue4Task = false;
        /// <summary>
        /// 任务或函数的队列
        /// </summary>
        public static Queue<object> arrFunctionLst4Queue = null;

        /// <summary>
        /// 系统参数：应用程序名
        /// </summary>
        public static string spAppName = "";
        /// <summary>
        /// 系统参数：当前所在的学校
        /// </summary>
        public static string spSchool;

        /// <summary>
        /// 系统参数：数据库的连接串
        /// </summary>
        public static string spConnectString = "";
        public static string spConnectString_GP = "";

        ///// <summary>
        ///// 当前应用虚拟目录,带IP地址及根域名
        ///// </summary>
        //private static string mstrspVirtualPath;		//当前应用虚拟目录
        ///// <summary>
        ///// 当前应用虚拟目录,不带IP地址及根域名
        ///// </summary>
        //private static string mstrspVirtualRoot;		//当前应用虚拟目录,不带IP地址及根域名

        /// <summary>
        /// 系统参数：统一平台的WebService前缀，主要指WebService文件所在目录
        /// </summary>
        public static string spCurrPrx = "";

        /// <summary>
        /// 系统参数：统一平台的WebService地址和端口。(不用带【http://】)
        /// </summary>
        public static string spCurrIPAddressAndPort = "";

        /// <summary>
        /// 系统参数：登录模式，如果是quick就是：没有登录时运行模块，就快速登录，然后再运行该模块
        /// </summary>
        public static string spLoginMode;   

        /// <summary>
        /// 用户类型有：高校（University)、中小学(MiddleSchool)、医院(Hospital)、企业(Enterprise)
        /// /*<add key="UserType" value="Hospital"/>*/
        /// </summary>
        public static string spUserType = "University";//

        /// <summary>
        /// 系统参数：当前登录的用户Id
        /// </summary>
        //public static string spUserId;      //系统参数：当前所在的学校
        /// <summary>
        /// 系统参数：当前登录用户的状态Id
        /// </summary>
        public static string spUserStateId;
        /// <summary>
        /// 系统参数：当前登录的用户IP
        /// </summary>
        public static string spUserIp;

        /// <summary>
        /// 系统参数：当前服务器的IP
        /// </summary>
        public static string spServerIp;      

        /// <summary>
        /// 系统参数：统一平台的地址
        /// </summary>
        public static string spGeneralPlatform;
        /// <summary>
        /// 系统参数：日志目录
        /// </summary>
        public static string spLogDir;
        /// <summary>
        /// 系统参数：设置重新刷新缓存，默认为True。
        /// </summary>
        public static bool spSetRefreshCacheOn = true;
            
        /// <summary>
        /// 是否Debug
        /// </summary>
        public static bool IsDebug;		//系统参数：是否Debug
        /// <summary>
        /// 播放视频的IP地址
        /// </summary>
        public static string spVedioIP;		//系统参数：播放视频的IP地址
        /// <summary>
        /// 播放视频的IP地址是否与播放网站在同一IP地址
        /// </summary>
        public static bool spIsUseVedioIPInSameIP;      //系统参数：播放视频的IP地址是否与播放网站在同一IP地址

        //public static bool spIsFstLcase = false;      //是否属性首字母小写

        /// <summary>
        /// Flv文件的播放器所在目录
        /// </summary>
        private static string mstrspFlvplayerPath;       //Flv文件的播放器所在目录


        /// <summary>
        /// 系统参数：视频文件的存放地址
        /// </summary>
        private static string mstrspFePicSavePath;
        /// <summary>
        /// 系统参数：视频文件的存放地址-短名
        /// </summary>
        public static string spFePicSavePath_Short;
        /// <summary>
        /// 系统参数：图像文件的存放地址
        /// </summary>
        public static string spImagePath;		
        /// <summary>
        /// 系统参数：华平视频文件的存放地址
        /// </summary>
        public static string spHuaPingFePicSavePath;
        /// <summary>
        /// 
        /// </summary>
        public static string spPlayerBackGround = "#FF3300";
      

        /// <summary>
        /// 应用程序名
        /// </summary>
        public static string strAppName = "";   //应用程序名

        /// <summary>
        /// 用户类型有：高校（University)、中小学(MiddleSchool)、医院(Hospital)、企业(Enterprise)
        /// /*<add key="UserType" value="Hospital"/>*/
        /// </summary>
        public static string strUserType = "University";


        /// <summary>
        /// 当前登录用户Id
        /// </summary>
        public static string strUserId = "";
        /// <summary>
        /// 当前登录用户名
        /// </summary>
        public static string strUserName = "";
        /// <summary>
        /// 当前项目Id(PrjId)
        /// </summary>
        public static string CurrPrjId = "";
        /// <summary>
        /// 当前项目中选择的PrjId(工程Id)
        /// </summary>
        public static string CurrSelPrjId = "";
        /// <summary>
        /// 当前登录的用户IP
        /// </summary>
        public static string strUserIp;
        /// <summary>
        /// 当前登录用户的角色Id
        /// </summary>
        public static string strUserRoleId;
        /// <summary>
        /// 当前登录用户的状态Id
        /// </summary>
        public static string strUserStateId;		//

        /// <summary>
        /// 当前登录用户的角色Id
        /// </summary>
        public static string strRoleId = "";
        /// <summary>
        /// 当前用户的所有角色Id
        /// </summary>
        public static List<string> arrUserAllRoleIds = null;
        /// <summary>
        /// 当前用户的中文权限名称列表
        /// </summary>
        public static List<string> arrChRightName;//
        /// <summary>
        /// 当前登录用户的部门ID
        /// </summary>
        public static string strDepartmentId;
                
        /// <summary>
        /// 设置网站首页
        /// </summary>
        public static string strIndexPage = "~/WebForm/Index.aspx";
       
        /// <summary>
        /// 当前使用的学校名称
        /// </summary>
        public static string SchoolName ="";// System.Configuration.ConfigurationSettings.AppSettings["SchoolName"].ToString();

        public static bool bolIsNeedReloadAnswerObjLst = false;//是否需要
        public static bool bolIsNeedReloadQuestionOptionsObjLst = false;//是否需要
       
        /// <summary>
        /// 当前学年
        /// </summary>
        public static string CurrYear;	//当前学年
        /// <summary>
        /// 当前学期
        /// </summary>
        public static string CurrTerm;	//当前学期
        /// <summary>
        /// 该统一平台的使用单位
        /// </summary>
        public static string strCompanyName = "";//
        /// <summary>
        /// Xml目录
        /// </summary>
        public static string strXMLFolder = @"~\XML\";
        /// <summary>
        /// 用于定义SQL存储过程的XML文件名称
        /// </summary>
		public static string strXMLFileName = "";	//。
        /// <summary>
        /// 临时的Xml文件名
        /// </summary>
        public static string strTempXMLFileName = "";
        /// <summary>
        /// 用于定义SQL存储过程的XML文件名称
        /// </summary>
        public static string strXmlSpParaFileName;  //用于定义SQL存储过程的XML文件名称。

        
        /// <summary>
        /// Xml数据源文件名
        /// </summary>
        public static string strXmlDataSourceFileName = "";
        /// <summary>
        /// 针对Xml的SpecSQL
        /// </summary>
        public static clsSpecSQLforXml objSpecSqlForXml = null;
        /// <summary>
        /// 是否使用Xml数据源
        /// </summary>
        public static bool bolIsUseXmlDataSource = false;
        /// <summary>
        /// 连接串名称
        /// </summary>
        public static string strConnectStrName = "";
        /// <summary>
        /// 是否使用连接串名称
        /// </summary>
        public static bool bolIsUseConnectStrName = false;
        /// <summary>
        /// 上传文件Web目录
        /// </summary>
        public static string UpLoadFilesWebFolder = @"~/UpLoadFiles/";
        /// <summary>
        /// 上传文件Web目录
        /// </summary>
        public static string UploadWebFolder
        {
            get
            {
                return UpLoadFilesWebFolder;
            }
        }
        /// <summary>
        /// 上传文件物理目录
        /// </summary>
        public static string UpLoadFilesFolder = "";
        /// <summary>
        /// 下载文件Web目录
        /// </summary>
        public static string DownLoadFilesWebFolder = @"~\DownLoadFiles\";
        /// <summary>
        /// 下载文件物理目录
        /// </summary>
        public static string DownLoadFilesFolder = "";	
        /// <summary>
        /// 配置文件名
        /// </summary>
		public static string ConfigFileName;
        
        /// <summary>
        /// Web临时文件目录
        /// </summary>
        public static string TempWebFolder = @"~\TempFiles\";
        /// <summary>
        /// 临时文件物理目录
        /// </summary>
		public static string TempFileFolder;	
       
        /// <summary>
        /// Web错误处理显示界面
        /// </summary>
		public static string ErrorPage = "~/Webform/ErrorMsg.aspx";
        /// <summary>
        /// Web成功处理显示界面
        /// </summary>
		public static string SuccessPage = "~/Webform/success.aspx";
		     
        /// <summary>
        /// 当前应用所在目录
        /// </summary>
        public static string CurrDirectory;
          /// <summary>
        /// 是否使用SilverLight播放器
        /// </summary>
        public static bool bolIsUseSilverLightPlay = false;//；
        ///// <summary>
        ///// 是否支持使用Html5
        ///// </summary>
        //public static bool bolIsSupportsHtml5 = false;//；
       
        /// <summary>
        /// 构造函数
        /// </summary>
        public clsSysParaEN()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
        /// <summary>
        /// 获取系统参数，以字符串的形式返回
        /// </summary>
        /// <returns></returns>
        public static string getAllSysPara()
        {
            StringBuilder sbSysPara = new StringBuilder();
            sbSysPara.AppendFormat("系统参数键-值关系如下：");
            sbSysPara.AppendFormat("spAppName=[{0}]\r\n", spAppName);
            sbSysPara.AppendFormat("spSchool=[{0}]\r\n", spSchool);
            sbSysPara.AppendFormat("spConnectString=[{0}]\r\n",spConnectString.Length>10? spConnectString.Substring(0,10) : spConnectString);
            //sbSysPara.AppendFormat("spVirtualPath=[{0}]\r\n", spVirtualPath);
            //sbSysPara.AppendFormat("spVirtualRoot=[{0}]\r\n", spVirtualRoot);
            sbSysPara.AppendFormat("spCurrIPAddressAndPort=[{0}]\r\n", spCurrIPAddressAndPort);
            sbSysPara.AppendFormat("spCurrPrx=[{0}]\r\n", spCurrPrx);
            sbSysPara.AppendFormat("spLoginMode=[{0}]\r\n", spLoginMode);
            sbSysPara.AppendFormat("spUserType=[{0}]\r\n", spUserType);
            sbSysPara.AppendFormat("spUserId=[{0}]\r\n", strUserId);
            sbSysPara.AppendFormat("spUserStateId=[{0}]\r\n", spUserStateId);
            sbSysPara.AppendFormat("spUserIp=[{0}]\r\n", spUserIp);
            sbSysPara.AppendFormat("spGeneralPlatform=[{0}]\r\n", spGeneralPlatform);
            sbSysPara.AppendFormat("spLogDir=[{0}]\r\n", spLogDir);
            sbSysPara.AppendFormat("spSetRefreshCacheOn=[{0}]\r\n", spSetRefreshCacheOn);
            sbSysPara.AppendFormat("IsDebug=[{0}]\r\n", IsDebug);
            sbSysPara.AppendFormat("spVedioIP=[{0}]\r\n", spVedioIP);
            sbSysPara.AppendFormat("spIsUseVedioIPInSameIP=[{0}]\r\n", spIsUseVedioIPInSameIP);
            //sbSysPara.AppendFormat("spFlvplayerPath=[{0}]\r\n", spFlvplayerPath);
            //sbSysPara.AppendFormat("spFePicSavePath=[{0}]\r\n", spFePicSavePath);
            sbSysPara.AppendFormat("spImagePath=[{0}]\r\n", spImagePath);
            sbSysPara.AppendFormat("spPlayerBackGround=[{0}]\r\n", spPlayerBackGround);
            sbSysPara.AppendFormat("spHuaPingFePicSavePath=[{0}]\r\n", spHuaPingFePicSavePath);
            sbSysPara.AppendFormat("strAppName=[{0}]\r\n", strAppName);
            sbSysPara.AppendFormat("strUserType=[{0}]\r\n", strUserType);
            sbSysPara.AppendFormat("strUserId=[{0}]\r\n", strUserId);
            sbSysPara.AppendFormat("strUserName=[{0}]\r\n", strUserName);
            sbSysPara.AppendFormat("CurrPrjId=[{0}]\r\n", CurrPrjId);
            sbSysPara.AppendFormat("CurrSelPrjId=[{0}]\r\n", CurrSelPrjId);
            sbSysPara.AppendFormat("strUserIp=[{0}]\r\n", strUserIp);
            sbSysPara.AppendFormat("strUserRoleId=[{0}]\r\n", strUserRoleId);
            sbSysPara.AppendFormat("strUserStateId=[{0}]\r\n", strUserStateId);
            sbSysPara.AppendFormat("strAppName=[{0}]\r\n", strAppName);
            sbSysPara.AppendFormat("strRoleId=[{0}]\r\n", strRoleId);
            sbSysPara.AppendFormat("arrUserAllRoleIds=[{0}]\r\n", arrUserAllRoleIds);
            sbSysPara.AppendFormat("arrChRightName=[{0}]\r\n", arrChRightName);
            sbSysPara.AppendFormat("strDepartmentId=[{0}]\r\n", strDepartmentId);
            sbSysPara.AppendFormat("strIndexPage=[{0}]\r\n", strIndexPage);
            sbSysPara.AppendFormat("SchoolName=[{0}]\r\n", SchoolName);
            sbSysPara.AppendFormat("CurrYear=[{0}]\r\n", CurrYear);
            sbSysPara.AppendFormat("CurrTerm=[{0}]\r\n", CurrTerm);
            sbSysPara.AppendFormat("strCompanyName=[{0}]\r\n", strCompanyName);
            sbSysPara.AppendFormat("strXMLFolder=[{0}]\r\n", strXMLFolder);
            sbSysPara.AppendFormat("strXMLFileName=[{0}]\r\n", strXMLFileName);
            sbSysPara.AppendFormat("strTempXMLFileName=[{0}]\r\n", strTempXMLFileName);
            sbSysPara.AppendFormat("strXmlSpParaFileName=[{0}]\r\n", strXmlSpParaFileName);
            sbSysPara.AppendFormat("strXmlDataSourceFileName=[{0}]\r\n", strXmlDataSourceFileName);
            sbSysPara.AppendFormat("bolIsUseXmlDataSource=[{0}]\r\n", bolIsUseXmlDataSource);
            sbSysPara.AppendFormat("strConnectStrName=[{0}]\r\n", strConnectStrName);
            sbSysPara.AppendFormat("bolIsUseConnectStrName=[{0}]\r\n", bolIsUseConnectStrName);
            sbSysPara.AppendFormat("UpLoadFilesWebFolder=[{0}]\r\n", UpLoadFilesWebFolder);
            sbSysPara.AppendFormat("UploadWebFolder=[{0}]\r\n", UploadWebFolder);
            sbSysPara.AppendFormat("UpLoadFilesFolder=[{0}]\r\n", UpLoadFilesFolder);
            sbSysPara.AppendFormat("DownLoadFilesWebFolder=[{0}]\r\n", DownLoadFilesWebFolder);
            sbSysPara.AppendFormat("DownLoadFilesFolder=[{0}]\r\n", DownLoadFilesFolder);
            sbSysPara.AppendFormat("ConfigFileName=[{0}]\r\n", ConfigFileName);
            sbSysPara.AppendFormat("TempWebFolder=[{0}]\r\n", TempWebFolder);
            sbSysPara.AppendFormat("TempFileFolder=[{0}]\r\n", TempFileFolder);
            sbSysPara.AppendFormat("ErrorPage=[{0}]\r\n", ErrorPage);
            sbSysPara.AppendFormat("SuccessPage=[{0}]\r\n", SuccessPage);
            sbSysPara.AppendFormat("CurrDirectory=[{0}]\r\n", CurrDirectory);
            sbSysPara.AppendFormat("bolIsUseSilverLightPlay=[{0}]\r\n", bolIsUseSilverLightPlay);
            //sbSysPara.AppendFormat("bolIsSupportsHtml5=[{0}]\r\n", bolIsSupportsHtml5);
            //sbSysPara.AppendFormat("strAppName=[{0}]\r\n", strAppName);
            //sbSysPara.AppendFormat("strAppName=[{0}]\r\n", strAppName);
            //sbSysPara.AppendFormat("strAppName=[{0}]\r\n", strAppName);


            return sbSysPara.ToString();
        }
        /// <summary>
        /// 当前考核年
        /// </summary>
        public static string strExamYear;   //
        /// <summary>
        /// 当前聘期Id
        /// </summary>
        public static string strCurrEngagePeriodId; //
        /// <summary>
        /// 当前聘期名称
        /// </summary>
        public static string strCurrEngagePeriodName;   //
        /// <summary>
        /// 当前聘期年列表
        /// </summary>
        public static ArrayList arrCurrEngagePeriodYear;    //
        /// <summary>
        /// 是否使用宽屏显示视频
        /// </summary>
        public static bool bolIsUseWidePage = false;//；
        /// <summary>
        /// 微格列表－是否使用宽屏显示视频；
        /// </summary>
        public static bool bolIsUseWidePage4MicroList = false;//
        /// <summary>
        /// 微格列表－是否使用行政班；
        /// </summary>
        public static bool bolIsUseAdminCls4MicroList = false;//
        /// <summary>
        /// 是否使用华平播放器；
        /// </summary>
        public static bool bolIsUseAvconPlay = false;//
        /// <summary>
        /// 是否学科学段；
        /// </summary>
        public static bool bolIsUseDisciplineStudyLevel = true;

        /// <summary>
        /// 在微格编辑中是否使用Html编辑器；
        /// </summary>
        public static bool bolIsUseHtmlEditor4MicroTeachEdit = false;
        /// <summary>
        /// 附加站点：上传文件Web目录
        /// </summary>
        public static string AddiSiteUpLoadFilesWebFolder = @"~\AddiSite\UpLoadFiles\";
        /// <summary>
        /// 附加站点：上传文件物理目录
        /// </summary>
        public static string AddiSiteUpLoadFilesFolder = "";	//

        /// <summary>
        /// 是否去除用户分组，即教师针对学生不分组，教师可以为每个学生打分；
        /// </summary>
        public static bool bolIsDeleteUserGroup = true;

        /// <summary>
        /// 
        /// </summary>
        public static string FileSvrFileName;
        /// <summary>
        /// 
        /// </summary>
		public static string strBasicDesc = "基层信息";
        /// <summary>
        /// 设置管理员角色的RoleId
        /// </summary>
        public static string AdminRoleId
        {
            get
            {
                if (SchoolName == "东海学院")
                {
                    return "01080001";
                }
                else if (SchoolName == "江苏二师")
                {
                    return "01080001";
                }
                else if (SchoolName == "上海泰泽")
                {
                    return "01080001";
                }
                else
                    return "00830011";
            }
        }

        /// <summary>
        /// 设置教师角色的RoleId
        /// </summary>
        public static string TeacherRoleId
        {
            get
            {
                if (SchoolName == "东海学院")
                {
                    return "01080002";
                }
                else if (SchoolName == "江苏二师")
                {
                    return "01080002";
                }
                else if (SchoolName == "上海泰泽")
                {
                    return "01080002";
                }
                else
                    return "00830005";
            }
        }
        /// <summary>
        /// 设置学生角色的RoleId
        /// </summary>
        public static string StudentRoleId
        {
            get
            {
                if (SchoolName == "东海学院")
                {
                    return "01080003";
                }
                else if (SchoolName == "江苏二师")
                {
                    return "01080003";
                }
                else if (SchoolName == "上海泰泽")
                {
                    return "01080003";
                }
                else
                    return "00830006";
            }
        }


        /// <summary>
        /// 设置管理员角色的RoleId
        /// </summary>
        public static string MajorRoleId
        {
            get
            {
                if (SchoolName == "东海学院")
                {
                    return "01080007";
                }
                else if (SchoolName == "江苏二师")
                {
                    return "01080007";
                }
                else if (SchoolName == "上海泰泽")
                {
                    return "01080007";
                }
                else
                    return "";
            }
        }
       
        /// <summary>
        /// Flv文件的播放器所在目录
        /// </summary>
        public static string spFlvplayerPath
        {
            get
            {
                if (string.IsNullOrEmpty(mstrspFlvplayerPath) == true)
                {
                    string strMsg = string.Format("Flv文件的播放器所在目录为空！({0})",
                        clsStackTrace.GetCurrClassFunctionByLevel(3));
                    throw new Exception(strMsg);
                }
                return mstrspFlvplayerPath;
            }

            set
            {
                if (string.IsNullOrEmpty(value) == true)
                {
                    string strMsg = string.Format("Flv文件的播放器所在目录为空！({0})",
                        clsStackTrace.GetCurrClassFunctionByLevel(3));
                    throw new Exception(strMsg);
                }
                mstrspFlvplayerPath = value;
            }
        }
        /// <summary>
        /// 系统参数：视频文件的存放地址
        /// </summary>
        public static string spFePicSavePath
        {
            get
            {
                if (string.IsNullOrEmpty(mstrspFePicSavePath) == true)
                {
                    string strMsg = string.Format("系统参数(spFePicSavePath)：视频文件的存放地址为空！({0}->{1}->{2})",
                        clsStackTrace.GetCurrClassFunctionByLevel(3), clsStackTrace.GetCurrClassFunctionByLevel(2), clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                return mstrspFePicSavePath;
            }

            set
            {
                if (string.IsNullOrEmpty(value) == true)
                {
                    string strMsg = string.Format("系统参数(spFePicSavePath)：视频文件的存放地址为空！({0}->{1}->{2})",
                        clsStackTrace.GetCurrClassFunctionByLevel(3), clsStackTrace.GetCurrClassFunctionByLevel(2), clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                mstrspFePicSavePath = value;
            }
        }
    }
}
