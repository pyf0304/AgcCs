using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using com.taishsoft.commdb;
using EcardDataClass;

namespace TestEardDataSyn
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //   
            SpecData.clsSpecSQL.strWebRoot = @"\TestEardDataSyn\";
            clsSpecSQLforSql.strWebRoot = @"\TestEardDataSyn\";

            string ss = Server.MapPath(clsSpecSQLforSql.strWebRoot);
            string sss = clsSpecSQLforSql.strConnectString;
            
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}