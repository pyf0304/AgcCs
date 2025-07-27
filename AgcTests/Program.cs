using System;
using System.Collections.Generic;
using System.Linq;
using com.taishsoft.common;

using com.taishsoft.syspara;

namespace Agc_CsWin
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            com.taishsoft.commdb.clsSpecSQLforSql.strAppType = "WINAPP";
            com.taishsoft.commdbfororacle.clsSpecSQLforOra.strAppType = "WINAPP";
            clsDebugBase_Sql.IsDebug = true;
            clsDebugBase_Sql.LogDir4Debug = @"D:\Log\AgcCs_Win\";
            clsDebugBase_Sql.LogFile4Debug = "Log4DataBase";
            clsDebugBase_Sql.TraceLevel = 4;
            clsDebugBase_Pub.TraceLevel = 4;



            //SpecData.clsSpecSQL.IsUseEncrypt = true;//使用加密连接串
            SpecData.clsSpecSQL.IsUseEncrypt = false;//使用加密连接串
                                                     //DataSynImport.ImportPara.XmlDataSourceFileName = clsSysParaEN.strXMLFolder + "TzSysDataSet.xml";

        }
    }
}
