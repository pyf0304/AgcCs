using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestTzAdvancedLib
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
            //clsPubVar4BLEx.objLog.LogDir = @"D:\Log\AgcCs_Win\";
            //clsPubVar4BLEx.objLog.LogFileName = "Debug4BL";
            //clsPubVar.objLog.LogDir = @"D:\Log\AgcCs_Win\";
            //clsPubVar.objLog.LogFileName = "Debug4Web";

            SpecData.clsSpecSQL.IsUseEncrypt = true;//使用加密连接串
            //SpecData.clsSpecSQL.IsUseEncrypt = false;//使用加密连接串
            clsApplicatoin.ExecutablePath = Application.ExecutablePath;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
