using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.syspara;
using AGC.Entity;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;
using CommonTable.Entity;
using AgcDataSyn;

namespace AgcDataSyn
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {

            clsDebugBase_Sql.IsDebug = clsMyConfig2.IsDebug4PubDatabase;
            clsDebugBase_Sql.LogDir4Debug = clsMyConfig2.LogDir4Debug;
            clsDebugBase_Sql.LogFile4Debug = "DataBaseLog4Agc_DataSyn";
            clsDebugBase_Sql.TraceLevel = 4;
            clsDebugBase_Pub.TraceLevel = 4;
            ServiceBase[] ServicesToRun;

            // 同一进程中可以运行多个用户服务。若要将
            // 另一个服务添加到此进程中，请更改下行以
            // 创建另一个服务对象。例如，
            //
            //   ServicesToRun = new ServiceBase[] {new Service1(), new MySecondUserService()};
            //
            ServicesToRun = new ServiceBase[] { new AgcDataSynService() };

            SpecData.clsSpecSQL.strAppType = "WINAPP";

            clsSysParaEN.bolIsUseConnectStrName = true;

            clsSpecSQLforSql.bolIsUseConnectStrName = true;
            //clsSysPara.strConnectStrName = "ConnectionStringWeb";
            //clsSpecSQLforSql.strConnectStrName = "ConnectionStringWeb";


            clsSysParaEN.strConnectStrName = "ConnectionString";

            clsSpecSQLforSql.strConnectStrName = "ConnectionString";
            SpecData.clsSpecSQL.IsUseEncrypt = false;
            //SpecData.clsSpecSQL.IsUseEncrypt = true;
            clsApplicatoin.ExecutablePath = Application.ExecutablePath;


            clsSysParaEN.strUserId = "pyf_DataSyn";

            ServiceBase.Run(ServicesToRun);
        }
    }
}