using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using AGC.BusinessLogicEx;


/// <summary>
/// clsMyConfig 的摘要说明
/// </summary>
public class clsMyConfig
{
    public static string strWebConfigPath = @"~\ConnStr\";

    public clsMyConfig()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public static long lngMaxFileSize
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);
            
            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName); 
            string strMaxFileSize = appSettings.Settings["lngMaxFileSize"].Value;
            return long.Parse(strMaxFileSize);
        }
    }
    public static string strWebFileDir
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strWebFileDir = appSettings.Settings["strWebFileDir"].Value;
            return strWebFileDir;
        }
    }
    public static string CurrPrjId
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strCurrPrjId = appSettings.Settings["CurrPrjId"].Value;
            return strCurrPrjId;
        }
    }
    public static string strUploadFileDir
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strUploadFileDir = appSettings.Settings["strUploadFileDir"].Value;
            return strUploadFileDir;
        }
    }
    public static string strDownloadFileDir
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strDownloadFileDir = appSettings.Settings["strDownloadFileDir"].Value;
            return strDownloadFileDir;
        }
    }
    public static string IsDebug
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["IsDebug"] != null)
            {
                return System.Configuration.ConfigurationManager.AppSettings["IsDebug"].ToString();
            }
            else
            {
                return "False";
            }
        }
    }
    /// <summary>
    /// 当前的IP地址和端口，用于用户统一平台
    /// </summary>
    public static string CurrIPAddressAndPort
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strCurrIPAddressAndPort = appSettings.Settings["CurrIPAddressAndPort"].Value;
            return strCurrIPAddressAndPort;
        }
    }


    /// <summary>
    /// 当前的IP地址和端口，用于用户统一平台
    /// </summary>
    public static string CurrIPAddressAndPortBackup
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strCurrIPAddressAndPort = appSettings.Settings["CurrIPAddressAndPortBackup"].Value;
            return strCurrIPAddressAndPort;
        }
    }

    /// <summary>
    /// 当前的虚拟目录，用于用户统一平台
    /// </summary>
    public static string CurrPrx
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strCurrPrx = appSettings.Settings["CurrPrx"].Value;
            return strCurrPrx;
        }
    }

    public static string CurrPrxWA
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strCurrPrxWA = appSettings.Settings["CurrPrxWA"].Value;
            return strCurrPrxWA;
        }
    }

    ///// <summary>
    ///// 当前的IP地址和端口，用于用户统一平台
    ///// </summary>
    //public static string CurrIPAddressAndPort
    //{
    //    get
    //    {
    //        if (System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort"] == null)
    //        {
    //            StringBuilder sbMsg = new StringBuilder();
    //            sbMsg.Append("配置文件中CurrIPAddressAndPort不能为空！");
    //            throw new Exception(sbMsg.ToString());
    //        }
    //        string strCurrIPAddressAndPort = System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort"].ToString();
    //        return strCurrIPAddressAndPort;
    //    }
    //}
    ///// <summary>
    ///// 当前的虚拟目录，用于用户统一平台
    ///// </summary>
    //public static string CurrPrx
    //{
    //    get
    //    {
    //        if (System.Configuration.ConfigurationManager.AppSettings["CurrPrx"] == null)
    //        {
    //            StringBuilder sbMsg = new StringBuilder();
    //            sbMsg.Append("配置文件中CurrPrx不能为空！");
    //            throw new Exception(sbMsg.ToString());
    //        }
    //        string strCurrPrx = System.Configuration.ConfigurationManager.AppSettings["CurrPrx"].ToString();
    //        return strCurrPrx;
    //    }
    //}


    /// <summary>
    /// 当前的IP地址和端口，用于用户统一平台
    /// </summary>
    public static string CurrIPAddressAndPort5AGC
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort5AGC"] == null)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.Append("配置文件中CurrIPAddressAndPort不能为空！");
                throw new Exception(sbMsg.ToString());
            }
            string strCurrIPAddressAndPort = System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort5AGC"].ToString();
            return strCurrIPAddressAndPort;
        }
    }
    /// <summary>
    /// 当前的虚拟目录，用于用户统一平台
    /// </summary>
    public static string CurrPrx5AGC
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["CurrPrx5AGC"] == null)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.Append("配置文件中CurrPrx不能为空！");
                throw new Exception(sbMsg.ToString());
            }
            string strCurrPrx = System.Configuration.ConfigurationManager.AppSettings["CurrPrx5AGC"].ToString();
            return strCurrPrx;
        }
    }
    /// <summary>
    /// 学校流水号
    /// </summary>
    public static string spId_School
    {
        get
        {
            string strId_School = clsXzSchoolBLEx.GetId_SchoolBySchoolId(clsMyConfig.spSchool);
            return strId_School;

        }
    }
    /// <summary>
    /// 学校名称
    /// </summary>
    public static string spSchool
    {
        get
        {
            //string strLoginMode = clsTSysParaBLEx.GetCurrSchool();
            //return strLoginMode;
            if (System.Configuration.ConfigurationManager.AppSettings["School"] != null)
            {
                return System.Configuration.ConfigurationManager.AppSettings["School"].ToString();
            }
            else
            {
                return "SHNU";
            }
        }
    }

    /// <summary>
    /// 学校名称
    /// </summary>
    public static string spSiteName
    {
        get
        {
            //string strLoginMode = clsTSysParaBLEx.GetCurrSiteName();
            //return strLoginMode;
            if (System.Configuration.ConfigurationManager.AppSettings["SiteName"] != null)
            {
                return System.Configuration.ConfigurationManager.AppSettings["SiteName"].ToString();
            }
            else
            {
                return "自动生成代码";
            }
        }
    }

    
    /// <summary>
    /// 样例Xls文件名，用于复制生成XLS用，用于ODBC的Excel导出
    /// </summary>
    public static string SamXlsFileName
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string SamXlsFileName = appSettings.Settings["SamXlsFileName"].Value;
            return SamXlsFileName;
        }
    }
}
