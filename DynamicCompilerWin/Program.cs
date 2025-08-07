using AGC.BusinessLogicEx;
using com.taishsoft.common;
using com.taishsoft.syspara;
using CommonTable.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DynamicCompilerWin
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            com.taishsoft.commdb.clsSpecSQLforSql.strAppType = "WINAPP";
            com.taishsoft.commdbfororacle.clsSpecSQLforOra.strAppType = "WINAPP";
            clsDebugBase_Sql.IsDebug = true;
            clsDebugBase_Sql.LogDir4Debug = @"D:\Log\AgcCs_Win\";
            clsDebugBase_Sql.LogFile4Debug = "Log4DataBase";
            clsDebugBase_Sql.TraceLevel = 4;
            clsDebugBase_Pub.TraceLevel = 4;
        
            SpecData.clsSpecSQL.IsUseEncrypt = true;//使用加密连接串
            //SpecData.clsSpecSQL.IsUseEncrypt = false;//使用加密连接串
            clsApplicatoin.ExecutablePath = Application.ExecutablePath;
            
            clsSysParaEN.objLog.LogDir = @"D:\Log\AgcCs_Test\";
            clsSysParaEN.objLog.LogFileName = "Debug4Test";
            clsPubFun4BLEx.SetCommFun4BL();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIParent1());
        }
    }
}
