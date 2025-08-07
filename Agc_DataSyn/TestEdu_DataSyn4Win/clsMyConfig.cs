
using CommonTable.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Configuration;

public class clsMyConfig2
{
    public static string strWebConfigPath = @"~\ConnStr\";

    public clsMyConfig2()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public static string SiteName
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["sitename"] != null)
            {
                return System.Configuration.ConfigurationManager.AppSettings["sitename"].ToString();
            }
            else
            {
                return "上海师范大学";
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
            if (System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort"] != null)
            {
                return System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort"].ToString();
            }
            else
            {
                return "";
            }

        }
    }
    /// <summary>
    /// 当前的虚拟目录，用于用户统一平台
    /// </summary>
    public static string CurrPrx
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["CurrPrx"] != null)
            {
                return System.Configuration.ConfigurationManager.AppSettings["CurrPrx"].ToString();
            }
            else
            {
                return "";
            }

        }
    }
    /// <summary>
    /// 当前的虚拟目录，用于用户统一平台LogDir4Debug
    /// </summary>
    public static bool IsDebug4PubDatabase
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["IsDebug4PubDatabase"] != null)
            {
                return bool.Parse(System.Configuration.ConfigurationManager.AppSettings["IsDebug4PubDatabase"].ToString());
            }
            else
            {
                return false;
            }

        }
    }

    /// <summary>
    /// Debug的日志目录，用于用户统一平台
    /// </summary>
    public static string LogDir4Debug
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["LogDir4Debug"] != null)
            {
                return System.Configuration.ConfigurationManager.AppSettings["LogDir4Debug"].ToString();
            }
            else
            {
                return "";
            }

        }
    }
    /// <summary>
    /// 发布的虚拟目录
    /// </summary>
    public static string VirtualRoot
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["VirtualRoot"] != null)
            {
                return System.Configuration.ConfigurationManager.AppSettings["VirtualRoot"].ToString();
            }
            else
            {
                return "";
            }
        }
    }

    /// <summary>
    /// 学校名称
    /// </summary>
    public static string School
    {
        get
        {
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
    public static string spSchool
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["School"] != null)
            {
                return System.Configuration.ConfigurationManager.AppSettings["School"].ToString();
            }
            else
            {
                return "上海师范大学";
            }
        }
    }

    /// <summary>
    /// 获取日时间片数
    /// </summary>
    /// <param name="strSchoolId"></param>
    /// <returns></returns>
    public static int getTimesliceNumPerDay(string strSchoolId)
    {

        try
        {
            string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).id_School;
            string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("日课时数", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
            return int.Parse(strParaValue);
        }
        catch (Exception objException)
        {
            ErrorInformationBL.AddInformation("clsMyConfig", "日课时数", objException.Message, "pyf");
            return 0;
        }

    }

    /// <summary>
    /// 获取学期周数
    /// </summary>
    /// <param name="strSchoolId"></param>
    /// <returns></returns>
    public static int  getWeeksNumPerSchoolTerm(string strSchoolId)
    {

        try
        {
            string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).id_School;

            string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("学期周数", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;

            return int.Parse(strParaValue);
        }
        catch (Exception objException)
        {
            ErrorInformationBL.AddInformation("clsMyConfig", "学期周数", objException.Message, "pyf");
            return 0;
        }

    }

    /// <summary>
    /// 获取排课周数
    /// </summary>
    /// <param name="strSchoolId"></param>
    /// <returns></returns>
    public static int getPk2WeeksNumPerSchoolTerm(string strSchoolId)
    {
        try
        {
            string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).id_School;
            string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("排课周数", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
            return int.Parse(strParaValue);
        }
        catch (Exception objException)
        {
            ErrorInformationBL.AddInformation("clsMyConfig", "排课周数", objException.Message, "pyf");
            return 0;
        }

    }
    /// <summary>
    /// 获取日常排课周数
    /// </summary>
    /// <param name="strSchoolId"></param>
    /// <returns></returns>
    public static int getCurrWeeksNumPerSchoolTerm(string strSchoolId)
    {
        try
        {
            string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).id_School;
            string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("日常排课周数", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
            return int.Parse(strParaValue);
        }
        catch (Exception objException)
        {
            ErrorInformationBL.AddInformation("clsMyConfig", "日常排课周数", objException.Message, "pyf");
            return 0;
        }

    }
    /// <summary>
    /// 是否全部使用排课2
    /// </summary>
    /// <param name="strSchoolId"></param>
    /// <returns></returns>
    public static bool getIsAllUsePk2(string strSchoolId)
    {

        try
        {
            string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).id_School;

            string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("全部使用排课V2", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;

            return bool.Parse(strParaValue);
        }
        catch (Exception objException)
        {
            ErrorInformationBL.AddInformation("clsMyConfig", "全部使用排课V2", objException.Message, "pyf");
            return false;
        }

    }
    /// <summary>
    /// 获取优秀比例
    /// </summary>
    /// <param name="strSchoolId"></param>
    /// <returns></returns>
    public static int getExcellentPortion(string strSchoolId)
    {

        try
        {
            string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).id_School;
            string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("优秀比例", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
            return int.Parse(strParaValue);
        }
        catch (Exception objException)
        {
            ErrorInformationBL.AddInformation("clsMyConfig", "优秀比例", objException.Message, "pyf");
            return 0;
        }

    }

    /// <summary>
    /// 获取优良比例
    /// </summary>
    /// <param name="strSchoolId"></param>
    /// <returns></returns>
    public static int getGoodPortion(string strSchoolId)
    {

        try
        {
            string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).id_School;
            string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("优良比例", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
            return int.Parse(strParaValue);
        }
        catch (Exception objException)
        {
            ErrorInformationBL.AddInformation("clsMyConfig", "优良比例", objException.Message, "pyf");
            return 0;
        }

    }
}

