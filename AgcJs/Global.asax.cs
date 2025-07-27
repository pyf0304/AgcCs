using AGC;
using AGC.FunClass;

//using AGC.WebSrv;

using com.taishsoft.common;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace AgcMvc3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            //{
            //    Path = "~/Scripts/jquery-3.4.1.min.js",
            //    DebugPath = "~/Scripts/jquery-3.4.1.js",
            //    CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-3.4.1.min.js",
            //    CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-3.4.1.js"
            //});

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
       
            clsDebugBase_Pub.TraceLevel = 4;
       

         
            clsSysPara_TzPubFunction.AppType = "WEBAPP";
      
            //AGC4WS.clsSysPara4WS.strCurrIPAddressAndPort = clsMyConfig.CurrIPAddressAndPort5AGC;// "202.121.48.246";
            //AGC4WS.clsSysPara4WS.strCurrPrx = clsMyConfig.CurrPrx5AGC;// "AGC_WS";

            //GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = clsMyConfig.CurrIPAddressAndPort;// "202.121.63.9";
            //GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = clsMyConfig.CurrPrx;// "GP_SHNU_WS";

            GeneralPlatform4WApi.clsSysPara4WebApi_GP.strCurrIPAddressAndPort = clsMyConfig.CurrIPAddressAndPort;// "202.121.63.9";
            GeneralPlatform4WApi.clsSysPara4WebApi_GP.strCurrPrx = clsMyConfig.CurrPrxWA;// "GP_SHNU_WS";
            //clsSpecSQLforSql.IsUseBackupConnect = true;
     

         
        }
    }
}
