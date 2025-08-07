using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.syspara;
using CommonTable.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestAgc_DataSyn4Win
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            clsDebugBase_Sql.IsDebug = clsMyConfig2.IsDebug4PubDatabase;
            clsDebugBase_Sql.LogDir4Debug = clsMyConfig2.LogDir4Debug;
            clsDebugBase_Sql.LogFile4Debug = "Log4DataSyn";
            clsDebugBase_Sql.TraceLevel = 4;
            clsDebugBase_Pub.TraceLevel = 4;
            clsDebugBase_Pub.IsDebug = clsMyConfig2.IsDebug4PubDatabase;
            clsDebugBase_Pub.LogDir4Debug = clsMyConfig2.LogDir4Debug;
            clsDebugBase_Pub.LogFile4Debug = "Log4DataSyn";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SpecData.clsSpecSQL.strAppType = "WINAPP";
         
            clsSysParaEN.bolIsUseConnectStrName = true;

            clsSpecSQLforSql.bolIsUseConnectStrName = true;
            //clsSysPara.strConnectStrName = "ConnectionStringWeb";
            //clsSpecSQLforSql.strConnectStrName = "ConnectionStringWeb";

      
            clsSysParaEN.strConnectStrName = "ConnectionString";

            clsSpecSQLforSql.strConnectStrName = "ConnectionString";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SpecData.clsSpecSQL.IsUseEncrypt = false;
            //SpecData.clsSpecSQL.IsUseEncrypt = true;
            clsApplicatoin.ExecutablePath = Application.ExecutablePath;


            clsSysParaEN.strUserId = "pyf_DataSyn";
            Application.Run(new Form1());
        }
    }
}
