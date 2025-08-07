using AGC;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.FunClass;
using AGC4WApi;
using AgcMvc3;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.syspara;
using GeneralPlatform4WApi;
using GP4WApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;


namespace AgcMvc4
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            //{
            //    Path = "~/Scripts/jquery-3.6.0.min.js",
            //    DebugPath = "~/Scripts/jquery-3.5.1.js",
            //    CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-3.6.0.min.js",
            //    CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-3.5.1.js"
            //});

            //AreaRegistration.RegisterAllAreas();
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);

            clsDebugBase_Sql.IsDebug = true;
            clsDebugBase_Sql.LogDir4Debug = @"D:\Log\Agc\";
            clsDebugBase_Sql.LogFile4Debug = "Log4DataBase";
            clsDebugBase_Sql.TraceLevel = 4;
            clsDebugBase_Pub.TraceLevel = 4;
            clsPubVar4BLEx.objLog4Error = new clsLog(@"D:\Log\Agc\", "Debug4BLEx");
            clsPubVar4BLEx.objLog4GC = new clsLog(@"D:\Log\Agc\", "Log4GC");
            clsSysParaEN.objErrorLog = new clsLog(@"D:\Log\Agc\", "errorMsg");

            clsSysParaEN_Local.objLog = new clsLog(@"D:\Log\Agc\", "Debug4SysPara");
            clsSysParaEN_Local.objLog4GCError = new clsLog(@"D:\Log\Agc\", "Error4GeneCode");
            clsPubVar.objLog = new clsLog(@"D:\Log\Agc\", "Debug4Web");
            //clsPubVar_WS.objLog = new clsLog(@"D:\Log\Agc\", "Debug4WS");


            // 在应用程序启动时运行的代码
            //com.taishsoft.commdb.clsSpecSQLforSql.IsUseEncrypt = true;
            com.taishsoft.commdb.clsSpecSQLforSql.IsUseEncrypt = false;
            com.taishsoft.commdb.clsSpecSQLforSql.AppType = "WEBAPP";

            com.taishsoft.commdb.clsSpecSQLforSql.strWebRoot = @"~\ConnStr\";
            com.taishsoft.commdbfororacle.clsSpecSQLforOra.strWebRoot = @"~\ConnStr\";
            com.taishsoft.commdb.clsSpecSQLforSql.WebConfigFileName = Server.MapPath(com.taishsoft.commdb.clsSpecSQLforSql.strWebRoot) + @"Web.Config";
            clsSysParaEN.strXMLFolder = Server.MapPath(@"~\XML\");
            clsSysParaEN.strXmlSpParaFileName = clsSysParaEN.strXMLFolder + "XMLSP.xml";
            clsSysParaEN_Local.IsBackupForGeneCode = false;
            clsSysParaEN.spServerIp = clsApplicatoin.GetAddressIP4();
            clsSysParaEN.TempFileFolder = Server.MapPath(clsSysParaEN.TempWebFolder);
            clsSysParaEN_Local.IsBackupForGeneCode = false;
            clsSysParaEN.CurrPrjId = "0005";
            clsSysParaEN.ErrorPage = "~/Webform/Error.aspx";

            clsSysPara_TzPubFunction.AppType = "WEBAPP";
            clsSysParaEN_Local.strDynamicLibPath = Server.MapPath(@"~\ConnStr\");
            //AGC4WS.clsSysPara4WS.strCurrIPAddressAndPort = clsMyConfig.CurrIPAddressAndPort5AGC;// "202.121.48.246";
            //AGC4WS.clsSysPara4WS.strCurrPrx = clsMyConfig.CurrPrx5AGC;// "AGC_WS";

            //GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = clsMyConfig.CurrIPAddressAndPort;// "202.121.63.9";
            //GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = clsMyConfig.CurrPrx;// "GP_SHNU_WS";

            clsSysPara4WebApi_GP.strCurrIPAddressAndPort = clsMyConfig.CurrIPAddressAndPort;// "202.121.63.9";
            clsSysPara4WebApi_GP.strCurrPrx = clsMyConfig.CurrPrxWA;// "GP_SHNU_WS";
            //clsSpecSQLforSql.IsUseBackupConnect = true;
            //clsSysPara4WebApi_Agc.strCurrIPAddressAndPort = "http://localhost:39540";
            //clsSysPara4WebApi_Agc.strCurrIPAddressAndPort = "https://103.116.76.183";
            //clsSysPara4WebApi_Agc.strCurrIPAddressAndPort = "tzar.ddns.net:9080";

            clsSysPara4WebApi_Agc.strCurrPrx = "Agc";
            //clsSysPara4WebApi.strCurrPrx = "GPJsie";
            //设置缓存刷新
            clsPubFun.SetCommFun4BL();
            clsPubFun4Delegate.InitDelegateEvent();
        }
    }
}
