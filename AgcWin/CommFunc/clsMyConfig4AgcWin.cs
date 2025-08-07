
using System;
using System.Text;

/// <summary>
/// clsMyConfig 的摘要说明
/// </summary>
public class clsMyConfig4AgcWin
{
    public static string strWebConfigPath = @"~\ConnStr\";

    public clsMyConfig4AgcWin()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
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
            if (System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort"] == null)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.Append("配置文件中CurrIPAddressAndPort不能为空！");
                throw new Exception(sbMsg.ToString());
            }
            string strCurrIPAddressAndPort = System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort"].ToString();
            return strCurrIPAddressAndPort;
        }
    }

    public static string CurrIPAddressAndPortBackup
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPortBackup"] == null)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.Append("配置文件中CurrIPAddressAndPortBackup不能为空！");
                throw new Exception(sbMsg.ToString());
            }
            string strCurrIPAddressAndPort = System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPortBackup"].ToString();
            return strCurrIPAddressAndPort;
        }
    }
    public static string CurrPrxWA
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["CurrPrxWA"] == null)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.Append("配置文件中CurrPrxWA不能为空！");
                throw new Exception(sbMsg.ToString());
            }
            string strCurrPrxWA = System.Configuration.ConfigurationManager.AppSettings["CurrPrxWA"].ToString();
            return strCurrPrxWA;
        }
    }

    /// <summary>
    /// 当前的IP地址和端口，用于用户统一平台
    /// </summary>
    public static string CurrIPAddressAndPort4WA
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort4WA"] == null)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.Append("配置文件中CurrIPAddressAndPort4WA不能为空！");
                throw new Exception(sbMsg.ToString());
            }
            string strCurrIPAddressAndPort = System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort4WA"].ToString();
            return strCurrIPAddressAndPort;
        }
    }


    /// <summary>
    /// 当前的IP地址和端口，用于用户统一平台
    /// </summary>
    public static string CurrIPAddressAndPort4WABackupBak
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort4WABackup"] == null)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.Append("配置文件中CurrIPAddressAndPort4WABackup不能为空！");
                throw new Exception(sbMsg.ToString());
            }
            string strCurrIPAddressAndPort = System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort4WABackup"].ToString();
            return strCurrIPAddressAndPort;
        }
    }

    public static string CurrIPAddressAndPort4WABackup180_153_158_158
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort4WABackup180_153_158_158"] == null)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.Append("配置文件中CurrIPAddressAndPort4WABackup180_153_158_158不能为空！");
                throw new Exception(sbMsg.ToString());
            }
            string strCurrIPAddressAndPort = System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort4WABackup180_153_158_158"].ToString();
            return strCurrIPAddressAndPort;
        }
    }


    /// <summary>
    /// 当前的IP地址和端口，用于用户统一平台
    /// </summary>
    public static string CurrIPAddressAndPort4WABackup63_42
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort4WABackup63_42"] == null)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.Append("配置文件中CurrIPAddressAndPort4WABackup63_42不能为空！");
                throw new Exception(sbMsg.ToString());
            }
            string strCurrIPAddressAndPort = System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort4WABackup63_42"].ToString();
            return strCurrIPAddressAndPort;
        }
    }
    /// <summary>
    /// 当前的IP地址和端口，用于用户统一平台
    /// </summary>
    public static string CurrIPAddressAndPort4WABackup202_195_112_201
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort4WABackup202_195_112_201"] == null)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.Append("配置文件中CurrIPAddressAndPort4WABackup202_195_112_201不能为空！");
                throw new Exception(sbMsg.ToString());
            }
            string strCurrIPAddressAndPort = System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort4WABackup202_195_112_201"].ToString();
            return strCurrIPAddressAndPort;
        }
    }
    /// <summary>
    /// 当前的IP地址和端口，用于用户统一平台
    /// </summary>
    public static string CurrIPAddressAndPort4WABackup115_5
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort4WABackup115_5"] == null)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.Append("配置文件中CurrIPAddressAndPort4WABackup115_5不能为空！");
                throw new Exception(sbMsg.ToString());
            }
            string strCurrIPAddressAndPort = System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort4WABackup115_5"].ToString();
            return strCurrIPAddressAndPort;
        }
    }

    /// <summary>
    /// 当前的IP地址和端口，用于用户统一平台
    /// </summary>
    public static string CurrIPAddressAndPort4WABackup115_6
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort4WABackup115_6"] == null)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.Append("配置文件中CurrIPAddressAndPort4WABackup115_6不能为空！");
                throw new Exception(sbMsg.ToString());
            }
            string strCurrIPAddressAndPort = System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort4WABackup115_6"].ToString();
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
            if (System.Configuration.ConfigurationManager.AppSettings["CurrPrx"] == null)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.Append("配置文件中CurrPrx不能为空！");
                throw new Exception(sbMsg.ToString());
            }
            string strCurrPrx = System.Configuration.ConfigurationManager.AppSettings["CurrPrx"].ToString();
            return strCurrPrx;
        }
    }


    /// <summary>
    /// 当前的IP地址和端口，用于用户统一平台
    /// </summary>
    public static string CurrIPAddressAndPort5AGCCS
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort5AGCCS"] == null)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.Append("配置文件中CurrIPAddressAndPort不能为空！");
                throw new Exception(sbMsg.ToString());
            }
            string strCurrIPAddressAndPort = System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort5AGCCS"].ToString();
            return strCurrIPAddressAndPort;
        }
    }
    /// <summary>
    /// 当前的虚拟目录，用于用户统一平台
    /// </summary>
    public static string CurrPrx5AGCCS
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["CurrPrx5AGCCS"] == null)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.Append("配置文件中CurrPrx不能为空！");
                throw new Exception(sbMsg.ToString());
            }
            string strCurrPrx = System.Configuration.ConfigurationManager.AppSettings["CurrPrx5AGCCS"].ToString();
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
            string strId_School = "";// clsXzSchoolExWApi.GetId_SchoolBySchoolId(clsMyConfig4AgcWin.spSchool);
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
            //string strLoginMode = clsTSysParaExWApi.GetCurrSchool();
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
            //string strLoginMode = clsTSysParaExWApi.GetCurrSiteName();
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
}
